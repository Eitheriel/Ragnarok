using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok
{
    static class ZabitFreye
    {
        /*Hero Frey { get; set; }
        List<string> menu { get; set; }
        Veci mec { get; set; }
        public ZabitFreye(Hero FJakoFrey,List<string> menu,Veci mec)
        {
            Frey = FJakoFrey;
            this.menu = menu;
            this.mec = mec;
        }*/

        public static void SmrtFreye(Hero Frey, List<string> menu, Veci mec)
        {

            if (Frey.Alive)
            {
                Util.Message($"\nPo úvodu bitvy se postavíš jednomu z hlavních bohů - {Frey}ovi. Víš, že\n" +
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
                            Util.Message(Texts.freyFire);
                            Frey.SetDead();
                            menu.Remove("Utkáš se s Freyem");
                            break;

                        case "2":
                            Util.Message($"\nNasral jsi ho.");
                            Console.WriteLine($"\nPak jsi ho svým ohnivým mečem rozsekl " +
                                                                $"ve dví, až z něj zbyl jen černý škvarek.");
                            Util.Message(Texts.freyFire);
                            Frey.SetDead();
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
