using Zenject;
using UnityEngine;
using RimuruDev.Code.Gameplay;
using Code.Gameplay.Common.Time;
using Code.Gameplay.Input.Service;

namespace Code.Infrastructure
{
    public class EcsRunner : MonoBehaviour
    {
        private GameContext gameContext;
        private ITimeService timeService;

        private BattleFeature battleFeature;
        private IInputService inputService;

        [Inject]
        private void Constructor(GameContext context, ITimeService service, IInputService inputService)
        {
            this.inputService = inputService;
            gameContext = context;
            timeService = service;
        }

        private void Start()
        {
            battleFeature = new BattleFeature(gameContext, timeService, inputService);
            battleFeature.Initialize();
        }

        private void Update()
        {
            battleFeature.Execute();
            battleFeature.Cleanup();
        }

        private void OnDestroy()
        {
            battleFeature.TearDown();
        }
    }
}