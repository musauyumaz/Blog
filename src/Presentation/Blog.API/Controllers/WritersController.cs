using Blog.Application.Features.Writers.Commands.Create;
using Blog.Application.Features.Writers.Commands.Delete;
using Blog.Application.Features.Writers.Commands.Update;
using Blog.Application.Features.Writers.Queries.GetAll;
using Blog.Application.Features.Writers.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WritersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WritersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllWriterQueryRequest getAllWriterQueryRequest)
        {
            GetAllWriterQueryResponse response = await _mediator.Send(getAllWriterQueryRequest);
            return Ok(response);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetAll([FromRoute] GetByIdWriterQueryRequest getByIdWriterQueryRequest)
        {
            GetByIdWriterQueryResponse response = await _mediator.Send(getByIdWriterQueryRequest);
            return Ok(response);
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteWriterCommandRequest deleteWriterCommandRequest)
        {
            DeleteWriterCommandResponse response = await _mediator.Send(deleteWriterCommandRequest);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateWriterCommandRequest createWriterCommandRequest)
        {
            CreateWriterCommandResponse response = await _mediator.Send(createWriterCommandRequest);
            return Ok(response);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateWriterCommandRequest updateWriterCommandRequest)
        {
            UpdateWriterCommandResponse response = await _mediator.Send(updateWriterCommandRequest);
            return Ok(response);
        }
    }
}
