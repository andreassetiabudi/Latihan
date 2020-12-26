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
public class TipeController : BaseController<Tipe, TipeRepository>
{
    private readonly TipeRepository _repository;

    public TipeController(TipeRepository TipeRepository) : base(TipeRepository)
    {
        this._repository = TipeRepository;
    }
}
}