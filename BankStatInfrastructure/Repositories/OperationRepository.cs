using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using BankStatInfrastructure.EF;

namespace BankStatInfrastructure.Repositories
{
    public class OperationRepository : IOperationRepository
    {
        private readonly BankContext _db;

        public OperationRepository(BankContext db)
        {
            _db = db;
        }

        public IEnumerable<OperationModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<OperationModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public OperationModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(OperationModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationModel> CreateAsync(OperationModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(OperationModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationModel> UpdateAsync(OperationModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(OperationModel model)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(OperationModel model)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
