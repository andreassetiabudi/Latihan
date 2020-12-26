using Latihan.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan.Model
{
    public class Asset : IEntity
    {
        [Key]
        public string id { get; set; }
        public string number { get; set; }
        public DateTime create_date { get; set; }

        public string type { get; set; }
        [ForeignKey("Type")]
        public Tipe Type{ get; set; }
        public string employee { get; set; }
        [ForeignKey("Employee")]
        public Employee Employee { get; set; }
    }
}
