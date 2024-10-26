using Entitas;
using NotImplementedException = System.NotImplementedException;

namespace RimuruDev.Code.Gameplay.Features.Hero.System
{
    public class SetHeroDirectionByInputSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> heroes;
        private readonly IGroup<GameEntity> inputs;

        public SetHeroDirectionByInputSystem(GameContext gameContext)
        {
            heroes = gameContext.GetGroup(GameMatcher.Hero);
            inputs = gameContext.GetGroup(GameMatcher.Input);
        }

        public void Execute()
        {
            foreach (var input in inputs)
            {
                foreach (var hero in heroes)
                {
                    hero.isMoving = input.hasAxisInput;

                    if (input.hasAxisInput)
                    {
                        hero.ReplaceDirection(input.AxisInput.normalized);
                    }
                }
            }
        }
    }
}