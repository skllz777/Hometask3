﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
Console.Write("Ведите координату X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите координату Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите координату Z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите координату X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите координату Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите координату Z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) +  Math.Pow(z1 - z2, 2)));