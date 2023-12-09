using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.BL.Managers.DTOs
{
    public class ApiResponseDTO<T>
    {
        public bool Success { get; set; }
        public List<T> Data { get; set; } = new List<T>();
        public string Message { get; set; }
    }
}
