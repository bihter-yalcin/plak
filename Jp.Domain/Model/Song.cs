using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jp.Domain.Model
{
    class Song
    {
        public string name { get; set; }
        public int RecordId  { get; set; }
        public virtual Record Record { get; set; }
        public Date? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Date? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
