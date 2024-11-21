using Microsoft.AspNetCore.Mvc;

namespace AlphabetCheckWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlphabetCheckController : ControllerBase
    {
       
       
        [HttpGet("{inputString}")]
        public ActionResult CheckAllAlphabets(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                return BadRequest("Input string cannot be null or empty.");
            }

            inputString = inputString.ToLower();
            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            bool containsAllLetters = alphabet.All(letter => inputString.Contains(letter));

            return Ok(containsAllLetters);
        }
    }
}
