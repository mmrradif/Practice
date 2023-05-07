using Microsoft.AspNetCore.Mvc;
using Practice.Interfaces;
using Practice.Models;

namespace Practice.Controllers
{
    public class EmployeeController : GetController<Employee>
    {

        //private readonly IGet<Employee> _get;
        public EmployeeController(IGet<Employee> get) : base(get)
        {
        }



        [HttpGet("employees")]
        public async Task<IActionResult> Index()
        {
            try
            {
                return await base.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }


        [HttpGet("employees/{id}")]
        public async Task<IActionResult> SearchById(int id)
        {
            try
            {
                return await base.GetAll(id);
            }
            catch (Exception)
            {
                throw;
            }
        }



        [HttpGet("employees/searchbyname/{name}")]
        public async Task<IActionResult> SearchByAName(string name)
        {
            try
            {
                return await base.GetAll(name);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
