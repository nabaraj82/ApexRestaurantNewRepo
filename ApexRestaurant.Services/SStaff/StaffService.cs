using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RStaff;

namespace ApexRestaurant.Services.SStaff
{
    public class StaffService : GenericService<Staff>, IStaffService
    {
        public StaffService(IStaffRepository staffRepository) :
        base(staffRepository)
        {

        }
    }
}