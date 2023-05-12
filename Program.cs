using HjælpTilLone.Classes;

namespace HjælpTilLone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wizard wiz = new Wizard();
            Babarian baba = new Babarian();
            Knight knigt = new Knight();
            Witch witch = new Witch();

            wiz.Fight();
            wiz.ThrowFrostNova();
            wiz.Teleport(5, 8);
            wiz.Heal();
            wiz.ThrowMagicMisile();
            wiz.Die();
            Console.WriteLine();

            baba.Fight();
            baba.Bash();
            baba.Heal();
            baba.Slash();
            baba.Die();
            Console.WriteLine();

            knigt.Fight();
            knigt.Bash();
            knigt.RaiseShield();
            knigt.Heal();
            knigt.Slash();
            knigt.ShieldGlare();
            knigt.Die();
            Console.WriteLine();

            witch.Fight();
            witch.Teleport(9, 3);
            witch.RaiseShield();
            witch.Heal();
            witch.ShieldGlare();
            witch.Die();
        }
    }
}