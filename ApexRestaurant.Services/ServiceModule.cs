using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Services.SCustomer;
using ApexRestaurant.Services.SMenu;
using ApexRestaurant.Services.SMenu_Items;
using ApexRestaurant.Services.SMeals;
using ApexRestaurant.Services.SRef_Staff_Roles;
using ApexRestaurant.Services.SStaff;
using ApexRestaurant.Services.SMeal_Dishes;
namespace ApexRestaurant.Services
{
    public static class ServicesModule
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IMenuService, MenuService>();
            services.AddTransient<IMenu_ItemsService, Menu_ItemsService>();
            services.AddTransient<IMealsService, MealsService>();
            services.AddTransient<IRef_Staff_RolesService, Ref_Staff_RolesService>();
            services.AddTransient<IStaffService, StaffService>();
            services.AddTransient<IMeal_DishesService, Meal_DishesService>();
        }
    }
}