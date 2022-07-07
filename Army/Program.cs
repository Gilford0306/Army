using Army;
using Army.Soldiers.Swordsman;
using Army.Soldiers.Axe_Warior;
using Army.Soldiers.Archer;

Viking viking = new Viking("Hrodger");
RomeLegionnaire rome = new RomeLegionnaire("Ruf");
IndianWarrior ind = new IndianWarrior("Ratonhnaketon");
ChinaCrossbowman chi = new ChinaCrossbowman("Lei");
Samurai sam = new Samurai("Jin");
EnglishLongbowmen eng = new EnglishLongbowmen("Neville");
for (int i = 0; i < 2; i++)
{
    viking.GetDamage(rome);
}
ind.GetDamage(chi);
chi.GetDamage(sam);
sam.GetDamage(eng);