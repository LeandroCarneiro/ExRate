using LeandroExRate.Domain;
using LeandroExRate.Domain.Interfaces;

namespace LeandroExRate.Application
{
    public interface IBusiness<T> : ICrud<T, long> where T : EntityBase<long>
    {
    }
}
