using Code.Gameplay.Common.Time;
using Code.Gameplay.Input.Service;
using RimuruDev.Code.Gameplay.Features.Movement;
using RimuruDev.Code.Gameplay.Input.Systems;

namespace RimuruDev.Code.Gameplay
{
    public class BattleFeature : Feature
    {
        public BattleFeature(GameContext gameContext, ITimeService timeService, IInputService inputService)
        {
            Add(new InitializeInputFeature(gameContext, inputService));
            Add(new MovementFeature(gameContext, timeService));
        }
    }
}