using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngresosEmbarques
{
    class Concesionaria
    {
        #region variables de todos los embarques
        int añoActual;
        public int cantEmbarques;
        public double montoEmbarques;
        #endregion

        #region xEmbarque
        public int nroEmbarque;
        public double montoXEmbarque;
        #endregion

        public void Inicializar(int añoActual)
        {
            this.añoActual = añoActual;
            cantEmbarques = 0;
            montoEmbarques = 0;
        }

        public void InicializarEmbarque(int nroEmbarque)
        {
            this.nroEmbarque = nroEmbarque;
            montoXEmbarque = 0;
        }

        public double AgregarMoto(int modelo, double valorFabricacion)
        {
            double valorActual=0d;

            #region calcular monto moto
            valorActual = valorFabricacion * Math.Pow(0.9, añoActual - modelo);
            #endregion

            #region actualizar el monto X embarque
            montoXEmbarque += valorActual;
            #endregion

            return valorActual;
        }

        public void FinalizarEmbarque()
        {            
            cantEmbarques++;

            #region actualizar el monto X embarque
            montoEmbarques += montoXEmbarque;
            #endregion            
        }
    }
}
