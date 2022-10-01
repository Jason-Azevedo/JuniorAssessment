namespace JuniorAssessment
{
    class Bucket
    {
        const decimal BISCUIT_NORMAL_BUCKET_PRICE = 2m;
        const decimal BISCUIT_LARGE_BUCKET_PRICE = 3.75m;

        const decimal CHEWIE_NORMAL_BUCKET_PRICE = 4.1m;
        const decimal CHEWIE_LARGE_BUCKET_PRICE = 4.5m;

        const decimal VITAMIN_NORMAL_BUCKET_PRICE = 2.5m;
        const decimal VITAMIN_LARGE_BUCKET_PRICE = 4.15m;


        public int BiscuitCount { get; set; }
        public int ChewieCount { get; set; }
        public int VitaminCount { get; set; }
        public string Size { get; set; } = "";
        public bool IsWeekend { get; set; }

        public decimal GetTotal()
        {
            decimal total = 0;

            /* Calculate price depending on bucket size */
            if (Size == "Large")
            {
                total += BiscuitCount * BISCUIT_LARGE_BUCKET_PRICE;
                total += ChewieCount * CHEWIE_LARGE_BUCKET_PRICE;
                total += VitaminCount * VITAMIN_LARGE_BUCKET_PRICE;
            }
            else
            {
                total += BiscuitCount * BISCUIT_NORMAL_BUCKET_PRICE;
                total += ChewieCount * CHEWIE_NORMAL_BUCKET_PRICE;
                total += VitaminCount * VITAMIN_NORMAL_BUCKET_PRICE;
            }

            /* Weekend price increase */
            if (IsWeekend) total *= 1.15m;

            /* Discounts */
            if (Size == "Normal" && VitaminCount > 7) total *= 0.95m;
            if (Size == "Large" && ChewieCount >= 10) total *= 0.90m;
            if (BiscuitCount + ChewieCount + VitaminCount > 20) total *= 0.80m;

            /* Cost for filling bucket */
            total += 2;

            return total;
        }
    }
}