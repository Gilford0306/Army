using Army.Weapone.OneHande;
namespace Army.Soldiers.Swordsman
{
    class RomeLegionnaire : SolderBase
    {
        public RomeLegionnaire(string name) : base(name, 5, 5,  new OneHandeBlade())
        {        }

        public override void GetDamage(SolderBase solder)
        {
            base.GetDamage(solder);
            this.HP -= solder.Weapone.Damage;
            if (this.HP <= 0) Dead();
        }

        public override void Move()
        {
            Console.WriteLine("I run!");
        }
    }
}
