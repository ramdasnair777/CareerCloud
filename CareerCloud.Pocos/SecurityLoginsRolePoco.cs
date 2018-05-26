using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class SecurityLoginsRolePoco
    {
        [Key]
        public Guid Id { get; set; }
        public byte[] TimeStamp { get; set; }
        public Guid Login { get; set; }
        public Guid Role { get; set; }
    }
}
