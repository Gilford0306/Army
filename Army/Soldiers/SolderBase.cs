using Army.Weapone;
namespace Army.Soldiers
{
    abstract class SolderBase
    {
        public string Name { get; }
        public int HP { get; set; }
        public int DamageLevel { get; set; }

        public WeaponeBase Weapone { get; set; }

        private SolderBase()
        {}

        protected SolderBase(string name, int hp, int damage, WeaponeBase weapone)
        {
            DamageLevel = damage;
            HP = hp;
            Weapone = weapone;
            Name = name;
        }

        public abstract void Move();
        public virtual void GetDamage(SolderBase solder)
        {
            string res1 = $"{solder.Name} send damage to {Name}!";
            Console.WriteLine(res1);
            string res2 = $"{solder.Name} hp is {solder.HP} / {Name} hp is {HP}!";
            Console.WriteLine(res2);
            Singleton s1 = Singleton.GetInstance();
            Singleton.Add(res1, res2);
        }
        public virtual void Dead()
        {
            Console.WriteLine($"{Name} dead");
        }
    }
}
