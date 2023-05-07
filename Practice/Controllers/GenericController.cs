using Microsoft.AspNetCore.Mvc;
using Practice.Context;
using Practice.Interfaces;

namespace Practice.Controllers
{
    public class GenericController<T> : Controller where T : class
    {
        private readonly  IGet<T> _get;

        public GenericController(IGet<T> get)
        {
            this._get = get;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var data = await _get.GetAll(); 

                if (data == null)
                {
                    return Ok("There is no data");
                }
                return Ok(data);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
