using System.ComponentModel.DataAnnotations;
using ExpressiveAnnotations.Attributes;

namespace PersonalTrainer.Models
{
    public class Parq
    {
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name="Yes/No")]
        public bool AnswerOne { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerTwo { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerThree { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerFour { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerFive { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerSix { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerSeven { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerEight { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerNine { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerTen { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerEleven { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerTwelve { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerThirteen { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerFourteen { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerFifteen { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerSixteen { get; set; }

        [Required(ErrorMessage = "Please enter your Name")]
        [Display(Name="Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your current email address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "If you answered YES to any of the questions above please give details:")]
        public string AddInfo { get; set; }

        [Display(Name = "Comments/Add info")]
        public string AddInfoParq { get; set; }

        [Required(ErrorMessage = "Please tick this box before you can continue")]
        public bool ParqAgreement { get; set; }

        [RequiredIf("AnswerOne == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoOne { get; set; }

        [RequiredIf("AnswerTwo == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoTwo { get; set; }

        [RequiredIf("AnswerThree == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoThree { get; set; }

        [RequiredIf("AnswerFour == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoFour { get; set; }

        [RequiredIf("AnswerFive == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoFive { get; set; }

        [RequiredIf("AnswerSix == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoSix { get; set; }

        [RequiredIf("AnswerSeven == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoSeven { get; set; }

        [RequiredIf("AnswerEight == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoEight { get; set; }

        [RequiredIf("AnswerNine == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoNine { get; set; }

        [RequiredIf("AnswerTen == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoTen { get; set; }

        [RequiredIf("AnswerEleven == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoEleven { get; set; }

        [RequiredIf("AnswerTwelve == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoTwelve { get; set; }

        [RequiredIf("AnswerThirteen == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoThirteen { get; set; }

        [RequiredIf("AnswerFourteen == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoFourteen { get; set; }

        [RequiredIf("AnswerFifteen == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoFifteen { get; set; }

        [RequiredIf("AnswerSixteen == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoSixteen { get; set; }
        } 
    }
