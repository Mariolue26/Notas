using PortalUnab.Models;
using PortalUnab.Bussines;

namespace PortalUnab.Services
{
    public interface IOperaciones
    {
        Double Suma(Acciones acciones);

        Double Resta(Acciones acciones);

        Double Multi(Acciones acciones);

        Double Div(Acciones acciones);


    }
}
