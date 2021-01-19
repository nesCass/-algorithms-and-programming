using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zbirka___C_sharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			/*
			// Zadatak 1.1

			Console.WriteLine("Unesite prvi broj:  ");
			int num1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Unesite drugi broj:  ");
			int num2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(num1 + num2);
			Console.WriteLine(num1 - num2);
			Console.WriteLine(num1 / num2);
			Console.WriteLine(num1 * num2);
			Console.WriteLine(num1 % num2);

			// Zadatak 1.3 

			Console.WriteLine("Unesite prvi broj:  ");
			int num1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Unesite drugi broj:  ");
			int num2 = Convert.ToInt32(Console.ReadLine());

			int temp = num1;
			num1 = num2;
			num2 = temp; 

			
			//Zadatak 1.4

			int num1 = 3, num2 = 5, num3 = 9;

			int temp = num1;
			num1 = num2;
			num2 = num3;
			num3 = temp;

			Console.WriteLine(num1);
			Console.WriteLine(num2);
			Console.WriteLine(num3);
			

			// Zadatak 1.5
			int num, num1, num2, num3;

			Console.WriteLine("Unesite trocifreni broj: ");
			num = Convert.ToInt32(Console.ReadLine());

			num3 = num % 10;
			num2 = (num / 10) % 10;
			num1 = (num / 100) % 10;

			Console.WriteLine(num1 + num2 + num3);
			
			// Zadatak 1.6
			int z, x, y, w, v;

			Console.WriteLine("Unesite trocifreni broj: ");
			z = Convert.ToInt32(Console.ReadLine());

			x = ++z;
			y = x++;
			w = x * y++;
			v = x * --w;
			
			// Zadatak 1.7
			public void Pointers()
			{
				unsafe
				{
					int x = 10;
					int y = 20;
					int* ptr = &x;
					ptr++;
					ptr = &y;
					ptr++;
					Console.WriteLine((int)ptr);
					Console.WriteLine(x);
					Console.WriteLine(y);
				}
			}
			
			// Zadatak 1.8


			int num, abs;

			Console.WriteLine("Unesite trocifreni broj: ");
			num = Convert.ToInt32(Console.ReadLine());

			if (num < 0)
			{
				abs = -1 * num;
			}
			else
			{
				abs = num;
			}
			Console.WriteLine(abs);
			

			// Zadatak 1.9   

			int visina, tezina;
			double temp1, temp2;
			string poruka;

			Console.WriteLine("Unesite trocifreni broj: ");
			visina = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Unesite trocifreni broj: ");
			tezina = Convert.ToInt32(Console.ReadLine());

			if (visina <168 && tezina <65)
			{
				poruka = "dzokej";
			}
			else if (visina < 184)
			{
				poruka = "Kosarkas'";
			}else if(visina>174 && visina < 189 && tezina <= 82)
			{
				poruka = "stjuart";
			}
			else
			{
				temp1 = Math.Abs(184 - visina) / 184.0;
				temp2 = Math.Abs(tezina - 65) / 65.0;

				if (temp1 < temp2)
				{
					poruka = "kosarkas";
				}
				else
				{
					poruka = "dzokej";
				}
			}

			Console.WriteLine(poruka);


			// Zadatak 1.10

			int i, z;

			for (i = 0; i < 9; i++)
			{

				if (i < 2)
				{
					z = i;
				}
				else if (i < 3)
				{
					z = 2;
				}
				else
				{
					z = i - 1;
				}

				Console.WriteLine(i);
				Console.WriteLine(z);
			}
			
			//Zadatak  1.11

			int a = 10, b = 20, c = 30, k, temp;


			Console.WriteLine("Unesite K: ");
			k = Convert.ToInt32(Console.ReadLine());


			for (int i = 0; i < k; i++)
			{
				temp = a;
				a = b;
				b = c;
				c = temp;
			}
			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine(c);
	


			//Zadatak	1.12

			int a = 10, b = 20, c = 30, k, s, temp;


			Console.WriteLine("Unesite K: ");
			k = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Unesite smer rotacije: ");
			s = Convert.ToInt32(Console.ReadLine());


			if (s == -1)
			{
				for (int i = 0; i < k; i++)
				{
					temp = a;
					a = b;
					b = c;
					c = temp;
				}
			}
			else if (s == 1)
			{
				for (int i = 0; i < k; i++)
				{
					temp = c;
					c = b;
					b = a;
					a = temp;
				}
			}
			else
			{
				Console.WriteLine("Rotiranja bez!");
			}
			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine(c);
			

			// Zadatak 1.13

			int k, sum = 0;

			Console.WriteLine("Unesite K: ");
			k = Convert.ToInt32(Console.ReadLine());

			for (int i = k; i > 0; i--)
			{
				sum += i;
			}
			Console.WriteLine(sum);


			//Zadatak   1.14 

			int d, f = 1;
			string msg;

			Console.WriteLine("Unesite broj: ");
			d = Convert.ToInt32(Console.ReadLine());

			if (d < 0)
			{
				msg = "nije def.";
			}
			else if (d == 1)
			{
				msg = "faktorijal je " + 1;

			}
			else
			{

				for (int i = d; i > 1; i--)
				{
					f *= i;
				}

				msg = "faktorijal je " + f;
			}

			Console.WriteLine(msg);

	

			// Zadatak 1.15

			int sum = 0, x;

			Console.WriteLine("Unesite broj: ");
			x = Convert.ToInt32(Console.ReadLine());


			for (int i = 2; i <= x; i = i + 2)
			{
				sum += i;
			}
			Console.WriteLine(sum);


	


			// Zadatak 1.16

			int sum = 0, max = 0, x;

			Console.WriteLine("Unesite max broj: ");
			x = Convert.ToInt32(Console.ReadLine());


			while (sum <= max)
			{
				Console.WriteLine("Unesite max broj: ");
				x = Convert.ToInt32(Console.ReadLine());

				sum += x;
				Console.WriteLine();

			}


			// Zadatak 1.17 

			int x = 1, count = 0, sum = 0;


			while (count < 101 && x > 0)
			{
				if (x % 2 == 0)
				{
					sum += x;
				}

				Console.WriteLine("Unesite broj: ");
				x = Convert.ToInt32(Console.ReadLine());
				count++;
			}
			Console.WriteLine(sum);


			//Zadatak 1.18 

			int x;
			bool check = true;

			Console.WriteLine("Unesite broj za proveru: ");
			x = Convert.ToInt32(Console.ReadLine());

			for (int i = x - 1; i > 1; i--)
			{
				if (x % i == 0)
				{
					check = false;
					break;
				}
			}

			string message = check ? "prost broj" : "nije";
			Console.WriteLine(message);
		
			// Zadatak 1.20   

			int c = 3, count = 2, i;

			Console.WriteLine("Unesite zeljini broj prostih brojeva: ");
			int num = Convert.ToInt32(Console.ReadLine());

			Console.Write("2");

			while (count <= num)
			{
				for (i = 2; i <= c - 1; i++)
				{
					if (c % i == 0)
					{
						break;
					}
				}
				if (i == c)
				{
					Console.Write(", " + c);
					count++;
				}
				c++;
			}

			Console.WriteLine();

			// Zadatak 1.21  

			int input, num, count = 0, sum = 0;

			Console.WriteLine("Unesite broj: ");
			input = Convert.ToInt32(Console.ReadLine());


			while (input > 0)
			{
				num = input % 10;
				sum += num;

				input /= 10;
				count++;
			}

			Console.WriteLine("Uneti broj ima  " + count + " cifara" + " i njhov zbir je: " + sum);



			// Zadatak 1.22 


			int input, num1, num2, num3, sum = 0;

			Console.WriteLine("Unesite zeljeni broj: ");
			input = Convert.ToInt32(Console.ReadLine());

			for (int i = 100; i <= 999; i++)
			{

				num3 = i % 10;
				num2 = (i / 10) % 10;
				num1 = i - (num2 * 10) - num3;

				sum = num1 + num2 + num3;

				if (sum % input == 0)
				{
					Console.Write(i + ", ");
				}

			}

			// Zadatak 1.23  


			int input, num, sum = 0;

			Console.WriteLine("Unesite broj: ");
			input = Convert.ToInt32(Console.ReadLine());


			while (input > 0)
			{
				num = input % 10;
				sum += num * num;

				input /= 10;
				
			}

			Console.WriteLine("Uneti broj je  " + input + " i zbir kvadrata njegovih cifata je: " + sum);


			// Zadatak 1.25  

			string msg = String.Empty;

			Console.WriteLine("Unesite jedan karakter: ");
			char input = Convert.ToChar(Console.ReadLine());

			if (input >= 'a' && input < 'z')
			{
				msg = "uneli ste malo slovo";
			}
			else if (input >= 'A' && input < 'Z')
			{
				msg = "uneli ste VELIKO slovo";
			}
			else if (input >= 'A' && input < 'Z')
			{
				msg = "uneli ste VELIKO slovo";
			}
			else if (input >= '0' && input < '9')
			{
				msg = "uneli ste broj";
			}

			else 
			{
				msg = "uneli ste specijalni karakter";
			}
			Console.WriteLine(msg);


			// Zadatak 1.26  


			int num1, num2, rez;
			string operacija = String.Empty;

			Console.WriteLine("Unesite broj: ");
			num1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Unesite broj: ");
			num2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Unesite operaciju: ");
			operacija = Console.ReadLine();



			switch (operacija)
			{
				case "-": rez = num1 - num2; break;

				case "+": rez = num1 + num2; break;

				case "*": rez = num1 * num2; break;

				case "/": rez = num1 / num2; break;

				default:
					rez = 0;
					break;
			}

			if (rez == 0)
			{
				Console.WriteLine("greska");
			}
			else
			{
				Console.WriteLine(rez);
			}



			// Zadatak 1.29 



			int num, a = 1, b = 1, c;

			Console.WriteLine("Unesite broj: ");
			num = Convert.ToInt32(Console.ReadLine());


			for (int i = 0; i < num; i++)
			{
				c = a + b;
				Console.Write(c + ", ");

				a = b;
				b = c;
			}


			// Zadatak 2.36   */




		}
	}
}
