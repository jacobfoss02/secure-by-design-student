namespace SalesApi.Domain.Model;

public class Product(ProductId id, string name, decimal price, string marketId)
{
    public ProductId Id { get; private set; } = id;
    public string Name { get; private set; } = name;
    public decimal Price { get; private set; } = price;
    public string MarketId { get; private set; } = marketId;

    public void UpdatePrice(decimal newPrice)
    {
        Price = newPrice;
    }
}