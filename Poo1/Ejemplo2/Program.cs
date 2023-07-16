using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Primer lote con 10 registros de productos, cada producto tiene:
                -Código de Artículo(3 digitos no correlativos)
                -Precio
                -Código de Marca(1 a 10)
              Segundo lote con las ventas de la semana. Cada venta tiene:
                -Código de Articulo
                -Cantidad
                -Código Cliente
              Este lote corta con código de cliente cero.

             */
            Articulo[] articulos= new Articulo[10];
            
            for(int i=0; i<10; i++)
            {
                articulos[i] = new Articulo();
                Console.WriteLine("Ingrese los datos del producto..");
                Console.WriteLine("Código de Artículo: ");
                articulos[i].CodigoArticulo=int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                articulos[i].Precio=float.Parse(Console.ReadLine());
                Console.WriteLine("Código de marca: ");
                articulos[i].CodMarca=int.Parse(Console.ReadLine());
            }
            //cargado el vector completo

            Venta venta= new Venta();
            Console.WriteLine("Ingrese la venta: ");
            Console.WriteLine("Código cliente");
            venta.CodCliente=int.Parse(Console.ReadLine());
            

            while (venta.CodCliente != 0)
            {
                Console.WriteLine("Código Artículo");
                venta.Articulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad");
                venta.Cantidad = int.Parse(Console.ReadLine());
                //trabajamos


                //pidocliente neuvamente
                Console.WriteLine("Ingrese la venta: ");
                Console.WriteLine("Código cliente");
                venta.CodCliente = int.Parse(Console.ReadLine());
            }
        }
    }
}
