using FakeBookApi.Data;
using FakeBookApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

public class CategoriesService
   {
       private readonly ApplicationDbContext _context;

       public CategoriesService(ApplicationDbContext context)
       {
           _context = context;
       }

       public async Task<List<Category>> GetAsync() =>
           await _context.Categories.ToListAsync();

       public async Task<Category?> GetAsync(string id) =>
           await _context.Categories.FindAsync(id);

       public async Task CreateAsync(Category newCategory)
       {
           _context.Categories.Add(newCategory);
           await _context.SaveChangesAsync();
       }

       public async Task UpdateAsync(string id, Category updatedCategory)
       {
           _context.Entry(updatedCategory).State = EntityState.Modified;
           await _context.SaveChangesAsync();
       }

       public async Task RemoveAsync(string id)
       {
           var category = await _context.Categories.FindAsync(id);
           if (category != null)
           {
               _context.Categories.Remove(category);
               await _context.SaveChangesAsync();
           }
       }
   }