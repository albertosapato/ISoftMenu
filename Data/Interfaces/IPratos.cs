﻿using Data.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IPratos : IGenericRepository<Prato>
    {
        Task<IQueryable<Prato>> GetOrdersAsync(string userName);

        Task<Order> GetOrdersAsync(int id);

        Task<IQueryable<OrderDetailTemp>> GetDetailTempsAsync(string userName);

        Task AddItemToOrderAsync(AddItemViewModel model, string userName);

        Task ModifyOrderDetailTempQuantityAsync(int id, double quantity);

        Task DeleteDetailTempAsync(int id);

        Task<bool> ConfirmOrderAsync(string userName);

        Task DeliverOrder(DeliverViewModel model);
    }
}
