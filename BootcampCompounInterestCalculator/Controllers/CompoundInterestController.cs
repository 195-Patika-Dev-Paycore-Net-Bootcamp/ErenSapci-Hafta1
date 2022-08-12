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
                InterestAmount = compoundInterestRequest.Balance,
                TotalBalance = compoundInterestRequest.Balance * Math.Pow((1 + compoundInterestRequest.InterestRate / 100), compoundInterestRequest.InterestTerm)
            };
            //Response object returned
            return compoundInterestResponse;
        }

    }
}
