using MicroServices.Models.Dtos.Product_PlanDtos;

namespace MicroServices.Application.IService.Product_Plan
{
    public interface IWork_Order_Service
    {
        Task<Work_OrderDtos> GetWork_Order_ServiceByIdAsync(int id);
        Task<List<Work_OrderDtos>> GetAllWork_Order_ServiceAsync();
        Task AddWork_Order_ServiceAsync(CreateUpdateWork_OrderDtos createUpdateWork_OrderDtos);
        Task UpdateWork_Order_ServiceAsync(CreateUpdateWork_OrderDtos createUpdateWork_OrderDtos);
        Task DeleteWork_Order_ServiceAsync(int id);
    }
}
