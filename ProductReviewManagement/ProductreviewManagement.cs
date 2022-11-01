﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductreviewManagement
    {
        //uc2
        public static void RetrieveTop3Reating(List<ProductReview> list)
        {
            Console.WriteLine("\nRetrieve Top 3 rating based on rating");
            var Top3Records = (from product in list orderby product.Rating descending select product).Take(3).ToList();
            Program.DisplayProductReviewRecords(Top3Records); 
        }
        //uc3
        public static void FetchBasedOnRatingAndProductId(List<ProductReview> list)
        {
            Console.WriteLine("\nFetch record based on rating and productId");
            List<ProductReview> basedOnProductId=list.Where(p=> p.Rating>3 && (p.ProductId ==1 || p.ProductId ==4 || p.ProductId == 9)).ToList();
            Program.DisplayProductReviewRecords(basedOnProductId);
        }
    }
}
