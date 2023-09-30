using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Chasty caacoy", StudentId = "211467", StudentAge = "20" },
            new StudentInfoModel { Name = "Vergilia Caacoy", StudentId = "211567", StudentAge = "25" },
            new StudentInfoModel { Name = "Domingo Caacoy", StudentId = "211667", StudentAge = "31" }
        };

        return View(studentInfoArray);
    }
}
