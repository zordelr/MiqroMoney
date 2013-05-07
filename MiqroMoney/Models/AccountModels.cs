using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace MiqroMoney.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext() : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }

    [Table("UserProfile")]
    public class UserProfile
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
	    public string MI { get; set; }
	    public string BirthDate { get; set; }
	    public string SSN { get; set; }
	    public int PercentOwnership { get; set; }
	    public string Title { get; set; }
	    public string DL { get; set; }
	    public string DLState { get; set; }
	    public string HomeAddress { get; set; }
	    public string City { get; set; }
	    public string State { get; set; }
	    public string Zip { get; set; }
	    public string HomePhone { get; set; }
	    public string CellPhone { get; set; }
        public string FaxNumber { get; set; }

    }

    public class LocalPasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(1, ErrorMessage= "The {0} field must be 1 character.")]
        [Display(Name = "Middle Initial")]
        public string MI { get; set; }

        [Required]
        [Display(Name = "Birth Date")]
        public string BirthDate { get; set; }

        [Required]
        [Display(Name = "SSN")]
        public string SSN { get; set; }

        [Required]
        [Display(Name = "% Ownsership")]
        public string PercentOwnership { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Driver's License #")]
        public string DL { get; set; }

        [Required]
        [Display(Name = "DL State")]
        public string DLState { get; set; }

        [Required]
        [Display(Name = "Home Address")]
        public string HomeAddress { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public string Zip { get; set; }

        [Required]
        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }

        [Required]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        [Required]
        [Display(Name = "Fax Number")]
        public string FaxNumber { get; set; }
    }

}
