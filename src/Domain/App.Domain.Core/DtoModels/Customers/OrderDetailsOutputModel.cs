namespace App.Domain.Core.DtoModels.Customers;

public class OrderDetailsOutputModel
{
    // public int CustomerId { get; set; }
    public int CustomerAddressId { get; set; }
    DateTime AvailabilityFrom { get; set; }
    public DateTime AvailabilityTo { get; set; }
    public int ServiceCategoryId { get; set; }
    public List<int> ListOfServiceIds { get; set; }

    public int? AcceptedExpertId { get; set; }
    public DateTime? ExpertStartedWorkAt { get; set; }
    public DateTime? ExpertFinishedWorkAt { get; set; }
    public int? ScoreByExpertId { get; set; }
    public int? ScoreByCustomerId { get; set; }

    public DateTime? CreatedAt { get; set; }
    public int CreatedByUserId { get; set; }

    public DateTime? LastModifiedAt { get; set; }
}