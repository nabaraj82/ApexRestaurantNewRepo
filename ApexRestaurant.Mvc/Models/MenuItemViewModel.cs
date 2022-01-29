using System;

namespace ApexRestaurant.Mvc.Models
{
    public class MenuItem
    {
        public int Id { get; set; }

        public string MenuName { get; set; }

        public string AvailableDateFrom { get; set; }

        public bool IsActive { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }

    }
}