using System;
using System.Collections.Generic;

namespace Boxing
{
    public class Boxer
    {
        public string Name { get; private set; }
        public int Weight { get; private set; }
        public int Hitpoints { get; private set; }
        public Dictionary<PunchType, int> Strength { get; set; }
        public Dictionary<PunchType, int> Agility { get; set; }

        public event BeforeAttackEvent OnBeforeAttack;

        public event AttackEvent OnAttack;

        public event DefenceEvent OnDefence;

        public event KnockoutEvent OnKnockout;

        public Boxer(string name, int weight, int hitpoints)
        {
            Name = name;
            Weight = weight;
            Hitpoints = hitpoints;
        }

        public void Attack()
        {
            var punchType = (PunchType)Enum.GetValues(typeof(PunchType)).Length.RandomUpTo();
            OnBeforeAttack?.Invoke(this, punchType, Strength[punchType]);
            OnAttack?.Invoke(this, punchType, Strength[punchType]);
        }

        public void Defend(PunchType punchType, int strength)
        {
            var defense = Agility[punchType].RandomUpTo();
            var damage = strength - defense;
            var isHit = damage > 0;
            if (isHit)
            {
                Hitpoints -= damage;
            }
            OnDefence?.Invoke(this, isHit, damage);
            if (Hitpoints <= 0)
            {
                Hitpoints = 0;
                OnKnockout?.Invoke(this);
            }
        }
    }
}