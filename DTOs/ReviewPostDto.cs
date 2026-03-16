namespace FMT_MONv2v2.DTOs;

public class ReviewPostDto
{
    public int ReviewId { get; set; }
    public int ApplicationId { get; set; }
    public string? LicenseCode { get; set; }
    public List<ReviewPostCriteriaDto>? Criteria { get; set; }
}

public class ReviewPostCriteriaDto
{
    public string? CriterionName { get; set; }
    public decimal CriterionFee { get; set; }
}
