using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Una empresa registró las compras realizadas a sus distintos proveedores durante
            todo el año anterior. Para cadacompra se registraron los siguientes datos:
            • Número de proveedor (número de cuatro cifras no correlativo).
            • Día (1 a 31).
            • Mes (1 a 12).
            • Tipo de Factura (Responsable inscripto: "A",Consumidor Final: "B", o
            Monotributo: "C").
            • Número de Producto (número no correlativo).
            • Cantidad comprada.
            • Precio unitario del producto.
            Este lote finaliza con un registro con número de proveedor igual a 0.
            Los registros están agrupados por número de proveedor. En el lote anterior no
            aparecen
            registros de los proveedores a los que que no se les hayan realizado compras.
            Se pide determinar e informar:
            a. El monto máximo registrado en una sola compra por cada proveedor y el
            número de proveedor al que se le compró.
            b. La inversión total de todo el año discriminada por tipo de factura.
            c. La compra con menor monto registrada durante el mes de Agosto junto al
            número de producto comprado.
            d. La cantidad de compras que se realizaron a cada proveedor.
            e. El número de producto con mayor cantidad comprada en una sola compra y
            en qué proveedor se compró. */

            int NumProveedor,actualProveedor, dia, mes, numProducto, cantComprada,AcuCantidadComprada;
            int maxCantidad = 0, maxProducto = 0, maxProveedor = 0;
            float precioUni, monto, MaxMonto, menorMonto = 0, menorProducto  = 0;
            float acuA = 0, acuB = 0,acuC = 0;  // La inversión total de todo el año discriminada por tipo de factura.
            char tipoFactura;
            bool bandera = false; // para guardar la primera compra minima en agosto
            
                // CARGA DE DATOS
            Console.WriteLine("Número de proveedor (número de cuatro cifras): ");
            NumProveedor = int.Parse(Console.ReadLine());

            Console.WriteLine("Día (1 a 31): ");
            dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Mes (1 a 12): ");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Tipo de Factura (Responsable inscripto: 'A',Consumidor Final: 'B', o Monotributo: 'C'): ");
            tipoFactura = char.Parse(Console.ReadLine());

            Console.WriteLine("Número de Producto (número no correlativo): ");
            numProducto = int.Parse(Console.ReadLine());

            Console.WriteLine("Cantidad comprada: ");
            cantComprada = int.Parse(Console.ReadLine());

            Console.WriteLine("Precio unitario del producto: ");
            precioUni = float.Parse(Console.ReadLine());

             // PRIMER LOTE
            while(NumProveedor != 0){
                MaxMonto = 0;

                AcuCantidadComprada = 0;

                 // SEGUNDO LOTE
                actualProveedor = NumProveedor;
                while(NumProveedor == actualProveedor && numProducto != 0){
                    monto = cantComprada * precioUni;
                    AcuCantidadComprada += cantComprada;
                    //El monto máximo registrado en una sola compra por cada proveedor

                    if(monto > MaxMonto)
                        MaxMonto = monto;

                     // La inversión total de todo el año discriminada por tipo de factura.
                    switch (tipoFactura)
                    {
                        case 'A':
                            acuA += monto;
                            break;
                        case 'B':
                            acuB += monto;
                            break;
                        case 'C':
                            acuC += monto;
                            break;
                        default:
                            break;
                    }
                     // La compra con menor monto registrada durante el mes de Agosto
                    if (mes == 8){

                        if(!bandera){
                            menorMonto = monto;
                            menorProducto = numProducto;
                            bandera = true;
                        }else if (monto < menorMonto){
                            menorMonto = monto;
                            menorProducto = numProducto;
                        }

                    }
                    // El número de producto con mayor cantidad comprada en una sola compra y el proveedor
                    if(cantComprada > maxCantidad){
                        maxCantidad = cantComprada;
                        maxProducto = numProducto;
                        maxProveedor = NumProveedor;
                    }
                            // CARGA DE DATOS
                    Console.WriteLine("Número de proveedor (número de cuatro cifras): ");
                    NumProveedor = int.Parse(Console.ReadLine());

                    Console.WriteLine("Día (1 a 31): ");
                    dia = int.Parse(Console.ReadLine());

                    Console.WriteLine("Mes (1 a 12): ");
                    mes = int.Parse(Console.ReadLine());

                    Console.WriteLine("Tipo de Factura (Responsable inscripto: 'A',Consumidor Final: 'B', o Monotributo: 'C'): ");
                    tipoFactura = char.Parse(Console.ReadLine());

                    Console.WriteLine("Número de Producto (número no correlativo): ");
                    numProducto = int.Parse(Console.ReadLine());

                    Console.WriteLine("Cantidad comprada: ");
                    cantComprada = int.Parse(Console.ReadLine());

                    Console.WriteLine("Precio unitario del producto: ");
                    precioUni = float.Parse(Console.ReadLine());

                }
                Console.WriteLine("EL MONTO MAXIMO EN UNA SOLA VENTA ES: " + MaxMonto + " Y EL NUM DE PROVEEDOR ES: "+ actualProveedor);

                Console.WriteLine("LA CANTIDAD COMPRADA FUE DE : " + AcuCantidadComprada);
            }

            Console.WriteLine("EL MONTO TOTAL PARA LA FACTURA 'A' ES : " + acuA);
            Console.WriteLine("EL MONTO TOTAL PARA LA FACTURA 'B' ES : " + acuB);
            Console.WriteLine("EL MONTO TOTAL PARA LA FACTURA 'C' ES : " + acuC);

            Console.WriteLine("LA COMPRA CON MENOR MONTO DURANTE EL MES DE AGOSTO ES : "+ menorMonto +" Y SU NUMERO DE PRODUCTO ES " + menorProducto);

            Console.WriteLine("EL NUM DE PRODUCTO CON MAYOR CANTIDAD COMPRADA ES : "+   maxProducto + " Y EL PROVEEDOR FUE "+ maxProveedor);
            Console.WriteLine("SU CANTIDAD COMPRADA FUE DE : " + maxCantidad + " PRODUCTOS");

        }
    }
}