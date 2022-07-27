using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TenderSystem.Business.Abstract;
using TenderSystem.Core.Utilities.RandomNumberGenerator;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : Controller
    {
                private ICategoryService _categoryService;
                
                public CategoriesController(ICategoryService categoryService)
                {
                    _categoryService = categoryService;
                }
            
            [HttpGet("getall")]
            public Result GetAll()
            {
                return _categoryService.GetAll();
            }
            
            [HttpGet("getbyid")]
            public Result GetById(int categoryId)
            {
                return _categoryService.GetById(categoryId);
            }
            
            [HttpPost("add")]
            public Result Add(Category category)
            {
                return _categoryService.Add(category);
            }

            [HttpPut("update")]
            public Result Update(Category category)
            {
                return _categoryService.Update(category);
            }

            [HttpDelete("delete")]
            public Result Delete(int categoryId)
            {
                return _categoryService.Delete(categoryId);
            }
    }
}
