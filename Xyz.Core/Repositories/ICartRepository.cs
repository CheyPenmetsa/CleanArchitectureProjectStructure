using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xyz.Core.Entities;

namespace Xyz.Core.Repositories
{
    public interface ICartRepository
    {
        Task UpdateCartAsync(Cart cart);

        Task<Cart> GetAsync(int cartId);
    }
}
