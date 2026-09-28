using AutoMapper;
using LeaveManagement.WebV2.Data;
using LeaveManagement.WebV2.Models;

namespace LeaveManagement.WebV2.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType,LeaveTypeViewModel>().ReverseMap();
        }
    }
}
