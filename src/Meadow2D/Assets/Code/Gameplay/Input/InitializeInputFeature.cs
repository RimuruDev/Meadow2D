using Code.Gameplay.Input.Service;

namespace RimuruDev.Code.Gameplay.Input.Systems
{
    public class InitializeInputFeature : Feature
    {
        public InitializeInputFeature(GameContext gameContext, IInputService inputService)
        {
            Add(new InitializeInputSystem());
            Add(new EmitInputSystem(gameContext, inputService));
        }
    }
}