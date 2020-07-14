using Cysharp.Threading.Tasks;
using Data.Repository.Interface;
using Domain.UseCase.Interface;
using UniRx;

namespace Data.Repository.Implement
{
    public class CountRepository : ICountRepository
    {
        private ICountDataStore CountDataStore { get; }

        public CountRepository(ICountDataStore dataSource)
        {
            this.CountDataStore = dataSource;
        }

        async UniTask<int> ICountRepository.GetCount()
        {
            await UniTask.Delay(100); // dummy wait for something process
            return await UniTask.FromResult(this.CountDataStore.GetCount());
        }

        async UniTask<Unit> ICountRepository.SetCount(int count)
        {
            this.CountDataStore.SetCount(count);
            await UniTask.Delay(100); // dummy wait for something process
            return Unit.Default;
        }
    }
}