using Microsoft.AspNetCore.Mvc;
using TenderSystem.Business.Abstract;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.DataAccess.Abstract;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BidsController : Controller
    {
            private IBidService _bidService;

            public BidsController(IBidService bidService)
            {
                _bidService = bidService;
            }

        [HttpGet("getall")]
        public Result GetAll()
        {
            return _bidService.GetAll();
        }

        [HttpGet("getbyid")]
        public Result GetById(int bidId)
        {
            return _bidService.GetById(bidId);
        }

        [HttpGet("getbytenderid")]
        public Result GetByTenderId(int tenderId)
        {
            return _bidService.GetByTenderId(tenderId);
        }

        [HttpGet("getbyclientid")]
        public Result GetByClientId(int clientId)
        {
            return _bidService.GetByClientId(clientId);
        }

        [HttpPost("add")]
        public Result Add(Bid bid)
        {
            return _bidService.Add(bid);
        }

        [HttpPut("update")]
        public Result Update(Bid bid)
        {
            return _bidService.Update(bid);
        }

        [HttpDelete("delete")]
        public Result Delete(int bidId)
        {
            return _bidService.Delete(bidId);
        }
    }
}