using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _categoryService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CategoriesViewModel>>(products));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            return Ok(_mapper.Map<CategoriesViewModel>(category));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CreateCategoryModel model)
        {
            var newCategory = await _categoryService.AddAsync(_mapper.Map<Category>(model));
            return Created(string.Empty, _mapper.Map<CreateCategoryModel>(newCategory));
        }

        [HttpPut]
        public IActionResult Update([FromBody] UpdateCategoryModel model,int id)
        {
            var updatedCategory = _categoryService.Update(_mapper.Map<Category>(model));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var category = _categoryService.GetByIdAsync(id).Result;
            _categoryService.Remove(category);
            return NoContent();
        }
    }
}
