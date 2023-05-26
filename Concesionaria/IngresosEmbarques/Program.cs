using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngresosEmbarques
{
    class Program
    {
        static void ImprimirMenu()
        {
            Console.Clear();
            Console.WriteLine("1-agregar embarque");
            Console.WriteLine("2-Consultar estado concesionaria");
            Console.WriteLine("otro - salir");
        }

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


            #region iniciar var...
            cantEmbarque = 0;
            montoEmbarques = 0;
            #endregion

            int op;
            do
            {
                ImprimirMenu();
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                    {
                            Console.Clear();

                            #region solicitar nro embarque
                            Console.WriteLine("Solicitar Número embarque (0 corta).");
                            nroEmbarque = Convert.ToInt32(Console.ReadLine());
                            #endregion

                            // proceso ingresar el embarque de motos
                            #region ingresar un embarque

                            #region solicitar modelo
                            Console.WriteLine("Solicitar Modelo moto (0 corta)");
                            modelo = Convert.ToInt32(Console.ReadLine());
                            #endregion

                            cantEmbarque++;

                            #region iniciar variables
                            montoXEmbarque = 0;
                            #endregion

                            while (modelo > 0) //xmoto
                            {
                                #region solicitar valor de fabricacion
                                Console.WriteLine("Solicitar valor fabriación $.");
                                valorFabricacion = Convert.ToInt32(Console.ReadLine());
                                #endregion

                                #region calcular monto moto
                                valorActual = valorFabricacion * Math.Pow(0.9, añoActual - modelo);
                                #endregion

                                #region actualizar el monto X embarque
                                montoXEmbarque += valorActual;
                                #endregion

                                #region solicitar modelo
                                Console.WriteLine("Solicitar Modelo moto (0 corta)");
                                modelo = Convert.ToInt32(Console.ReadLine());
                                #endregion
                            }

                            Console.Clear();
                            Console.WriteLine("Resumen del embarque");

                            #region informar el total del embarque
                            Console.WriteLine("Monto total del embarque ingresado es: ${0:f2}", montoXEmbarque);
                            #endregion

                            #region actualizar el monto X embarque
                            montoEmbarques += montoXEmbarque;
                            #endregion
                            #endregion
                            // informar los resultados

                            Console.WriteLine("Presione una tecla para volver al menú");
                            Console.ReadKey();
                    }
                    break;
                    case 2:
                    {
                            Console.Clear();

                            // mostrar resultados finales de caja
                            #region informar el total de todos los embarques y cantidad de embarques
                            Console.WriteLine("Monto total de todos los embarques ingresados es: ${0:f2}", montoEmbarques);
                            Console.WriteLine("Cantidad de embarques: {0}", cantEmbarque);
                            #endregion

                            Console.WriteLine("Presione una tecla para volver al menú");
                            Console.ReadKey();
                        }
                    break;
                }
            
            } while (op>0);

        }
    }
}
