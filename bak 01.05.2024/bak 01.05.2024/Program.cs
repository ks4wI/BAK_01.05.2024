class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj rozmiar listy: ");
        int rozmiar = Convert.ToInt32(Console.ReadLine());

        List<int> liczby = new List<int>(rozmiar);

        Random random = new Random();
        for (int i = 0; i < rozmiar; i++)
        {
            liczby.Add(random.Next(1, 100));
        }

        int dominant = znajdzDominante(liczby);

        Console.WriteLine("Dominanta w liście: "+dominant);
    }

    static int znajdzDominante(List<int> liczby)
    {
        if (liczby == null || liczby.Count == 0)
        {
            throw new ArgumentException("Lista nie może być pusta.");
        }

        int maxCount = 0;
        int dominanta = liczby[0];

        foreach (int liczba in liczby)
        {
            int count = 0;
            for (int i = 0; i < liczby.Count; i++)
            {
                if (liczby[i] == liczba)
                {
                    count++;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
                dominanta = liczba;
            }
        }

        return dominanta;
    }
}
