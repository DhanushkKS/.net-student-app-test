using StudentAPI.Domain;

namespace StudentAPI.Application.Repositories;

public interface IStudentRepository
{
    Task Create(Student student);
}