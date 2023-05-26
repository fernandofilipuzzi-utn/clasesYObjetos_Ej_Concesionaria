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
        public int CantEmbarques { get; private set; }
        public double MontoEmbarques { get; private set; }
        #endregion

        #region xEmbarque
        public int nroEmbarque;
        public double montoXEmbarque;
        #endregion

        public void Inicializar(int añoActual)
        {
            this.añoActual = añoActual;
            CantEmbarques = 0;
            MontoEmbarques = 0;
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
            CantEmbarques++;

            #region actualizar el monto X embarque
            MontoEmbarques += montoXEmbarque;
            #endregion            
        }
    }
}
