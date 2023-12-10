using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.BL.DTOs.Doctors
{
    public class GetDoctorDTO
    {
        public string Name {  get; set; }
        public string Email {  get; set; }
        public string Phones { get; set; }
        public string Specialization { get; set; }
        public string Img { get; set; }
    }
}
