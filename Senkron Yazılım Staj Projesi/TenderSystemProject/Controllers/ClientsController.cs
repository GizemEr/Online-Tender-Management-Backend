using Microsoft.AspNetCore.Mvc;
using TenderSystem.Business.Abstract;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : Controller
    {
            private IClientService _clientService;

            public ClientsController(IClientService clientService)
            {
                _clientService = clientService;
            }

        [HttpGet("getall")]
        public Result GetAll()
        {
            return _clientService.GetAll();
        }

        [HttpGet("getbyid")]
        public Result GetById(int clientId)
        {
            return _clientService.GetById(clientId);
        }

        [HttpGet("getbyusername")]
        public Result GetByUserName(string userName)
        {
            return _clientService.GetByUserName(userName);
        }

        [HttpPost("add")]
        public Result Add(Client client)
        {
            return _clientService.Add(client);
        }

        [HttpPut("update")]
        public Result Update(Client client)
        {
            return _clientService.Update(client);
        }

        [HttpDelete("delete")]
        public Result Delete(int clientId)
        {
            return _clientService.Delete(clientId);
        }
    }
}