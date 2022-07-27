using Microsoft.AspNetCore.Mvc;
using TenderSystem.Business.Abstract;
using TenderSystem.Core.Utilities.Results;

namespace TenderSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenderStatusesController : Controller
    {
            private ITenderStatusService _tenderStatusService;

            public TenderStatusesController(ITenderStatusService tenderStatusService)
            {
                _tenderStatusService = tenderStatusService;
            }

        [HttpGet("getall")]
        public Result GetAll()
        {
            return _tenderStatusService.GetAll();
        }

        [HttpGet("getbyid")]
        public Result GetById(int tenderStatusId)
        {
            return _tenderStatusService.GetById(tenderStatusId);
        }
    }
}