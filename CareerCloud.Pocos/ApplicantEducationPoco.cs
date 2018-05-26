using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Educations")]
    class ApplicantEducationPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Applicant { get; set; }
        public string Major { get; set; }
        [Column("Certificate_Diploma")]
        public string CertificateDiploma { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public byte? CompletionPercent { get; set; }
        public byte[] TimeStamp { get; set; } 

    }
}
