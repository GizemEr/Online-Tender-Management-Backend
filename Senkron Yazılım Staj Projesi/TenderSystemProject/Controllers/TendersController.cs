using Microsoft.AspNetCore.Mvc;
using TenderSystem.Business.Abstract;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.Entities.Concrete;
using TenderSystem.Core.Utilities.RandomNumberGenerator;

namespace TenderSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TendersController : Controller
    {
            private ITenderService _tenderService;
            private IRandomNumberGenerator _randomNumberGenerator;
            
            public TendersController(ITenderService tenderService, IRandomNumberGenerator randomNumberGenerator)
            {
                _tenderService = tenderService;
                _randomNumberGenerator = randomNumberGenerator;
            }
        
        [HttpGet("getall")]
        public Result GetAll()
        {
            return _tenderService.GetAll();
        }

        [HttpGet("getbyid")]
        public Result GetById(int tenderId)
        {
            return _tenderService.GetById(tenderId);
        }

        [HttpGet("getbytenderno")]
        public Result GetByTenderNo(int tenderNo)
        {
            return _tenderService.GetByTenderNo(tenderNo);
        }

        [HttpGet("getbyadminid")]
        public Result GetByAdminId(int adminId)
        {
            return _tenderService.GetByAdminId(adminId);
        }

        [HttpGet("getbywinnerclientid")]
        public Result GetByWinnerClientId(int winnerClientId)
        {
            return _tenderService.GetByWinnerClientId(winnerClientId);
        }

        [HttpGet("getbycategoryid")]
        public Result GetByCategoryId(int categoryId)
        {
            return _tenderService.GetByCategoryId(categoryId);
        }

        [HttpGet("getbystatusid")]
        public Result GetByStatusId(int statusId)
        {
            return _tenderService.GetByStatusId(statusId);
        }

        [HttpGet("getbystartprice")]
        public Result GetByStartPrice(decimal min, decimal max)
        {
            return _tenderService.GetByStartPrice(min, max);
        }

        [HttpGet("getbyclientid")]
        public Result GetByClientId(int clientId)
        {
            return _tenderService.GetByClientId(clientId);
        }

        [HttpGet("getbystatusandcategoryid")]
        public Result GetByStatusAndCategoryId(int statusId, int categoryId)
        {
            return _tenderService.GetByStatusAndCategoryId(statusId, categoryId);
        }

        [HttpPost("add")]
        public Result Add(Tender tender)
        {
            tender.TenderNo = _randomNumberGenerator.EightDigits();
            return _tenderService.Add(tender);
        }

        [HttpPut("update")]
        public Result Update(Tender tender)
        {
            return _tenderService.Update(tender);
        }

        [HttpDelete("delete")]
        public Result Delete(int tenderId)
        {
            return _tenderService.Delete(tenderId);
        }
    }
}