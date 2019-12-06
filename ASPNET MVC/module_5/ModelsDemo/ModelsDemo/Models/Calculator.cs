using System.ComponentModel.DataAnnotations;

namespace ModelsDemo.Models
{
    public class Calculator
    {
        [Required(ErrorMessage = "Please enter a value for the first number.")]
        [Range(minimum: 1, maximum: 100, ErrorMessage = "Enter a number between 1 and 100")]
        [Display(Name = "First Number")]
        public double NumberOne { get; set; }

        [Required(ErrorMessage = "Please enter a value for the second number.")]
        [Display(Name="Second Number")]
        public double NumberTwo { get; set; }

        [Required]
        public string Operation { get; set; }

        public double Calculate()
        {
            double answer = 0;

            switch (Operation)
            {
                case "Multiply":
                    answer = NumberOne * NumberTwo;
                    break;
                case "Divide":
                    answer = NumberOne / NumberTwo;
                    break;
                case "Subtract":
                    answer = NumberOne - NumberTwo;
                    break;
                case "Add":
                default:
                    answer = NumberOne + NumberTwo;
                    break;
            }

            return answer;
        }
    }
}