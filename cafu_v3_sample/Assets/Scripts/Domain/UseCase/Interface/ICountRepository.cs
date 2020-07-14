using System;
using Cysharp.Threading.Tasks;
using UniRx;

namespace Domain.UseCase.Interface
{
    public interface ICountRepository
    {
        UniTask<int> GetCount();
        UniTask<Unit> SetCount(int count);
    }
}