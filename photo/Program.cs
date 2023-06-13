
Console.Clear();
int[,] mas;
int n, m;
n = 10;
m = 10;
mas = new int[n, m];
 
int c = 0;
c = 0;
            
for (int a = 0; a < n; a++)
 
for (int i = a, j = 0; i >= 0 & j <= a; j++, i--)
    {
 
        mas[j, i] = c;
        c++;
 
    }
 
for (int b = 1; b < n; b++)
 
for (int i = n-1, j = b; i >= b & j < n; i--, j++)
    {
 
        mas[j, i] = c;
        c++;
 
    }
            
 
 
for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
 
            Console.Write(mas[i, j] + "\t");
 
        }
    Console.WriteLine();
    }
    