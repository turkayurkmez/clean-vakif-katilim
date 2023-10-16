// See https://aka.ms/new-console-template for more information
using ExceptionHandling;

Console.WriteLine("Hello, World!");
/*
 * NullReferenceException: Object reference not set to instance of an object.
 * 
 */
//var result = new ProductService().AddTwoBytes(255, 2);
//Console.WriteLine(result);

var service = new ProductService();


service.ChangeProductStock(3, 20);
try
{
    service.ChangeProductStock(3, -19);
}
catch (ProductServiceException ps)
{

    Console.WriteLine(ps.Message);
    Console.WriteLine(ps.Reason);
}