using FMT_MONv2v2.DTOs;
using Microsoft.Data.SqlClient;

namespace FMT_MONv2v2.Repositories;

public class ReviewsRepository : IReviewsRepository
{
    private readonly string _connectionString = 
        "Server=localhost;Database=APBD;Trusted_Connection=True;TrustServerCertificate=True";

    private const string sql = @"SELECT r.date, a.first_name AS applicant_firstName, a.last_name AS applicant_lastName,
a.date_of_birth, rr.reviewer_id, rr.licese_code, c.name, rc.criterion_fee
FROM Review r JOIN Applicant a ON r.applicant_id = a.applicant_id
JOIN Reviewer rr ON r.reviewer_id = rr.reviewer_id
JOIN Review_Criterion rc ON r.review_id = rc.review_id
JOIN Criterion c ON rc.criterion_id = c.criterion_id";
    
    
    public async Task<ReviewResponseDto?> GetByIdAsync(int id)
    {
        await using var connection = new SqlConnection(_connectionString);
        await using var command = new SqlCommand(sql, connection);
        return new ReviewResponseDto();
    }
}