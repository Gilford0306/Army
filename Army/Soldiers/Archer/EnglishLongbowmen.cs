using Army.Weapone.Bow;
namespace Army.Soldiers.Archer
{
    class EnglishLongbowmen : SolderBase
    {
        public EnglishLongbowmen(string name) : base(name, 7, 8, new English_longbow())
        { }

        public override void GetDamage(SolderBase solder)
        {
            base.GetDamage(solder);
            this.HP -= solder.Weapone.Damage;
            if (this.HP <= 0) Dead();
        }

        public override void Move()
        {
            Console.WriteLine("I go!");
        }
    }
}