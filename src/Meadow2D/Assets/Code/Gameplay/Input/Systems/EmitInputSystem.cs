using Code.Gameplay.Input.Service;
using Entitas;
using UnityEngine;

namespace RimuruDev.Code.Gameplay.Input.Systems
{
    public class EmitInputSystem : IExecuteSystem
    {
        private readonly IInputService inputService;
        private readonly IGroup<GameEntity> inputs;

        public EmitInputSystem(GameContext gameContext, IInputService inputService)
        {
            this.inputService = inputService;
            inputs = gameContext.GetGroup(GameMatcher.Input);
        }

        public void Execute()
        {
            foreach (var input in inputs)
            {
                if (inputService.HasAxisInput())
                {
                    var direction = new Vector2(inputService.GetHorizontalAxis(), inputService.GetVerticalAxis());
                    input.ReplaceAxisInput(direction);
                }
                else if (input.hasAxisInput)
                {
                    input.RemoveAxisInput();
                }
            }
        }
    }
}