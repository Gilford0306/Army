using Army.Weapone.TwoHande;
using Army.Weapone.OneHande;
namespace Army.Soldiers.Swordsman

{
    class SwordsmanBase : SolderBase
    {
        delegate void WarriorDelegate();
        WarriorDelegate warriorDelegate;
        public SwordsmanBase(string name, string warrior = "viking") : base(name, 1, 1, new TwoHandeBlade())
        {
            if (warrior.ToLower().Equals("viking"))
                this.warriorDelegate += Create_Viking;
            else if (warrior.ToLower().Equals("rome"))
                this.warriorDelegate += Create_RomeLegionnaire;
            else if (warrior.ToLower().Equals("indian"))
                this.warriorDelegate += Create_IndianWarrior;
            else 
                this.warriorDelegate += Create_Samurai;
        }

        public void Create_Viking()
        {
            this.HP = 15;
            this.DamageLevel = 10;
        }
        public void Create_RomeLegionnaire()
        {
            this.HP = 5;
            this.DamageLevel = 5;
            this.Weapone = new OneHandeBlade();
        }
        public void Create_IndianWarrior()
        {
            this.HP = 7;
            this.DamageLevel = 7;
            this.Weapone = new Tomahawk();
        }
        public void Create_Samurai()
        {
            this.HP = 8;
            this.DamageLevel = 7;
            this.Weapone = new Katana();
        }
        public override void GetDamage(SolderBase solder)
        {
            this.HP -= solder.Weapone.Damage;
            base.GetDamage(solder);
            if (this.HP <= 0) Dead();
        }
        public override void Move()
        {
            Console.WriteLine("I walk!");
        }
        public void Run()
        {
            this.warriorDelegate?.Invoke();
        }
    }
}

