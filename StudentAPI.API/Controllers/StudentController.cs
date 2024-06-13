using Microsoft.AspNetCore.Mvc;
using StudentAPI.Application.Repositories;
using StudentAPI.Domain;

namespace StudentAPI.Controllers;

public class StudentController:ApiBaseController
{
    private readonly IStudentRepository _studentRepository;

    public StudentController(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }
    
    //Create Student
    [HttpPost]
    public async Task<IActionResult> Create(Student student)
    {
       await _studentRepository.Create(student);
        return Ok(student);
    }
}