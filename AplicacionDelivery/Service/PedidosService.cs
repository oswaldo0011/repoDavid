using AplicacionDelivery.Models;
using System.Text.Json;

namespace AplicacionDelivery.Service
{
    internal class PedidosService : IPedidosService
    {
        const string URL = "https://productos-api-eclw.onrender.com/api/productos";
        public async Task<List<AppPedidosMaui>> Get()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(URL);
            var content = await response.Content.ReadAsStringAsync();
            var Pedido = JsonSerializer.Deserialize<List<AppPedidosMaui>>(content);
            return Pedido;
        }
    }
}
