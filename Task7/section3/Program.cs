﻿List<int> list = new List<int>() { 1, 0, 5, -4, 5, 10, -80, 24, 0, -4, 100, 24, 45, 6, -1 };
list.Sort();
foreach (var item in list)
{
    System.Console.Write(item + "  ");
}