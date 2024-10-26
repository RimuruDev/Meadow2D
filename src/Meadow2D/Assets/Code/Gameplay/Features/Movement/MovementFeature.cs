using Code.Gameplay.Common.Time;
using RimuruDev.Code.Gameplay.Features.Movement.Systems;

namespace RimuruDev.Code.Gameplay.Features.Movement
{
    public class MovementFeature : Feature
    {
        public MovementFeature(GameContext gameContext, ITimeService timeService)
        {
            Add(new DirectionalDeltaMoveSystem(gameContext, timeService));
        }
    }
}