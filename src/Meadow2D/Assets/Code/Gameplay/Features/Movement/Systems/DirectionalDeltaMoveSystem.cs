using Entitas;

namespace RimuruDev.Code.Gameplay.Features.Movement.Systems
{
    public class DirectionalDeltaMoveSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> movers;

        public DirectionalDeltaMoveSystem(GameContext gameContext)
        {
            movers = gameContext.GetGroup(GameMatcher
                .AllOf(GameMatcher.WorldPosition,
                    GameMatcher.Speed)
            );
        }

        public void Execute()
        {
        }
    }
}