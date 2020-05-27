using System.ComponentModel.DataAnnotations;

namespace WestieClub.Models
{
    public class Referral
    {
        public static Referral Sup;
        [Display(Name="First Name*")]
        [Required]
        public string FirstName {get;set;}
        [Display(Name="Last Name")]
        public string LastName {get;set;}
        [Required]
        [Display(Name="City*")]
        public string City {get;set;}
        [Required]
        [Display(Name="State*")]
        public string State {get;set;}
        [Required]
        [EmailAddress]
        [Display(Name="Email Address*")]
        public string Email {get;set;}
        [Required]
        [EmailAddress]
        [Compare("Email")]
        [Display(Name="Repeat Email Address*")]
        public string EmailConfirm {get;set;}
        [Required]
        [Display(Name="Desired Gender*")]
        public string Gender {get;set;}
        public enum Genders
        {
            Male = 0, Female = 1, Either = 3
        };
        [Required]
        [Display(Name="Puppy or Adult*")]
        public string DesiredAge {get;set;}
        public enum Ages
        {
            Puppy = 0, Adult = 1, Either = 3
        };
        [Display(Name="What is your desired timing?")]
        public string Timing {get;set;}
        [Display(Name="Desired characteristics")]
        public string Characteristics {get;set;}
        [Display(Name="Comments or Questions")]
        public string Comments {get;set;}
        
    }
}