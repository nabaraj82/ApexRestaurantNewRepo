using System;

namespace ApexRestaurant.Mvc.Models
{
    public class StaffRole
    {
        public int Id { get; set; }

        public string StaffRoleDescription { get; set; }

        public bool IsActive { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }

    }
}