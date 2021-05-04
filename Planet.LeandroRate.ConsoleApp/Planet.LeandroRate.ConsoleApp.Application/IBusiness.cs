using Planet.LeandroRate.ConsoleApp.Domain;
using Planet.LeandroRate.ConsoleApp.Domain.Interfaces;

namespace Planet.LeandroRate.ConsoleApp.Application
{
    public interface IBusiness<T> : ICrud<T, long> where T : EntityBase<long>
    {
    }
}
