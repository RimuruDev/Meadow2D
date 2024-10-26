using System;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Hero.Behaviours;
using UnityEngine;

namespace RimuruDev.Code.Gameplay.Features.Hero.Registrars
{
    public class HeroRegistrar : MonoBehaviour
    {
        public float Speed = 2f;
        public HeroAnimator HeroAnimator;
        
        private GameEntity entity;

        private void Awake()
        {
            entity = CreateEntity
                    .Empty()
                    .AddTransform(transform)
                    .AddHeroAnimator(HeroAnimator)
                    .AddWorldPosition(transform.position)
                    .AddDirection(Vector2.zero)
                    .AddSpeed(Speed)
                    .With(x => x.isHero = true)
                ;
        }
    }
}