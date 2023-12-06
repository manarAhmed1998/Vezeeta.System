using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.System.DAL;

namespace Vezeeta.System.BL;

public class DoctorsManager:IDoctorsManager
{
    private readonly IUnitOfWork _unitOfWork;

    public DoctorsManager(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
}
