namespace FMT_MONv2v2.DTOs;

public class ReviewResponseDto
{
    public DateTime Date { get; set; }
    public ApplicantDto Applicant { get; set; } = null!;
    public ReviewerDto Reviewer { get; set; } = null!;
    public List<ReviewCriteriaDto> ReviewCriteria { get; set; } = new();
    
}

public class ApplicantDto
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
}

public class ReviewerDto
{
    public int ReviewerId { get; set; }
    public string? LicenseCode { get; set; }
}

public class ReviewCriteriaDto
{
    public string? Name { get; set; }
    public decimal CreterionFee { get; set; }
}

