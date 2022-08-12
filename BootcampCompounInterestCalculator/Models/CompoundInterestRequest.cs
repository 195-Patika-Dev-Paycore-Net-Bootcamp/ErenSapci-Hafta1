using System.ComponentModel.DataAnnotations;

namespace BootcampCompoundInterest.DTO
{
    //the class to which the properties to be sent are defined
    public class CompoundInterestRequest
    {
        //Checking whether numeric values ​​are valid
        [Required(ErrorMessage = "Enter a number")]
        [Range(0, double.MaxValue, ErrorMessage = "enter a valid number")]
        public double Balance { get; set; }

        //Checking whether numeric values ​​are valid
        [Required(ErrorMessage = "Enter a number")]
        [Range(0, double.MaxValue, ErrorMessage = "enter a valid number")]
        public double InterestRate { get; set; }

        //Checking whether numeric values ​​are valid
        [Required(ErrorMessage = "Enter a number")]
        [Range(0, double.MaxValue, ErrorMessage = "enter a valid number")]
        public double InterestTerm { get; set; }
    }
}
