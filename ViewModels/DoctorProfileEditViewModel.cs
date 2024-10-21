﻿using System.ComponentModel.DataAnnotations;

namespace Project.ViewModels
{
    public class DoctorProfileEditViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [StringLength(500, ErrorMessage = "Bio must be less than 500 characters")]
        public string Bio { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "License number is required")]
        [Display(Name = "License Number")]
        [StringLength(20, ErrorMessage = "License number must be less than 20 characters")]
        public string LicenseNumber { get; set; }

        [Required(ErrorMessage = "Specialization is required")]
        public string SpecializationName { get; set; }

        [Required(ErrorMessage = "Clinic name is required")]
        [Display(Name = "Clinic Name")]
        [StringLength(50, ErrorMessage = "Clinic name must be less than 50 characters")]
        public string ClinicName { get; set; }

        [Required(ErrorMessage = "Clinic price is required")]
        [Display(Name = "Clinic Price")]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive value")]
        public double ClinicPrice { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(50, ErrorMessage = "City name must be less than 50 characters")]
        public string City { get; set; }

        [Required(ErrorMessage = "Area is required")]
        [StringLength(50, ErrorMessage = "Area name must be less than 50 characters")]
        public string Area { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, ErrorMessage = "Address must be less than 100 characters")]
        public string Address { get; set; }

        [Display(Name = "GPS Location")]
        public string GpsLoc { get; set; }
    }
}