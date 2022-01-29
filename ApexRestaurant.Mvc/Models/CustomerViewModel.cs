using System;
using System.ComponentModel.DataAnnotations;
namespace ApexRestaurant.Mvc.Models
{
    public class CustomerViewModel
    {


        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneRes { get; set; }
        public string PhoneMob { get; set; }
        public DateTime EnrollDate { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}