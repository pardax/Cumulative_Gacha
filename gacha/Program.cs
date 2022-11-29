﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

public class Characters
{
    public string name;
    public int percentage;
    public string flavorText;
    public int rank;

    public Characters(string name, int percentage, string text, int rank)
    {
        this.name = name;
        this.percentage = percentage;
        this.flavorText = text;
        this.rank = rank;
    }
}

class gacha_gacha_cute
{
    Characters blueCap = new Characters("BlueCap", 1, "\"The hero appears\"", 1);
    Characters hiruki = new Characters("Hiruki", 9, "\"Hello world\"", 2);
    Characters reimu = new Characters("Reimu", 30, "\"Destory All Youkais!\"", 3);
    Characters marisa = new Characters("Marisa", 30, "\"Master Spark!!\"", 3);
    Characters alice = new Characters("Alice", 30, "\"YouKoSo\"", 3);

    public void Gacha()
    {
        Characters[] capsules =
            {
                blueCap,    //1
                hiruki,     //9
                reimu,      //30
                marisa,     //30
                alice       //30
                };

        Random rand = new Random(DateTime.Now.Millisecond);
        int cumulative = 0;
        int gift = 0;

        for (int i = 0; i < capsules.Length; i++)
        {
            int gacha = rand.Next(0, 101);
            cumulative += capsules[i].percentage;

            if (gacha <= cumulative)
            {
                gift = i;
                break;
            }
        }

        if(capsules[gift].rank == 1)
            Console.Write(capsules[gift].flavorText + "  ★");

        Console.WriteLine(capsules[gift].name);

    }
}
namespace gacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            gacha_gacha_cute machine = new gacha_gacha_cute();
            machine.Gacha();
            machine.Gacha();
            machine.Gacha();


        }
    }
}
