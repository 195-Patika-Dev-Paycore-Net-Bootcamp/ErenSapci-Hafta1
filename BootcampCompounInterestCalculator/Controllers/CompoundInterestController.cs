using BootcampCompoundInterest.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BootcampCompoundInterest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompoundInterestController : ControllerBase
    {


        [HttpGet("CompoundInterest")]
        public ActionResult<CompoundInterestResponse> CompoundInterest([FromQuery] CompoundInterestRequest compoundInterestRequest)
        {
            CompoundInterestResponse compoundInterestResponse = new() //Created object of CompoundInterestResponse class
            {
                //Compound interest calculation has been carried out
                
                TotalBalance = compoundInterestRequest.Balance * Math.Pow((1 + compoundInterestRequest.InterestRate / 100), compoundInterestRequest.InterestTerm),
                
            };

            //Calculation of interest amount
            compoundInterestResponse.InterestAmount = compoundInterestResponse.TotalBalance - compoundInterestRequest.Balance;
            
            //Response object returned
            return compoundInterestResponse;
        
        }

    }
}
