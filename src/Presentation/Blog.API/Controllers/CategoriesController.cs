using Blog.Application.Features.Categories.Commands.Create;
using Blog.Application.Features.Categories.Queries.GetAll;
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
        public async Task<IActionResult> GetAll([FromQuery]GetAllCategoryQueryRequest getAllCategoryQueryRequest)
        {
            GetAllCategoryQueryResponse response = await _mediator.Send(getAllCategoryQueryRequest);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreateCategoryCommandRequest createCategoryCommandRequest)
        {
            CreateCategoryCommandResponse response = await _mediator.Send(createCategoryCommandRequest);
            return Ok(response);
        }
    }
}
