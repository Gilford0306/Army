using Army.Weapone.TwoHande;
namespace Army.Soldiers.Swordsman
{
    internal class Samurai : SolderBase
    {
        public Samurai(string name) : base(name, 8, 7, new Katana())
        { }

        public override void GetDamage(SolderBase solder)
        {
            base.GetDamage(solder);
            this.HP -= solder.Weapone.Damage;
            if (this.HP <= 0) Dead();
        }

        public override void Move()
        {
            Console.WriteLine("I tread!");
        }
    }
}
