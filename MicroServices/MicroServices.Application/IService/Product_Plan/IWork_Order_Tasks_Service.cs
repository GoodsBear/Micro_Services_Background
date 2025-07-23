using MicroServices.Models.Dtos.Product_PlanDtos;

namespace MicroServices.Application.IService.Product_Plan
{
    public interface IWork_Order_Tasks_Service
    {
        Task<Work_Order_TasksDto> GetWork_Order_Tasks_ServiceByIdAsync(int id);
        Task<List<Work_Order_TasksDto>> GetAllWork_Order_Tasks_ServiceAsync();
        Task AddWork_Order_Tasks_ServiceAsync(CreateUpdateWork_Order_TasksDtos createUpdateWork_Order_TasksDtos);
        Task UpdateWork_Order_Tasks_ServiceAsync(CreateUpdateWork_Order_TasksDtos createUpdateWork_Order_TasksDtos);
        Task DeleteWork_Order_Tasks_ServiceAsync(int id);
    }
}
