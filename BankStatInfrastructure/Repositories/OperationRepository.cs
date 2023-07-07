using BankStatCore.Contracts.Repositories;
using BankStatCore.Models;
using BankStatInfrastructure.EF;

namespace BankStatInfrastructure.Repositories
{
    public class OperationRepository : BaseRepository<OperationModel>, IOperationRepository
    {
        public OperationRepository(BankContext db)
            : base(db)
        {
        }
    }
}