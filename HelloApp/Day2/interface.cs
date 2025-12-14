// interface- specifies the responsibility of a class.
// 		100% abstract


//  and abstract class

using System;

interface punitwork
{
    bool checkprime(int num);
    void printprimelist(int s, int e);
}

class punit : punitwork
{
    public bool checkprime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    public void printprimelist(int s, int e)
    {
        for (int i = s; i <= e; i++)
        {
            if (checkprime(i))
                Console.WriteLine(i);
        }
    }
}

class Trst
{
    static void Main()
    {
        punit obj = new punit();

        if (obj.checkprime(5))
            Console.WriteLine("Prime");
        else
            Console.WriteLine("Not Prime");

       // obj.printprimelist(1, 20);
    }
}
