using StudentAPI.Application.Dtos;
using StudentAPI.Domain;

namespace StudentAPI.Application.Profile;

public class ProfileMapping :AutoMapper.Profile
{
    public ProfileMapping()
    {
        CreateMap<StudentDto, Student>();
    }
}