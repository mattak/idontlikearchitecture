using UniRx;

namespace Domain.Entity.Interface
{
    public interface ICountEntity
    {
        ReactiveProperty<int> Count { get; }
    }
}