using BooksListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BooksListRazor.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db;

        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Book> BookS { get; set; }


        public async Task OnGet()
        {
            BookS = await _db.Books.ToListAsync();
        }

        public async Task <IActionResult> OnPostDelete(int id)
        {
            var book = await _db.Books.FindAsync(id);
            if(book == null)
            {
                return NotFound();
            }
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");

        }
    }
}
