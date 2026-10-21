using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplikacja_do_testowania
{
    public class Sortowanie
    {
        public int[] ShellSort(int[] tablica)
        {
            int n = tablica.Length;

            for (int odstep = n / 2; odstep > 0; odstep /= 2)
            {
                for (int i = odstep; i < n; i++)
                {
                    int temp = tablica[i];
                    int j = i;

                    while (j >= odstep && tablica[j - odstep] > temp)
                    {
                        tablica[j] = tablica[j - odstep];
                        j -= odstep;
                    }

                    tablica[j] = temp;
                }
            }

            return tablica;
        }

    }
}
