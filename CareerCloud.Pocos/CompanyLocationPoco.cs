using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class CompanyLocationPoco
    {
        [Key]
        public Guid Id { get; set; }
        public string CountryCode { get; set; }
        public string Province { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public byte[] TimeStamp { get; set; }
        public Guid Company { get; set; }
    }
}
