using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jp.Domain.Model
{
    public class Record
    {
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
        public double Price { get; set; }
        public int DiscountId { get; set; }
        public Discount Discount { get; set; }
        public bool IsShipmentFree { get; set; }
        public Category Category { get; set; }
        public Store Store { get; set; }
        public ICollection<Song> SongList { get; set; }
        public string Barcode { get; set; }
        public Date? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Date? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }




    }
}
