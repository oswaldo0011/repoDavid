using AplicacionDelivery.Models;

namespace AplicacionDelivery.Service
{
    internal interface IPedidosService
    {
        public Task<List<AppPedidosMaui>> Get();

    }
}
