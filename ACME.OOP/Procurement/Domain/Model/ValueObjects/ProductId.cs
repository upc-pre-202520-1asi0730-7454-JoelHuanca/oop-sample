namespace ACME.OOP.Procurement.Domain.Model.ValueObjects;

/// <summary>
/// Value object representing a unique identifier for a product.
/// </summary>
public record ProductId
{
    public Guid Id { get; init; }
    
    /// <summary>
    /// Creates a new instance of <see cref="ProductId"/>. with the specified GUID
    /// </summary>
    /// <param name="id"></param>
    /// <exception cref="ArgumentException"></exception>
    public  ProductId(Guid id)
    {
        if (id == Guid.Empty)
        {
            throw new ArgumentException("Product ID cannot be empty");
        }
        Id = id;
    }
    
    /// <summary>
    /// Generates a new unique <see cref="ProductId"/>.\ instance with a unique GUID.
    /// </summary>
    /// <returns></returns>
    public static ProductId New()=>new(Guid.NewGuid());
    
    /// <summary>
    ///  Returns a string representation of the product ID.
    /// </summary>
    /// <returns></returns>
    public override string ToString()=>Id.ToString();
}