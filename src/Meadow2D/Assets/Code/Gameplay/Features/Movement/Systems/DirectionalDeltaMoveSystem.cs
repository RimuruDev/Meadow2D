using Code.Gameplay.Common.Time;
using Entitas;
using UnityEngine;

namespace RimuruDev.Code.Gameplay.Features.Movement.Systems
{
    public class DirectionalDeltaMoveSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> movers;
        private readonly ITimeService timeService;

        public DirectionalDeltaMoveSystem(GameContext gameContext, ITimeService timeService)
        {
            this.timeService = timeService;
            movers = gameContext.GetGroup(GameMatcher
                .AllOf(
                    // Entity
                    GameMatcher.WorldPosition,
                    GameMatcher.Direction,
                    GameMatcher.Speed,
                    // Flags
                    GameMatcher.Moving
                )
            );
        }

        public void Execute()
        {
            foreach (var entityMover in movers)
            {
                var delta = entityMover.Direction * (entityMover.Speed * timeService.DeltaTime);
                var newDirection = (Vector2)entityMover.WorldPosition + delta;

                entityMover.ReplaceWorldPosition(newDirection);
            }
        }
    }
}