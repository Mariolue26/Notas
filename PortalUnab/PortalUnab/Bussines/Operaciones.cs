using PortalUnab.Models;
using PortalUnab.Services;

namespace PortalUnab.Bussines
{
    public class Operaciones : IOperaciones
    {
        public double Div(Acciones acciones)
        {
            return acciones.number1 / acciones.number2;
        }

        public double Multi(Acciones acciones)
        {
            return acciones.number1 * acciones.number2;
        }

        public double Resta(Acciones acciones)
        {
            return acciones.number1 - acciones.number2;
        }

        public double Suma(Acciones acciones)
        {
            
            return acciones.number1 + acciones.number2; ;
        }
    }
}
