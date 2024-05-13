using MediatR;
using Microsoft.EntityFrameworkCore;
using Newsletter.Domain.Entities;
using Newsletter.Domain.Repositories;
using TS.Result;

namespace Newsletter.Application.Features.Blogs.GetAllBlog;
public sealed record GetAllBlogQuery(
    string Search): IRequest<Result<List<Blog>>>;

internal sealed class GetAllBlogQueryHandler(IBlogRepository blogRepository) :IRequestHandler<GetAllBlogQuery, Result<List<Blog>>>
{
    public async Task<Result<List<Blog>>> Handle(GetAllBlogQuery request, CancellationToken cancellationToken)
    {
       var response = await blogRepository
            .Where(p => p.Title.ToLower().Contains(request.Search.ToLower()))
            .OrderByDescending(p => p.PublishDate)
            .ToListAsync(cancellationToken);

        return response;
    }
}
