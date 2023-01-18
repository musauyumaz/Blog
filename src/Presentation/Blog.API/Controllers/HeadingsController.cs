using Blog.Application.Features.Headings.Commands.Create;
using Blog.Application.Features.Headings.Commands.Delete;
using Blog.Application.Features.Headings.Commands.Update;
using Blog.Application.Features.Headings.DTOs;
using Blog.Application.Features.Headings.Queries.GetAll;
using Blog.Application.Features.Headings.Queries.GetById;
using Blog.Application.Utilities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HeadingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HeadingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllHeadingsQueryRequest getAllHeadingsQueryRequest)
        {
            IDataResult<ListHeadingRootDTO> data = await _mediator.Send(getAllHeadingsQueryRequest);
            return Ok(data);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdHeadingQueryRequest getByIdHeadingQueryRequest)
        {
            IDataResult<HeadingDTO> data = await _mediator.Send(getByIdHeadingQueryRequest);
            return Ok(data);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteHeadingCommandRequest deleteHeadingCommandRequest)
        {
            IDataResult<HeadingDTO> data = await _mediator.Send(deleteHeadingCommandRequest);
            return Ok(data);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateHeadingCommandRequest updateHeadingCommandRequest)
        {
            IDataResult<HeadingDTO> data = await _mediator.Send(updateHeadingCommandRequest);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateHeadingCommandRequest createHeadingCommandRequest)
        {
            IDataResult<HeadingDTO> data = await _mediator.Send(createHeadingCommandRequest);
            return Ok(data);
        }
    }
}