using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examples.Charge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonPhoneController : BaseController
    {
        private readonly IPersonPhoneFacade _facade;

        public PersonPhoneController(IPersonPhoneFacade facade)
        {
            _facade = facade;
        }

        [HttpGet]
        public async Task<ActionResult<ListPersonPhoneResponse>> Get() => Response(await _facade.FindAllAsync());

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonPhoneResponse>> Get(int id)
        {
            return Response(await _facade.FindAsync(id));
        }

        //[HttpPost]
        //public IActionResult Post([FromBody] ExampleRequest request)
        //{
        //    return Response(0, null);
        //}

        // POST: PersonPhoneController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: PersonPhoneController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: PersonPhoneController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: PersonPhoneController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: PersonPhoneController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
