using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Base64Encoder.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Base64Controller : ControllerBase
    {
        [HttpPost("encode")]
        public IActionResult Encode(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return BadRequest("Text cannot be empty");
            }

            Random random = new Random();
            int delay = random.Next(1000, 5000); // Generate a random delay between 1 to 5 seconds
            System.Threading.Thread.Sleep(delay); // Wait for the random delay
            var encodedText = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(text));
            return Ok(encodedText);
        }
    }
}
