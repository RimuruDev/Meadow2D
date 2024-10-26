using Entitas;

namespace RimuruDev.Code.Gameplay.Features.Movement.Systems
{
    public class UpdateTransformPositionSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> transforms;

        public UpdateTransformPositionSystem(GameContext gameContext)
        {
            transforms = gameContext.GetGroup(
                GameMatcher.AllOf(
                    GameMatcher.Transform,
                    GameMatcher.WorldPosition
                )
            );
        }

        public void Execute()
        {
            foreach (var transform in transforms)
            {
                transform.Transform.position = transform.WorldPosition;
            }
        }
    }
}