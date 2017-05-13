using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortowanieAlgorytmow
{
    class pj_Sortowanie
    {
        public static int pj_SelectionSort(int[] tab)
        {
            int pom, licznik = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                int min = i;//
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[j] < tab[min]) min = j;
                    licznik++;
                } // koniec for j
                pom = tab[i];
                tab[i] = tab[min];
                tab[min] = pom;
            }
            return licznik;
        } // koniec SelectionSort

        public static int pj_InsertionSort(int[] tab)
        {
            int v, j, licznik = 0;
            for (int i = 1; i < tab.Length; i++)
            {
                j = i; v = tab[i];
                while (tab[j - 1] > v)
                {
                    tab[j] = tab[j - 1]; j = j - 1;
                    licznik++;
                    if (j == 0) break;
                } // koniec while
                tab[j] = v;
            } // koniec for i
            return licznik;
        } // koniec InsertionSort

        public static int pj_QuickSort(int[] tab, int d, int g)
        {
            int elementOsiowy = tab[(d + g) / 2];
            int i = d;
            int j = g;
            int pom, licznik = 0;
            do
            {
                while (tab[i] < elementOsiowy) { i++; licznik++; }
                while (tab[j] > elementOsiowy) { j--; licznik++; }
                if (i <= j)
                {
                    pom = tab[i];
                    tab[i] = tab[j];
                    tab[j] = pom;
                    j--; i++;
                }

            } while (i <= j);
            if (d < j) licznik += pj_QuickSort(tab, d, j);
            if (g > i) licznik += pj_QuickSort(tab, i, g);
            return licznik;
        }
        public static int pj_MegreSort(int[] tab, int rozmiar)
        {
            int pj_licznik = 0;
            int[] pj_wynik = new int[rozmiar];
            for (int x = 1; x < rozmiar; x += x)
            {
                int i = 0;
                for (int j = 0; j < rozmiar; j += x + x)
                {
                    int l = j;
                    int lend = Math.Min(l + x, rozmiar);
                    int r = lend;
                    int rend = Math.Min(r + x, rozmiar);
                    while (l < lend && r < rend)
                    {
                        pj_wynik[i++] = (tab[l].CompareTo(tab[r]) < 1 ? tab[l++] : tab[r++]);
                        pj_licznik++;
                    }
                    while (l < lend)
                    {
                        pj_wynik[i++] = tab[l++];
                        pj_licznik++;
                    }
                    while (r < rend)
                    {
                        pj_wynik[i++] = tab[r++];
                        pj_licznik++;
                    }
                }
                var tmp = tab;
                tab = pj_wynik;
                pj_wynik = tmp;
            }
            return pj_licznik;
        }
        public static void pj_swap<T>(T[] items, int i, int k)
        {
            T t = items[i];
            items[i] = items[k];
            items[k] = t;
        }
        public static int pj_HeapSort(int[] tab, int rozmiar)
        {
            int pj_licznik = 0;
            int pj_heapSize = rozmiar;
            for (int h = (pj_heapSize - 1) / 2; h >= 0; h--)
                pj_Heap(tab, pj_heapSize, h, ref pj_licznik);

            for (int i = rozmiar - 1; i > 0; i--)
            {
                pj_swap(tab, i, 0);

                pj_heapSize--;
                pj_Heap(tab, pj_heapSize, 0, ref pj_licznik);
            }
            return pj_licznik;
        }
        private static void pj_Heap(int[] items, int heapSize, int index, ref int pj_licznik)
        {
            int pj_left = (index + 1) * 2 - 1;
            int pj_right = (index + 1) * 2;
            int pj_largest = 0;

            if (pj_left < heapSize && items[pj_left].CompareTo(items[index]) == 1)
                pj_largest = pj_left;
            else
                pj_largest = index;
            if (pj_right < heapSize && items[pj_right].CompareTo(items[pj_largest]) == 1)
                pj_largest = pj_right;

            if (pj_largest != index)
            {
                pj_swap(items, index, pj_largest);

                pj_Heap(items, heapSize, pj_largest, ref pj_licznik);
            }
            pj_licznik++;
        }
        public static int pj_BubbleSort(int[] tab, int rozmiar)
        {
            int pj_licznik = 0;
            for (int i = 0; i < rozmiar - 1; i++)
                for (int j = 0; j < rozmiar - i - 1; j++)
                    if (tab[j].CompareTo(tab[j + 1]) == 1)
                    {
                        pj_swap(tab, j, j + 1);
                        pj_licznik++;
                    }
            return pj_licznik;
        }
        public static int pj_ShellSort(int[] tab, int rozmiar)
        {
            int pj_licznik = 0;
            int pj_step = rozmiar / 2;
            while (pj_step > 0)
            {
                for (int i = 0; i < (rozmiar - pj_step); i++)
                {
                    int j = i;
                    while (j >= 0 && tab[j].CompareTo(tab[j + pj_step]) == 1)
                    {
                        pj_swap(tab, j, j + pj_step);
                        j--;
                        pj_licznik++;
                    }
                }
                pj_step = pj_step / 2;
            }
            return pj_licznik;
        }
        public static int pj_CombSort(int[] tab, int rozmiar)
        {
            int pj_licznik = 0;
            int pj_r = rozmiar;
            bool pj_f = true;
            while (pj_r > 1 || pj_f)
            {
                pj_r = pj_r * 10 / 13;
                if (pj_r == 0)
                    pj_r = 1;
                pj_f = false;
                for (int i = 0; i + pj_r < rozmiar; i++)
                    if (tab[i + pj_r].CompareTo(tab[i]) == -1)
                    {
                        pj_swap(tab, i + pj_r, i);
                        pj_f = true;
                        pj_licznik++;
                    }
            }
            return pj_licznik;
        }
    }
}
