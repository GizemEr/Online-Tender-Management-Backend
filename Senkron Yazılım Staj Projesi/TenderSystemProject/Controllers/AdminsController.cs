using Microsoft.AspNetCore.Mvc;
using TenderSystem.Business.Abstract;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : Controller
    {
            private IAdminService _adminService;

            public AdminsController(IAdminService adminService)
            {
                _adminService = adminService;
            }

        [HttpGet("getall")]
        public Result GetAll()
        {
            return _adminService.GetAll();
        }

        [HttpGet("getbyid")]
        public Result GetById(int adminId)
        {
            return _adminService.GetById(adminId);
        }

        [HttpPost("add")]
        public Result Add(Admin admin)
        {
            return _adminService.Add(admin);
        }

        [HttpPut("update")]
        public Result Update(Admin admin)
        {
            return _adminService.Update(admin);
        }

        [HttpDelete("delete")]
        public Result Delete(int adminId)
        {
            return _adminService.Delete(adminId);
        }
    }
}