using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
    public interface ICobertura
    {
        string getDetalle();

        double getPrecio();

    }
}
