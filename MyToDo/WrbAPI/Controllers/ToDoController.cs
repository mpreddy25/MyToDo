using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : Controller
    {
        List<ToDoModel> _toDoList = new List<ToDoModel>();
        public ToDoController()
        {
            _toDoList.Add(new ToDoModel() { Id = 1, Title="Task 1"});
            _toDoList.Add(new ToDoModel() { Id = 2, Title="Task 2"});
        }

        [HttpGet(Name = "GetAll")]
        public List<ToDoModel> GetAll()
        {
            return _toDoList;
        }
    }
}
