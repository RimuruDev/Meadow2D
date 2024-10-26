using Entitas;
using Code.Gameplay.Features.Hero.Behaviours;

namespace RimuruDev.Code.Gameplay.Features.Hero
{
   [Game] public class Hero : IComponent { }
   [Game] public class HeroAnimatorComponent : IComponent { public  HeroAnimator Value; }
}