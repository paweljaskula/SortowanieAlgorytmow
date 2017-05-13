using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting;


namespace SortowanieAlgorytmow
{
    public partial class Form1 : Form
    {
        private Pen pj_Pen = new Pen(Color.Black, 1.0f);
        int pj_maxRozTab = 30, a, b=0, i=0;
        int[] pj_pomTab, pj_posortowana;
        int[,] pj_wyniki;
        public Form1()
        {
            InitializeComponent();
            pj_TabAfter.Visible = false;
            pj_Pen.Width = 4;
            pj_TabKosztA.Visible = false;
            pj_Wykres.Visible = false;
            pj_lbl1.Visible = false;
            pj_lbl2.Visible = false;
            pj_lbl3.Visible = false;
            pj_lbl4.Visible = false;
            pj_lbl5.Visible = false;
            pj_lbl6.Visible = false;
            pj_lbl7.Visible = false;
            pj_lbl8.Visible = false;
            pj_lbl9.Visible = false;
            pj_lbl10.Visible = false;
            pj_pomTab = new int[10];
            Random pj_los = new Random();
            for (int i = 0; i < 10; i++)
            {
                pj_pomTab[i] = pj_los.Next(1, 101);
            }
            pj_posortowana = pj_pomTab;
            pj_Sortowanie.pj_SelectionSort(pj_posortowana);
        }
        bool pj_PobirzDane(out int pj_rozmiar, out int pj_a, out int pj_b, out int pj_max)
        {
            pj_rozmiar = 0; pj_a = 0; pj_b = 0; pj_max = 0;
            if (string.IsNullOrEmpty(pj_txtMin.Text))
            {
                pj_error.SetError(pj_txtMin, "ERROR: Musisz podać wartość");
                return false;
            }
            else pj_error.Dispose();
            if (string.IsNullOrEmpty(pj_txtMax.Text))
            {
                pj_error.SetError(pj_txtMax, "ERROR: Musisz podać wartość");
                return false;
            }
            else pj_error.Dispose();
            if (string.IsNullOrEmpty(pj_txtDolnaG.Text))
            {
                pj_error.SetError(pj_txtDolnaG, "ERROR: Musisz podać wartość");
                return false;
            }
            else pj_error.Dispose();
            if (string.IsNullOrEmpty(pj_txtGornaG.Text))
            {
                pj_error.SetError(pj_txtGornaG, "ERROR: Musisz podać wartość");
                return false;
            }
            else pj_error.Dispose();
            if (!int.TryParse(pj_txtMin.Text, out pj_rozmiar))
            {
                pj_error.SetError(pj_txtMin, "ERROR: Wystąpił błąd w zapisie zmiennej - niedozwolony znak");
                return false;
            }
            else pj_error.Dispose();
            if (!int.TryParse(pj_txtDolnaG.Text, out pj_a))
            {
                pj_error.SetError(pj_txtDolnaG, "ERROR: Wystąpił błąd w zapisie zmiennej - niedozwolony znak");
                return false;
            }
            else pj_error.Dispose();
            if (!int.TryParse(pj_txtGornaG.Text, out pj_b))
            {
                pj_error.SetError(pj_txtGornaG, "ERROR: Wystąpił błąd w zapisie zmiennej - niedozwolony znak");
                return false;
            }
            else pj_error.Dispose();
            if (!int.TryParse(pj_txtMax.Text, out pj_max))
            {
                pj_error.SetError(pj_txtMax, "ERROR: Wystąpił błąd w zapisie zmiennej - niedozwolony znak");
                return false;
            }
            else pj_error.Dispose();
            if (pj_a > pj_b)
            {
                pj_error.SetError(pj_txtGornaG, "ERROR: Górna granica jest mniejsza niż dolna");
                return false;
            }
            else pj_error.Dispose();
            return true;
        }
        private void pj_btnKolorLinii_Click(object sender, EventArgs e)
        {
            if (pj_cdKolorLini.ShowDialog() == DialogResult.OK)
            {
                pj_lblKolorLini.BackColor = pj_cdKolorLini.Color;

            }
            pj_Pen.Color = pj_lblKolorLini.BackColor;
            pj_panel.Refresh();
        }

