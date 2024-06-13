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
    //GetAll
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        await _studentRepository.GetAll();
        return Ok(200);
    }
    //GetBiYd
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        await _studentRepository.GetById(id);
        return Ok(200);
    }
    
    
    //Create Student
    [HttpPost]
    public async Task<IActionResult> Create(Student student)
    {
       await _studentRepository.Create(student);
        return Ok(student);
    }
}