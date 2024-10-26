namespace RimuruDev.Code.Gameplay.Features.Hero.System
{
    public class HeroFeature : Feature
    {
        public HeroFeature(GameContext gameContext)
        {
            Add(new SetHeroDirectionByInputSystem(gameContext));
            Add(new AnimateHeroMovementSystem(gameContext));
        }
    }
}