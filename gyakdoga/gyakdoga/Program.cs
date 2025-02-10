int napokszama = 5;
int[] homer = [1, 2, 3];
int fagyos = 0;
int nap = 0;
for (int i = nap; i < napokszama; i++)
{
    if(homer[i] < 0)
    {
        fagyos = fagyos + 1;
    }
    nap = nap + 1;
}

Console.WriteLine(fagyos);