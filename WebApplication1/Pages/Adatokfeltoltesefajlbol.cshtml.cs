using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class AdatokfeltoltesefajlbolModel : PageModel
    {
        private readonly IWebHostEnvironment _env;
        private readonly FociDbContext _context;
        [BindProperty]
        public IFormFile Feltoltes { get; set; }

        public AdatokfeltoltesefajlbolModel(IWebHostEnvironment env,FociDbContext context)
        {
            _env = env;
            _context = context;
        }

        public void OnGet()
        {
            
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (Feltoltes == null || Feltoltes.Length==0)
            {
                ModelState.AddModelError("Feltoltes","Adj meg egy állományt");
                return Page();
            }


            var UploadDirPath = Path.Combine(_env.ContentRootPath,"uploads");
            var UploadFilePath = Path.Combine(UploadDirPath, Feltoltes.FileName);
            using (var stream=new FileStream(UploadFilePath,FileMode.Create))
            {
                await Feltoltes.CopyToAsync(stream);
            }

            StreamReader sr = new StreamReader(UploadFilePath);

            sr.ReadLine();

            while (!sr.EndOfStream) 
            {
                var line = sr.ReadLine();
                var elemek = line.Split();
                Meccs ujmeccs = new Meccs();

                ujmeccs.Fordulo =int.Parse(elemek[0]);
                ujmeccs.HazaiVeg=int.Parse(elemek[1]);
                ujmeccs.VendegVeg=int.Parse(elemek[2]);
                ujmeccs.HazaiFelido=int.Parse(elemek[3]);
                ujmeccs.VendegFelido = int.Parse(elemek[4]);
                ujmeccs.HazaiCsapat=elemek[5];
                ujmeccs.VendegCsapat=elemek[6];
                //ujmeccs.

                _context.Add(ujmeccs);
            }

            sr.Close();
            _context.SaveChanges();
            System.IO.File.Delete(UploadFilePath);
            return Page();
        }
    }
}
