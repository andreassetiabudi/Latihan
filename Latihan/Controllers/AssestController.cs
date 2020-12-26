using Latihan.Base;
using Latihan.Model;
using Latihan.Repository.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan.Controllers
//[Authorize(AuthenticationSchemes = "Bearer")]
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class AssetController : BaseController<Asset, AssetRepository>
    {
        private readonly AssetRepository _repository;
        public AssetController(AssetRepository AssetRepository) : base(AssetRepository)
        {
            this._repository = AssetRepository;
        }
    }
}