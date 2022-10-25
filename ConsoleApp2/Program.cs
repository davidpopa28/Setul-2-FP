// See https://aka.ms/new-console-template for more information
//int main{

//}
void p1()
{
    int n=int.Parse(Console.ReadLine());
    int count = 0;
    string[] t = Console.ReadLine().Split(' ');
    for(int i=0;i<n;i++)
    {
        int m = int.Parse(t[i]);
        if (m % 2 == 0) 
        {
            count++;    
        }
    }
    Console.WriteLine(count);
}

void p2()
{
    int n = int.Parse(Console.ReadLine());
    int nrpoz = 0, nrneg = 0, nr0 = 0;
    string[] t = Console.ReadLine().Split(' ');
    for (int i = 0; i < n; i++)
    {
        int m = int.Parse(t[i]);
        if (m > 0)
        {
            nrpoz++;
        }
        else if(m==0)
        {
            nr0++;
        }
        else if(m<0)
        {
            nrneg++;
        }
    }
    Console.WriteLine(nrpoz + "sunt pozitive.");
    Console.WriteLine(nr0 + "sunt egale cu 0.");
    Console.WriteLine(nrneg + "sunt negative.");
}

void p3()
{
    int n = int.Parse(Console.ReadLine());
    int s = 0, p = 1;
    for(int i=0;i<n;i++)
    {
        s = s + i;
        p = p * i;
    }
    Console.WriteLine("Suma numerelor de la 1 la " + n + " este " + s);
    Console.WriteLine("Produsul numerelor de la 1 la " + n + " este " + p);
}

void p4()
{
    int n = int.Parse(Console.ReadLine());
    int a = int.Parse(Console.ReadLine());
    string[] t = Console.ReadLine().Split(' ');
    for (int i=0;i<n;i++)
    {
        int m = int.Parse(t[i]);
        if (m == a)
        {
            Console.WriteLine(i);
            break;
        }
    }
}

void p5()
{
    int n = int.Parse(Console.ReadLine());
    int count = 0;
    string[] t = Console.ReadLine().Split(' ');
    for (int i=0;i<n;i++)
    {
        int m = int.Parse(t[i]);
        if (m == i) 
        {
            count++;
        }
    }
    Console.WriteLine(count);
}

void p6()
{
    int n = int.Parse(Console.ReadLine());
    int x = int.Parse(Console.ReadLine());
    bool ok = true;
    string[] t = Console.ReadLine().Split(' ');
    for (int i = 1; i < n; i++)
    {
        int y = int.Parse(t[i]);
        if(y>x)
        {
            ok = false;
            break;
        }
        y = x;
    }
    if (ok == true)
    {
        Console.WriteLine(1);
    }
    else
    {
        Console.WriteLine(0);
    }
}

void p7()
{
    int n = int.Parse(Console.ReadLine());
    int max = int.MinValue; int min = int.MaxValue;
    string[] t = Console.ReadLine().Split(' ');
    for (int i=0;i<n;i++)
    {
        int m = int.Parse(t[i]);
        if (m > max) 
        {
            max = m;
        }
        if (m < min) 
        {
            min = m;
        }
    }
    Console.WriteLine("Minimul din secventa este " + min + " si maximul este " + max+".");
}

static void p8()
{
    int n = int.Parse(Console.ReadLine());
    int x = 0;
    int y = 1;
    int z;
    if (n == 1)
    {
        Console.WriteLine(x);
    }
    else if(n==2)
    {
        Console.WriteLine(y);
    }
    else
    {
        for (int i = 3; i <= n; i++)
        {
            z = y + x;
            x = y;
            y = z;
        }
        Console.WriteLine(y);
    }
}

void p9()
{
    int n = int.Parse(Console.ReadLine());
    string[] t = Console.ReadLine().Split(' ');
    int x = int.Parse(t[0]);
    int y = int.Parse(t[1]);
    bool cresc, descresc;
    if(x>y)
    {
        descresc = true;
        for (int i=2;i<n;i++)
        {
            x = int.Parse(t[i]);
            if(x<y)
            {
                descresc = false;
                break;
            }
            y = x;
        }
        if(descresc==true)
        {
            Console.WriteLine("Secventa monoton descrescatoare");
        }
        else
        {
            Console.WriteLine("Secventa nu este monotana");
        }
    }
    else
    {
        cresc = true;
        for (int i = 2; i < n; i++)
        {
            x = int.Parse(t[i]);
            if (x > y)
            {
                cresc = false;
                break;
            }
            y = x;
        }
        if (cresc == true)
        {
            Console.WriteLine("Secventa monoton crescatoare");
        }
        else
        {
            Console.WriteLine("Secventa nu este monotana");
        }
    }
}

