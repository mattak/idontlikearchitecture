using System;
using Domain.UseCase.Interface;
using Presentation.View.Interface;
using UniRx;
using Zenject;

namespace Presentation.Presenter
{
    public class CounterPresenter : ICounterPresenter
    {
        private IText text;
        private IButton button;

        public CounterPresenter(
            [Inject(Id = "CountButton")] IButton button,
            [Inject(Id = "CountText")] IText text
        )
        {
            this.button = button;
            this.text = text;
        }

        void ICounterPresenter.RenderCount(int value) => this.text.Render(value.ToString());

        IObservable<Unit> ICounterPresenter.OnClickCount() => this.button.ClickAsObservable();
    }
}