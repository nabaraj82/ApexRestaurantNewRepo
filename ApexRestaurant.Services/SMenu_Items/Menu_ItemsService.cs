using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RMenu_Items;

namespace ApexRestaurant.Services.SMenu_Items
{
    public class Menu_ItemsService : GenericService<Menu_Items>, IMenu_ItemsService
    {
        public Menu_ItemsService(IMenu_ItemsRepository menu_itemsRepository) :
        base(menu_itemsRepository)
        {

        }
    }
}