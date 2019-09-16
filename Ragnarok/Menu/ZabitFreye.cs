using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Menu
{
    class ZabitFreye
    {
        Hero Frey { get; set; }
        List<string> menu { get; set; }
        Veci mec { get; set; }
        public ZabitFreye(Hero FJakoFrey,List<string> menu,Veci mec)
        {
            Frey = FJakoFrey;
            this.menu = menu;
            this.mec = mec;

        }

        public void SmrtFreye()
        {

            if (Frey.alive)
            {
                Program.Message($"\nPo úvodu bitvy se postavíš jednomu z hlavních bohů - {Frey}ovi. Víš, že\n" +
                    $"u sebe nemá zbraň - kouzelný meč, kterého se vzdal kvůli své lásce.");
                Console.WriteLine(Texts.frey1);
                while (true)
                {
                    string tezkeRozhodnuti = Console.ReadLine();
                    switch (tezkeRozhodnuti)
                    {
                        case "1":
                            Console.WriteLine($"\nZaútočil jsi na {Frey}e a s obří silou jsi ho svým ohnivým mečem {mec}m \nrozsekl " +
                                $"ve dví, až z něj zbyl jen černý škvarek.");
                            Program.Message(Texts.freyFire);
                            Frey.setDead();
                            menu.Remove("Utkáš se s Freyem");
                            break;

                        case "2":
                            Program.Message($"\nNasral jsi ho.");
                            Console.WriteLine($"\nPak jsi ho svým ohnivým mečem rozsekl " +
                                                                $"ve dví, až z něj zbyl jen černý škvarek.");
                            Program.Message(Texts.freyFire);
                            Frey.setDead();
                            menu.Remove("Utkáš se s Freyem");
                            break;
                        default:
                            continue;
                    }
                    break;
                }
            }
        }
    }
}
