namespace ACME.OOP.Procurement.Domain.Model.ValueObjects;

public record ProductId
{
    public Guid Id { get; init; }
    
    public  ProductId(Guid id)
    {
        if (id == Guid.Empty)
        {
            throw new ArgumentException("Product ID cannot be empty");
        }
        Id = id;
    }
    
    public static ProductId New()=>new(Guid.NewGuid());
}