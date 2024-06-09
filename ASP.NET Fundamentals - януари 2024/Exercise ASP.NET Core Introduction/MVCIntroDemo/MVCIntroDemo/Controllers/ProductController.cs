using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using MVCIntroDemo.Models.Product;
using System.Text;
using System.Text.Json;

namespace MVCIntroDemo.Controllers
{
    public class ProductController : Controller
    {
        private IEnumerable<ProductViewModel> products
            = new List<ProductViewModel>()
            {
                new ProductViewModel()
                {
                    Id = 1,
                    Name = "Cheese",
                    Price = 7.00
                },
                new ProductViewModel()
                {
                    Id = 2,
                    Name = "Ham",
                    Price = 5.50
                },
                new ProductViewModel()
                {
                    Id = 3,
                    Name = "Bread",
                    Price = 1.50
                },
            };
        public IActionResult Index()
        {
            return View();
        }

        [ActionName("My-Products")]
        public IActionResult All(string keyword)
        {
            if(keyword != null)
            {
                var foundProducts = products
                    .Where(p => p.Name.ToLower()
                    .Contains(keyword.ToLower()));

                return View(foundProducts);
            }
            return View(products);
        }

        public IActionResult ById(int id)
        {
            var _product = products.FirstOrDefault(x => x.Id == id);
            if (_product == null)
            {
                return BadRequest();
            }
            return View(_product);
        }

		public IActionResult AllAsJSON()
		{
			var options = new JsonSerializerOptions
			{
				WriteIndented = true,
			};
			return Json(products, options);
		}

		public IActionResult AllAsText()
		{
            var text = string.Empty;
            foreach (var item in products)
            {
                text += $"Product {item.Id}: {item.Name} - {item.Price} lv.";
                text += "\r\n";
            }
            return Content(text);
		}

		public IActionResult AllAsTextFile()
		{
			StringBuilder sb = new StringBuilder();
            foreach(var item in products)
            {
                sb.AppendLine($"Product: {item.Id}: {item.Name} - {item.Price:f2} lv.");
            }

            Response.Headers.Add(HeaderNames.ContentDisposition,
                @"attachment;filename=products.txt");

            return File(Encoding.UTF8.GetBytes(sb.ToString().TrimEnd()), "text/plain");
		}
	}
}
