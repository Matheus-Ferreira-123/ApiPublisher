// Controllers/PedidoController.cs
using Microsoft.AspNetCore.Mvc;
using ApiPublisherApp.Models;
using ApiPublisherApp.Services;

namespace PublisherAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PedidoController : ControllerBase
{
    private readonly PedidoService _pedidoService;

    public PedidoController(PedidoService pedidoService)
    {
        _pedidoService = pedidoService;
    }

    [HttpPost]
    public IActionResult Post([FromBody] Pedido pedido)
    {
        _pedidoService.PublicarPedido(pedido);
        return Ok("Pedido enviado com sucesso para a fila!");
    }
}
