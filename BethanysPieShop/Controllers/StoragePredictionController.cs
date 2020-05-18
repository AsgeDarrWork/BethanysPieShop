using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    public class StoragePredictionController : Controller
    {

        private readonly IPieRepository _pieRepository;
        private readonly IStorageRepository _storageRepository; 



        public StoragePredictionController(IPieRepository pieRepository, IStorageRepository storageRepository)
        {
            _pieRepository = pieRepository;
            _storageRepository = storageRepository;

        }

        // GET: /<controller>/
        public ViewResult Index()
        {
            


            var storageViewModel = new StorageViewModel
            {
                pieRepository = _pieRepository,
                storageRepository = (StorageRepository)_storageRepository

            };


            return View(storageViewModel);
        }
    }
}
