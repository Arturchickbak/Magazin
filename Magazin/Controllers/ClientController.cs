using Microsoft.AspNetCore.Mvc;
using Svyaznoi.Context;
using Svyaznoi.Context.Contracts.Models;

namespace Svyaznoi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IContext context1;
        public ClientController(IContext context1)
        {
            this.context1 = context1;
        }
        [HttpGet] //localhost:111224/group
        public IActionResult GetAllPlatelshik()
        {
            var clientlist = context1.Clients.ToList();
            return Ok(clientlist);
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var clientlist = context1.Clients.FirstOrDefault(x => x.Id == id);
            return Ok(clientlist);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var group1 = context1.Clients.FirstOrDefault(x => x.Id == id);
            if (group1 != null)
            {
                context1.Clients.Remove(group1);
            }
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(Client model)
        {
            var item1 = new Client
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Number = model.Number,
                Email= model.Email,
                Card = model.Card,
            };
            context1.Clients.Add(item1);
            context1.SaveChanges();
            return Ok(item1);
        }
        [HttpPut("{id}")]
        public IActionResult Edit(Guid Id, Client model)
        {
            var group1 = context1.Clients.FirstOrDefault(x => x.Id == Id);
            if (group1 != null)
            {
                return NotFound();
            }
            group1.Name = model.Name;
            group1.Number = model.Number;
            group1.Email = model.Email;
            group1.Card = model.Card;
            context1.SaveChanges();

            return Ok(group1);
        }
    }
}
