using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using VKCommunity.DAL.Models.Base;
using VKCommunity.RepositoryStorage.Repository;

namespace VKCommunityWebApi.Controllers.Base
{
    public interface IWebApiBase<TEntity>
        where TEntity: class
    {
        ActionResult<IEnumerable<TEntity>> Get();
        ActionResult<TEntity> Get(int id);
        ActionResult<TEntity> Create(TEntity item);
        ActionResult Update(int id, TEntity itemNew);
        ActionResult Delete(int id);
        ActionResult Patch(int id, JsonPatchDocument<TEntity> patchDoc);
    }

    [ApiController]
    [Route("api/[controller]")]
    public abstract class WebApiBase<TEntity, TController> : ControllerBase, IWebApiBase<TEntity>
        where TEntity: class, IBaseEntity<int>
        where TController: class
    {
        private readonly IRepository<TEntity> _repository;
        private readonly ILogger<TController> _logger;

        public WebApiBase(IRepository<TEntity> repository, ILogger<TController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpPost]
        public ActionResult<TEntity> Create(TEntity item)
        {
            _repository.Create(item);
            _repository.SaveChanges();

            return CreatedAtAction(nameof(Get), new { id = item.Id }, item);
        }

        [HttpGet]
        public ActionResult<IEnumerable<TEntity>> Get()
        {
            var items = _repository.Get();
            if (items.Count() <= 0)
            {
                return NotFound();
            }

            return Ok(items);
        }

        [HttpGet("{id}")]
        public ActionResult<TEntity> Get(int id)
        {
            var item = _repository.Get(id);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpPatch("{id}")]
        public ActionResult Patch(int id, JsonPatchDocument<TEntity> patchDoc)
        {
            var item = _repository.Get(id);
            if (item == null)
            {
                return NotFound();
            }

            patchDoc.ApplyTo(item, ModelState);

            if (!TryValidateModel(item))
            {
                return ValidationProblem(ModelState);
            }

            _repository.SaveChanges();

            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, TEntity itemNew)
        {
            var itemOld = _repository.Get(id);
            if (itemOld == null)
            {
                return NotFound();
            }

            _repository.Update(itemNew);
            _repository.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var item = _repository.Get(id);
            if (item == null)
            {
                return NotFound();
            }

            _repository.Delete(item);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}
