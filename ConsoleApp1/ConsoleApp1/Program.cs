static float avrage(int[] tab)
{
    int sum = 0;
    for(int i=0; i < tab.Length; i++)
    {
        sum += tab[i];
    }
    float res = sum / tab.Length;
    return res;
} 