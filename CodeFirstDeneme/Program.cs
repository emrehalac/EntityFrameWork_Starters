// See https://aka.ms/new-console-template for more information
using CodeFirstDeneme.DAL;
using Microsoft.EntityFrameworkCore;
Initializer.Build();
using (var _context = new AppDbContext())
{
    var newProduct = new Product { Name = "Kalem 17", Price = 12, Stock = 10 };
    Console.WriteLine($"İlk state: {_context.Entry(newProduct).State}");
    await _context.AddAsync(newProduct);
    Console.WriteLine($"Son state: {_context.Entry(newProduct).State}");
    await _context.SaveChangesAsync();
    Console.WriteLine($"Son state: {_context.Entry(newProduct).State}");

   // _context.Products.Add( newProduct ); 
    await _context.Products.AddAsync(new Product { Name = "Kalem 35", Price = 13 , Stock = 14 });
    await _context.SaveChangesAsync();
    


    var products = await _context.Products.ToListAsync();

    products.ForEach(
     p=> Console.WriteLine($"{p.Id} : {p.Name}"));

}
