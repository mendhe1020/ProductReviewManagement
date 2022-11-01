namespace ProductReviewManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview() {ProductId=3,UserId=1,IsLike=true,Review="good",Reating=80},
                new ProductReview() {ProductId=1,UserId=2,IsLike=true,Review="bad",Reating=81},
                new ProductReview() {ProductId=1,UserId=3,IsLike=false,Review="good",Reating=84},
                new ProductReview() {ProductId=2,UserId=4,IsLike=true,Review="bad",Reating=90},
                new ProductReview() {ProductId=3,UserId=5,IsLike=false,Review="good",Reating=70},
                new ProductReview() {ProductId=4,UserId=6,IsLike=true,Review="bad",Reating=60},
                new ProductReview() {ProductId=5,UserId=7,IsLike=false,Review="good",Reating=85},
                new ProductReview() {ProductId=6,UserId=8,IsLike=true,Review="good",Reating=75},
                new ProductReview() {ProductId=7,UserId=9,IsLike=true,Review="bad",Reating=85},
                new ProductReview() {ProductId=8,UserId=10,IsLike=false,Review="bad",Reating=86},
                new ProductReview() {ProductId=9,UserId=11,IsLike=false,Review="good",Reating=82},
                new ProductReview() {ProductId=32,UserId=12,IsLike=true,Review="good",Reating=81},
                new ProductReview() {ProductId=31,UserId=13,IsLike=true,Review="bad",Reating=65},
                new ProductReview() {ProductId=32,UserId=14,IsLike=false,Review="good",Reating=72},
                new ProductReview() {ProductId=24,UserId=15,IsLike=false,Review="bad",Reating=87},
                new ProductReview() {ProductId=10,UserId=16,IsLike=true,Review="good",Reating=86},
                new ProductReview() {ProductId=11,UserId=17,IsLike=true,Review="bad",Reating=90},
                new ProductReview() {ProductId=12,UserId=18,IsLike=true,Review="good",Reating=95},
                new ProductReview() {ProductId=13,UserId=19,IsLike=false,Review="good",Reating=50},
                new ProductReview() {ProductId=14,UserId=20,IsLike=true,Review="bad",Reating=40},
                new ProductReview() {ProductId=11,UserId=21,IsLike=false,Review="good",Reating=88},
                new ProductReview() {ProductId=20,UserId=22,IsLike=true,Review="bad",Reating=89},
                new ProductReview() {ProductId=41,UserId=23,IsLike=true,Review="good",Reating=96},
                new ProductReview() {ProductId=42,UserId=24,IsLike=false,Review="good",Reating=80},
                new ProductReview() {ProductId=74,UserId=25,IsLike=true,Review="good",Reating=80}
            };
        }
    }
}