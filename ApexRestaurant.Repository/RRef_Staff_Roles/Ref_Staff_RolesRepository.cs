using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository.RRef_Staff_Roles
{
    public class Ref_Staff_RolesRepository : GenericRepository<Ref_Staff_Roles>, IRef_Staff_RolesRepository
    {
        public Ref_Staff_RolesRepository(RestaurantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}