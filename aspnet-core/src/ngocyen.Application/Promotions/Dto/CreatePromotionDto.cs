namespace ngocyen.Promotions.Dto
{
    public class CreatePromotionDto
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal DiscountValue { get; set; }
        public int Quantity { get; set; }
    }
}