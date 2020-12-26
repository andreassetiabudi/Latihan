using Latihan.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan.Model
{
    public class EmployeeAsset : IEntity
    {
        [Key]
        public string id { get; set; }
        public DateTime receive_date { get; set; }
        public DateTime return_date { get; set; }
        public string note { get; set; }

        public string asset { get; set; }
        [ForeignKey("Asset")]
        public Asset Asset { get; set; }
        public string employee { get; set; }
        [ForeignKey("Employee")]
        public Employee Employee { get; set; }
    }
}
