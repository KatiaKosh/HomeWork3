﻿// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

Console.WriteLine("Введите координаты двух точек");
  Console.Write("Введите x1 :");
    int x1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите y1 :");
    int y1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите z1 :");
    int z1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите x2 :");
    int x2 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите y2 :");
    int y2 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите z2 :");
    int z2 = Convert.ToInt32(Console.ReadLine());

    //d = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

     double L = Math.Sqrt(Math.Pow(x2 - x1 , 2) + Math.Pow(y2 - y1 , 2) + Math.Pow(z2 - z1 , 2));
     Console.WriteLine(" Растояние между точками равна: " + L);

