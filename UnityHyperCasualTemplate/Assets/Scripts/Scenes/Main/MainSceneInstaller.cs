namespace TheOneStudio.HyperCasual.Scenes.Main
{
    using GameFoundation.Scripts.UIModule.ScreenFlow.Managers;
    using GameFoundation.Scripts.UIModule.Utilities;
    using TheOneStudio.HyperCasual.StateMachines.Game;

    public class MainSceneInstaller : BaseSceneInstaller
    {
        public override void InstallBindings()
        {
            base.InstallBindings();
            this.Container.InitScreenManually<HomeSimpleScreenPresenter>();
            
            GameStateMachineInstaller.Install(this.Container);
        }
    }
}