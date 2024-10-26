namespace RimuruDev.Code.Gameplay.Features.Hero.System
{
    public class HeroFeature : Feature
    {
        public HeroFeature(GameContext gameContext)
        {
            Add(new SetHeroDirectionByInput(gameContext));
        }
    }
}