using Latihan.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan.Model
{
    public class Tipe : IEntity
    {
        [Key]
        public string id { get; set; }
        public string name { get; set; }
    }
}
