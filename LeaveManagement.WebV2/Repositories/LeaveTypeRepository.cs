using LeaveManagement.WebV2.Data;

namespace LeaveManagement.WebV2.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
