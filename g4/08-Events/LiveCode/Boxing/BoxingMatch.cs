using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing
{
    public class BoxingMatch
    {
        public Boxer Champion { get; private set; }
        public Boxer Challenger { get; private set; }
        public int Rounds { get; private set; }

        private bool hasKnockout = false;

        private List<IDisplay> displays = new List<IDisplay>();

        public BoxingMatch(Boxer champion, Boxer challenger, int rounds)
        {
            Champion = champion;
            Challenger = challenger;
            Rounds = rounds;

            Champion.OnAttack += (sender, punchType, strength) => Challenger.Defend(punchType, strength);
            Challenger.OnAttack += (sender, punchType, strength) => Champion.Defend(punchType, strength);

            Challenger.OnKnockout += (sender) => hasKnockout = true;
            Champion.OnKnockout += (sender) => hasKnockout = true;
        }

        public void RunGame()
        {
            for (int index = 0; index < Rounds; index++)
            {
                InitiateRound(index+1);
                Champion.Attack();
                if (hasKnockout)
                {
                    break;
                }
                Challenger.Attack();
                if (hasKnockout)
                {
                    break;
                }
            }
            ShowResults();
        }

        private void ShowResults()
        {
            foreach (var display in displays)
            {
                display.ShowResults(Champion, Challenger);
            }
        }

        private void InitiateRound(int index)
        {
            foreach (var display in displays)
            {
                display.InitateRound(index);
            }
        }

        public void AttachDisplay(IDisplay display)
        {
            Champion.OnBeforeAttack += (sender, punchType, strength) => display.ShowAttack(sender, punchType, strength);
            Challenger.OnBeforeAttack += (sender, punchType, strength) => display.ShowAttack(sender, punchType, strength);

            Champion.OnDefence += (sender, isHit, damage) => display.ShowDefence(Challenger, Champion, isHit, damage);
            Challenger.OnDefence += (sender, isHit, damage) => display.ShowDefence(Champion, Challenger, isHit, damage);

            Champion.OnKnockout += sender => display.ShowKnockout(Challenger, Champion);
            Challenger.OnKnockout += sender => display.ShowKnockout(Champion, Challenger);

            displays.Add(display);
        }

    }
}
