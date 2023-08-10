using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BulkyWebRazor_Temp2.Data;
using BulkyWebRazor_Temp2.Models;

namespace BulkyWebRazor_Temp2.Pages.Categories
{
	[BindProperties]
    public class CreateModel : PageModel
    {
		private readonly ApplicationDbContext _db;
		public Category Category { get; set; }
		public CreateModel (ApplicationDbContext db)
		{
			_db = db;
		}
		public void OnGet()
        {
        }
		public IActionResult OnPost()
		{
			_db.Categories.Add(Category);
			_db.SaveChanges();
			TempData["success"] = ("Category created successfully");
			return RedirectToPage("Index");



		}
	}
}
