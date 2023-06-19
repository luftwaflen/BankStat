using AutoMapper;
using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using BankStatInfrastructure.EF;
using BankStatInfrastructure.Entities;

namespace BankStatInfrastructure.Repositories
{
    public class OperationRepository : IOperationRepository
    {
        private readonly IMapper _mapper;
        private readonly BankContext _db;

        public OperationRepository(BankContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public IEnumerable<OperationModel> GetAll()
        {
            var operationEntities = _db.Operations.ToList();

            var operations = new List<OperationModel>();
            foreach (var operationEntity in operationEntities)
            {
                var operation = _mapper.Map<OperationModel>(operationEntity);
                operations.Add(operation);
            }

            return operations;
        }

        public OperationModel GetById(string id)
        {
            var operationEntity = _db.Operations.FirstOrDefault(e => e.Id == id);
            var operation = _mapper.Map<OperationModel>(operationEntity);
            return operation;
        }

        public void Create(OperationModel model)
        {
            var operationEntity = _mapper.Map<OperationEntity>(model);
            _db.Operations.Add(operationEntity);
            _db.SaveChanges();
        }

        public void Update(OperationModel model)
        {
            var operationEntity = _mapper.Map<OperationEntity>(model);
            _db.Operations.Update(operationEntity);
            _db.SaveChanges();
        }

        public void Delete(OperationModel model)
        {
            var operationEntity = _mapper.Map<OperationEntity>(model);
            _db.Operations.Remove(operationEntity);
            _db.SaveChanges();
        }

        public void DeleteById(string id)
        {
            var operationEntity = _db.Operations.FirstOrDefault(e => e.Id == id);
            _db.Operations.Remove(operationEntity);
            _db.SaveChanges();
        }
    }
}