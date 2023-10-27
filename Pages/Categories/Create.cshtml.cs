using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Olteanu_Carla_Antonia_Lab2.Data;
using Olteanu_Carla_Antonia_Lab2.Models;

namespace Olteanu_Carla_Antonia_Lab2.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Olteanu_Carla_Antonia_Lab2.Data.Olteanu_Carla_Antonia_Lab2Context _context;

        public CreateModel(Olteanu_Carla_Antonia_Lab2.Data.Olteanu_Carla_Antonia_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Category == null || Category == null)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
