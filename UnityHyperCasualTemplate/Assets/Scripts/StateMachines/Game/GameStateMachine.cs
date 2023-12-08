namespace TheOneStudio.HyperCasual.StateMachines.Game
{
    using System.Collections.Generic;
    using System.Linq;
    using GameFoundation.Scripts.Utilities.LogService;
    using TheOneStudio.HyperCasual.Others.StateMachine.Interface;
    using TheOneStudio.HyperCasual.StateMachines.Game.Interfaces;
    using TheOneStudio.HyperCasual.StateMachines.Game.States;
    using TheOneStudio.UITemplate.UITemplate.Others.StateMachine.Controller;
    using Zenject;

    public class GameStateMachine : StateMachine, IInitializable
    {
        public GameStateMachine(
            List<IGameState> listState,
            ILogService logService
        )
            : base(listState.Select(state => state as IState).ToList(), logService)
        {
        }

        public void Initialize() { this.TransitionTo<GameHomeState>(); }
    }
}