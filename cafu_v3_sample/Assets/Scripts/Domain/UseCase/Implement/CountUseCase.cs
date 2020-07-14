using System;
using Domain.Entity.Interface;
using Domain.UseCase.Interface;
using UniRx;

namespace Domain.UseCase.Implement
{
    public class CountUseCase : IDisposable
    {
        private ICountRepository repository { get; }
        private ICountEntity entity { get; }

        private ICounterPresenter presenter { get; }

        private CompositeDisposable disposables { get; }

        public CountUseCase(ICountRepository repository, ICountEntity entity, ICounterPresenter presenter)
        {
            this.repository = repository;
            this.entity = entity;
            this.presenter = presenter;
            this.disposables = new CompositeDisposable();

            SetUp();
        }

        private async void SetUp()
        {
            this.entity.Count.Value = await this.repository.GetCount();

            presenter.OnClickCount()
                .Subscribe(value =>
                {
                    this.entity.Count.Value = this.entity.Count.Value + 1;
                    this.repository.SetCount(this.entity.Count.Value);
                })
                .AddTo(disposables);

            this.entity.Count.Subscribe(value => { this.presenter.RenderCount(value); })
                .AddTo(disposables);
        }

        public void Dispose() => disposables?.Dispose();
    }
}