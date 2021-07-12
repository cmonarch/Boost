using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class BaseAPIController : ControllerBase
    {
       int Chuck = 0; 
    }
}