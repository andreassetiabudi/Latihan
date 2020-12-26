using Latihan.Repository.Interface;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan.Base
{
    //Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository _repository;

        public BaseController(TRepository repository) { this._repository = repository; }

        [HttpGet]
        public async Task<ActionResult<TEntity>> Get()
        {
            var get = await _repository.Get();
            return Ok(new { data = get });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var get = await _repository.Get(id);
            if (get == null)
            {
                return NotFound();
            }
            return Ok(get);
        }

        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            var post = await _repository.Post(entity);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(new { message = "Insert Success" });
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TEntity>> Put(string id, TEntity entity)
        {
            if (id != entity.id)
            {
                return BadRequest();
            }
            await _repository.Put(entity);
            return Ok(new { message = "Update Success" });
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<IEntity>> Delete(int id)
        {
            var delete = await _repository.Delete(id);
            if (delete == null)
            {
                return NotFound();
            }
            return Ok(new { message = "Delete Success" }); ;
        }
    }
}