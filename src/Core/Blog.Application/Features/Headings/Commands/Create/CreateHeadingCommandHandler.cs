using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Headings.Constants;
using Blog.Application.Features.Headings.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Headings.Commands.Create
{
    public class CreateHeadingCommandHandler : IRequestHandler<CreateHeadingCommandRequest, IDataResult<HeadingDTO>>
    {
        private readonly IHeadingService _headingService;

        public CreateHeadingCommandHandler(IHeadingService headingService)
        {
            _headingService = headingService;
        }

        public async Task<IDataResult<HeadingDTO>> Handle(CreateHeadingCommandRequest request, CancellationToken cancellationToken)
        {
            HeadingDTO headingDTO = await _headingService.AddHeadingAsync(new() { Name = request.Name, WriterId = request.WriterId, CategoryId = request.CategoryId });
            return new SuccessDataResult<HeadingDTO>(Messages.AddHeading, headingDTO);
        }
    }
}
