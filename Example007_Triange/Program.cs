﻿Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");
int xa = 40, ya = 1,
    xb = 1, yb = 25,
    xc = 80, yc = 25;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("^");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("^");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("^");

int x = xa, y = ya;
int count = 0;
while(count < 10000)
{
    int randNum = new Random().Next(0,3);
    if (randNum == 0) 
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
    }
    if (randNum == 1) 
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
    }
     if (randNum == 2) 
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("^");
    count++;
}
Console.SetCursorPosition(1, 26);