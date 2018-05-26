﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class SecurityLoginsLogPoco
    {
        [Key]
        public Guid Id { get; set; }
        public string SourceIP { get; set; }
        public DateTime LogonDate { get; set; }
        public bool IsSuccesful { get; set; }
        public Guid Login { get; set; }

    }
}
