using StudentAPI.Application.Repositories;
using StudentAPI.Domain;

namespace StudentAPI.Infrascture.Repositories;

public class StudentRepository:IStudentRepository
{
    private readonly StudentDbContext _dbContext;

    public StudentRepository(StudentDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public  Task Create(Student student)
    {

         _dbContext.Students.Add(student);
         return Task.FromResult(student);
    }

    public Task<List<Student>> GetAll()
    {
      var students =   _dbContext.Students.ToList();
      return Task.FromResult(students);
    }

    public Task GetById(int id)
    {
        var student = _dbContext.Students.FirstOrDefault(s => s.Id == id);
        return Task.FromResult(student);
    }
}