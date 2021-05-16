using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]public int ContentID { get; set; }  /*içerik id*/
        [StringLength(1000)]public string ContentValue { get; set; } /*içerik*/
        public DateTime ContentDate { get; set; } /*içeriktarihi*/
        //ContentYazar
        //ContentBaşlık

        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

        public int? WriterID { get; set; } // ? null olabilen type yapar ...
        public virtual Writer Writer { get; set; }
    }
}
