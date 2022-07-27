using System.Runtime.InteropServices.ComTypes;
using Microsoft.AspNetCore.Mvc;
using TenderSystem.Business.Abstract;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : Controller
    {
            private IImageService _imageService;

            public ImagesController(IImageService imageService)
            {
                _imageService = imageService;
            }

        [HttpGet("getall")]
        public Result GetAll()
        {
            return _imageService.GetAll();
        }

        [HttpGet("getbyid")]
        public Result GetById(int imageId)
        {
            return _imageService.GetById(imageId);
        }

        [HttpGet("getbytenderid")]
        public Result GetByTenderId(int tenderId)
        {
            return _imageService.GetByTenderId(tenderId);
        }

        [HttpPost("add")]
        public Result Add(Image image)
        {
            return _imageService.Add(image);
        }

        [HttpPut("update")]
        public Result Update(Image image)
        {
            return _imageService.Update(image);
        }

        [HttpDelete("delete")]
        public Result Delete(int imageId)
        {
            return _imageService.Delete(imageId);
        }
    }
}