        private void pj_btnKolorTla_Click(object sender, EventArgs e)
        {
            if (pj_cdKolorLini.ShowDialog() == DialogResult.OK)
            {
                pj_lblKolorTla.BackColor = pj_cdKolorLini.Color;
            }
        }

        private void pj_tbGruboscLinii_Scroll(object sender, EventArgs e)
        {
            pj_panel.Refresh();
            pj_Pen.Width = pj_tbGruboscLinii.Value;
            pj_numericGrubosc.Value = pj_tbGruboscLinii.Value;
            
        }

        private void pj_numericGrubosc_ValueChanged(object sender, EventArgs e)
        {
            pj_panel.Refresh();
            pj_Pen.Width = pj_tbGruboscLinii.Value;
            pj_tbGruboscLinii.Value = (int)pj_numericGrubosc.Value;
            
        }

        private void pj_btnWizPrzed_Click(object sender, EventArgs e)
        {
            pj_dGWTabelaprzed.Visible = true;
            pj_Wykres.Visible = false;
            pj_TabAfter.Visible = false;
            pj_TabKosztA.Visible = false;
            pj_TabBefore.HeaderText = "Tablica przed sortowaniem";
            pj_TabAfter.HeaderText = "Tablica po sortowaniu";
            int pj_a=0;
            int pj_b=0, pj_rozmiar, pj_max;
            if (!pj_PobirzDane(out pj_rozmiar, out pj_a, out pj_b, out pj_max))
            {
                return;
            }
            int[] pj_wynik = new int[pj_rozmiar];
            Random pj_los = new Random();
            for (int i = 0; i < pj_rozmiar; i++)
            {
                pj_wynik[i] = pj_los.Next(pj_a, pj_b);
            }
            if (pj_dGWTabelaprzed.RowCount > 1)
            {
                pj_dGWTabelaprzed.Rows.Clear();
                pj_dGWTabelaprzed.Refresh();
            }
            for (int i = 0; i < pj_wynik.GetLength(0); i++)
            {
                pj_dGWTabelaprzed.Rows.Add(pj_wynik[i].ToString());
            }
            
            
        }

        private void pj_btnWizPo_Click(object sender, EventArgs e)
        {
            pj_dGWTabelaprzed.Visible = true;
            pj_Wykres.Visible = false;
            pj_TabAfter.Visible = true;
            pj_TabKosztA.Visible = false;
            pj_TabBefore.HeaderText = "Tablica przed sortowaniem";
            pj_TabAfter.HeaderText = "Tablica po sortowaniu";
            int[] pj_tabela = new int[pj_dGWTabelaprzed.Rows.Count-1];
            if (pj_dGWTabelaprzed.RowCount > 1)
            {
                for (int i = 0; i < pj_tabela.Length ; i++)
                {
                    pj_tabela[i] = int.Parse(pj_dGWTabelaprzed[0,i].Value.ToString());
                }
            }
            else
                MessageBox.Show("Nie utworzono tabeli");
            for (int i = 1; i < pj_tabela.Length + 1; i++)
            {
                switch (pj_cbAlgorytm.Text)
                {
                    case "Selection":
                        {
                            pj_Sortowanie.pj_SelectionSort(pj_tabela);
                        }
                        break;
                    case "Insertion":
                        {
                            pj_Sortowanie.pj_InsertionSort(pj_tabela);
                        }
                        break;
                    case "Quick":
                        {
                            pj_Sortowanie.pj_QuickSort(pj_tabela, 0, pj_tabela.Length - 1);
                        }
                        break;
                    case "Merge":
                        {
                            pj_Sortowanie.pj_MegreSort(pj_tabela, pj_tabela.Length);
                        }
                        break;
                    case "Heap":
                        {
                            pj_Sortowanie.pj_HeapSort(pj_tabela, pj_tabela.Length);
                        }
                        break;
                    case "Bubble":
                        {
                            pj_Sortowanie.pj_BubbleSort(pj_tabela, pj_tabela.Length );
                        }
                        break;
                    case "Shell":
                        {
                            pj_Sortowanie.pj_ShellSort(pj_tabela, pj_tabela.Length );
                        }
                        break;
                    case "Comb":
                        {
                            pj_Sortowanie.pj_CombSort(pj_tabela, pj_tabela.Length );
                        }
                        break;
                    default:
                        {
                            pj_Sortowanie.pj_SelectionSort(pj_tabela);
                        }
                        break;
                }
            }
            for (int i = 0; i < pj_tabela.Length; i++)
            {
                pj_dGWTabelaprzed.Rows[i].Cells[1].Value = pj_tabela[i];
            }
        }

