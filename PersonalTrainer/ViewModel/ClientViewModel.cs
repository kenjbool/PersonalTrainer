using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ExpressiveAnnotations.Attributes;

namespace PersonalTrainer.ViewModel
{
    public class ClientViewModel
    {
        public int ClientNum { get; set; }

        [Key]
        public string ClientId { get; set; }

        [Required(ErrorMessage = "Please enter a first name")]
        [Display(Name = "First Name:")]
        public string FName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last Name:")]
        public string LName { get; set; }

        [Required(ErrorMessage = "Please enter house name/number")]
        [Display(Name = "Please enter your address:")]
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

        public List<string> GoalList { get; set; }

        [Display(Name = "Additional Info:")]
        public string AddInfo { get; set; }

        public DateTime RegistrationDate { get; set; }

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