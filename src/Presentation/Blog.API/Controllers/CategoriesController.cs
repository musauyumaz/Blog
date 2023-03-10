using Blog.Application.Features.Categories.Commands.Create;
using Blog.Application.Features.Categories.Commands.Delete;
using Blog.Application.Features.Categories.Commands.Update;
using Blog.Application.Features.Categories.DTOs;
using Blog.Application.Features.Categories.Queries.GetAll;
using Blog.Application.Features.Categories.Queries.GetById;
using Blog.Application.Features.Categories.Queries.GetCategoryHeadingsByCategoryId;
using Blog.Application.Utilities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllCategoryQueryRequest getAllCategoryQueryRequest)
        {
            IDataResult<CategoryListRootDTO> response = await _mediator.Send(getAllCategoryQueryRequest);
            return Ok(response);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdCategoryQueryRequest getByIdCategoryQueryRequest)
        {
            IDataResult<CategoryDTO> response = await _mediator.Send(getByIdCategoryQueryRequest);
            return Ok(response);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetCategoryHeadingsByCategoryId([FromRoute] GetCategoryHeadingsByCategoryIdQueryRequest getCategoryHeadingsByCategoryIdQueryRequest)
        {
            IDataResult<CategoryHeadingsDTO> response = await _mediator.Send(getCategoryHeadingsByCategoryIdQueryRequest);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCategoryCommandRequest createCategoryCommandRequest)
        {
            IDataResult<CategoryDTO> response = await _mediator.Send(createCategoryCommandRequest);
            return Ok(response);
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteCategoryCommandRequest deleteCategoryCommandRequest)
        {
            IDataResult<CategoryDTO> response = await _mediator.Send(deleteCategoryCommandRequest);
            return Ok(response);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCategoryCommandRequest updateCategoryCommandRequest)
        {
            IDataResult<CategoryDTO> response = await _mediator.Send(updateCategoryCommandRequest);
            return Ok(response);
        }
    }
}
