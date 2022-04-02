using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LA_COLMENA
{
    class Program
    {

         public static void Main (string[] args)
        {


            int op;
            do
            {
                Console.WriteLine("****************************************");
                Console.WriteLine("****************************************");
                Console.WriteLine("*********MINISUPER LA COLMENA***********");
                Console.WriteLine("****************************************");
                Console.WriteLine("****************************************");
            
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("1.-NUEVA VENTA");
                Console.WriteLine("2.-VENTAS ANTERIORES");
                Console.WriteLine("3.-SALIR");
                Console.WriteLine("Seleccione una opcion");
                op = int.Parse(Console.ReadLine());


                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Ventas();
                        break;
                    case 2:
                        Console.Clear();
                        Historial();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Vuelva pronto, Muchas Gracias c: !!! ");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("no es parte del menu");
                        break;
                }

            } while (op != 0);


        }


        public static void Ventas()
        {
            string mas = "S";
            string producto = "";
            string precio = "";
            string cantidad = "";
            string total = "";

            do
            {

                Console.WriteLine("Capture el producto");
                string Producto = Console.ReadLine();
                Console.WriteLine("Catidad");
                int Cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio Unitario");

                double Precio = double.Parse(Console.ReadLine());

                double Total = Cantidad * Precio;
                double acum = 0;
                acum = acum + Total;


                Console.WriteLine("¿desea algun producto mas?");
                mas = Console.ReadLine();


                Console.WriteLine("1 para agregar");

            } while (mas != "N");
           


            StreamWriter fichero;
            string nombrefichero = "C:\\Users\\equipo jaime\\Desktop\\LA COLMENA VENTAS TICKETS" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".txt";
            fichero = File.AppendText(nombrefichero);
            fichero.WriteLine("Producto:" + producto + "  Cantidad:" + cantidad + "  Precio unitario:" + precio + " Total:" + total);
            fichero.WriteLine("---------------------------------------------------------------------------------");
            fichero.Close();

            Console.ReadKey();
        }

        public static void Historial()
        {

            //Console.WriteLine("ingrese la fecha");
            //DateTime fecha = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("°°°°°°°°°°°°°" + DateTime.Now.ToShortDateString().Replace("/", "-") + "°°°°°°°°°°°°°°°°°°°°");
            //Console.WriteLine("°°°°°°°°°°°°°°°°°°VENTAS DEL DIA " + fecha.ToShortDateString().Replace("/", "-") + "°°°°°°°°°°°°°°°°°°°°°");
            StreamReader fichero;
            string nombrefichero = "C:\\Users\\equipo jaime\\Desktop\\LA COLMENA VENTAS TICKETS" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".txt";
            //string nombrefichero = "C:\\Users\\equipo jaime\\Desktop\\LA COLMENA VENTAS TICKETS" + fecha.ToShortDateString().Replace("/", "-") + ".txt";
            fichero = File.OpenText(nombrefichero);
            string linea = "";

            while ((linea = fichero.ReadLine()) != null)
            {

                Console.WriteLine(linea);
            }
            fichero.Close();
            Console.WriteLine("********************************************************************");
            Console.WriteLine("                                   Total venta del dia:");
            Console.ReadKey();

        }
    }
}
