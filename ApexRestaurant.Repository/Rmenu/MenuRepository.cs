using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository.RMenu
{
    public class MenuRepository : GenericRepository<Menu>, IMenuRepository
    {
        public MenuRepository(RestaurantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}