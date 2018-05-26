using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class SecurityRolePoco
    {
        [Key]
        public Guid Id { get; set; }
        public bool IsInactive { get; set; }
        public string Role { get; set; }
    }
}
