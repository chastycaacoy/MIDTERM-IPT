using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Chasty Mae Caacoy", StudentId = "211467", StudentAge = "20" },
            new StudentInfoModel { Name = "Vergilia Caacoy", StudentId = "211567", StudentAge = "30" },
            new StudentInfoModel { Name = "Domingo Caacoy", StudentId = "211667", StudentAge = "40" }
        };

        return View(studentInfoArray);
    }
}
