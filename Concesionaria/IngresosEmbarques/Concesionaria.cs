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
        public int NroEmbarque { get; private set; }
        public double MontoXEmbarque { get; private set; }
        #endregion

        public void Inicializar(int añoActual)
        {
            this.añoActual = añoActual;
            CantEmbarques = 0;
            MontoEmbarques = 0;
        }

        #region operaciones propias de un embarque
        public void InicializarEmbarque(int nroEmbarque)
        {
            this.NroEmbarque = nroEmbarque;
            MontoXEmbarque = 0;
        }

        public double AgregarMoto(int modelo, double valorFabricacion)
        {
            double valorActual=0d;

            #region calcular monto moto
            valorActual = valorFabricacion * Math.Pow(0.9, añoActual - modelo);
            #endregion

            #region actualizar el monto X embarque
            MontoXEmbarque += valorActual;
            #endregion

            return valorActual;
        }

        public void FinalizarEmbarque()
        {            
            CantEmbarques++;

            #region actualizar el monto X embarque
            MontoEmbarques += MontoXEmbarque;
            #endregion            
        }
        #endregion
    }
}
