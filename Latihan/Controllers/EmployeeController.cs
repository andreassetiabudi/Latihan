using Dapper;
using Latihan.Base;
using Latihan.Model;
using Latihan.MyContext;
using Latihan.Repository;
using Latihan.Repository.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class EmployeeController : BaseController<Employee, EmployeeRepository>
        {
            private readonly EmployeeRepository _repository;

            public EmployeeController (EmployeeRepository employeeRepository) : base(employeeRepository)
            {
                this._repository = employeeRepository;
            }
        }
    }