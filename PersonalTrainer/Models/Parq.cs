using System.ComponentModel.DataAnnotations;
using ExpressiveAnnotations.Attributes;

namespace PersonalTrainer.Models
{
    public class Parq
    {
        [CustomAttribute.DbColumn("AnswerOne")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name="Yes/No")]
        public bool AnswerOne { get; set; }

        [CustomAttribute.DbColumn("AnswerTwo")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerTwo { get; set; }

        [CustomAttribute.DbColumn("AnswerThree")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerThree { get; set; }

        [CustomAttribute.DbColumn("AnswerFour")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerFour { get; set; }

        [CustomAttribute.DbColumn("AnswerFive")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerFive { get; set; }

        [CustomAttribute.DbColumn("AnswerSix")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerSix { get; set; }

        [CustomAttribute.DbColumn("AnswerSeven")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerSeven { get; set; }

        [CustomAttribute.DbColumn("AnswerEight")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerEight { get; set; }

        [CustomAttribute.DbColumn("AnswerNine")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerNine { get; set; }

        [CustomAttribute.DbColumn("AnswerTen")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerTen { get; set; }

        [CustomAttribute.DbColumn("AnswerEleven")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerEleven { get; set; }

        [CustomAttribute.DbColumn("AnswerTwelve")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerTwelve { get; set; }

        [CustomAttribute.DbColumn("AnswerThirteen")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerThirteen { get; set; }

        [CustomAttribute.DbColumn("AnswerFourteen")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerFourteen { get; set; }

        [CustomAttribute.DbColumn("AnswerFifteen")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerFifteen { get; set; }

        [CustomAttribute.DbColumn("AnswerSixteen")]
        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool AnswerSixteen { get; set; }

        [Required(ErrorMessage = "Please enter your Name")]
        [Display(Name="Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your current email address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [CustomAttribute.DbColumn("AdditionalInfo")]
        [Display(Name = "Comments/Add info")]
        public string AddInfoParq { get; set; }

        [Required(ErrorMessage = "Please tick this box before you can continue")]
        public bool ParqAgreement { get; set; }

        [CustomAttribute.DbColumn("AddInfoOne")]
        [RequiredIf("AnswerOne == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoOne { get; set; }

        [CustomAttribute.DbColumn("AddInfoTwo")]
        [RequiredIf("AnswerTwo == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoTwo { get; set; }

        [CustomAttribute.DbColumn("AddInfoThree")]
        [RequiredIf("AnswerThree == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoThree { get; set; }

        [CustomAttribute.DbColumn("AddInfoFour")]
        [RequiredIf("AnswerFour == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoFour { get; set; }

        [CustomAttribute.DbColumn("AddInfoFive")]
        [RequiredIf("AnswerFive == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoFive { get; set; }

        [CustomAttribute.DbColumn("AddInfoSix")]
        [RequiredIf("AnswerSix == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoSix { get; set; }

        [CustomAttribute.DbColumn("AddInfoSeven")]
        [RequiredIf("AnswerSeven == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoSeven { get; set; }

        [CustomAttribute.DbColumn("AddInfoEight")]
        [RequiredIf("AnswerEight == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoEight { get; set; }

        [CustomAttribute.DbColumn("AddInfoNine")]
        [RequiredIf("AnswerNine == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoNine { get; set; }

        [CustomAttribute.DbColumn("AddInfoTen")]
        [RequiredIf("AnswerTen == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoTen { get; set; }

        [CustomAttribute.DbColumn("AddInfoEleven")]
        [RequiredIf("AnswerEleven == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoEleven { get; set; }

        [CustomAttribute.DbColumn("AddInfoTwelve")]
        [RequiredIf("AnswerTwelve == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoTwelve { get; set; }

        [CustomAttribute.DbColumn("AddInfoThirteen")]
        [RequiredIf("AnswerThirteen == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoThirteen { get; set; }

        [CustomAttribute.DbColumn("AddInfoFourteen")]
        [RequiredIf("AnswerFourteen == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoFourteen { get; set; }

        [CustomAttribute.DbColumn("AddInfofifteen")]
        [RequiredIf("AnswerFifteen == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoFifteen { get; set; }

        [CustomAttribute.DbColumn("AddInfoSixteen")]
        [RequiredIf("AnswerSixteen == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfoSixteen { get; set; }
        } 
    }
