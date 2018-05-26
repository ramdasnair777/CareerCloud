using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class ApplicantJobApplicationPoco
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime ApplicationDate { get; set; }

        public byte[] TimeStamp { get; set; }

        public Guid Applicant { get; set; }

        public Guid Job { get; set; }

    }
}
