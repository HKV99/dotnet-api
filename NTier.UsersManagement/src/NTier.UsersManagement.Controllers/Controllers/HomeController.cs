using Microsoft.AspNetCore.Mvc;

namespace NTier.UsersManagement.Controllers.Controllers;

public class ApiResponse<T>
{
    public int StatusCode { get; set; }
    public string? Message { get; set; }
    public T? Data { get; set; }
}

[ApiController]
[Route("/api/home")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public async Task<ApiResponse<string>> Get()
    {
        return new ApiResponse<string> 
        { 
            StatusCode = 200,
            Message = "Success", 
            Data = "Success"
        };
    }
}
