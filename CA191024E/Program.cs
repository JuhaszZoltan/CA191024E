using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CA191024E
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            #region 2 hatvanyai 10M-ig
            //int x = 2;
            //while(x < 10000000)
            //{
            //    Console.WriteLine(x);
            //    x *= 2;
            //}
            #endregion
            #region jelszo be
            //string jelszo = "Password123";
            //string be;
            //do
            //{
            //    Console.Write("írd be a jelszót: ");
            //    be = Console.ReadLine();
            //} while (jelszo != be);
            //Console.WriteLine("grat, beléptél!");
            #endregion
            #region kitalal
            //int szam = rnd.Next(10);
            //int tipp;
            //Console.WriteLine("Gondoltam egy számra, próbáld meg kitalálni!\n");
            //do
            //{
            //    Console.Write("tipp: ");
            //    tipp = int.Parse(Console.ReadLine());
            //} while (tipp != szam);
            //Console.WriteLine($"\ngart, tényleg a {szam}-ra gondoltam!");
            #endregion
            #region kitalal 2.0
            //int szam = rnd.Next(1, 101);
            //int tipp;
            //Console.WriteLine("Gondoltam egy számra, próbáld meg kitalálni!\n");
            //do
            //{
            //    Console.Write("tipp: ");
            //    tipp = int.Parse(Console.ReadLine());

            //    if (tipp < szam) Console.WriteLine("nagyobbra gondoltam!");
            //    else if (tipp > szam) Console.WriteLine("kissebbre gondoltam!");

            //} while (tipp != szam);
            //Console.WriteLine($"\ngart, tényleg a {szam}-ra gondoltam!");
            #endregion
            #region kitalal 3.0
            //int szam = rnd.Next(1, 101);
            //int tipp;
            //int also = 1;
            //int felso = 100;
            //Console.WriteLine("Gondoltam egy számra, próbáld meg kitalálni!\n");
            //do
            //{
            //    tipp = (also + felso) / 2;
            //    Console.WriteLine($"tipp: {tipp}");
            //    if (tipp < szam)
            //    {
            //        Console.WriteLine("nagyobbra gondoltam!");
            //        also = tipp;
            //    }
            //    else if (tipp > szam)
            //    {
            //        Console.WriteLine("kissebbre gondoltam!");
            //        felso = tipp;
            //    }
            //} while (tipp != szam);
            //Console.WriteLine($"\ngart, tényleg a {szam}-ra gondoltam!");
            #endregion
            #region f5/ 1.0
            //int cs = 0;
            //do
            //{
            //    Console.WriteLine($"cs = {cs}");
            //    cs += rnd.Next(1, 4);
            //} while (cs < 50);
            #endregion
            #region f5/ 1.1
            //int cs = 0;
            //while (cs < 50)
            //{
            //    Console.Clear();
            //    cs += rnd.Next(1, 4);
            //    for (int i = 0; i < cs; i++) Console.Write(" ");
            //    Console.Write("*");
            //    Thread.Sleep(200);
            //}
            #endregion
            #region f5/ 1.2
            //int cs = 0;
            //int ku = 0;
            //while (cs < 50 && ku < 50)
            //{
            //    Console.Clear();
            //    cs += rnd.Next(1, 4);
            //    for (int i = 0; i < cs; i++) Console.Write(" ");
            //    Console.Write("*");
            //    Console.Write("\n\n");
            //    ku += rnd.Next(1, 4);
            //    for (int i = 0; i < ku; i++) Console.Write(" ");
            //    Console.Write("@");
            //    Thread.Sleep(200);
            //}
            //if (cs > ku) Console.WriteLine("\n* nyert!");
            //else if (ku > cs) Console.WriteLine("\n@ nyert!");
            //else Console.WriteLine("döntetlen!");
            #endregion
            #region f5/ 1.3 - 1.4 hf: 1.5
            //int cs = 0;
            //int ku = 0;

            //int csgy = 0;
            //int kugy = 0;

            //for (int j = 0; j < 10; j++)
            //{
            //    while (cs < 50 && ku < 50)
            //    {
            //        Console.Clear();
            //        cs += rnd.Next(1, 4);
            //        for (int i = 0; i < cs; i++) Console.Write(" ");
            //        Console.Write("*");

            //        Console.Write("\n\n");

            //        ku += rnd.Next(1, 4);
            //        for (int i = 0; i < ku; i++) Console.Write(" ");
            //        Console.Write("@");

            //        Thread.Sleep(30);
            //    }

            //    if (cs > ku)
            //    {
            //        Console.WriteLine("\n* nyert!");
            //        csgy++;
            //    }
            //    else if (ku > cs)
            //    {
            //        Console.WriteLine("\n@ nyert!");
            //        kugy++;
            //    }
            //    else Console.WriteLine("döntetlen!");
            //    Thread.Sleep(200);
            //    ku = 0;
            //    cs = 0;
            //}

            //Console.WriteLine($"*: {csgy} | @: {kugy}");
            //if (csgy > kugy) Console.WriteLine("10 futam után a * győzött!");
            //else if (kugy > csgy) Console.WriteLine("10 futam után a @ győzött!");
            //else Console.WriteLine("10 futam után döntetlen az eredmény");
            #endregion

            ///PROGRAMOZÁSI TÉTELEK II.

            #region eldöntés tétele
            ////IN: sorozat
            ////OUT: logikai érték
            ////eldöntjük egy sorozatról, hogy adott tulahjdonsággal rendelkezik-e, vagy sem

            //int[] t = { 11, 30, 42, 56, 69, 102 }; //N=6

            ////el kell döntenem, hogy van-e benne 3mal osztható elem

            //int i = 0;
            //while (i < t.Length && t[i] % 3 != 0)
            //{
            //    i++;
            //}
            //bool valasz = i < t.Length;

            //if (valasz) Console.WriteLine("VAN 3mal osztható eleme");
            //else Console.WriteLine("NINCS 3mal osztható eleme");

            //string s = "cipőfűző";

            //char[] ekezetes = { 'á', 'é', 'í', 'ú', 'ü', 'ű','ó', 'ö', 'ő' };

            //int i2 = 0;
            //while (i2 < s.Length && !ekezetes.Contains(s[i2]))
            //{
            //    i2++;
            //}

            //if (i2 < s.Length) Console.WriteLine("VAN benne ékezetes betű");
            //else Console.WriteLine("NINCS benne ékezetes ebetű");

            #endregion
            #region lineáris keresés tétele (LinKer)
            ////NEM rendezett adathalmazon alkalmazzuk
            ////IN: sorozat
            ////OUT: hiba VAGY a sorozat egy indexe

            //int[] t = { 11, 30, 42, 56, 69, 102 };
            ////keresem az 56-ot;
            //int i = 0;
            //while (i < t.Length && t[i] != 56)
            //{
            //    i++;
            //}
            //if (i < t.Length)
            //{
            //    Console.WriteLine("VAN találat a keresésre");
            //    Console.WriteLine($"Ez a {i} indexű vagyis");
            //    Console.WriteLine($"Az {i + 1}. elem");
            //}
            //else
            //{
            //    Console.WriteLine("NINCS találat a keresésre");
            //}
            ////--------------------------------

            //string s = "cipőfűző";
            ////keresem a q betűt
            //int i2 = 0;
            //while (i2 < s.Length && s[i2] != 'q')
            //{
            //    i2++;
            //}

            //if (i2 < s.Length)
            //{
            //    Console.WriteLine("VAN találat a keresésre");
            //    Console.WriteLine($"Ez a {i} indexű karakter a szóban");
            //    Console.WriteLine($"vagyis a {i + 1}. betű");
            //}
            //else Console.WriteLine("NINCS ebben a szóban ilyen betű");
            #endregion
            #region kiválasztás
            ////akkor használom, ha BIZTOSAN tudom, hogy a keresett elem
            ////BENNE VAN a sorozatban
            ////IN: sorozat
            ////OUT: index

            //int[] prim = { 2, 3, 5, 7, 11, 13, 17, 19, 23, };

            ////hányadik prímszám a 11?
            //int i = 0;
            //while (prim[i] != 11)
            //{
            //    i++;
            //}
            //Console.WriteLine($"A 11 a {i + 1}. prímszám.");
            #endregion
            #region SZÉTválogatás tétele
            ////IN: egy sorozat
            ////OUT: KETTŐ sorozat (és nem több vagy kevesebb)

            //float[] atlagok = { 1.5F, 2.0F, 3.7F, 4.72F, 1.8F, 2.1F, 4.0F, 3.2F, 1.5F, 2.9F };

            //float[] atment = new float[atlagok.Length];
            //int ai = 0;

            //float[] bukott = new float[atlagok.Length];
            //int bi = 0;

            //for (int i = 0; i < atlagok.Length; i++)
            //{
            //    if(atlagok[i] >= 2.0F)
            //    {
            //        atment[ai] = atlagok[i];
            //        ai++;
            //    }
            //    else
            //    {
            //        bukott[bi] = atlagok[i];
            //        bi++;
            //    }
            //}

            //Console.Write("átmentek: ");
            //for (int i = 0; i < ai; i++) Console.Write($"{atment[i]}|");
            //Console.Write("\nmegbuktak: ");
            //for (int i = 0; i < bi; i++) Console.Write($"{bukott[i]}|");
            #endregion
            Console.ReadKey();
        }
    }
}
