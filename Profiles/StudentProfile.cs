using AutoMapper;
using smsapi.DTO;

namespace smsapi.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Model.Student, StudentDto>()
           .ForMember(dest => dest.StudentId, opt => opt.MapFrom(src => src.StudentId))
           .ForMember(dest => dest.FName, opt => opt.MapFrom(src => src.FName))
           .ForMember(dest => dest.DOB, opt => opt.MapFrom(src => src.DOB))
           .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
           .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
           .ForMember(dest => dest.LName, opt => opt.MapFrom(src => src.LName))
           .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FName + src.LName));

        }

    }
}