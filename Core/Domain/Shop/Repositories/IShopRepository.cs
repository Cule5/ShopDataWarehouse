using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Shop.Repositories
{
    public interface IShopRepository
    {
        Task<Shop> GetAsync(Guid shopId);
        Task AddAsync(Shop shop);
    }
}
