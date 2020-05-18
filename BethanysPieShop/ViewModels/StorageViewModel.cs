using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels
{
    public class StorageViewModel
    {
        public IPieRepository pieRepository { get; set; }
        public StorageRepository storageRepository { get; set; }

    }
    
}
