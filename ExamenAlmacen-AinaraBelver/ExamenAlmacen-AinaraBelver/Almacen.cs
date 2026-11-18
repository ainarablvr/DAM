using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ExamenAlmacen_AinaraBelver
{
    internal class Almacen
    {
        //VARIABLES
        Pendiente pendiente = null;
        List <Articulo> lista = new List<Articulo>();
        Stack<Articulo> agotados = new Stack<Articulo>();

        //añadimos los objetos
        public void iniciar() //en vez de crearlos al principio creo este metodo que se llama una vez al iniciar el programa
        {
            lista.Add(new Existencia(1, "Teclado", 3));
            lista.Add(new Existencia(2, "Raton", 2));
            lista.Add(new Existencia(3, "Monitor", 1));

            Pendiente pendiente = new Pendiente(4, "Gafas", 0);
            agotados.Push(pendiente);
        }

        public void consultar()
        {
            

            Console.WriteLine("\n---ALMACÉN---");
            foreach (Existencia art in lista)
            {
                Console.WriteLine($"{art}");
            }
          

            Console.WriteLine("\n---PENDIENTES DE REPONER---");
            foreach (Articulo art in agotados)
            {
                    Console.WriteLine($"{art}");
                
            }
            if(agotados == null)
            {
                Console.WriteLine("No hay ningun articulo pendiente de reponer");
            }
            

        }

        public  void retirar(int cod, int cant) //void porque es menos lioso
        {
            foreach (Articulo comprobar in lista)
            {
                if(comprobar.cod == cod)
                {
                    comprobar.cod = cod;
                    if (comprobar.cant >= cant)
                    {
                        comprobar.cant -= cant;
                        Console.WriteLine("Retirado correctamente");
                        if (comprobar.cant == 0)
                        {
                            agotados.Push(comprobar);
                            Console.WriteLine("Retirado correctamente y se agotó el articulo");
                            Console.WriteLine("Inserte cantidad a añadir");
                            int cantAnadir = int.Parse(Console.ReadLine());
                            reponer(cod,cantAnadir); //mas facil llamar directamente al metodo pasandole los datos
                        }
                    }
                    else
                    {
                        throw new ArgumentException("No hay suficiente cantidad");
                    }
                }
            }
            
        }

        public void reponer(int cod, int cant) //void porque es menos lioso
        {
            foreach (Articulo comprobar in agotados)
            {
                if (comprobar.cod == cod)
                {
                    comprobar.cod = cod;
                    comprobar.cant += cant;
                    Articulo eliminar = agotados.Pop();
                    eliminar = null;
                    Console.WriteLine("Repuesto correctamente");
                    Articulo nuevo = (Articulo)comprobar;
                    lista.Add(nuevo);
                }
                else
                {
                    throw new ArgumentException("No se encontró el articulo");
                }
            }

            foreach (Articulo comprobar in lista)
            {
                if (comprobar.cod == cod)
                {
                    comprobar.cod = cod;
                    comprobar.cant += cant;
                    Console.WriteLine("Añadido correctamente");
                }

            }
        }
    }
}
