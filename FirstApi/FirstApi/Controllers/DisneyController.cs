using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApi.Model;
using FirstApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    public class DisneyController : Controller
    {
        private readonly IDisneyServices _disneyServices;

        public DisneyController(IDisneyServices disneyServices)
        {
            _disneyServices = disneyServices;
        }


        [HttpGet]
        [Route("v1/disney")]
        public ActionResult GetCharacters()
        {
            ViewBag.Message = "Marvel Search Prototype";

            return View();
        }

        [HttpPost]
        [Route("v1/disney/random")]
        public async Task<IActionResult> Display(Search model)
        {
            var result = await _disneyServices.GetRandomDisBasedOnSearchCritera(model);

            return Ok(result);
        }

    }
}


