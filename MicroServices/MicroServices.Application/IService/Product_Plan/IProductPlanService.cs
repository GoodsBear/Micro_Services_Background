using MicroServices.Models.Dtos.Product_PlanDtos;
using MicroServices.Models.Dtos.RBACDtos;
using MricoServices.Shared.ApiResult;

namespace MicroServices.Application.IService.Product_Plan
{
    public interface IProductPlanService
    {
        Task<ApiResult<ApiPaging<List<ProductPlanDto>>>> GetIProduction_Plan_ServiceByIdAsync(Search search);
        Task<ApiPaging<List<ProductPlanDto>>> GetAllIProduction_Plan_ServiceAsync();
        Task<ApiResult> AddIProduction_Plan_ServiceAsync(CreateUpdateProductionPlanDto createUpdateProductionPlanDto);
        Task<ApiResult<ProductPlanDto>> UpdateIProduction_Plan_ServiceAsync(int id,CreateUpdateProductionPlanDto createUpdateProductionPlanDto);
        Task<ApiResult> DeleteIProduction_Plan_ServiceAsync(int id);
    }
}
