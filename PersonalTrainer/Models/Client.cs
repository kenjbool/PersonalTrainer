using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ExpressiveAnnotations.Attributes;

namespace PersonalTrainer.Models
{
    public class Client
    {
        public Client()
        {
        }

        public int ClientNum { get; set; }

        public string ClientId { get; set; }

        [Required(ErrorMessage = "Please enter a first name")]
        [Display(Name = "First Name:")]
        public string FName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last Name:")]
        public string LName { get; set; }

        [Required(ErrorMessage = "Please enter house name/number")]
        [Display(Name="Please enter your address:")]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Please enter a valid postcode")]
        [Display(Name = "Post code:")]
        public string Postcode { get; set; }

        [Required(ErrorMessage = "Please enter your age")]
        [Display(Name = "Age:")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please select Gender")]
        [Display(Name = "Gender:")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter your Date of Birth")]
        [Display(Name = "Date Of Birth:")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        [Display(Name = "Email Address:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a valid Phone number")]
        // [RegularExpression("\b{5}[ ]{6}\b", ErrorMessage="Please enter a valid phone number in the format \"XXXXX XXXXXX\"")]
        [Display(Name = "Phone Number:")]
        public string Phone { get; set; }

        [Display(Name = "Emergency Contact:")]
        public string EmergencyContact { get; set; }

        [Required(ErrorMessage = "Please enter an emergency contact number")]
        [Display(Name = "Emergency Contact Number:")]
        public string EmergencyContactNumber { get; set; }

        [Required(ErrorMessage = "Please enter your height in centimeters")]
        [Display(Name = "Height(cm):")]
        public decimal Height { get; set; }

        [Required(ErrorMessage = "Please enter your weight in kg's")]
        [Display(Name = "Weight(kg):")]
        public decimal Weight { get; set; }

        [Display(Name = "Clients BMI:")]
        public decimal BodyMass { get; set; }

        public List<string> GoalList { get; set; }

        [Display(Name = "Goal:")]
        public string GoalId { get; set; }

        public bool SpecifiedGoal { get; set; }

        [RequiredIf("SpecifiedGoal == true")]
        [Display(Name = "Specific Goal Name:")]
        public string GoalSpecificName { get; set; }

        public string Focus { get; set; }

        public DateTime RegistrationDate { get; set; }

        [Display(Name = "Additional Info:")]
        public string AddInfo { get; set; }

        [Display(Name = "Body Composition")]
        public string BodyComposition { get; set; }

        [Display(Name = "Body Fat %")]
        public double BodyFatPercentage { get; set; }

        [Display(Name = "Waist")]
        public int Waist { get; set; }

        [Display(Name = "Hips")]
        public int Hips { get; set; }

        [Display(Name = "Chest")]
        public int Chest { get; set; }

        [Display(Name = "Arm")]
        public int Arm { get; set; }

        [Display(Name = "Thigh")]
        public int Thigh { get; set; }

        [Display(Name = "Systolic BP")]
        public int BloodPressureSystolic { get; set; }

        [Display(Name = "Diastolic BP")]
        public int BloodPressureDiastolic { get; set; }

        [Display(Name = "Resting HR")]
        public decimal RestingHeartRate { get; set; }

        [Display(Name = "HR Zone 1")]
        public decimal HeartRateZone1 { get; set; }

        [Display(Name = "HR Zone 2")]
        public decimal HeartRateZone2 { get; set; }

        [Display(Name = "HR Zone 3")]
        public decimal HeartRateZone3 { get; set; }
    }

    public class Parq
    {
        [Key]
        [Required(ErrorMessage = "Please enter your Full Name")]
        [RegularExpression("^[a-zA-Z\\s]+ [a-zA-Z\\s]+", ErrorMessage = "Please make sure you have entered your full name")]
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

    public enum Gender
    {
        Male,
        Female
    }

    public enum Goal
    {
        ToneUp,
        LoseWeight,
        BuildMuscle,
        LookGoodNaked,
        GoalSpecific
    }
}