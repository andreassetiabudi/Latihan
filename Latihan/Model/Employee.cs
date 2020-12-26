using Latihan.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan.Model
{
    public class Employee : IEntity
    {
        [Key]
        public string id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime birth_date { get; set; }
        public enum gender { Male, Female }
        public string email { get; set; }
        public string phone { get; set; }
        public object photo { get; set; }
        public int is_deleted { get; set; }
        public DateTime create_date { get; set; }

        public Employee() { }

        public Employee(Employee employee)
        {
            this.email = employee.email;
            this.create_date = DateTime.Now;
            this.is_deleted = 0;
        }

        public void Update(Employee employee)
        {
            this.email= employee.email;
        }

        public void Delete()
        {
            this.is_deleted = 1;
        }
    }
}
