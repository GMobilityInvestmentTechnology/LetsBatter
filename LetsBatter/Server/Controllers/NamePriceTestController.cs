using LetsBatter.Shared.Data;
using LetsBatter.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace LetsBatter.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NamePriceTestController : Controller
    {
        private LetsBatterDbContext _dbContext;

        public NamePriceTestController(LetsBatterDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("{int:id}",Name = nameof(GetNamePriceTest))]
        public ActionResult<NamePriceTest> GetNamePriceTest(int id)
        {
            var result = _dbContext.NamePriceTests.FirstOrDefault(x => x.Id == id);
            if (result == null)
                return NotFound();

            return Json(result);
        }

        [HttpGet(Name = nameof(GetNamePriceTests))]
        public ActionResult<IEnumerable<NamePriceTest>> GetNamePriceTests()
        {
            return _dbContext.NamePriceTests.ToList();
        }

        [HttpPost(Name = nameof(PostNamePriceTest))]
        public ActionResult<NamePriceTest> PostNamePriceTest(NamePriceTest payload)
        {
            if (!ModelState.IsValid)
                return BadRequest(payload);

            _dbContext.NamePriceTests.Add(payload);
            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpDelete(Name = nameof(DeleteNamePrice))]
        public ActionResult<NamePriceTest> DeleteNamePrice(int id)
        {
            var result = _dbContext.NamePriceTests.FirstOrDefault(x => x.Id == id);

            if(result == null)
                return NotFound();

            _dbContext.NamePriceTests.Remove(result);

            _dbContext.SaveChanges();
            return Ok(result);
        }
    }
}
