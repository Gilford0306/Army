using Army.Weapone.OneHande;
namespace Army.Soldiers.Axe_Warior
{
    internal class IndianWarrior : SolderBase
    {
        public IndianWarrior(string name) : base(name, 7, 7, new Tomahawk())
        { }

        public override void GetDamage(SolderBase solder)
        {
            base.GetDamage(solder);
            this.HP -= solder.Weapone.Damage;
            if (this.HP <= 0) Dead();
        }

        public override void Move()
        {
            Console.WriteLine("I jogging!");
        }
    }
}