void p10()
{
    int n = int.Parse(Console.ReadLine());
    int count = 1, countmax = 0;
    string[] t = Console.ReadLine().Split(' ');
    int x = int.Parse(t[0]);
    for(int i=1;i<n;i++)
    {// 1 2 2 2 2 3 4
        int y=int.Parse(t[i]);
        if (x == y)
        {
            count++;
        }
        else
        {
            if (count > countmax)
            {
                countmax = count;
            }
            count = 1;
        }
        x = y;
    }
    if(count>countmax)
    {
        countmax = count;
    }
    Console.WriteLine(countmax);
}

int inversaP11(int n)
{
    int s = 0, p = 1;
    while(n>0)
    {
        int c = n % 10;
        s = s * p + c;
        p *= 10;
        n = n / 10;
    }
    return s;
}

void p11()
{
    int n = int.Parse(Console.ReadLine());
    string[] t = Console.ReadLine().Split(' ');
    int s = 0;
    for(int i=0;i<n;i++)
    {
        int x=int.Parse(t[i]);
        x = inversaP11(x);
        s = s + x;
    }
    Console.WriteLine(s);
}

void p12()
{
    int n = int.Parse(Console.ReadLine());
    string[] t = Console.ReadLine().Split(' ');
    int x = int.Parse(t[0]);
    int count = 1, countmax = 0;
    for(int i=1;i<n;i++)
    {
        int y = int.Parse(t[i]);
        if (x + 1 == y && x != 0) 
        {
            count++;
        }
        else
        {
            if(count>countmax)
            {
                countmax = count;
            }
            count = 1;
        }
        x = y;
    }
    Console.WriteLine(countmax);
}

void p13()
{
    // 1 2 7 4 6 9 9
    // 2 7 4 6 9 9 1
    int n = int.Parse(Console.ReadLine());
    string[] t = Console.ReadLine().Split(' ');
    int x = int.Parse(t[0]);
    int ok = 0;
    for(int i=1;i<n;i++)
    {
        int y=int.Parse(t[i]);
        if(x>y)
        {
            ok++;
        }
        x = y;
    }
    if (ok > 1 && ok != n - 1)
    {
        Console.WriteLine(0);
    }
    else
    {
        Console.WriteLine(1);
    }
}

void p14()
{
    int n = int.Parse(Console.ReadLine());
    string[] t = Console.ReadLine().Split(' ');
    int x = int.Parse(t[0]);
    int ok = 0;
    for (int i = 1; i < n; i++)
    {
        int y = int.Parse(t[i]);
        if (x > y || x == y)
        {
            ok++;
        }
        x = y;
    }
    if (ok > 1 && ok != n - 1)
    {
        Console.WriteLine(0);
    }
    else
    {
        Console.WriteLine(1);
    }
}

void p15()
{
    // 1 2 3 4 3 2
    int n = int.Parse(Console.ReadLine());
    string[] t = Console.ReadLine().Split(' ');
    int x = int.Parse(t[0]);
    int ok = 0;
    for (int i = 1; i < n; i++)
    {
        int y = int.Parse(t[i]);
        if (x < y)
        {
            ok = 0;
        }
        else
        {
            ok = 1;
        }
        x = y;
    }
    if (ok == 1)
    {
        Console.WriteLine(1);
    }
    else
    {
        Console.WriteLine(0);
    }
}

void p16()
{
    // 1 2 3 4 3 2
    int n = int.Parse(Console.ReadLine());
    string[] t = Console.ReadLine().Split(' ');
    int x = int.Parse(t[0]);
    int ok = 0;
    int count1 = 0, count2 = 0;
    for (int i = 1; i < n; i++)
    {
        int y = int.Parse(t[i]);
        if (x < y)
        {
            ok = 0;
            count1++;
            count2 = 1;
        }
        else
        {
            ok = 1;
            count2++;
        }
        x = y;
    }
    if (ok == 1 && count1 + count2 == n - 1)
    {
        Console.WriteLine(1);
    }
    else
    {
        Console.WriteLine(0);
    }
}

void p17()
{
    int n = int.Parse(Console.ReadLine());
    string[] t = Console.ReadLine().Split(' ');
    int count0 = 0, count1 = 0;
    bool dude = true;
    for(int i=0;i<n;i++)
    {
        int x= int.Parse(t[i]);
        if(i==0 && x==1)
        {
            dude = false;
            break;
        }
        else if(x==0)
        {
            count0++;
        }
        else if(x==1)
        {
            count1++;
        }
        if(count1>count0)
        {
            dude = false;
            break;
        }
    }
    if(count1>count0 || count0>count1)
    {
        dude = false;
    }
    if(dude==false)
    {
        Console.WriteLine(0);
    }
    else
    {
        Console.WriteLine(1);
    }
}
Console.ReadKey();
