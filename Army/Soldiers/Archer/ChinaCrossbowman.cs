using Army.Weapone.Bow;
namespace Army.Soldiers.Archer
{
    class ChinaCrossbowman:SolderBase
{
        public ChinaCrossbowman(string name) : base(name, 5, 5, new Crossbow())
        { }

        public override void GetDamage(SolderBase solder)
        {
            base.GetDamage(solder);
            this.HP -= solder.Weapone.Damage;
            if (this.HP <= 0) Dead();
        }

        public override void Move()
        {
            Console.WriteLine("I sneak!");
        }
    }
}
