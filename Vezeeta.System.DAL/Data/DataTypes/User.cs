using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL.Data.DataTypes
{
    public abstract class User
    {
        public Guid Id { get; set; }
        public string img { get; set; }
        public string Name { get; set; } = string.Empty;
        public AccountType AccountType { get; set; }
    }
}
