using StudentAPI.Domain;

namespace StudentAPI.Application.Repositories;

public interface IStudentRepository
{
    Task Create(Student student);

    Task<List<Student>> GetAll();
    Task GetById(int id);
}