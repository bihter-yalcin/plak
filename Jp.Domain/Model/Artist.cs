using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jp.Domain.Model
{
    public class Artist
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Date? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Date? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public virtual Record Record { get; set; }

    }
}
