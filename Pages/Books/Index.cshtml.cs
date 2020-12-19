using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Luncan_Alexandru_Lab8.Data;
using Luncan_Alexandru_Lab8.Models;

namespace Luncan_Alexandru_Lab8.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Luncan_Alexandru_Lab8.Data.Luncan_Alexandru_Lab8Context _context;

        public IndexModel(Luncan_Alexandru_Lab8.Data.Luncan_Alexandru_Lab8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
