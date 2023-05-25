using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngresosEmbarques
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variables del embarques
            int añoActual=0;
            double montoEmbarques;
            int cantEmbarque;
            #endregion

            # region xEmbarque
            int nroEmbarque;
            double montoXEmbarque;
            #endregion

            #region xMoto
            int modelo;
            double valorFabricacion;
            double valorActual;
            #endregion

            #region solicitar año actual
            Console.WriteLine("Solicitar año actual.");
            añoActual = Convert.ToInt32(Console.ReadLine());
            #endregion


            #region solicitar nro embarque
            Console.WriteLine("Solicitar Número embarque (0 corta).");
            nroEmbarque = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region iniciar var...
            cantEmbarque = 0;
            montoEmbarques = 0;
            #endregion

            while (nroEmbarque>0) //xembarque
            {
                #region solicitar modelo
                Console.WriteLine("Solicitar Modelo moto (0 corta)");
                modelo = Convert.ToInt32(Console.ReadLine() );
                #endregion

                cantEmbarque++;

                #region iniciar variables
                montoXEmbarque = 0;
                #endregion

                while (modelo>0) //xmoto
                {
                    #region solicitar valor de fabricacion
                    Console.WriteLine("Solicitar valor fabriación $.");
                    valorFabricacion = Convert.ToInt32(Console.ReadLine());
                    #endregion

                    #region calcular monto moto
                    valorActual = valorFabricacion * Math.Pow(0.9, añoActual- modelo );
                    #endregion

                    #region actualizar el monto X embarque
                    montoXEmbarque += valorActual;
                    #endregion

                    #region solicitar modelo
                    Console.WriteLine("Solicitar Modelo moto (0 corta)");
                    modelo = Convert.ToInt32(Console.ReadLine());
                    #endregion
                }

                #region informar el total del embarque
                Console.WriteLine("Monto total del embarque ingresado es: ${0:f2}", montoXEmbarque);
                #endregion

                #region actualizar el monto X embarque
                montoEmbarques += montoXEmbarque;
                #endregion

                #region solicitar nro embarque
                Console.WriteLine("Solicitar Número embarque (0 corta).");
                nroEmbarque = Convert.ToInt32(Console.ReadLine());
                #endregion
            }

            #region informar el total de todos los embarques y cantidad de embarques
            Console.WriteLine("Monto total de todos los embarques ingresados es: ${0:f2}", montoEmbarques);
            Console.WriteLine("Cantidad de embarques: {0}", cantEmbarque);
            #endregion

            Console.ReadKey();
        }
    }
}
