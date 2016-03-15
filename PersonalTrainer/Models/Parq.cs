using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonalTrainer.Models
{
    public class Parq
    {
        public class answers
        {
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name="Yes/No")]
        public bool answerOne { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool answerTwo { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool answerThree { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool answerFour { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool answerFive { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool answerSix { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool answerSeven { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool answerEight { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool answerNine { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool answerTen { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool answerEleven { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool answerTwelve { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool answerThirteen { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool answerFourteen { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool answerFifteen { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool answerSixteen { get; set; }

        [Display(Name = "If you answered YES to any of the questions above please give details:")]
        public string AddInfo { get; set; }

        public string AddInfoOne { get; set; }
        public string AddInfoTwo { get; set; }
        public string AddInfoThree { get; set; }
        public string AddInfoFour { get; set; }
        public string AddInfoFive { get; set; }
        public string AddInfoSix { get; set; }
        public string AddInfoSeven { get; set; }
        public string AddInfoEight { get; set; }
        public string AddInfoNine { get; set; }
        public string AddInfoTen { get; set; }
        public string AddInfoEleven { get; set; }
        public string AddInfoTwelve { get; set; }
        public string AddInfoThirteen { get; set; }
        public string AddInfoFourteen { get; set; }
        public string AddInfoFifteen { get; set; }
        public string AddInfoSixteen { get; set; }
        }
    }
}