        private void pj_panel_Paint(object sender, PaintEventArgs e)
        {
            pj_Pen.Width = (float)pj_numericGrubosc.Value;
            pj_Pen.Color = pj_lblKolorLini.BackColor;
            e.Graphics.DrawLine(pj_Pen, 0, pj_panel.Height / 2, pj_panel.Width, pj_panel.Height / 2);
        }

        private void pj_cbStylLinii_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (pj_cbStylLinii.SelectedIndex)
            {
                case 0:
                    pj_Pen.DashStyle = DashStyle.Solid;
                    break;
                case 1:
                    pj_Pen.DashStyle = DashStyle.Dash;
                    break;
                case 2:
                    pj_Pen.DashStyle = DashStyle.Dot;
                    break;
                case 3:
                    pj_Pen.DashStyle = DashStyle.DashDot;
                    break;
                case 4:
                    pj_Pen.DashStyle = DashStyle.DashDotDot;
                    break;
                default:
                    break;
            }
            pj_panel.Refresh();
        }

        private void pj_btnTabela_Click(object sender, EventArgs e)
        {
            pj_dGWTabelaprzed.Visible = true;
            pj_Wykres.Visible = false;
            pj_dGWTabelaprzed.Rows.Clear();
            pj_TabKosztA.Visible = true;
            pj_TabAfter.Visible = true;
            pj_TabBefore.HeaderText = "Rozmiar sortowanej tablicy";
            pj_TabAfter.HeaderText = "Wynik pomiaru kosztu czasowego";
            int pj_a = 0;
            int pj_b = 0, pj_rozmiar, pj_max;
            if (!pj_PobirzDane(out pj_rozmiar, out pj_a, out pj_b, out pj_max))
            {
                return;
            }
            pj_wyniki = new int[3, pj_maxRozTab+1];
            int[] pj_tab;
            Random rnd = new Random();
            for (int i = 1; i < pj_maxRozTab+1; i++)
            {
                pj_tab = new int[i];
                for (int j = 0; j < pj_tab.Length; j++)
                {
                    pj_tab[j] = rnd.Next(pj_a, pj_b);
                }
                pj_wyniki[0, i - 1] = i;
                switch (pj_cbAlgorytm.Text)
                {
                    case "Selection":
                        {
                            pj_wyniki[1, i - 1] = pj_Sortowanie.pj_SelectionSort(pj_tab);
                            pj_wyniki[2, i - 1] = i * (i - 1) / 2;
                        }
                        break;
                    case "Insertion":
                        {
                            pj_wyniki[1, i - 1] = pj_Sortowanie.pj_InsertionSort(pj_tab);
                            pj_wyniki[2, i - 1] = (i + 2) * (i - 1) / 2;
                        }
                        break;
                    case "Quick":
                        {
                            pj_wyniki[1, i - 1] = pj_Sortowanie.pj_QuickSort(pj_tab, 0, pj_tab.Length - 1);
                            pj_wyniki[2, i - 1] = (int)Math.Log(i) * 1;
                        }
                        break;
                    case "Merge":
                        {
                            pj_wyniki[1, i - 1] = pj_Sortowanie.pj_MegreSort(pj_tab, pj_tab.Length - 1);
                            pj_wyniki[2, i - 1] = i * (int)Math.Log(i);
                        }
                        break;
                    case "Heap":
                        {
                            pj_wyniki[1, i - 1] = pj_Sortowanie.pj_HeapSort(pj_tab, pj_tab.Length - 1);
                            pj_wyniki[2, i - 1] = i * (int)Math.Log(i);
                        }
                        break;
                    case "Bubble":
                        {
                            pj_wyniki[1, i - 1] = pj_Sortowanie.pj_BubbleSort(pj_tab, pj_tab.Length - 1);
                            pj_wyniki[2, i - 1] = i*i;
                        }
                        break;
                    case "Shell":
                        {
                            pj_wyniki[1, i - 1] = pj_Sortowanie.pj_ShellSort(pj_tab, pj_tab.Length - 1);
                            pj_wyniki[2, i - 1] = (int)Math.Pow(i, 1.15);
                        }
                        break;
                    case "Comb":
                        {
                            pj_wyniki[1, i - 1] = pj_Sortowanie.pj_CombSort(pj_tab, pj_tab.Length - 1);
                            pj_wyniki[2, i - 1] = i * (int)Math.Log(i); // wydajnosc w najlepszym wypadku
                        }
                        break;
                    default:
                        {
                            pj_wyniki[1, i - 1] = pj_Sortowanie.pj_SelectionSort(pj_tab);
                            pj_wyniki[2, i - 1] = i * (i - 1) / 2;
                        }
                        break;
                }
            }
            if (pj_dGWTabelaprzed.RowCount > 1)
            {
                pj_dGWTabelaprzed.Rows.Clear();
                pj_dGWTabelaprzed.Refresh();
            }
            string[] pj_cells = new string[3];
            for (int i = 0; i < pj_wyniki.GetLength(1); i++)
            {
                pj_cells[0] = pj_wyniki[0, i].ToString();
                pj_cells[1] = pj_wyniki[1, i].ToString();
                pj_cells[2] = pj_wyniki[2, i].ToString();
                if (i == pj_wyniki.GetLength(1)-1)
                {
                    break;
                }
                pj_dGWTabelaprzed.Rows.Add(pj_cells);
            }
        }

