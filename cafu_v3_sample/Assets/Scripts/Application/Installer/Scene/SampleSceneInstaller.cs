using Data.DataStore;
using Data.Repository.Implement;
using Data.Repository.Interface;
using Domain.Entity.Implement;
using Domain.Entity.Interface;
using Domain.UseCase.Implement;
using Domain.UseCase.Interface;
using Presentation.Presenter;
using Presentation.View.Implement;
using Presentation.View.Interface;
using Zenject;

namespace Application.Installer.Scene
{
    public class SampleSceneInstaller : MonoInstaller
    {
        public CounterButton Button;
        public CountRenderer Text;

        public override void InstallBindings()
        {
            Container.Bind<IButton>().WithId("CountButton").FromInstance(this.Button);
            Container.Bind<IText>().WithId("CountText").FromInstance(this.Text);
            Container.Bind<ICounterPresenter>().To<CounterPresenter>().AsSingle();
            Container.Bind<ICountEntity>().To<CountEntity>().AsCached();
            Container.Bind<ICountRepository>().To<CountRepository>().AsSingle();
            Container.Bind<ICountDataStore>().To<CountDataStore>().AsSingle();
            Container.BindInterfacesAndSelfTo<CountUseCase>().AsSingle();
        }
    }
}