using AutoMapper;
using MyStudentApp.Dtos;

namespace MyStudentApp;

public class MyStudentAppApplicationAutoMapperProfile : Profile
{
    public MyStudentAppApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Student, StudentDto>().ReverseMap();
        CreateMap<Student, CreateUpdateStudentDto>().ReverseMap();
    }
}
