using Abp.Application.Services;
using Abp.Domain.Repositories;
using ngocyen.Promotions;
using ngocyen.Promotions.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using ngocyen.Promotions.Dto;
using System;
namespace ngocyen.Promotions
{
    public class PromotionAppService : ApplicationService
    {
        
        private readonly IRepository<Promotion> _promotionRepository;

        public PromotionAppService(IRepository<Promotion> promotionRepository)
        {
            _promotionRepository = promotionRepository;
        }
        public async Task<List<PromotionDto>> GetAllAsync()
        {
            var promotions = await _promotionRepository.GetAllListAsync();

            var result = ObjectMapper.Map<List<PromotionDto>>(promotions);

            foreach (var p in result)
            {
                p.IsActive =
                    p.IsActive &&
                    DateTime.Now >= p.StartDate &&
                    DateTime.Now <= p.EndDate;
            }

            return result;
        }
        public async Task CreateAsync(PromotionDto input)
        {
            var promotion = ObjectMapper.Map<Promotion>(input);

            promotion.StartDate = DateTime.Now;
            promotion.EndDate = DateTime.Now.AddMonths(1);

            promotion.IsActive = true;

            await _promotionRepository.InsertAsync(promotion);
        }
        public async Task UpdateAsync(PromotionDto input)
        {
            var promotion = await _promotionRepository.GetAsync(input.Id);

            var oldStartDate = promotion.StartDate;
            var oldEndDate = promotion.EndDate;
            var oldIsActive = promotion.IsActive;

            ObjectMapper.Map(input, promotion);

            promotion.StartDate = oldStartDate;
            promotion.EndDate = oldEndDate;
            promotion.IsActive = oldIsActive;
            await _promotionRepository.UpdateAsync(promotion);
        }
        public async Task DeleteAsync(EntityDto<int> input)
        {
            await _promotionRepository.DeleteAsync(input.Id);
        }
        
    }
}