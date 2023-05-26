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
            Concesionaria c = new Concesionaria();

            #region solicitar año actual
            Console.WriteLine("Solicitar año actual.");
            int añoActual = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region iniciar var...
            c.Inicializar(añoActual);
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
                            int nroEmbarque = Convert.ToInt32(Console.ReadLine());
                            c.InicializarEmbarque(nroEmbarque);
                            #endregion

                            // proceso ingresar el embarque de motos
                            #region ingresar un embarque

                            #region solicitar modelo
                            Console.WriteLine("Solicitar Modelo moto");
                            int modelo = Convert.ToInt32(Console.ReadLine());
                            #endregion
                                                        
                            while (modelo > 0) //xmoto
                            {
                                #region solicitar valor de fabricacion
                                Console.WriteLine("Solicitar valor fabriación $.");
                                double valor = Convert.ToInt32(Console.ReadLine());
                                #endregion

                                c.AgregarMoto(modelo, valor);
                                
                                #region solicitar modelo
                                Console.WriteLine("Solicitar Modelo moto (0 corta)");
                                modelo = Convert.ToInt32(Console.ReadLine());
                                #endregion
                            }

                            c.FinalizarEmbarque();

                            Console.Clear();
                            Console.WriteLine("Resumen del embarque");

                            #region informar el total del embarque
                            Console.WriteLine("Monto total del embarque ingresado es: ${0:f2}", c.MontoXEmbarque);
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
                            Console.WriteLine("Monto total de todos los embarques ingresados es: ${0:f2}", c.MontoEmbarques);
                            Console.WriteLine("Cantidad de embarques: {0}", c.CantEmbarques);
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
