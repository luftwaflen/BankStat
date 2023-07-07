using BankStatCore.Contracts.Repositories;
using BankStatCore.Contracts.Services;
using BankStatCore.Models;

namespace BankStatApplication.Services;

public class OperationService : IOperationService
{
    private readonly IOperationRepository _operationRepository;

    public OperationService(IOperationRepository operationRepository)
    {
        _operationRepository = operationRepository;
    }

    public IEnumerable<OperationModel> OperationsHistory(string accountId)
    {
        var operations = _operationRepository.GetAll();
        var accountOperations = operations.Where(o => o.Receiver.Id == accountId || o.Sender.Id == accountId);

        return accountOperations;
    }

    public void Deposit(AccountModel sender, AccountModel receiver, decimal amount, CurrencyModel cur)
    {
        if (receiver.Currency.Iso != cur.Iso)
            throw new InvalidDataException("Operation currency and receiver currency are not match");

        receiver.Amount += amount;

        var operation = new OperationModel
        {
            Sender = sender,
            Receiver = receiver,
            Amount = amount,
            Currency = cur,
            Type = "deposit"
        };
        _operationRepository.Create(operation);
    }

    public void Withdraw(AccountModel sender, AccountModel receiver, decimal amount, CurrencyModel cur)
    {
        if (receiver.Currency.Iso != cur.Iso)
            throw new InvalidDataException("Operation currency and receiver currency are not match");

        receiver.Amount -= amount;

        var operation = new OperationModel
        {
            Sender = sender,
            Receiver = receiver,
            Amount = amount,
            Currency = cur,
            Type = "withdraw"
        };
        _operationRepository.Create(operation);
    }

    public void Transaction(AccountModel sender, AccountModel receiver, decimal amount, CurrencyModel cur)
    {
        if (sender.Currency.Iso != cur.Iso)
            throw new InvalidDataException("Operation currency and sender currency are not match");
        if (receiver.Currency.Iso != cur.Iso)
            throw new InvalidDataException("Operation currency and receiver currency are not match");
        if (sender.Id == receiver.Id) throw new InvalidDataException("Sender and receiver are same");
        if (sender.Amount < amount) throw new Exception("Sender has insufficient funds");

        sender.Amount -= amount;
        receiver.Amount += amount;

        var operation = new OperationModel
        {
            Sender = sender,
            Receiver = receiver,
            Amount = amount,
            Currency = cur,
            Type = "deposit"
        };
        _operationRepository.Create(operation);
    }
}