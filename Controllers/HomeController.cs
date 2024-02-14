using Microsoft.AspNetCore.Mvc;
using SG1.models;
using SG1.ViewModels;

namespace SG1.Controllers
{
    public class HomeController : Controller
    {
        User _user = new User("Ivan","qwe@mail.ru",27);
        Car _car = new Car("Honda",2012);

        public IActionResult Index()
        {
            IndexViewModel _indexViewModel = new IndexViewModel(
                new List<User>()
            { 
                _user,
                _user,
                _user
            }, 
                new List<Car>()
            {
                _car,
                _car,
                _car
            });
            ViewData["name"] = "Ivan";
            return View(_indexViewModel);
        }
        public IActionResult Short()
        {
            ViewData["name"] = "new Ivan";
            return View();
        }
    }
}
