using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class SystemLanguageCodePoco
    {
        [Key]
        public string LanguageID { get; set; }
        public string Name { get; set; }
        public string NativeName { get; set; }
 
    }
}
