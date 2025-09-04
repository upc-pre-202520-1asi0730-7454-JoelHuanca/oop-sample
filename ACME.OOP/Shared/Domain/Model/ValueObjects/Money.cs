namespace ACME.OOP.Shared.Domain.Model.ValueObjects;

/// <summary>
/// Represents a monetary value with an amount and a currency.
/// </summary>
public record Money
{
    public decimal Amount { get; init; }
    public string Currency { get; init; }

    /// <summary>
    /// Creates a new instance of <see cref="money"/>.
    /// </summary>
    /// <param name="amount">The monetary amount.</param>
    /// <param name="currency">The currency code(ISA 4217 format).</param>
    /// <exception cref="ArgumentException">Throw when the currency code is invalid.</exception>
    public Money(decimal amount, string currency)
    {
        if (string.IsNullOrWhiteSpace(currency) || currency.Length != 3)
            throw new ArgumentException("Currency must be a vali 3-letter ISO code." );
        Amount = amount;
        Currency = currency;
    }
    
    /// <summary>
    /// Returns a string representation of the monetary value.
    /// </summary>
    /// <returns></returns>
     public override string ToString() => $"{Amount} {Currency}"; 
}