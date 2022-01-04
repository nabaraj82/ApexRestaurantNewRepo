using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RMeals;

namespace ApexRestaurant.Services.SMeals
{
    public class MealsService : GenericService<Meals>, IMealsService
    {
        public MealsService(IMealsRepository mealsRepository) :
        base(mealsRepository)
        {

        }
    }
}