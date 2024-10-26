using Code.Gameplay.Common.Time;
using RimuruDev.Code.Gameplay.Features.Movement;

namespace RimuruDev.Code.Gameplay
{
    public class BattleFeature : Feature
    {
        public BattleFeature(GameContext gameContext, ITimeService timeService)
        {
            Add(new MovementFeature(gameContext, timeService));
        }
    }
}