using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using BethanysPieShop.ViewModels;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Configuration;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    public class FileUploadController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;
        public IConfiguration Configuration { get; }

        public FileUploadController(IPieRepository pieRepository, ICategoryRepository categoryRepository, IConfiguration configuration)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
            Configuration = configuration;
        }



        [HttpPost]
        public async Task<IActionResult> ImageSearchAsync(IFormFile file)
        {

            

            byte[] b;
            using (BinaryReader br = new BinaryReader(file.OpenReadStream()))
            {
                b = br.ReadBytes((int)file.OpenReadStream().Length);
                // Convert the image in to bytes
            }
            string jsonResponse = await MakePredictionRequestNew(b);

            var obj = JObject.Parse(jsonResponse);
            var category = (string)obj.SelectToken("predictions[0].tagName");


            return List(category);

        }

        //public IActionResult Index() => List("Fruit pies");


        public async Task<string> MakePredictionRequestNew(byte[] byteData)
        {
            var client = new HttpClient();

            // Request headers - replace this example key with your valid Prediction-Key.
            client.DefaultRequestHeaders.Add("Prediction-Key", "fea09d124b2f4e39a759750fc94f108a");

            // Prediction URL - replace this example URL with your valid Prediction URL.
            string url = Configuration.GetConnectionString("ImageSerchConnection");

            HttpResponseMessage response;

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                response = await client.PostAsync(url, content);
                string jsonResponse = await response.Content.ReadAsStringAsync(); 
                return (jsonResponse);
            }


        }


        public ViewResult List(string category)
        {
            IEnumerable<Pie> pies;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                pies = _pieRepository.AllPies.OrderBy(p => p.PieId);
                currentCategory = "All pies";
            }
            else
            {
                pies = _pieRepository.AllPies.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.PieId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new PiesListViewModel
            {
                Pies = pies,
                CurrentCategory = currentCategory
            });
        }





    }
}
