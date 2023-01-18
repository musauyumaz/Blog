using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Headings.Constants;
using Blog.Application.Features.Headings.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Headings.Commands.Update
{
    public class UpdateHeadingCommandHandler : IRequestHandler<UpdateHeadingCommandRequest, IDataResult<HeadingDTO>>
    {
        private readonly IHeadingService _headingService;

        public UpdateHeadingCommandHandler(IHeadingService headingService)
        {
            _headingService = headingService;
        }

        public async Task<IDataResult<HeadingDTO>> Handle(UpdateHeadingCommandRequest request, CancellationToken cancellationToken)
        {
            HeadingDTO headingDTO = await _headingService.UpdateHeadingAsync(new() { Id = request.Id, Name = request.Name, CategoryId = request.CategoryId, WriterId = request.WriterId, IsActive = request.IsActive });
            return new SuccessDataResult<HeadingDTO>(Messages.UpdateHeading, headingDTO);
        }
    }
}

