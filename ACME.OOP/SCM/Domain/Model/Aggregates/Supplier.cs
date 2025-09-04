using ACME.OOP.Shared.Domain.Model.ValueObjects;

namespace ACME.OOP.SCM.Domain.Model.Aggregates;
/// <summary>
/// Represents a supplier aggregate in the supply chain management bounded context.
/// </summary>
/// <param name="identifier">The unique identifier fot the supplier.</param>
/// <param name="name">the name of the supplier</param>
/// <param name="address">the supplier of the address</param>
public class Supplier(string identifier, string name, Address address)
{
    public string Identifier { get; } = identifier ?? throw new ArgumentException("Supplier identifier cannot be null or empty");
    public string Name { get; } = name ?? throw new ArgumentException("Supplier name cannot be null or empty");
    public Address Address { get; } = address ?? throw new ArgumentNullException(nameof(address));
}