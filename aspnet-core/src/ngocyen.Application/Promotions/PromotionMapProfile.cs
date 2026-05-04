using AutoMapper;
using ngocyen.Promotions.Dto;

namespace ngocyen.Promotions
{
    public class PromotionMapProfile : Profile
    {
        public PromotionMapProfile()
        {
            CreateMap<Promotion, PromotionDto>();
            CreateMap<PromotionDto, Promotion>();
        }
    }
}