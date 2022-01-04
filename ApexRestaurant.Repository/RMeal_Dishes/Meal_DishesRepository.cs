using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository.RMeal_Dishes
{
    public class Meal_DishesRepository : GenericRepository<Meal_Dishes>, IMeal_DishesRepository
    {
        public Meal_DishesRepository(RestaurantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}