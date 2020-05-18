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



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    public class FileUploadController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public FileUploadController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
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


        public static async Task<string> MakePredictionRequestNew(byte[] byteData)
        {
            var client = new HttpClient();

            // Request headers - replace this example key with your valid Prediction-Key.
            client.DefaultRequestHeaders.Add("Prediction-Key", "72dbf2d29df44dfbbeb5e6b3a457158e");

            // Prediction URL - replace this example URL with your valid Prediction URL.
            string url = "https://imagesearchclassifier.cognitiveservices.azure.com/customvision/v3.0/Prediction/864ab938-2427-4541-acc4-c79343555f02/classify/iterations/Iteration2/image";

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
