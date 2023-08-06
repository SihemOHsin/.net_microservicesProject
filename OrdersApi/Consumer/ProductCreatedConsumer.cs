using MassTransit;
using OrdersApi.Data;
using OrdersApi.Models;
using shared;

namespace OrdersApi.Consumer
{
    public class ProductCreatedConsumer : IConsumer<ProductCreated>
    {
        private readonly OrdersApiContext _OrdersApiContext;
        public ProductCreatedConsumer(OrdersApiContext ordersApiContext)
        {
            _OrdersApiContext = ordersApiContext;
        }

        public async Task Consume(ConsumeContext<ProductCreated> context)

        {
            var newProduct = new Product
            {
                Name = context.Message.Name
            };
            _OrdersApiContext.Add(newProduct);
            await _OrdersApiContext.SaveChangesAsync();

        }
    }
}
