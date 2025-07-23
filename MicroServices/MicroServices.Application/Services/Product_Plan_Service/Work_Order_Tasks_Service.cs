using AutoMapper;
using MicroServices.Application.IService.Product_Plan;
using MicroServices.Domain.Product_Plan;
using MicroServices.Models.Dtos.Product_PlanDtos;
using MricoServices.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Application.Services.Product_Plan_Service
{
    public class Work_Order_Tasks_Service : IWork_Order_Tasks_Service
    {
        private readonly IBaseRepository<Work_Order_Tasks> workordertasksrepository;
        private readonly IMapper mapper;

        public Work_Order_Tasks_Service(IBaseRepository<Work_Order_Tasks> workordertasksrepository,IMapper mapper)
        {
            this.workordertasksrepository = workordertasksrepository;
            this.mapper = mapper;
        }

        public Task AddWork_Order_Tasks_ServiceAsync(CreateUpdateWork_Order_TasksDtos createUpdateWork_Order_TasksDtos)
        {
            throw new NotImplementedException();
        }

        public Task DeleteWork_Order_Tasks_ServiceAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Work_Order_TasksDto>> GetAllWork_Order_Tasks_ServiceAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Work_Order_TasksDto> GetWork_Order_Tasks_ServiceByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateWork_Order_Tasks_ServiceAsync(CreateUpdateWork_Order_TasksDtos createUpdateWork_Order_TasksDtos)
        {
            throw new NotImplementedException();
        }
    }
}
