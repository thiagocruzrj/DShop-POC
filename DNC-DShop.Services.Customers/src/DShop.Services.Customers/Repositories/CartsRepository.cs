using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DShop.Common.Mongo;
using DShop.Services.Customers.Domain;

namespace DShop.Services.Customers.Repositories
{
    public class CartsRepository : ICartsRepository
    {
        private readonly IMongoRepository<Cart> _repository;
        
        public CartsRepository(IMongoRepository<Cart> repository)
        {
            _repository = repository;
        }

        public async Task<Cart> GetAsync(Guid id)
            => await _repository.GetAsync(id);
        
        public async Task<IEnumerable<Cart>> GetAllWithProduct(Guid productId)
            => await _repository.FindAsync(x => x.Items.Any(i => i.ProductId == productId));

        public async Task AddAsync(Cart cart)
            => await _repository.AddAsync(cart);

        public async Task UpdateAsync(Cart cart)
            => await _repository.UpdateAsync(cart);

        public async Task UpdateManyAsync(IEnumerable<Cart> carts)
        {
            foreach (var cart in carts)
            {
                await _repository.UpdateAsync(cart);
            }
        }
    }
}