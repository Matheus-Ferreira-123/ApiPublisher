using RabbitMQ.Client;
using System.Text;
using System.Text.Json;
using ApiPublisherApp.Models;

namespace ApiPublisherApp.Services
{
    public class PedidoService
    {
        private readonly IModel _channel;

    public PedidoService()
    {
        var factory = new ConnectionFactory() { HostName = "localhost" };
        var connection = factory.CreateConnection();
        _channel = connection.CreateModel();
        _channel.QueueDeclare(
            queue: "filaPedido",
            durable: false,
            exclusive: false,
            autoDelete: false,
            arguments: null);
    }

    public void PublicarPedido(Pedido pedido)
    {
        var json = JsonSerializer.Serialize(pedido);
        var body = Encoding.UTF8.GetBytes(json);

        _channel.BasicPublish(
            exchange: "",
            routingKey: "filaPedido",
            body: body);
    }
    }
}