
using Army.Soldiers.Swordsman;


SwordsmanBase vik  = new SwordsmanBase("Hrodger");
vik.Run();
SwordsmanBase rom = new SwordsmanBase("Ruf", "rome");
rom.Run();
SwordsmanBase sam = new SwordsmanBase("Jin", "samurai");
sam.Run();
SwordsmanBase ind = new SwordsmanBase("Ratonhnaketon", "indian");
ind.Run();

vik.GetDamage(rom);
sam.GetDamage(rom);
vik.GetDamage(sam);
vik.GetDamage(ind);

