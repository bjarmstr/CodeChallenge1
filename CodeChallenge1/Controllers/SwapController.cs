using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace CodeChallenge1.Controllers
{
    [Route("api/cups/[controller]")]
    [ApiController]
    public class SwapController : ControllerBase
    {

        [HttpPost]
        public ActionResult<char> SwapCups(string[] swaps)
        {
			    //regex pattern must start and end with either A, B or C
				Regex rg = new Regex(@"^[ABC][ABC]$");
				int position = 1;

				foreach (string swap in swaps)
				{

				    //verify input is correct
					if (swap.Length != 2) return BadRequest("Swaps must consist of just 2 characters");
				    
					if (!swap.ToUpper().Contains(swap)) return BadRequest("Swaps must be defined in UpperCase");
					
					if (!rg.IsMatch(swap)) return BadRequest("Swaps must only contain A,B and C");
					
					if (swap[0] == swap[1]) return BadRequest("Swaps can't repeat the same position");
					
					//move ball to swapped location 
					if (swap.Contains("A") && position == 0)
					{
						position = (swap.Contains("B")) ? 1 : 2;
					}
					else if (swap.Contains("B") && position == 1)
					{
						position = (swap.Contains("A")) ? 0 : 2;
					}
					else if (swap.Contains("C") && position == 2)
					{
						position = (swap.Contains("A")) ? 0 : 1;
					}

				}
				string cupLetter = "ABC";
				char finalSwap = cupLetter[position];
				
				return Ok(finalSwap);
		}


		
    }
}
