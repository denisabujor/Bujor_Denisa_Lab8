using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bujor_Denisa_Lab8.Data;
using Bujor_Denisa_Lab8.Models;

namespace Bujor_Denisa_Lab8.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Bujor_Denisa_Lab8.Data.Bujor_Denisa_Lab8Context _context;

        public IndexModel(Bujor_Denisa_Lab8.Data.Bujor_Denisa_Lab8Context context)
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
