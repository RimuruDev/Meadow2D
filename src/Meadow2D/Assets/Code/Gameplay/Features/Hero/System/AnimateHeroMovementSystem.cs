using Entitas;

namespace RimuruDev.Code.Gameplay.Features.Hero.System
{
    public class AnimateHeroMovementSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> heroes;

        public AnimateHeroMovementSystem(GameContext gameContext)
        {
            heroes = gameContext.GetGroup(GameMatcher.AllOf(GameMatcher.Hero, GameMatcher.HeroAnimator));
        }

        public void Execute()
        {
            foreach (var hero in heroes)
            {
                if (hero.isMoving)
                    hero.HeroAnimator.PlayMove();
                else
                    hero.HeroAnimator.PlayIdle();
            }
        }
    }
}