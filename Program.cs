//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

  
/*void Palindrome(int num)

{
    if (num > 9999 && num < 100000){
    
        if (num / 10000 == num % 10 && (num / 1000) % 10 == (num / 10) % 10)
            Console.WriteLine("Число полиндромное"); 
            
        else
            Console.WriteLine("Число НЕ полиндромное"); 
        }    
    else  
        {
        Console.WriteLine("Число НЕ пятизначное, попробуйте снова ввести пятизначное число");
        }    
}

Console.WriteLine("Введите пятизначное число: ");
int user_num = Convert.ToInt32(Console.ReadLine());

Palindrome(user_num);
*/

//Задача 21.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


/*Double Longline(int x1, int y1, int z1, int x2, int y2, int z2, int x3, int y3, int z3)
{
        int x = x3 - x2 - x1;
        int y = y3 - y2 - y1;
        int z = z3 - z2 - z1;
        double lengthAB  = Math.Sqrt (x*x + y*y + z*z);
    return lengthAB;
}

Console.WriteLine ("Input x cordinat of A:");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input y cordinat of A:");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input z cordinat of A:");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input y cordinat of B:");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input y cordinat of B:");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input z cordinat of B:");
int zB = Convert.ToInt32(Console.ReadLine());

double dist = Longline(xA, yA, zA, xB, yB, zB );
Console.WriteLine($"Distance AB is {dist}");

*/

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void Cube(int num)
{
    int current = 1;
    //int length = cube.Length;

    while (current <= num)
        {
            int rescube = current * current * current; 
            Console.Write ($"{rescube}" );
            current++;
        }  
    }         
    Console.WriteLine ("Input {number} ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number>=1)
    {
    Console.WriteLine("{number} ->" );
    Cube (number);  
}
else Console.Write("Inposible number!");
*/