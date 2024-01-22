using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crud_Razor.Data;
using Crud_Razor.Model;

namespace Crud_Razor.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly Crud_Razor.Data.Crud_RazorContext _context;

        public IndexModel(Crud_Razor.Data.Crud_RazorContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
