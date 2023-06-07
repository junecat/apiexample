using apiexample;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class DemoController : ControllerBase {
    static int num = 0;

    [HttpGet(Name ="Demo")]
    public int Get() {
        return ++num; 
    }

}