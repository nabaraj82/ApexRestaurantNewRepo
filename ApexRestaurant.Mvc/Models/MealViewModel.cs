using System;

namespace ApexRestaurant.Mvc.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string DateOfMeal { get; set; }
        public string CostOfMeal { get; set; }
        public string OtherDetails { get; set; }
    }
}