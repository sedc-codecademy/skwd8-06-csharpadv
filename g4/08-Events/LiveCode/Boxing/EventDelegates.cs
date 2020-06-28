using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing
{
    public delegate void BeforeAttackEvent(Boxer sender, PunchType type, int strength);
    public delegate void AttackEvent(Boxer sender, PunchType type, int strength);
    public delegate void DefenceEvent(Boxer sender, bool isHit, int damage);
    public delegate void KnockoutEvent(Boxer sender);
}
