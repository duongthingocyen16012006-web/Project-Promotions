using Abp.Application.Services.Dto;
using System;

namespace ngocyen.Promotions.Dto
{
    public class PromotionDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public int DiscountType { get; set; }

        public decimal DiscountValue { get; set; }

        public decimal? MinOrderValue { get; set; }

        public decimal? MaxDiscountValue { get; set; }

        public int Quantity { get; set; }

        public int UsedCount { get; set; }
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }
    }
}