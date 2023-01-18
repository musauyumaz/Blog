using Blog.Application.Abstractions.Services;
using Blog.Application.Features.Headings.Constants;
using Blog.Application.Features.Headings.DTOs;
using Blog.Application.Utilities;
using MediatR;

namespace Blog.Application.Features.Headings.Queries.GetById
{
    public class GetByIdHeadingQueryHandler : IRequestHandler<GetByIdHeadingQueryRequest, IDataResult<HeadingDTO>>
    {
        private readonly IHeadingService _headingService;

        public GetByIdHeadingQueryHandler(IHeadingService headingService)
        {
            _headingService = headingService;
        }

        public async Task<IDataResult<HeadingDTO>> Handle(GetByIdHeadingQueryRequest request, CancellationToken cancellationToken)
        {
            HeadingDTO headingDTO = await _headingService.GetByIdAsync(request.Id);
            return new SuccessDataResult<HeadingDTO>(Messages.GetHeading, headingDTO);
        }
    }
}
