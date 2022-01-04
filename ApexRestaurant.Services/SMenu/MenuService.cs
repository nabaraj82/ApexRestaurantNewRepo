using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RMenu;

namespace ApexRestaurant.Services.SMenu
{
    public class MenuService : GenericService<Menu>, IMenuService
    {
        public MenuService(IMenuRepository menuRepository) :
        base(menuRepository)
        {

        }
    }
}