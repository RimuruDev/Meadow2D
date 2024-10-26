using Zenject;
using UnityEngine;
using RimuruDev.Code.Gameplay;
using Code.Gameplay.Common.Time;

namespace Code.Infrastructure
{
    public class EcsRunner : MonoBehaviour
    {
        private GameContext gameContext;
        private ITimeService timeService;

        private BattleFeature battleFeature;

        [Inject]
        private void Constructor(GameContext context, ITimeService service)
        {
            gameContext = context;
            timeService = service;
        }

        private void Start()
        {
            battleFeature = new BattleFeature(gameContext, timeService);
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