namespace Data.Controllers
{
    using Data.Controllers.Helps;
    using Data.Interfaces;
    using Data.Models;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class PratosControllers : IPratos
    {
        private readonly MenuContext menuContext;
        public PratosControllers(MenuContext menuContext)
        {
            this.menuContext = menuContext;
        }
        public Task<Prato> CreateAsync(Prato entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Prato entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Prato> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Prato> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Prato> UpdateAsync(Prato entity)
        {
            throw new NotImplementedException();
        }
    }
}
