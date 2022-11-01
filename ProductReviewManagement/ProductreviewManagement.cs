using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductreviewManagement
    {
        public static void RetrieveTop3Reating(List<ProductReview> list)
        {
            Console.WriteLine("\nRetrieve Top 3 rating based on rating");
            var Top3Records = (from product in list orderby product.Rating descending select product).Take(3).ToList();
            Program.DisplayProductReviewRecords(Top3Records); 
        }
    }
}
