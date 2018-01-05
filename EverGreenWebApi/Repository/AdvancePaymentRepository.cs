using EverGreenWebApi.DBHelper;
using EverGreenWebApi.Interfaces;
using EverGreenWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EverGreenWebApi.Repository
{
    public class AdvancePaymentRepository : IAdvancePaymentRepository
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public AdvancePaymentModel GetAdvancePaymentDetails(AdvancePaymentModel model)
        {
            using (storefeedback_androidEntities context = new storefeedback_androidEntities())
            {
                var data = context.advancemasters.Where(a =>a.OrderNumber == model.OrderNumber).Select(s => new AdvancePaymentModel()
                {
                    AdvanceId =s.AdvanceId,
                    StoreId = (int)s.StoreId,                    
                    OrderNumber = s.OrderNumber,
                    AdvancePrice = (decimal)s.AdvancePrice
                }).FirstOrDefault();

                return data;
            }
        }
    }
}