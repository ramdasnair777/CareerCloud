using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class ApplicantProfilePoco
    {
        [Key]
        public Guid Id { get; set; }
        public decimal CurrentSalary { get; set; }
        [Column()]
        public byte[] CurrentRate { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public byte[] TimeStamp { get; set; }
        public Guid Login { get; set; }
        public string Currency { get; set; }

    }
}
