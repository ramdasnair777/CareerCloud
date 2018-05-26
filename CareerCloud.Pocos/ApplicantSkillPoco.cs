using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class ApplicantSkillPoco
    {
        [Key]
        public Guid Id { get; set; }
        public string SkillLevel { get; set; }
        public byte StartMonth { get; set; }
        public int StartYear { get; set; }
        public byte EndMonth { get; set; }
        public int EndYear { get; set; }
        public Byte[] TimeStamp { get; set; }
        public Guid Applicant { get; set; }
        public string Skill { get; set; }
    }
}
