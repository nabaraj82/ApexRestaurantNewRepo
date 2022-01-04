using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository.RMenu_Items
{
    public class Menu_ItemsRepository : GenericRepository<Menu_Items>, IMenu_ItemsRepository
    {
        public Menu_ItemsRepository(RestaurantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}