namespace ACME.OOP.SCM.Domain.Model.ValueObjects;

public record SupplierId
{
    public string Identifier { get; init; }
    

    /// <summary>
    /// Creates a new instance of <see cref="Supplierld"/>.
    /// </summary>
    /// <param name="identifier"></param>
    public SupplierId(string identifier)
    {
        if (string.IsNullOrEmpty(identifier))
        {
            throw new ArgumentException("Supplier identifier cannot be null or empty");
        }
        Identifier = identifier;
    }
}