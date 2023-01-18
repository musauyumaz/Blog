using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Headings.Constants;
using Blog.Application.Features.Headings.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Headings.Queries.GetAll
{
    public class GetAllHeadingsQueryHandler : IRequestHandler<GetAllHeadingsQueryRequest, IDataResult<ListHeadingRootDTO>>
    {
        private readonly IHeadingService _headingService;

        public GetAllHeadingsQueryHandler(IHeadingService headingService)
        {
            _headingService = headingService;
        }

        public async Task<IDataResult<ListHeadingRootDTO>> Handle(GetAllHeadingsQueryRequest request, CancellationToken cancellationToken)
        {
            ListHeadingRootDTO listHeadingRootDTO = await _headingService.GetAllAsync(request.Page, request.Size);
            return new SuccessDataResult<ListHeadingRootDTO>(Messages.GetAllHeading,listHeadingRootDTO);
        }
    }
}
