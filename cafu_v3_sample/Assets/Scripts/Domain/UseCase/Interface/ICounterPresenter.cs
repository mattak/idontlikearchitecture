using System;
using UniRx;

namespace Domain.UseCase.Interface
{
    public interface ICounterPresenter
    {
        void RenderCount(int value);
        IObservable<Unit> OnClickCount();
    }
}