﻿using System;

namespace Extensions02
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "Bom dia queridos estudantes!";
			Console.WriteLine(s.Cortar(10));
			Console.ReadLine();
		}
	}
}
/*
Vamos criar um extension method chamado "Cut(int)" na classe String
para receber um valor inteiro como parâmetro e gerar um recorte do
string original daquele tamanho. Por exemplo:


String s1 = "Good morning dear students!";
Console.WriteLine(s1.Cut(10));
"Good morni..."
*/