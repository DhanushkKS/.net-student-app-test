using Microsoft.AspNetCore.Mvc;

namespace StudentAPI.Controllers;
[ApiController]
[Route(BasePath+"[controller]")]
public class ApiBaseController:ControllerBase
{
    private const string BasePath = "/api";
}