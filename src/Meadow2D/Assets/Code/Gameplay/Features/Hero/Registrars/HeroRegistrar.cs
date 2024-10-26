using System;
using Code.Common.Entity;
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
                    .AddWorldPosition(transform.position)
                    .AddDirection(Vector2.zero)
                    .AddSpeed(Speed)
                ;
        }
    }
}