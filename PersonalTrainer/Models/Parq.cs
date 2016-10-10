namespace PersonalTrainer.Models
{
    using System.ComponentModel.DataAnnotations;
    using ExpressiveAnnotations.Attributes;

    public class Parq
    {
        [Key]
        [Required(ErrorMessage = "Please enter your Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool Answer1 { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool Answer2 { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool Answer3 { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool Answer4 { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool Answer5 { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool Answer6 { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool Answer7 { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool Answer8 { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool Answer9 { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool Answer10 { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool Answer11 { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool Answer12 { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool Answer13 { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool Answer14 { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool Answer15 { get; set; }

        [Required(ErrorMessage = "Please Select Yes or No")]
        [Display(Name = "Yes/No")]
        public bool Answer16 { get; set; }

        [Required(ErrorMessage = "Please enter your current email address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Comments/Add info")]
        public string AddInfoParq { get; set; }

        [Required(ErrorMessage = "Please tick this box before you can continue")]
        public bool ParqAgreement { get; set; }

        [RequiredIf("Answer1 == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfo1 { get; set; }

        [RequiredIf("Answer2 == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfo2 { get; set; }

        [RequiredIf("Answer3 == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfo3 { get; set; }

        [RequiredIf("Answer4 == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfo4 { get; set; }

        [RequiredIf("Answer5 == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfo5 { get; set; }

        [RequiredIf("Answer6 == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfo6 { get; set; }

        [RequiredIf("Answer7 == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfo7 { get; set; }

        [RequiredIf("Answer8 == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfo8 { get; set; }

        [RequiredIf("Answer9 == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfo9 { get; set; }

        [RequiredIf("Answer10 == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfo10 { get; set; }

        [RequiredIf("Answer11 == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfo11 { get; set; }

        [RequiredIf("Answer12 == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfo12 { get; set; }

        [RequiredIf("Answer13 == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfo13 { get; set; }

        [RequiredIf("Answer14 == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfo14 { get; set; }

        [RequiredIf("Answer15 == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfo15 { get; set; }

        [RequiredIf("Answer16 == true", ErrorMessage = "As you have answered 'Yes' please add further information")]
        public string AddInfo16 { get; set; }
    }
}
