using AutoMapper;
using smsapi.DTO;

namespace smsapi.Profiles
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Model.Department, DepartmentDto>()
           .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
           .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.DepartmentName));






        }

    }
}