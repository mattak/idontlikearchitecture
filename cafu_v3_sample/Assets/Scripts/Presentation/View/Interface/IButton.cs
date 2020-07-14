using System;
using UniRx;

namespace Presentation.View.Interface
{
    public interface IButton
    {
        IObservable<Unit> ClickAsObservable();
    }
}