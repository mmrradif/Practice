using Microsoft.AspNetCore.Mvc;
using Practice.Interfaces;

namespace Practice.Controllers
{
    public class GetController<T> : Controller where T : class
    {
        private readonly IGet<T> _get;

        public GetController(IGet<T> get)
        {
            this._get = get;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var data = await _get.GetAll();
                return View(data);
            }
            catch (Exception)
            {

                throw;
            }
        }


        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetAll(int id)
        //{
        //    try
        //    {
        //        var data = await _get.GetAll(id);
        //        return View(data);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}


        [HttpGet("{id}")]
        public async Task<IActionResult> GetAll(int id)
        {
            try
            {
                var employee = await _get.GetAll(id);
                if (employee == null)
                {
                    return View("SearchById");
                }
                return View("SearchById", employee);
            }
            catch (Exception)
            {
                throw;
            }
        }


        [HttpGet("{name}")]
        public async Task<IActionResult> GetAll(string name)
        {
            try
            {
                var data = await _get.GetAll(name);
                return View(data);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