        private void pj_btnWykres_Click(object sender, EventArgs e)
        {
            pj_dGWTabelaprzed.Visible = false;
            pj_Wykres.Visible = true;
            int pj_a = 0;
            int pj_b = 0, pj_rozmiar, pj_max;
            if (!pj_PobirzDane(out pj_rozmiar, out pj_a, out pj_b, out pj_max))
            {
                return;
            }
            pj_wyniki = new int[3, pj_maxRozTab + 1];
            int[] pj_tab;
            Random rnd = new Random();
            for (int i = 1; i < pj_maxRozTab + 1; i++)
            {
                pj_tab = new int[i];
                for (int j = 0; j < pj_tab.Length; j++)
                {
                    pj_tab[j] = rnd.Next(pj_a, pj_b);
                }
                pj_wyniki[0, i - 1] = i;
                switch (pj_cbAlgorytm.Text)
                {
                    case "Selection":
                        {
                            pj_wyniki[1, i - 1] = pj_Sortowanie.pj_SelectionSort(pj_tab);
                            pj_wyniki[2, i - 1] = i * (i - 1) / 2;
                        }
                        break;
                    case "Insertion":
                        {
                            pj_wyniki[1, i - 1] = pj_Sortowanie.pj_InsertionSort(pj_tab);
                            pj_wyniki[2, i - 1] = (i + 2) * (i - 1) / 2;
                        }
                        break;
                    case "Quick":
                        {
                            pj_wyniki[1, i - 1] = pj_Sortowanie.pj_QuickSort(pj_tab, 0, pj_tab.Length - 1);
                            pj_wyniki[2, i - 1] = (int)Math.Log(i) * 1;
                        }
                        break;
                    case "Merge":
                        {
                            pj_wyniki[1, i - 1] = pj_Sortowanie.pj_MegreSort(pj_tab, pj_tab.Length - 1);
                            pj_wyniki[2, i - 1] = i * (int)Math.Log(i);
                        }
                        break;
                    case "Heap":
                        {
                            pj_wyniki[1, i - 1] = pj_Sortowanie.pj_HeapSort(pj_tab, pj_tab.Length - 1);
                            pj_wyniki[2, i - 1] = i * (int)Math.Log(i);
                        }
                        break;
                    case "Bubble":
                        {
                            pj_wyniki[1, i - 1] = pj_Sortowanie.pj_BubbleSort(pj_tab, pj_tab.Length - 1);
                            pj_wyniki[2, i - 1] = i * i;
                        }
                        break;
                    case "Shell":
                        {
                            pj_wyniki[1, i - 1] = pj_Sortowanie.pj_ShellSort(pj_tab, pj_tab.Length - 1);
                            pj_wyniki[2, i - 1] = (int)Math.Pow(i, 1.15);
                        }
                        break;
                    case "Comb":
                        {
                            pj_wyniki[1, i - 1] = pj_Sortowanie.pj_CombSort(pj_tab, pj_tab.Length - 1);
                            pj_wyniki[2, i - 1] = i * (int)Math.Log(i); // wydajnosc w najlepszym wypadku
                        }
                        break;
                    default:
                        {
                            pj_wyniki[1, i - 1] = pj_Sortowanie.pj_SelectionSort(pj_tab);
                            pj_wyniki[2, i - 1] = i * (i - 1) / 2;
                        }
                        break;
                }
            }
            if (pj_Wykres.Series.Count > 0)
                pj_Wykres.Series.Clear();
            pj_Wykres.Series.Add("liczba operacji z pomiaru");
            switch (pj_cbStylLinii.SelectedIndex)
            {
                case 0:
                    pj_Wykres.Series[0].BorderDashStyle = ChartDashStyle.Solid;
                    break;
                case 1:
                    pj_Wykres.Series[0].BorderDashStyle = ChartDashStyle.Dash;
                    break;
                case 2:
                    pj_Wykres.Series[0].BorderDashStyle = ChartDashStyle.Dot;
                    break;
                case 3:
                    pj_Wykres.Series[0].BorderDashStyle = ChartDashStyle.DashDot;
                    break;
                case 4:
                    pj_Wykres.Series[0].BorderDashStyle = ChartDashStyle.DashDotDot;
                    break;
                default:
                    pj_Wykres.Series[0].BorderDashStyle = ChartDashStyle.Solid;
                    break;
            }
            pj_Wykres.Series[0].Color = pj_lblKolorLini.BackColor;
            pj_Wykres.Series[0].BorderWidth = pj_tbGruboscLinii.Value;

            pj_Wykres.Series.Add("liczba operacji z obliczen");
            switch (pj_cbStylLinii.SelectedIndex)
            {
                case 0:
                    pj_Wykres.Series[1].BorderDashStyle = ChartDashStyle.Solid;
                    break;
                case 1:
                    pj_Wykres.Series[1].BorderDashStyle = ChartDashStyle.Dash;
                    break;
                case 2:
                    pj_Wykres.Series[1].BorderDashStyle = ChartDashStyle.Dot;
                    break;
                case 3:
                    pj_Wykres.Series[1].BorderDashStyle = ChartDashStyle.DashDot;
                    break;
                case 4:
                    pj_Wykres.Series[1].BorderDashStyle = ChartDashStyle.DashDotDot;
                    break;
                default:
                    pj_Wykres.Series[1].BorderDashStyle = ChartDashStyle.Solid;
                    break;
            }
            pj_Wykres.Series[1].Color = pj_kolLini2.BackColor;
            pj_Wykres.Series[1].BorderWidth = pj_tbGruboscLinii.Value;
            pj_Wykres.BackColor = pj_lblKolorTla.BackColor;
            pj_Wykres.Series[0].ChartType = SeriesChartType.Line;
            pj_Wykres.Series[1].ChartType = SeriesChartType.Line;
            for (int i = 0; i < pj_wyniki.GetLength(1)-1; i++)
            {
                pj_Wykres.Series[1].Points.AddXY(i, pj_wyniki[2, i]);
                pj_Wykres.Series[0].Points.AddXY(i, pj_wyniki[1, i]);

            }
        }

        private void pj_btnResetuj_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pj_cdKolorLini.ShowDialog() == DialogResult.OK)
            {
                pj_kolLini2.BackColor = pj_cdKolorLini.Color;

            }
            pj_Pen.Color = pj_kolLini2.BackColor;
            pj_panel.Refresh();
        }

        private void pj_btnDemo_Click(object sender, EventArgs e)
        {
            
        }

        private void pj_zegar_Tick(object sender, EventArgs e)
        {
           

        }
    }
}
