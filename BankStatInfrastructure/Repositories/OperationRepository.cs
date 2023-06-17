using AutoMapper;
using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using BankStatInfrastructure.EF;

namespace BankStatInfrastructure.Repositories
{
    public class OperationRepository : BaseRepository<OperationModel>, IOperationRepository
    {
        private readonly IMapper _mapper;

        public OperationRepository(BankContext db, IMapper mapper)
            : base(db)
        {
            _mapper = mapper;
        }

        public override IEnumerable<OperationModel> GetAll()
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
    }
}