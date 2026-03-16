using FMT_MONv2v2.DTOs;

namespace FMT_MONv2v2.Repositories;

public interface IReviewsRepository
{
    public Task<ReviewResponseDto?> GetByIdAsync(int id);
}