using FMT_MONv2v2.DTOs;
using FMT_MONv2v2.Repositories;

namespace FMT_MONv2v2.Services;

public class ReviewsService : IReviewsService
{
    private readonly IReviewsRepository _repository;

    ReviewsService(IReviewsRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<ReviewResponseDto?> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }
}