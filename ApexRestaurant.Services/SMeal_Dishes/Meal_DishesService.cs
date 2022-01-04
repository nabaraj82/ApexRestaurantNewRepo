using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RMeal_Dishes;

namespace ApexRestaurant.Services.SMeal_Dishes
{
    public class Meal_DishesService : GenericService<Meal_Dishes>, IMeal_DishesService
    {
        public Meal_DishesService(IMeal_DishesRepository meal_dishesRepository) :
        base(meal_dishesRepository)
        {

        }
    }
}