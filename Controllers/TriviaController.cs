using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OPTriviaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TriviaController : ControllerBase
    {
        #region Constructor and Context
        public TriviaController(DataContext context)
        {
            this.context = context;
        }

        private readonly DataContext context;
        #endregion

        [HttpGet]
        [Route("index")]
        public async Task<ActionResult<List<Trivia>>> Index()
        {
            return Ok(await context.Trivias.ToListAsync());
        }

        [HttpGet]
        [Route("showRandom")]
        public async Task<ActionResult<Trivia>> GetRandom()
        {
            List<Trivia> currentTrivia = await context.Trivias.ToListAsync();
            int id = new Random().Next(currentTrivia.Count);

            var triviaTarget = currentTrivia[id];
            if (triviaTarget == null)
                return BadRequest("Trivia not Found");
            return Ok(triviaTarget);    // returns a 200 status (OK!)
        }

        [HttpGet]
        [Route("show")]
        public async Task<ActionResult<Trivia>> Show(int id)
        {
            var triviaTarget = await context.Trivias.FindAsync(id);
            if (triviaTarget == null)
                return BadRequest("Trivia not Found");
            return Ok(triviaTarget);    // returns a 200 status (OK!)
        }

        [HttpPost]
        public async Task<ActionResult<Trivia>> Create(Trivia newTrivia)
        {
            context.Trivias.Add(newTrivia);
            await context.SaveChangesAsync();

            return Ok(newTrivia);
        }

        [HttpPatch]
        public async Task<ActionResult<Trivia>> Update(Trivia request)
        {
            Trivia dbTrivia = await context.Trivias.FindAsync(request.Id);
            if (dbTrivia == null)
                return BadRequest("Trivia not Found");

            dbTrivia.Text = request.Text;
            await context.SaveChangesAsync();

            return Ok(dbTrivia);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<Trivia>> Delete(int id){
            Trivia dbTrivia = await context.Trivias.FindAsync(id);

            if (dbTrivia == null)
                return BadRequest("Trivia not found");

            context.Trivias.Remove(dbTrivia);
            await context.SaveChangesAsync();

            return Ok(dbTrivia);
        }
    }
}
