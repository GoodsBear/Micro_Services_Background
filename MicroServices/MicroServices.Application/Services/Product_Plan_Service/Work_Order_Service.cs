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
    public class Work_Order_Service : IWork_Order_Service
    {
        private readonly IBaseRepository<Work_Order> workorderrepository;
        private readonly IMapper mapper;

        public Work_Order_Service(IBaseRepository<Work_Order> workorderrepository,IMapper mapper)
        {
            this.workorderrepository = workorderrepository;
            this.mapper = mapper;
        }

        public Task AddWork_Order_ServiceAsync(CreateUpdateWork_OrderDtos createUpdateWork_OrderDtos)
        {
            throw new NotImplementedException();
        }

        public Task DeleteWork_Order_ServiceAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Work_OrderDtos>> GetAllWork_Order_ServiceAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Work_OrderDtos> GetWork_Order_ServiceByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateWork_Order_ServiceAsync(CreateUpdateWork_OrderDtos createUpdateWork_OrderDtos)
        {
            throw new NotImplementedException();
        }
    }
}
