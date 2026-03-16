using FMT_MONv2v2.DTOs;

namespace FMT_MONv2v2.Services;

public interface IReviewsService
{
    public Task<ReviewResponseDto?> GetByIdAsync(int id);
}