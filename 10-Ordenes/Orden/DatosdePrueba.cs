/* 
    Autor: Jonatán Amaya
    Universidad: UNAH-VS
    Carrera: Licenciatura en Informática Administrativa
    Hora: 18:00 - 19:00
    Catedrático: Lic. billy fernandez
    Clase: Lenguaje de Programación II
*/ 

using System;
using System.Collections.Generic;
public class DatosdePrueba
{
    public List<Producto> ListadeProductos { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Vendedor> ListadeVendedores { get; set; }
    public List<Orden> ListaOrdenes { get; set; }

    public DatosdePrueba()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeVendedores = new List<Vendedor>();
        cargarVendedores();

        ListaOrdenes = new List<Orden>();
    }

    private void cargarProductos()
    {
        Producto p1 = new Producto(1, "Mouse", 150);
        ListadeProductos.Add(p1);

        Producto p2 = new Producto(2, "Teclado", 550);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto(3, "Monitor", 4000);
        ListadeProductos.Add(p3);

        Producto p4 = new Producto(4, "Camara Web", 750);
        ListadeProductos.Add(p4);

        Producto p5 = new Producto(5, "Disco Externo 1TB", 1400);
        ListadeProductos.Add(p5);

        Producto p6 = new Producto(6, "Memoria USB 128Gb ", 950);
        ListadeProductos.Add(p6);

        Producto p7 = new Producto(7, "Impresora Epson L3050", 5900);
        ListadeProductos.Add(p7);

        Producto p8 = new Producto(8, "Mouse bluetooth", 300);
        ListadeProductos.Add(p8);
    }

    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, "Antonio", "3398-5489");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2, "Elson", "9857-2030");
        ListadeClientes.Add(c2);

        Cliente c3 = new Cliente(3, "Fernando", "3236-7328");
        ListadeClientes.Add(c3);

    }

    private void cargarVendedores()
    {
        Vendedor v1 = new Vendedor(1, "Brian", "V001");
        ListadeVendedores.Add(v1);

        Vendedor v2 = new Vendedor(2, "Lester", "V002");
        ListadeVendedores.Add(v2);

        Vendedor v3 = new Vendedor (3, "Stiven", "V003");
        ListadeVendedores.Add(v3);

    }

    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Productos");
        Console.WriteLine("==================");
        Console.WriteLine("");
        
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
        }

        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Clientes");
        Console.WriteLine("=================");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono);
        }

        Console.ReadLine();
    }

    public void ListarVendedores()
    {
        Console.Clear();
        Console.WriteLine("Lista de Vendedores");
        Console.WriteLine("===================");
        Console.WriteLine("");
        
        foreach (var vendedor in ListadeVendedores)
        {
            Console.WriteLine(vendedor.Codigo + " | " + vendedor.Nombre + " | " + vendedor.CodigoVendedor);
        }

        Console.ReadLine();
    }

    public void CrearOrden()
    {
        Console.WriteLine("Creando Orden");
        Console.WriteLine("=============");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);        
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el codigo del vendedor: ");
        string codigoVendedor = Console.ReadLine();

        Vendedor vendedor = ListadeVendedores.Find(v => v.Codigo.ToString() == codigoVendedor);
        if (vendedor == null) 
        {
            Console.WriteLine("Vendedor no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Vendedor: " + vendedor.Nombre);
            Console.WriteLine("");
        }

        int nuevoCodigo = ListaOrdenes.Count + 1;

        Orden nuevaOrden = new Orden(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, vendedor);
        ListaOrdenes.Add(nuevaOrden);

        while(true)
        {
            Console.WriteLine("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaOrden.AgregarProducto(producto);
            }

            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }    
        }

         
        
        Console.ReadLine();
    }

    public void ListarOrdenes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Ordenes");
        Console.WriteLine("================");
        Console.WriteLine("");  
        Console.WriteLine("Codigo | Fecha | Total");
        Console.WriteLine("Cliente | Vendedor");
        Console.WriteLine("======================");
        Console.WriteLine("");  

        foreach (var orden in ListaOrdenes)
        {
            Console.WriteLine("Codigo | Fecha | Total");
            Console.WriteLine(orden.Codigo + " | " + orden.Fecha + " | " + orden.Total);
            Console.WriteLine("Cliente | Vendedor");
            Console.WriteLine(orden.Cliente.Nombre + " | " + orden.Vendedor.Nombre);
            
            foreach (var detalle in orden.ListaOrdenDetalle)
            {
                 Console.WriteLine("Producto | Cantidad | Precio ");
                Console.WriteLine("     " + detalle.Producto.Descripcion + " | " + detalle.Cantidad + " | " + detalle.Precio);
            }
            Console.WriteLine("Subtotal: " + orden.SubTotal);
            Console.WriteLine("ISV 15%: " + orden.ISV);
            Console.WriteLine("Total: " + orden.Total);

            Console.WriteLine();
        } 

        Console.ReadLine();
    }
}