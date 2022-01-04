using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Repository.RCustomer;
using ApexRestaurant.Repository.RMeal_Dishes;
using ApexRestaurant.Repository.RMeals;
using ApexRestaurant.Repository.RMenu;
using ApexRestaurant.Repository.RRef_Staff_Roles;
using ApexRestaurant.Repository.RMenu_Items;
using ApexRestaurant.Repository.RStaff;

namespace ApexRestaurant.Repository
{
    public static class RepositoryModule
    {
        public static void Register(IServiceCollection services, string connection,
        string migrationsAssembly)
        {
            services.AddDbContext<RestaurantContext>(options =>
options.UseNpgsql(connection, builder =>
builder.MigrationsAssembly(migrationsAssembly)));
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IMeal_DishesRepository, Meal_DishesRepository>();
            services.AddTransient<IMealsRepository, MealsRepository>();
            services.AddTransient<IMenuRepository, MenuRepository>();
            services.AddTransient<IRef_Staff_RolesRepository, Ref_Staff_RolesRepository>();
            services.AddTransient<IMenu_ItemsRepository, Menu_ItemsRepository>();
            services.AddTransient<IStaffRepository, StaffRepository>();
        }
    }
}