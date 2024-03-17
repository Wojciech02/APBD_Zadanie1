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

static int max(int[] tab)
{
    int max = tab[0];
    for(int i =1;i<tab.Length;i++)
    {
        if(max < tab[i])
        {
            max = tab[i];
        }
    }
    return max;
}