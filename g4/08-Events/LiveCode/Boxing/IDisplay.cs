namespace Boxing
{
    public interface IDisplay
    {
        void InitateRound(int index);
        void ShowAttack(Boxer attacker, PunchType punchType, int strength);
        void ShowDefence(Boxer attacker, Boxer defender, bool isHit, int damage);
        void ShowKnockout(Boxer challenger, Boxer champion);
        void ShowResults(Boxer champion, Boxer challenger);
    }
}