using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class SecurityLoginPoco
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime PasswordUpdate { get; set; }
        public DateTime AgreementAccepted { get; set; }
        public bool IsLocked { get; set; }
        public bool IsInactive { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public bool ForceChangePassword { get; set; }
        public string PrefferredLanguage { get; set; }
        public byte[] TimeStamp { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
