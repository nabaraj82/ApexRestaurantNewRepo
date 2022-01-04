using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository.RMeals
{
    public class MealsRepository : GenericRepository<Meals>, IMealsRepository
    {
        public MealsRepository(RestaurantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}