using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.System.BL.Managers.DTOs;
using Vezeeta.System.DAL;

namespace Vezeeta.System.BL;

public class PatientsManager:IPatientsManager
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly UserManager<ApplicationUser> _userManager;

    public PatientsManager(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }

    public async Task<bool> AddPatient(AddPatientDTO credentials)
    {
        var user = new ApplicationUser
        {
            UserName = credentials.UserName,
            Email = credentials.Email,
            AccountType = AccountType.Patient
        };

        using (var transaction = _unitOfWork.BeginTransaction())
        {
            try
            {
                var creationResult = await _userManager.CreateAsync(user, credentials.Password);

                if (!creationResult.Succeeded)
                {
                    // Rollback the transaction if user creation fails
                    transaction.Rollback();
                    return false;
                }

                // Assign some credentials for the user
                var userClaims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.UserName),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Role,user.AccountType.ToString())
        };

                await _userManager.AddClaimsAsync(user, userClaims);

                var patient = new Patient
                {
                    Id = Guid.NewGuid(),
                    ApplicationUserId = user.Id,
                    Img = credentials.Img,
                    AccountType = AccountType.Patient
                };

                // Add Doctor to the repository
                _unitOfWork.PatientsRepo.Add(patient);

                // Save changes within the same transaction
                _unitOfWork.Save();

                // Commit the transaction if everything is successful
                transaction.Commit();

                return true;
            }
            catch (Exception)
            {
                // Rollback the transaction if an exception occurs
                transaction.Rollback();
                throw new Exception("Error occured while registering, try again"); // Re-throw the exception to signal the failure
            }
        }
    }
}
