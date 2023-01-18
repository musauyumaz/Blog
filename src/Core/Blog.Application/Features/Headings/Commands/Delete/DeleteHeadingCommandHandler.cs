using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Headings.Constants;
using Blog.Application.Features.Headings.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Headings.Commands.Delete
{
    public class DeleteHeadingCommandHandler : IRequestHandler<DeleteHeadingCommandRequest, IDataResult<HeadingDTO>>
    {
        private readonly IHeadingService _headingService;

        public DeleteHeadingCommandHandler(IHeadingService headingService)
        {
            _headingService = headingService;
        }

        public async Task<IDataResult<HeadingDTO>> Handle(DeleteHeadingCommandRequest request, CancellationToken cancellationToken)
        {
            HeadingDTO headingDTO = await _headingService.DeleteHeadingAsync(request.Id);
            return new SuccessDataResult<HeadingDTO>(Messages.DeleteHeading, headingDTO);
        }
    }
}
