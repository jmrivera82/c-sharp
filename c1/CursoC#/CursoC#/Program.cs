

using Clase5Objetos; 

    //crear una instancia de la clase producto (objeto)


    Producto producto = new Producto();
    Producto producto2 = new Producto(1, "Pepsi", 5000, 10000, "Gaseosa");


    bool tieneprecio1 = producto.HayPreciodeVenta();
    bool tieneprecio2 = producto2.HayPreciodeVenta();

    

    producto2.Descripcion = "Manaos";
    producto2.PrecioCompra = 2500;
    producto2.PrecioVenta = 5000;
    producto2.Codigo = 3;

Console.WriteLine("Codigo: " + producto2.Codigo);
Console.WriteLine("Descripción: " + producto2.Descripcion);
Console.WriteLine("Precio de Compra: " + producto2.PrecioCompra);
Console.WriteLine("Precio de Venta: " + producto2.PrecioVenta);
Console.WriteLine("Categoría: " + producto2.Categoria);

Console.ReadKey();