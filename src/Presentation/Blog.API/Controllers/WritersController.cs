using Blog.Application.Features.Writers.Commands.Create;
using Blog.Application.Features.Writers.Commands.Delete;
using Blog.Application.Features.Writers.Commands.Update;
using Blog.Application.Features.Writers.DTOs;
using Blog.Application.Features.Writers.Queries.GetAll;
using Blog.Application.Features.Writers.Queries.GetById;
using Blog.Application.Features.Writers.Queries.GetHeadingsByWriter;
using Blog.Application.Utilities;
using MediatR;
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
            IDataResult<ListWriterRootDTO> response = await _mediator.Send(getAllWriterQueryRequest);
            return Ok(response);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdWriterQueryRequest getByIdWriterQueryRequest)
        {
            IDataResult<WriterDTO> response = await _mediator.Send(getByIdWriterQueryRequest);
            return Ok(response);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetHeadingsByWriterId([FromRoute] GetHeadingsByWriterQueryRequest getHeadingsByWriterIdQueryRequest)
        {
            IDataResult<List<string>> response = await _mediator.Send(getHeadingsByWriterIdQueryRequest);
            return Ok(response);
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteWriterCommandRequest deleteWriterCommandRequest)
        {
            IDataResult<WriterDTO> response = await _mediator.Send(deleteWriterCommandRequest);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateWriterCommandRequest createWriterCommandRequest)
        {
            IDataResult<WriterDTO> response = await _mediator.Send(createWriterCommandRequest);
            return Ok(response);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateWriterCommandRequest updateWriterCommandRequest)
        {
            IDataResult<WriterDTO> response = await _mediator.Send(updateWriterCommandRequest);
            return Ok(response);
        }
    }
}
