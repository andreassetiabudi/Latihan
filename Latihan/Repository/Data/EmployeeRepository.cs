using Latihan.Model;
using Latihan.MyContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan.Repository.Data
{
    public class EmployeeRepository : GeneralRepository<Employee, Context>
    {

        public EmployeeRepository(Context myContext) : base(myContext)
        {

        }
    }
}

