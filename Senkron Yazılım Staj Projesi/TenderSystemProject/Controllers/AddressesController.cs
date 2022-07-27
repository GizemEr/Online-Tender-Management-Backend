using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TenderSystem.Business.Abstract;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : Controller
    {
            private IAddressService _addressService;

            public AddressesController(IAddressService addressService)
            {
                _addressService = addressService;
            }

        [HttpGet("getall")]
        public Result GetAll()
        {
            return _addressService.GetAll();
        }

        [HttpGet("getbyid")]
        public Result GetById(int addressId)
        {
            return _addressService.GetById(addressId);
        }

        [HttpGet("getbyclientid")]
        public Result GetByClientId(int clientId)
        {
            return _addressService.GetByClientId(clientId);
        }

        [HttpPost("add")]
        public Result Add(Address address)
        {
            return _addressService.Add(address);
        }

        [HttpPut("update")]
        public Result Update(Address address)
        {
            return _addressService.Update(address);
        }

        [HttpDelete("delete")]
        public Result Delete(int addressId)
        {
            return _addressService.Delete(addressId);
        }
    }
}
