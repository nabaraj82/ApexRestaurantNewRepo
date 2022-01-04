using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RRef_Staff_Roles;

namespace ApexRestaurant.Services.SRef_Staff_Roles
{
    public class Ref_Staff_RolesService : GenericService<Ref_Staff_Roles>, IRef_Staff_RolesService
    {
        public Ref_Staff_RolesService(IRef_Staff_RolesRepository ref_staff_rolesRepository) :
        base(ref_staff_rolesRepository)
        {

        }
    }
}