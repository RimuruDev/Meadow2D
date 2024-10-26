using System;
using Code.Common.Entity;
using Code.Common.Extensions;
using UnityEngine;

namespace RimuruDev.Code.Gameplay.Features.Hero.Registrars
{
    public class HeroRegistrar : MonoBehaviour
    {
        public float Speed = 2f;

        private GameEntity entity;

        private void Awake()
        {
            entity = CreateEntity
                    .Empty()
                    .AddTransform(transform)
                    .AddWorldPosition(transform.position)
                    .AddDirection(Vector2.zero)
                    .AddSpeed(Speed)
                    .With(x => x.isHero = true) // Добавили entity Hero 
                //.With(x => x.isMoving = true) // Добавили entity Moving 
                ;
        }
    }
}