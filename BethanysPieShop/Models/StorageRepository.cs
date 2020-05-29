using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace BethanysPieShop.Models
{
    public class StorageRepository: IStorageRepository
    {
        private readonly AppDbContext _appDbContext;

        public StorageRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //public IEnumerable<Storage> AllStocks => _appDbContext.Storages;


        public IEnumerable<Storage> AllStocks
        {
            get
            {
                return _appDbContext.Storages.Include(c => c.Week);
            }
        }

        public int GetStorageByPieId(int pieId)
        {

            int weekNum = DateTime.Now.DayOfYear / 7;
            var recordDesired = _appDbContext.Storages.FirstOrDefault(d => d.Week == weekNum);
            int pieStock = recordDesired.GetStockById(pieId);

            return (pieStock);

            
        }

        public async Task<int> GetPredictionByIdAsync(int pieId)
        {
            int weekNum = (DateTime.Now.DayOfYear / 7)+1;
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            var record_1_week_ago= _appDbContext.Storages.FirstOrDefault(d => d.Week == (weekNum-1));
            int pieStock_1_week_ago = record_1_week_ago.GetStockById(pieId);

            var record_2_week_ago = _appDbContext.Storages.FirstOrDefault(d => d.Week == (weekNum - 1));
            int pieStock_2_week_ago = record_2_week_ago.GetStockById(pieId);

           
            int[,] input = new int[,] { { weekNum, year,month, pieStock_1_week_ago, pieStock_2_week_ago },
                                        { weekNum, year,month, pieStock_1_week_ago, pieStock_2_week_ago } };

            
            //Convert ML Model input to string
            var strInput = string.Join(",", input.OfType<int>()
                .Select((value, index) => new { value, index })
                .GroupBy(x => x.index / input.GetLength(1))
                .Select(x => $"[{string.Join(",", x.Select(y => y.value))}]"));

            strInput = "[" + strInput + "]";

            //strInput = "[[3,2020,9,5,9],[3,2020,10,1,2]]";


            string url = "http://a628f561-3428-4825-863f-6ccf9cc72e7d.eastus2.azurecontainer.io/score?data=";
            string data = strInput;

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), (url+data)))
                {
                    var response = await httpClient.SendAsync(request);

                    using (HttpContent content = response.Content)
                    {
                        var jsonResult = content.ReadAsStringAsync().Result;

                        Regex rg = new Regex(@"[-+]?\d*\.\d+|\d+");

                        MatchCollection matchedAuthors = rg.Matches(jsonResult);
                        
                        int res = (int)Math.Round(float.Parse(matchedAuthors[0].ToString()));
                        return (res);
                    }
                }
            }            
        }

        public int GetDifference(int storage, int estimate)
        {
            int result = estimate - storage;

            if (result >= 0)
            {
                return (result);
            }
            else
            {
                return (0);
            }
            


        }

    }
}
