using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class Storage
    {
        [Key]
        public int Week { get; set; }
        public int Year { get; set; }
        
        public int Pie_id_1_stock { get; set; }
        public int Pie_id_2_stock { get; set; }
        public int Pie_id_3_stock { get; set; }
        public int Pie_id_4_stock { get; set; }
        public int Pie_id_5_stock { get; set; }
        public int Pie_id_6_stock { get; set; }
        public int Pie_id_7_stock { get; set; }
        public int Pie_id_8_stock { get; set; }
        public int Pie_id_9_stock { get; set; }
        public int Pie_id_10_stock { get; set; }
        public int Pie_id_11_stock { get; set; }





        public int GetStockById(int id)
        {
            int caseSwitch = id;

            switch (caseSwitch)
            {
                case 1:
                    return (Pie_id_1_stock);
                case 2:
                    return (Pie_id_2_stock);
                case 3:
                    return (Pie_id_3_stock);
                case 4:
                    return (Pie_id_4_stock);
                case 5:
                    return (Pie_id_5_stock);
                case 6:
                    return (Pie_id_6_stock);
                case 7:
                    return (Pie_id_7_stock);
                case 8:
                    return (Pie_id_8_stock);
                case 9:
                    return (Pie_id_9_stock);
                case 10:
                    return (Pie_id_10_stock);
                case 11:
                    return (Pie_id_11_stock);

                default:
                    return (0);
                    break;
            }
        }
    }

    
}
