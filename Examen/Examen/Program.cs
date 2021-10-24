using System;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Catalogo = { "Leche", "Pan", "Huevos", "Café", "Arepas" };
            int[] Precios = { 3500, 200, 500, 400, 1500 };
            bool programa = true;
            int Total = 0;
            int Fiar = 0;
            int[] Compras = new int[0];
            int Cantidad = 0;
            int nCompras = 0;
            string[] Clientes = { "1,Jeronimo", "2,Andres", "3,Juliana", "4,Esteban", "5,Camila" };
            int JeronimoSaldo = 0;
            int AndresSaldo = 0;
            int JulianaSaldo = 0;
            int EstebanSaldo = 0;
            int CamilaSaldo = 0;
            int IDcliente = 0;
            int TotalJeronimo = 0;
            int TotalAndres = 0;
            int TotalJuliana = 0;
            int TotalEsteban = 0;
            int TotalCamila = 0;
            int Leche = 10;
            int Pan = 20;
            int Huevos = 100;
            int Café = 18;
            int Arepas = 33;


            //Menu de opciones
            Console.WriteLine("Tienda Soledad");
            Console.WriteLine();
            Console.WriteLine("Opciones");
            Console.WriteLine();
            Console.WriteLine("1. Buscar Producto");
            Console.WriteLine();
            Console.WriteLine("2. Suma Rapida de Productos");
            Console.WriteLine();
            Console.WriteLine("3. Pagar Cuenta");
            Console.WriteLine();
            Console.WriteLine("4. Consultar Cuenta del CLiente");
            Console.WriteLine();
            Console.WriteLine("5. Calcular Informe de Ventas");
            Console.WriteLine();
            Console.WriteLine("6. Calcular Cartera del Cliente");
            Console.WriteLine();
            Console.WriteLine("7. Salir");
            Console.WriteLine();
            Console.WriteLine("8.Creditos");
            Console.WriteLine();
            Console.WriteLine("9.Inventario");
            Console.WriteLine();
            Console.WriteLine("10.Clientes");

            //Inicia el programa
            while (programa)
            {
                Console.WriteLine("Ingrese un numero");
                string verde = Console.ReadLine();
                switch (int.Parse(verde)) 
                {
                    //Muestra el Catalogo de Productos
                    case 1:
                        Console.WriteLine("Lista de Productos:");
                        for (int i = 0; i < Catalogo.Length; i++)
                        {
                            Console.WriteLine(Catalogo[i]);
                        } 
                        Console.WriteLine("¿Qué producto busca?");
                        string azul = Console.ReadLine();
                        for (int j = 0; j < Catalogo.Length; j++)
                        {
                            if (Catalogo[j].Equals(azul))
                            {
                                Console.WriteLine("El producto "+ Catalogo[j] + " Tiene un precio de: " + Precios[j]);
                            } 
                        }
                        break;

                    case 2:
                        //Inicia un contador para llevar las compras de los clientes
                        Cantidad++;
                        int subtotal = 0;
                        Array.Resize<int>(ref Compras, Cantidad);
                        Console.WriteLine("¿Cual es su ID de cliente?");
                        IDcliente =int.Parse(Console.ReadLine());

                        Console.WriteLine("¿Cuantos productos desea llevar?");
                        //Seleccion de productos por cliente
                        string rojo = Console.ReadLine();
                        for (int n = 0; n < int.Parse(rojo); n++)
                        {
                            Console.WriteLine("Lista de Productos:");
                            for (int i = 0; i < Catalogo.Length; i++)
                            {
                                Console.WriteLine(Catalogo[i]);
                            }
                            Console.WriteLine("¿Qué producto busca?");
                            string amarillo = Console.ReadLine();
                            if (amarillo == "Leche")
                            {
                                Leche--;
                            }
                            if (amarillo == "Huevos")
                            {
                                Huevos--;
                            }
                            if (amarillo == "Café")
                            {
                                Café--;
                            }
                            if (amarillo == "Pan")
                            {
                                Pan--;
                            }
                            if (amarillo == "Arepas")
                            {
                                Arepas--;
                            }
                            for (int j = 0; j < Catalogo.Length; j++)
                            {
                                if (Catalogo[j].Equals(amarillo))
                                {
                                    Console.WriteLine("El producto " + Catalogo[j] + " Tiene un precio de: " + Precios[j]);
                                    subtotal += Precios[j];
                                }
                            }
                        }
                        Console.WriteLine("El precio total es: " + subtotal);
                        Total += subtotal;
                        Compras[nCompras] = subtotal;
                        //Inicio de secion por ID para sumar los precios de las compras
                        if (IDcliente == 1)
                        {
                            JeronimoSaldo = JeronimoSaldo + subtotal;
                            TotalJeronimo = TotalJeronimo + subtotal;
                        }
                        if (IDcliente == 2)
                        {
                            AndresSaldo = AndresSaldo + subtotal;
                            TotalAndres = TotalAndres + subtotal;
                        }
                        if (IDcliente == 3)
                        {
                            JulianaSaldo = JulianaSaldo + subtotal;
                            TotalJuliana = TotalJuliana + subtotal;
                        }
                        if (IDcliente == 4)
                        {
                            EstebanSaldo = EstebanSaldo + subtotal;
                            TotalEsteban = TotalEsteban + subtotal;
                        }
                        if (IDcliente == 5)
                        {
                            CamilaSaldo = CamilaSaldo  + subtotal;
                            TotalCamila = TotalCamila + subtotal;
                        }
                        nCompras++;
                        
                        break;

                    case 3:
                        subtotal = 0;
                        IDcliente = 0;
                        Console.WriteLine("¿Cual es su ID de cliente que desea pagar?");
                        IDcliente = int.Parse(Console.ReadLine());
                        //Se suma las compras de los clientes más las deudas a la hora de pagar
                        if (IDcliente == 1)
                        {
                            subtotal = JeronimoSaldo + Fiar;
                        }
                        if (IDcliente == 2)
                        {
                            subtotal = AndresSaldo + Fiar;
                        }
                        if (IDcliente == 3)
                        {
                            subtotal = JulianaSaldo + Fiar;
                        }
                        if (IDcliente == 4)
                        {
                            subtotal = EstebanSaldo + Fiar;
                        }
                        if (IDcliente == 5)
                        {
                            subtotal = CamilaSaldo + Fiar;
                        }
                        Console.WriteLine("El precio total es: " + subtotal);
                        Console.WriteLine("1. Pagar en efectivo");
                        Console.WriteLine("2. Fiar");
                        string morado = Console.ReadLine();
                    //se paga
                        if (int.Parse(morado)==1)
                        {
                            Console.WriteLine("¿Con cuanto va a pagar?");
                            string negro = Console.ReadLine();
                            int devuelta = int.Parse(negro) - subtotal;
                            Console.WriteLine("Su devuelta es de:" + devuelta);
                            if (IDcliente == 1)
                            {
                                JeronimoSaldo = JeronimoSaldo - int.Parse(negro) ;

                            }
                            if (IDcliente == 2)
                            {
                                AndresSaldo = AndresSaldo - int.Parse(negro);
                            }
                            if (IDcliente == 3)
                            {
                                JulianaSaldo = JulianaSaldo - int.Parse(negro);
                            }
                            if (IDcliente == 4)
                            {
                                EstebanSaldo = EstebanSaldo - int.Parse(negro);
                            }
                            if (IDcliente == 5)
                            {
                                CamilaSaldo = CamilaSaldo - int.Parse(negro);
                            }
                            if (devuelta == 0)
                            {
                                Fiar = 0; //si se paga todo la deuda es = 0
                            }
                        }
                        //Se fia
                        if (int.Parse(morado) == 2)
                        {
                            if (IDcliente == 1)
                            {
                                JeronimoSaldo =JeronimoSaldo + Fiar;

                            }
                            if (IDcliente == 2)
                            {
                                AndresSaldo = AndresSaldo + Fiar;
                            }
                            if (IDcliente == 3)
                            {
                                JulianaSaldo =JulianaSaldo + Fiar;
                            }
                            if (IDcliente == 4)
                            {
                                EstebanSaldo =EstebanSaldo + Fiar;
                            }
                            if (IDcliente == 5)
                            {
                                CamilaSaldo =CamilaSaldo + Fiar;
                            }
                            Fiar = subtotal;
                            Console.WriteLine("Ahora debe el total de: " + Fiar);
                        }
                        Fiar = 0;
                        break;
                    case 4:
                        //Cada cliente puede ver con su ID si tiene deudas y cuanto debe
                        subtotal = 0;
                        Console.WriteLine("Para ver su cuenta dijite su ID de cliente");
                        IDcliente = int.Parse(Console.ReadLine());
                        if (IDcliente == 1)
                        {
                            subtotal = JeronimoSaldo;
                        }
                        if (IDcliente == 2)
                        {
                            subtotal = AndresSaldo;
                        }
                        if (IDcliente == 3)
                        {
                            subtotal = JulianaSaldo;
                        }
                        if (IDcliente == 4)
                        {
                            subtotal = EstebanSaldo;
                        }
                        if (IDcliente == 5)
                        {
                            subtotal = CamilaSaldo;
                        }
                        Console.WriteLine("Su saldo por pagar es de: " + subtotal);
                        break;
  
                      //Historial de compras en la tienda dividido por el valor pagado de los clientes
                    case 5:
                        Console.WriteLine("Su historial de Compras es: ");       
                        Console.WriteLine("Las compras de Jeronimo fueron: " + TotalJeronimo);
                        Console.WriteLine("Las compras de Andres fueron: " + TotalAndres);
                        Console.WriteLine("Las compras de Juliana fueron: " + TotalJuliana);
                        Console.WriteLine("Las compras de Esteban fueron: " + TotalEsteban);
                        Console.WriteLine("Las compras de Camila fueron: " + TotalCamila);
                        Console.WriteLine("El total es de: " + Total);
                        break;
                    case 6:
                        //Se ve la deuda individual de cada Cliente
                        int deudas = 0;
                        deudas = JeronimoSaldo + AndresSaldo + JulianaSaldo + EstebanSaldo + CamilaSaldo;
                        Console.WriteLine("Su historial de deudas por cliente es: ");
                        Console.WriteLine("Las deudas de Jeronimo son: " + JeronimoSaldo);
                        Console.WriteLine("Las deudas de Andres son: " + AndresSaldo);
                        Console.WriteLine("Las deudas de Juliana son: " + JulianaSaldo);
                        Console.WriteLine("Las deudas de Esteban son: " + EstebanSaldo);
                        Console.WriteLine("Las deudas de Camila son: " + CamilaSaldo);
                        Console.WriteLine("El total de deudas es: " + deudas );
                        break;
                    case 7:
                        //Salida/Despedida para el usuario
                        Console.WriteLine("Gracias por comprar en La Soledad");
                        programa = false;

                        break;
                    default: 
                        Console.WriteLine("Se ingreso un número fuera del rango");

                        break;
                    case 8:
                        //Creditos
                        Console.WriteLine("Hecho por Jeronimo Jaramillo Marin");
                        break;
                    case 9:
                        //muestra final de los inventarios
                        Console.WriteLine("El inventario final de Leche es: " + Leche);
                        Console.WriteLine("El inventario final de Pan es: " + Pan);
                        Console.WriteLine("El inventario final de Huevos es: " + Huevos);
                        Console.WriteLine("El inventario final de Arepas es: " + Arepas);
                        Console.WriteLine("El inventario final de Café es: " + Café);
                        break;
                    case 10:
                        //Nombre de los clientes
                        Console.WriteLine("Jeronimo");
                        Console.WriteLine("Andres");
                        Console.WriteLine("Juliana");
                        Console.WriteLine("Esteban");
                        Console.WriteLine("Camila");
                        break;
                }
            }
        }
    }
}
