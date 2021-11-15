using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using VKCommunity.DAL.Models;
using VKCommunity.RepositoryStorage.Repository;

namespace VKCommunityWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : WebApiBase<User, UsersController>
    {
        public UsersController(IRepository<User> userRepository, ILogger<UsersController> logger) : base(userRepository, logger)
        {

        }

        //[HttpGet]
        //public ActionResult<IEnumerable<User>> Get()
        //{
        //    var users = _userRepository.Get();
        //    if (users.Count() <= 0)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(users);
        //}

        //[HttpGet("{id}")]
        //public ActionResult<User> Get(int id)
        //{
        //    var user = _userRepository.Get(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(user);
        //}

        //[HttpPost]
        //public ActionResult<User> Create(User user)
        //{
        //    _userRepository.Create(user);
        //    _userRepository.SaveChanges();

        //    return CreatedAtRoute(nameof(Get), new { id = user.Id }, user);
        //}

        //[HttpPut("{id}")]
        //public ActionResult Update(int id, User userNew)
        //{
        //    var userOld = _userRepository.Get(id);
        //    if (userOld == null)
        //    {
        //        return NotFound();
        //    }

        //    _userRepository.Update(userNew);
        //    _userRepository.SaveChanges();

        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public ActionResult Delete(int id)
        //{
        //    var user = _userRepository.Get(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    _userRepository.Delete(user);
        //    _userRepository.SaveChanges();

        //    return NoContent();
        //}

        //[HttpPatch("{id}")]
        //public ActionResult Patch(int id, JsonPatchDocument<User> patchDoc)
        //{
        //    var user = _userRepository.Get(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    patchDoc.ApplyTo(user, ModelState);

        //    if (!TryValidateModel(user))
        //    {
        //        return ValidationProblem(ModelState);
        //    }

        //    _userRepository.SaveChanges();

        //    return NoContent();
        //}
    }
}
