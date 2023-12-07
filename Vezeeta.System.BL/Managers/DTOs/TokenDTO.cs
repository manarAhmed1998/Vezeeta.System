﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.BL.Managers.DTOs
{
    public class TokenDTO
    {
        public string Token { get; init; } = null!;
        public DateTime ExpiryDate { get; init; }
    }
}
