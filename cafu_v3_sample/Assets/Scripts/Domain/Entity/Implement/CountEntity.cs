using Domain.Entity.Interface;
using UniRx;

namespace Domain.Entity.Implement
{
    public class CountEntity : ICountEntity
    {
        public ReactiveProperty<int> Count { get; } = new ReactiveProperty<int>(0);
    }
}