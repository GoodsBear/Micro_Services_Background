using AutoMapper;
using MicroServices.Domain.Product_Plan;
using MricoServices.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Application.Services.Product_Plan_Service
{
    public class Work_Order_Service
    {
        private readonly IBaseRepository<Work_Order> workorderrepository;
        private readonly IMapper mapper;

        public Work_Order_Service(IBaseRepository<Work_Order> workorderrepository,IMapper mapper)
        {
            this.workorderrepository = workorderrepository;
            this.mapper = mapper;
        }
    }
}
