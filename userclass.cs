using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Remoting.Services;

namespace Personal.Models
{
    public class userclass
    {
        [Required(ErrorMessage="Upload Profile Image!")]
        [Display(Name ="Profile Image:")]
        public string Img { get; set; }
        [Required(ErrorMessage = "Enter Username!")]
        [Display(Name = "Enter Username:")]
        public string rname { get; set; }
        [Required(ErrorMessage = "Enter Lastname!")]
        [Display(Name = "Enter Lastname:")]
        public string lname { get; set; }
        [Required(ErrorMessage = "Please enter the email address!")]
        [Display(Name = "Email Id:")]
        public string email { get; set; }
        [Required(ErrorMessage = "Select Gender!")]
        [Display(Name = "Gender:")]
        public string gender { get; set; }
        [Required(ErrorMessage = "Please enter Address!")]
        [Display(Name = "Enter Address:")]
        public string address { get; set; }
        [Required(ErrorMessage = "Please enter City!")]
        [Display(Name = "Enter City:")]
        public string city { get; set; }
        [Required(ErrorMessage = "Please enter State!")]
        [Display(Name = "Enter State:")]
        public string state { get; set; }
        [Required(ErrorMessage = "Please enter Pincode!")]
        [Display(Name = "Pincode:")]
        public int rcode { get; set; }
        [Required(ErrorMessage = "Please enter Contact Number!")]
        [Display(Name = "Contact number:")]
        public string phone { get; set; }


    }
}