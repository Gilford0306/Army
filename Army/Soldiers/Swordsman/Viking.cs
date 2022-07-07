using Army.Weapone.TwoHande;

namespace Army.Soldiers.Swordsman
{
     class Viking : SolderBase
    {
        public Viking(string name) : base(name, 10, 5, new TwoHandeBlade())
        { }

        public override void GetDamage(SolderBase solder)
        {
            base.GetDamage(solder);
            this.HP -= solder.Weapone.Damage;
            if (this.HP <= 0)
            {
                solder.GetDamage(this);
                Dead();
            }
        }

        public override void Move()
        {
            Console.WriteLine("I walk!");
        }
    }
}
