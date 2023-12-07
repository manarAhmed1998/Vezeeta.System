using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.System.BL.Managers.DTOs;
using Vezeeta.System.DAL;

namespace Vezeeta.System.BL.Managers.Admin
{
    public class AdminManager : IAdminManager
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminManager(IUnitOfWork unitOfWork,
                              UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }
        public async Task<bool> AddDoctor(RegisterDTO credentials)
        {
            var user = new ApplicationUser
            {
                UserName = credentials.UserName,
                Email = credentials.Email,
                AccountType = AccountType.Doctor
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
            new Claim(ClaimTypes.Email, user.Email)
        };

                    await _userManager.AddClaimsAsync(user, userClaims);

                    var doctor = new Doctor
                    {
                        Id = Guid.NewGuid(),
                        ApplicationUserId = user.Id,
                        SpecializationId = credentials.SpecializationId,
                        Img = credentials.Img,
                        Name = credentials.Name,
                        Price = credentials.Price,
                    };

                    // Add Doctor to the repository
                    _unitOfWork.DoctorsRepo.Add(doctor);

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
}
