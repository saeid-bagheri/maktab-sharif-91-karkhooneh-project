namespace App.Domain.Core.Entities;

public partial class Service
{
    public int Id { get; set; }

    public int? ParentId { get; set; }

    public string Title { get; set; } = null!;

    public int BasePrice { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public bool IsDeleted { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<ExpertService> ExpertServices { get; set; } = new List<ExpertService>();

    public virtual ICollection<OrderService> OrderServices { get; set; } = new List<OrderService>();

    public virtual ServiceCategory? Parent { get; set; }
}
