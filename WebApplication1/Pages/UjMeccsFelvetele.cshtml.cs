using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class UjMeccsFelveteleModel : PageModel
    {
        [BindProperty]
        public Meccs UjMeccs { get; set; }

        public List<Meccs> meccsekListaja {  get; set; }=new List<Meccs>();
        private readonly FociDbContext _db;

        public UjMeccsFelveteleModel(FociDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            meccsekListaja = _db.Meccsek.ToList();
        }

        public IActionResult OnPost()
        {
            _db.Meccsek.Add(UjMeccs);
            _db.SaveChanges();
            return Page();
        }
    }
}
