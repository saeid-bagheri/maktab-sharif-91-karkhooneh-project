﻿using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels.Customers;
using App.Domain.Core.Entities;
using App.Domain.Core.Enums;
using App.Infrastructures.Db.SqlServer.Ef.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructures.Data.Repositories
{
    internal class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;

        public CustomerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public int AddOrder(AddOrderInputModel model)
        {

            //var x = new List<OrderService>();
            //foreach (var item in model.ListOfServiceIds)
            //{
            //    x.Add(new OrderService
            //    {
            //        ServiceId = item,

            //    })
            //}

            var newOrder = new Order()
            {
                CustomerId = model.CustomerId,
                CustomerAddressId = model.CustomerAddressId,
                AvailabilityFrom = model.AvailabilityFrom,
                AvailabilityTo = model.AvailabilityTo,
                StatusId = (int)OrderStatusEnum.WaitingExpertAdvice,
                ServiceCategoryId = model.ServiceCategoryId,
                CreatedBy = model.CreatedByUserId,
                CreatedAt = DateTime.Now
            };
            _appDbContext.Orders.Add(newOrder);
            _appDbContext.SaveChanges();
            return newOrder.Id;




        }
    }
}