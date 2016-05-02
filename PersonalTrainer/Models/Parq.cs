using System.ComponentModel.DataAnnotations;
using ExpressiveAnnotations.Attributes;

namespace PersonalTrainer.Models
{
    public class Parq
    {
        [DbColumn("AnswerOne")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name="Yes/No")]
        public bool AnswerOne { get; set; }

        [DbColumn("AnswerTwo")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerTwo { get; set; }

        [DbColumn("AnswerThree")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerThree { get; set; }

        [DbColumn("AnswerFour")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerFour { get; set; }

        [DbColumn("AnswerFive")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerFive { get; set; }

        [DbColumn("AnswerSix")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerSix { get; set; }

        [DbColumn("AnswerSeven")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerSeven { get; set; }

        [DbColumn("AnswerEight")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerEight { get; set; }

        [DbColumn("AnswerNine")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerNine { get; set; }

        [DbColumn("AnswerTen")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerTen { get; set; }

        [DbColumn("AnswerEleven")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerEleven { get; set; }

        [DbColumn("AnswerTwelve")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerTwelve { get; set; }

        [DbColumn("AnswerThirteen")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerThirteen { get; set; }

        [DbColumn("AnswerFourteen")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerFourteen { get; set; }

        [DbColumn("AnswerFifteen")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerFifteen { get; set; }

        [DbColumn("AnswerSixteen")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerSixteen { get; set; }

        [Required(ErrorMessage = "Please enter your Name")]
        [Display(Name="Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your current email address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [DbColumn("AdditionalInfo")]
        [Display(Name = "Comments/Add info")]
        public string AddInfoParq { get; set; }

        [Required(ErrorMessage = "Please tick this box before you can continue")]
        public bool ParqAgreement { get; set; }

        [DbColumn("AddInfoOne")]
        [RequiredIf("AnswerOne == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoOne { get; set; }

        [DbColumn("AddInfoTwo")]
        [RequiredIf("AnswerTwo == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoTwo { get; set; }

        [DbColumn("AddInfoThree")]
        [RequiredIf("AnswerThree == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoThree { get; set; }

        [DbColumn("AddInfoFour")]
        [RequiredIf("AnswerFour == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoFour { get; set; }

        [DbColumn("AddInfoFive")]
        [RequiredIf("AnswerFive == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoFive { get; set; }

        [DbColumn("AddInfoSix")]
        [RequiredIf("AnswerSix == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoSix { get; set; }

        [DbColumn("AddInfoSeven")]
        [RequiredIf("AnswerSeven == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoSeven { get; set; }

        [DbColumn("AddInfoEight")]
        [RequiredIf("AnswerEight == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoEight { get; set; }

        [DbColumn("AddInfoNine")]
        [RequiredIf("AnswerNine == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoNine { get; set; }

        [DbColumn("AddInfoTen")]
        [RequiredIf("AnswerTen == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoTen { get; set; }

        [DbColumn("AddInfoEleven")]
        [RequiredIf("AnswerEleven == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoEleven { get; set; }

        [DbColumn("AddInfoTwelve")]
        [RequiredIf("AnswerTwelve == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoTwelve { get; set; }

        [DbColumn("AddInfoThirteen")]
        [RequiredIf("AnswerThirteen == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoThirteen { get; set; }

        [DbColumn("AddInfoFourteen")]
        [RequiredIf("AnswerFourteen == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoFourteen { get; set; }

        [DbColumn("AddInfofifteen")]
        [RequiredIf("AnswerFifteen == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoFifteen { get; set; }

        [DbColumn("AddInfoSixteen")]
        [RequiredIf("AnswerSixteen == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoSixteen { get; set; }
        } 
    }
