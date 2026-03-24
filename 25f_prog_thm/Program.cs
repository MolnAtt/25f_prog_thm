using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _25f_prog_thm
{
	internal class Program
	{

		static int Összeg(List<int> lista)
		{
			int sum = 0;

			for (int i = 0; i < lista.Count; i++)
			{
				//sum = sum + lista[i];
				sum += lista[i];
			}
			return sum;
		}
		static int Összeg_paratlan(List<int> lista)
		{
			int sum = 0;

			for (int i = 0; i < lista.Count; i++) // végigmegyünk a listán
			{
				//sum = sum + lista[i];
				if (lista[i]%2 == 1) // a páratlanok esetében
				{
					sum += lista[i]; // növeljük a sumot az értékkel
				}
			}

			return sum;
		}

		static int Hány_páros_szám(List<int> lista)
		{
			int db = 0;

			for (int i = 0; i < lista.Count; i++)
			{
				if (lista[i]%2==0)
				{
					// db = db + 1;
					// db += 1;
					db++;
				}
			}
			return db;
		}

		static int Maximumkereses(List<int> lista)
		{
			if (lista.Count==0)
			{
				throw new Exception("Üres a lista, szóval nem lesz maximum sem!");
			}

			int best = lista[0];

			for (int i = 1; i < lista.Count; i++)
			{
				if (best < lista[i])
				{
					best = lista[i];
				}
			}
			return best;
		}

		static bool Benne_van_e_7(int[] t)
		{
			for (int i = 0; i < t.Length; i++)
			{
				if (t[i] == 7)
				{
					return true;
				}
			}
			return false;
		}

		static bool Benne_van_e_7_2(int[] t)
		{
			int i = 0;
			while (i < t.Length && !(t[i] == 7) )
			{
				i++;
			}

			return i < t.Length;
		}

		/// <summary>
		/// Megkeresi az első 7-es helyét, ami ha nincs meg, akkor a tömb hosszát adja vissza!
		/// </summary>
		/// <param name="t"></param>
		/// <returns></returns>
		static int Helye_7(int[] t)
		{
			int i = 0;
			while (i<t.Length && !(t[i]==7 ))
			{
				i++;
			}

			return i;
		}

		static bool bennevane_7(int[] t)
		{
			return Helye_7(t) < t.Length;
		}

		/// <summary>
		/// Megkeresi az első 7-es helyét, ami ha nincs meg, akkor -1-et ad vissza
		/// </summary>
		/// <param name="t"></param>
		/// <returns></returns>
		static int indexe_7(int[] t)
		{
			int h = Helye_7(t);
			if (h == t.Length)
			{
				return -1;
			}
			return h;

		}

		/// <summary>
		/// Megkeresi az első 7-es helyét, ami ha nincs meg, akkor -1-et ad vissza
		/// </summary>
		/// <param name="t"></param>
		/// <returns></returns>
		static int indexe_7_2(int[] t)
		{
			int h = Helye_7(t);
			return h == t.Length ? -1 : h; // inline-if
		}


		static Random r = new Random();

		static int[] Plusz10(int[] t)
		{
			int[] result  = new int[t.Length];

			for (int i = 0; i < t.Length; i++)
			{
				result[i] = t[i] + 10;
			}

			return result;
		}

		static List<int> Páros_számai(int[] t)  // fontos, hogy listát adunk vissza, mert nem tudjuk a kiválogatott elemek számosságát az elején!
		{
			List<int> result = new List<int>();

			for (int i = 0; i < t.Length; i++)
			{
				if (t[i]%2==0)
				{
					result.Add(t[i]);
				}
			}

			return result;
		}

		static void Kiir(List<int> lista)
		{
			for (int i = 0; i < lista.Count; i++)
			{
				Console.Write(lista[i]);
				Console.Write(" ");
			}
			Console.WriteLine();
		}

		static void Main(string[] args)
		{

			int vel = r.Next(2, 5);

			List<int> lista = new List<int> { 3, 17, 5, 4, 2, 5, 1, 8, 4, 5, 6, 4, 5, 6, 9 };
			Console.WriteLine($"a számok összege: {Összeg(lista)}");
			Console.WriteLine(lista.Sum());
			Console.WriteLine($"a páratlanok összege: {Összeg_paratlan(lista)}");
			Console.WriteLine($"a párosok ennyien vannak: {Hány_páros_szám(lista)}");
			Console.WriteLine($"a legnagyobb szám: {Maximumkereses(lista)}");
			//Console.WriteLine($"a legnagyobb szám HELYE: {Maximumkereses_hely(lista)}");


			Console.WriteLine(Benne_van_e_7_2(lista.ToArray()));


			Kiir(lista);
			Kiir(Plusz10(lista.ToArray()).ToList());
			Kiir(Páros_számai(lista.ToArray()));
		}

	}
}
