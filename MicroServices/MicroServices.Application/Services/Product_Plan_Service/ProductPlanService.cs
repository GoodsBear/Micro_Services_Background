using AutoMapper;
using MicroServices.Application.IService.Product_Plan;
using MicroServices.Domain.Product_Plan;
using MicroServices.Domain.ProductPlan;
using MicroServices.Models.Dtos.Product_PlanDtos;
using MricoServices.Repository.IRepository;
using MricoServices.Shared.ApiResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Application.Services.Product_Plan_Service
{
    public class ProductPlanService : IProductPlanService
    {
        private readonly IBaseRepository<ProductPlan> productionPlanningRepository;
        private readonly IMapper mapper;

        public ProductPlanService(IBaseRepository<ProductPlan> productionPlanningRepository, IMapper mapper)
        {
            this.productionPlanningRepository = productionPlanningRepository;
            this.mapper = mapper;
        }
        /// <summary>
        /// 生产计划添加
        /// </summary>
        /// <param name="createUpdateProductionPlanDto"></param>
        /// <returns></returns>
        public async Task<ApiResult> AddIProduction_Plan_ServiceAsync(CreateUpdateProductionPlanDto createUpdateProductionPlanDto)
        {
            try
            {
                var productionPlan = mapper.Map<ProductPlan>(createUpdateProductionPlanDto);
                var result = await productionPlanningRepository.AddAsync(productionPlan);

                return result > 0
                    ? ApiResult.Success(ResultCode.Ok)
                    : ApiResult.Fail(ResultCode.Fail, "生产计划添加失败");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"添加生产计划时发生异常: {ex.Message}");
                return ApiResult.Fail(ResultCode.Fail, "添加生产计划时发生内部错误。"); // 返回通用错误信息
            }
        }

        public async Task<ApiResult> DeleteIProduction_Plan_ServiceAsync(int id)
        {
            try
            {
                var exists = await productionPlanningRepository.GetAll().Where(d => d.Id == id).AnyAsync();
                if (!exists)
                {
                    return ApiResult.Fail(ResultCode.Fail, "该生产计划不存在");
                }

                var result = await productionPlanningRepository.SoftDeleteAsync(id); // 假设 IBaseRepository 提供了 SoftDeleteAsync 方法

                return result > 0
                    ? ApiResult.Success(ResultCode.Ok)
                    : ApiResult.Fail(ResultCode.Fail, "生产计划删除失败");
            }
            catch (Exception ex)
            {
                // 记录异常日志
                Console.WriteLine($"删除生产计划时发生异常: {ex.Message}");
                return ApiResult.Fail(ResultCode.Fail, "删除生产计划时发生内部错误。");
            }
        }

        public Task<ApiPaging<List<ProductPlanDto>>> GetAllIProduction_Plan_ServiceAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResult<ApiPaging<List<ProductPlanDto>>>> GetIProduction_Plan_ServiceByIdAsync(Search search)
        {
            try
            {
                var query = productionPlanningRepository.GetAll();

                // 根据DTO中的条件进行过滤，这里假设 SearchProductionPlanDto 包含 PlanName 属性
                if (!string.IsNullOrEmpty(search.Plan_Name) || !string.IsNullOrEmpty(search.Plan_Id))
                {
                    query = query.Where(d => d.Plan_Name.Contains(search.Plan_Name) || d.Plan_Id.Contains(search.Plan_Id));
                }
                if(search.FromType != null || search.FromType != 0)
                {
                    query = query.Where(d => d.FromType == search.FromType);
                }
                if(!string.IsNullOrEmpty(search.ProductName))
                {
                    query = query.Where(d => d.ProductName == search.ProductName);
                }
                if(search.Status != null || search.Status != 0)
                {
                    query = query.Where(d => d.Status == search.Status);
                }

                var totalCount = await query.CountAsync();
                var totalPage = (int)Math.Ceiling(totalCount * 1.0 / search.PageSize); // 使用 totalCount 而非再次 count

                var pagedData = await query.OrderByDescending(d => d.CreatedAt) // 假设 Production_Planning 有 CreatedAt 属性
                                           .Skip((search.PageIndex - 1) * search.PageSize)
                                           .Take(search.PageSize)
                                           .ToListAsync();

                var data = mapper.Map<List<ProductPlanDto>>(pagedData);

                var apiPagingData = new ApiPaging<List<ProductPlanDto>>
                {
                    TotalCount = totalCount,
                    TotalPage = totalPage,
                    Data = data
                };

                return ApiResult<ApiPaging<List<ProductPlanDto>>>.Success(ResultCode.Ok, apiPagingData);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ApiResult<ProductPlanDto>> UpdateIProduction_Plan_ServiceAsync(int id, CreateUpdateProductionPlanDto createUpdateProductionPlanDto)
        {
            try
            {
                var productionPlan = await productionPlanningRepository.GetByIdAsync(id);
                if (productionPlan == null)
                {
                    return ApiResult<ProductPlanDto>.Fail(ResultCode.Fail, "该生产计划不存在");
                }

                // 映射 DTO 的值到现有实体
                mapper.Map(createUpdateProductionPlanDto, productionPlan);

                var updateSuccess = await productionPlanningRepository.UpdateAsync(productionPlan);

                return updateSuccess > 0
                    ? ApiResult<ProductPlanDto>.Success(ResultCode.Ok, mapper.Map<ProductPlanDto>(productionPlan))
                    : ApiResult<ProductPlanDto>.Fail(ResultCode.Fail, "生产计划更新失败");
            }
            catch (Exception ex)
            {
                // 记录异常日志
                Console.WriteLine($"更新生产计划时发生异常: {ex.Message}");
                return ApiResult<ProductPlanDto>.Fail(ResultCode.Fail, "更新生产计划时发生内部错误。");
            }
        }
    }
}
