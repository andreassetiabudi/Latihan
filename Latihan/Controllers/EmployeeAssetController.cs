using Latihan.Base;
using Latihan.Model;
using Latihan.Repository.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan.Controllers
{ 
[Route("api/[controller]")]
[ApiController]
public class EmployeeAssetController : BaseController<EmployeeAsset, EmployeeAssetRepository>
{
    private readonly EmployeeAssetRepository _repository;

    public EmployeeAssetController(EmployeeAssetRepository employeeRepository) : base(employeeRepository)
    {
        this._repository = employeeRepository;
    }
}
}