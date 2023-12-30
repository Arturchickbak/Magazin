using Microsoft.AspNetCore.Mvc;
using Svyaznoi.Context;
using Svyaznoi.Context.Contracts.Models;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace Svyaznoi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MagazinController : ControllerBase
    {
        private readonly IContext context1;
        public MagazinController(IContext context1)
        {
            this.context1 = context1;
        }

        [HttpGet] //localhost:111224/group
        public IActionResult GetAllNakladnaya()
        {
            var magazinlist = context1.Magazins.ToList();
            return Ok(magazinlist);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var magazinlist = context1.Magazins.FirstOrDefault(x => x.Id == id);
            return Ok(magazinlist);
        }

        [HttpPost]
        public IActionResult Create(Context.Contracts.Models.Magazin model)
        {
            var item = new Context.Contracts.Models.Magazin
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Address = model.Address,
                City = model.City,  
            };
            context1.Magazins.Add(item);
            context1.SaveChanges();
            return Ok(item);
        }

        [HttpDelete("{id}")] 
        public IActionResult Delete(Guid id) 
        {
            var group = context1.Magazins.FirstOrDefault(x => x.Id == id);
            if (group != null)
            {
                context1.Magazins.Remove(group);
            }
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Edit(Guid Id, Context.Contracts.Models.Magazin model)
        {
         var group = context1.Magazins.FirstOrDefault(x => x.Id == Id);
            if (group != null) 
            {
                return NotFound();
            }
            group.Name = model.Name;
            group.Address = model.Address;
            group.City = model.City;    

            context1.SaveChanges();

            return Ok(group);
        }
    }
}
