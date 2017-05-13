namespace SortowanieAlgorytmow
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pj_btnKolorLinii = new System.Windows.Forms.Button();
            this.pj_btnKolorTla = new System.Windows.Forms.Button();
            this.pj_lblKolorTla = new System.Windows.Forms.Label();
            this.pj_lblWzierniktla = new System.Windows.Forms.Label();
            this.pj_lblWziernikLinii = new System.Windows.Forms.Label();
            this.pj_lblStylLinii = new System.Windows.Forms.Label();
            this.pj_cbStylLinii = new System.Windows.Forms.ComboBox();
            this.pj_lblGruboscLinii = new System.Windows.Forms.Label();
            this.pj_tbGruboscLinii = new System.Windows.Forms.TrackBar();
            this.pj_numericGrubosc = new System.Windows.Forms.NumericUpDown();
            this.pj_lblGruboscLiczbowo = new System.Windows.Forms.Label();
            this.pj_lblinfo1 = new System.Windows.Forms.Label();
            this.pj_txtMin = new System.Windows.Forms.TextBox();
            this.pj_lblinfo2 = new System.Windows.Forms.Label();
            this.pj_txtMax = new System.Windows.Forms.TextBox();
            this.pj_lblinfo5 = new System.Windows.Forms.Label();
            this.pj_txtDolnaG = new System.Windows.Forms.TextBox();
            this.pj_txtGornaG = new System.Windows.Forms.TextBox();
            this.pj_lblinfo4 = new System.Windows.Forms.Label();
            this.pj_lblinfo3 = new System.Windows.Forms.Label();
            this.pj_cbAlgorytm = new System.Windows.Forms.ComboBox();
            this.pj_btnWizPrzed = new System.Windows.Forms.Button();
            this.pj_btnWizPo = new System.Windows.Forms.Button();
            this.pj_btnTabela = new System.Windows.Forms.Button();
            this.pj_btnDemo = new System.Windows.Forms.Button();
            this.pj_btnResetuj = new System.Windows.Forms.Button();
            this.pj_btnWykres = new System.Windows.Forms.Button();
            this.pj_lblWzorzec = new System.Windows.Forms.Label();
            this.pj_cdKolorLini = new System.Windows.Forms.ColorDialog();
            this.pj_panel = new System.Windows.Forms.Panel();
            this.pj_naglowek = new System.Windows.Forms.Label();
            this.pj_dGWTabelaprzed = new System.Windows.Forms.DataGridView();
            this.pj_TabBefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pj_TabAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pj_TabKosztA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pj_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.pj_lblKolorLini = new System.Windows.Forms.Label();
            this.pj_Wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.pj_kolLini2 = new System.Windows.Forms.Label();
            this.pj_infoo = new System.Windows.Forms.Label();
            this.pj_zegar = new System.Windows.Forms.Timer(this.components);
            this.pj_lbl1 = new System.Windows.Forms.Label();
            this.pj_lbl2 = new System.Windows.Forms.Label();
            this.pj_lbl3 = new System.Windows.Forms.Label();
            this.pj_lbl4 = new System.Windows.Forms.Label();
            this.pj_lbl5 = new System.Windows.Forms.Label();
            this.pj_lbl6 = new System.Windows.Forms.Label();
            this.pj_lbl7 = new System.Windows.Forms.Label();
            this.pj_lbl8 = new System.Windows.Forms.Label();
            this.pj_lbl9 = new System.Windows.Forms.Label();
            this.pj_lbl10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pj_tbGruboscLinii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pj_numericGrubosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pj_dGWTabelaprzed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pj_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pj_Wykres)).BeginInit();
            this.SuspendLayout();
            // 
            // pj_btnKolorLinii
            // 
            this.pj_btnKolorLinii.AutoSize = true;
            this.pj_btnKolorLinii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pj_btnKolorLinii.Location = new System.Drawing.Point(12, 64);
            this.pj_btnKolorLinii.Name = "pj_btnKolorLinii";
            this.pj_btnKolorLinii.Size = new System.Drawing.Size(108, 44);
            this.pj_btnKolorLinii.TabIndex = 0;
            this.pj_btnKolorLinii.Text = "Wybierz kolor \r\nlinii";
            this.pj_btnKolorLinii.UseVisualStyleBackColor = true;
            this.pj_btnKolorLinii.Click += new System.EventHandler(this.pj_btnKolorLinii_Click);
            // 
            // pj_btnKolorTla
            // 
            this.pj_btnKolorTla.AutoSize = true;
            this.pj_btnKolorTla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pj_btnKolorTla.Location = new System.Drawing.Point(342, 99);
            this.pj_btnKolorTla.Name = "pj_btnKolorTla";
            this.pj_btnKolorTla.Size = new System.Drawing.Size(166, 60);
            this.pj_btnKolorTla.TabIndex = 3;
            this.pj_btnKolorTla.Text = "Wybierz kolor tła dla \r\nobszaru wykresu";
            this.pj_btnKolorTla.UseVisualStyleBackColor = true;
            this.pj_btnKolorTla.Click += new System.EventHandler(this.pj_btnKolorTla_Click);
            // 
            // pj_lblKolorTla
            // 
            this.pj_lblKolorTla.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pj_lblKolorTla.Location = new System.Drawing.Point(530, 131);
            this.pj_lblKolorTla.Name = "pj_lblKolorTla";
            this.pj_lblKolorTla.Size = new System.Drawing.Size(129, 20);
            this.pj_lblKolorTla.TabIndex = 5;
            // 
            // pj_lblWzierniktla
            // 
            this.pj_lblWzierniktla.AutoSize = true;
            this.pj_lblWzierniktla.Location = new System.Drawing.Point(531, 91);
            this.pj_lblWzierniktla.Name = "pj_lblWzierniktla";
            this.pj_lblWzierniktla.Size = new System.Drawing.Size(128, 34);
            this.pj_lblWzierniktla.TabIndex = 4;
            this.pj_lblWzierniktla.Text = "Wziernik koloru tła \r\ndla wykresu";
            this.pj_lblWzierniktla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pj_lblWziernikLinii
            // 
            this.pj_lblWziernikLinii.AutoSize = true;
            this.pj_lblWziernikLinii.Location = new System.Drawing.Point(126, 64);
            this.pj_lblWziernikLinii.Name = "pj_lblWziernikLinii";
            this.pj_lblWziernikLinii.Size = new System.Drawing.Size(129, 17);
            this.pj_lblWziernikLinii.TabIndex = 6;
            this.pj_lblWziernikLinii.Text = "Wziernik koloru linii";
            // 
            // pj_lblStylLinii
            // 
            this.pj_lblStylLinii.AutoSize = true;
            this.pj_lblStylLinii.Location = new System.Drawing.Point(828, 108);
            this.pj_lblStylLinii.Name = "pj_lblStylLinii";
            this.pj_lblStylLinii.Size = new System.Drawing.Size(150, 17);
            this.pj_lblStylLinii.TabIndex = 7;
            this.pj_lblStylLinii.Text = "Ustaw styl linii wykresu";
            this.pj_lblStylLinii.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pj_cbStylLinii
            // 
            this.pj_cbStylLinii.FormattingEnabled = true;
            this.pj_cbStylLinii.Items.AddRange(new object[] {
            "Solid ",
            "Dash",
            "Dot",
            "Dash_Dot",
            "Dash_Dot_Dot"});
            this.pj_cbStylLinii.Location = new System.Drawing.Point(831, 128);
            this.pj_cbStylLinii.Name = "pj_cbStylLinii";
            this.pj_cbStylLinii.Size = new System.Drawing.Size(147, 24);
            this.pj_cbStylLinii.TabIndex = 8;
            this.pj_cbStylLinii.Text = "Ciągła (solid)";
            this.pj_cbStylLinii.SelectedIndexChanged += new System.EventHandler(this.pj_cbStylLinii_SelectedIndexChanged);
            // 
            // pj_lblGruboscLinii
            // 
            this.pj_lblGruboscLinii.AutoSize = true;
            this.pj_lblGruboscLinii.Location = new System.Drawing.Point(1106, 99);
            this.pj_lblGruboscLinii.Name = "pj_lblGruboscLinii";
            this.pj_lblGruboscLinii.Size = new System.Drawing.Size(130, 34);
            this.pj_lblGruboscLinii.TabIndex = 9;
            this.pj_lblGruboscLinii.Text = "Zmień grubość linii \r\nwykresu";
            this.pj_lblGruboscLinii.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pj_tbGruboscLinii
            // 
            this.pj_tbGruboscLinii.Location = new System.Drawing.Point(1109, 139);
            this.pj_tbGruboscLinii.Minimum = 1;
            this.pj_tbGruboscLinii.Name = "pj_tbGruboscLinii";
            this.pj_tbGruboscLinii.Size = new System.Drawing.Size(127, 45);
            this.pj_tbGruboscLinii.TabIndex = 10;
            this.pj_tbGruboscLinii.Value = 4;
            this.pj_tbGruboscLinii.Scroll += new System.EventHandler(this.pj_tbGruboscLinii_Scroll);
            // 
            // pj_numericGrubosc
            // 
            this.pj_numericGrubosc.Location = new System.Drawing.Point(1116, 258);
            this.pj_numericGrubosc.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pj_numericGrubosc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pj_numericGrubosc.Name = "pj_numericGrubosc";
            this.pj_numericGrubosc.Size = new System.Drawing.Size(120, 23);
            this.pj_numericGrubosc.TabIndex = 11;
            this.pj_numericGrubosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pj_numericGrubosc.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.pj_numericGrubosc.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.pj_numericGrubosc.ValueChanged += new System.EventHandler(this.pj_numericGrubosc_ValueChanged);
            // 
            // pj_lblGruboscLiczbowo
            // 
            this.pj_lblGruboscLiczbowo.AutoSize = true;
            this.pj_lblGruboscLiczbowo.Location = new System.Drawing.Point(1106, 221);
            this.pj_lblGruboscLiczbowo.Name = "pj_lblGruboscLiczbowo";
            this.pj_lblGruboscLiczbowo.Size = new System.Drawing.Size(147, 34);
            this.pj_lblGruboscLiczbowo.TabIndex = 12;
            this.pj_lblGruboscLiczbowo.Text = "Ustalona grubość linii \r\n(liczbowo)";
            this.pj_lblGruboscLiczbowo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pj_lblinfo1
            // 
            this.pj_lblinfo1.AutoSize = true;
            this.pj_lblinfo1.Location = new System.Drawing.Point(12, 187);
            this.pj_lblinfo1.Name = "pj_lblinfo1";
            this.pj_lblinfo1.Size = new System.Drawing.Size(224, 68);
            this.pj_lblinfo1.TabIndex = 13;
            this.pj_lblinfo1.Text = "Minimalna próba badawcza\r\n(liczba powtórzeń sortowania\r\ntablicy o tych samych roz" +
    "miarach, \r\nale o różnej zawartości)";
            // 
            // pj_txtMin
            // 
            this.pj_txtMin.Location = new System.Drawing.Point(15, 258);
            this.pj_txtMin.Name = "pj_txtMin";
            this.pj_txtMin.Size = new System.Drawing.Size(150, 23);
            this.pj_txtMin.TabIndex = 14;
            this.pj_txtMin.Text = "10";
            // 
            // pj_lblinfo2
            // 
            this.pj_lblinfo2.AutoSize = true;
            this.pj_lblinfo2.Location = new System.Drawing.Point(12, 313);
            this.pj_lblinfo2.Name = "pj_lblinfo2";
            this.pj_lblinfo2.Size = new System.Drawing.Size(136, 34);
            this.pj_lblinfo2.TabIndex = 15;
            this.pj_lblinfo2.Text = "Maksymalny rozmiar\r\n sortowanych tablic";
            // 
            // pj_txtMax
            // 
            this.pj_txtMax.Location = new System.Drawing.Point(15, 350);
            this.pj_txtMax.Name = "pj_txtMax";
            this.pj_txtMax.Size = new System.Drawing.Size(150, 23);
            this.pj_txtMax.TabIndex = 16;
            this.pj_txtMax.Text = "30";
            // 
            // pj_lblinfo5
            // 
            this.pj_lblinfo5.AutoSize = true;
            this.pj_lblinfo5.Location = new System.Drawing.Point(12, 403);
            this.pj_lblinfo5.Name = "pj_lblinfo5";
            this.pj_lblinfo5.Size = new System.Drawing.Size(165, 51);
            this.pj_lblinfo5.TabIndex = 17;
            this.pj_lblinfo5.Text = "Dolna granica przedziału\r\nwartości elementów \r\nsortowanych tablicy";
            this.pj_lblinfo5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pj_txtDolnaG
            // 
            this.pj_txtDolnaG.Location = new System.Drawing.Point(15, 457);
            this.pj_txtDolnaG.Name = "pj_txtDolnaG";
            this.pj_txtDolnaG.Size = new System.Drawing.Size(150, 23);
            this.pj_txtDolnaG.TabIndex = 18;
            this.pj_txtDolnaG.Text = "1";
            // 
            // pj_txtGornaG
            // 
            this.pj_txtGornaG.Location = new System.Drawing.Point(15, 562);
            this.pj_txtGornaG.Name = "pj_txtGornaG";
            this.pj_txtGornaG.Size = new System.Drawing.Size(150, 23);
            this.pj_txtGornaG.TabIndex = 20;
            this.pj_txtGornaG.Text = "101";
            // 
            // pj_lblinfo4
            // 
            this.pj_lblinfo4.AutoSize = true;
            this.pj_lblinfo4.Location = new System.Drawing.Point(12, 508);
            this.pj_lblinfo4.Name = "pj_lblinfo4";
            this.pj_lblinfo4.Size = new System.Drawing.Size(172, 51);
            this.pj_lblinfo4.TabIndex = 19;
            this.pj_lblinfo4.Text = "Górna granica przedziału \r\nwartości elementów \r\nsortowanych tablicy";
            this.pj_lblinfo4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pj_lblinfo3
            // 
            this.pj_lblinfo3.AutoSize = true;
            this.pj_lblinfo3.Location = new System.Drawing.Point(12, 614);
            this.pj_lblinfo3.Name = "pj_lblinfo3";
            this.pj_lblinfo3.Size = new System.Drawing.Size(185, 17);
            this.pj_lblinfo3.TabIndex = 21;
            this.pj_lblinfo3.Text = "Wybierz algorytm do analizy";
            this.pj_lblinfo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pj_cbAlgorytm
            // 
            this.pj_cbAlgorytm.FormattingEnabled = true;
            this.pj_cbAlgorytm.Items.AddRange(new object[] {
            "Insertion",
            "Selection",
            "Merge",
            "Heap",
            "Quick",
            "Bubble",
            "Shell",
            "Comb"});
            this.pj_cbAlgorytm.Location = new System.Drawing.Point(15, 645);
            this.pj_cbAlgorytm.Name = "pj_cbAlgorytm";
            this.pj_cbAlgorytm.Size = new System.Drawing.Size(150, 24);
            this.pj_cbAlgorytm.TabIndex = 22;
            this.pj_cbAlgorytm.Text = "Insertion";
            // 
            // pj_btnWizPrzed
            // 
            this.pj_btnWizPrzed.AutoSize = true;
            this.pj_btnWizPrzed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pj_btnWizPrzed.Location = new System.Drawing.Point(375, 758);
            this.pj_btnWizPrzed.Name = "pj_btnWizPrzed";
            this.pj_btnWizPrzed.Size = new System.Drawing.Size(184, 60);
            this.pj_btnWizPrzed.TabIndex = 23;
            this.pj_btnWizPrzed.Text = "Wizualizacja tablicy przed \r\nsortowaniem";
            this.pj_btnWizPrzed.UseVisualStyleBackColor = true;
            this.pj_btnWizPrzed.Click += new System.EventHandler(this.pj_btnWizPrzed_Click);
            // 
            // pj_btnWizPo
            // 
            this.pj_btnWizPo.AutoSize = true;
            this.pj_btnWizPo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pj_btnWizPo.Location = new System.Drawing.Point(567, 758);
            this.pj_btnWizPo.Name = "pj_btnWizPo";
            this.pj_btnWizPo.Size = new System.Drawing.Size(193, 60);
            this.pj_btnWizPo.TabIndex = 24;
            this.pj_btnWizPo.Text = "Wizualizacja tablicy po\r\n sortowaniu";
            this.pj_btnWizPo.UseVisualStyleBackColor = true;
            this.pj_btnWizPo.Click += new System.EventHandler(this.pj_btnWizPo_Click);
            // 
            // pj_btnTabela
            // 
            this.pj_btnTabela.AutoSize = true;
            this.pj_btnTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pj_btnTabela.Location = new System.Drawing.Point(1087, 434);
            this.pj_btnTabela.Name = "pj_btnTabela";
            this.pj_btnTabela.Size = new System.Drawing.Size(166, 60);
            this.pj_btnTabela.TabIndex = 25;
            this.pj_btnTabela.Text = "Wyniki w formie \r\ntabelarycznej";
            this.pj_btnTabela.UseVisualStyleBackColor = true;
            this.pj_btnTabela.Click += new System.EventHandler(this.pj_btnTabela_Click);
            // 
            // pj_btnDemo
            // 
            this.pj_btnDemo.AutoSize = true;
            this.pj_btnDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pj_btnDemo.Location = new System.Drawing.Point(1087, 739);
            this.pj_btnDemo.Name = "pj_btnDemo";
            this.pj_btnDemo.Size = new System.Drawing.Size(171, 60);
            this.pj_btnDemo.TabIndex = 26;
            this.pj_btnDemo.Text = "Demo\r\n(działanie algorytmu)";
            this.pj_btnDemo.UseVisualStyleBackColor = true;
            this.pj_btnDemo.Click += new System.EventHandler(this.pj_btnDemo_Click);
            // 
            // pj_btnResetuj
            // 
            this.pj_btnResetuj.AutoSize = true;
            this.pj_btnResetuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pj_btnResetuj.Location = new System.Drawing.Point(1087, 645);
            this.pj_btnResetuj.Name = "pj_btnResetuj";
            this.pj_btnResetuj.Size = new System.Drawing.Size(166, 60);
            this.pj_btnResetuj.TabIndex = 27;
            this.pj_btnResetuj.Text = "Resetuj\r\n(stan początkowy)";
            this.pj_btnResetuj.UseVisualStyleBackColor = true;
            this.pj_btnResetuj.Click += new System.EventHandler(this.pj_btnResetuj_Click);
            // 
            // pj_btnWykres
            // 
            this.pj_btnWykres.AutoSize = true;
            this.pj_btnWykres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pj_btnWykres.Location = new System.Drawing.Point(1087, 539);
            this.pj_btnWykres.Name = "pj_btnWykres";
            this.pj_btnWykres.Size = new System.Drawing.Size(166, 60);
            this.pj_btnWykres.TabIndex = 28;
            this.pj_btnWykres.Text = "Wyniki w formie\r\nwykresu";
            this.pj_btnWykres.UseVisualStyleBackColor = true;
            this.pj_btnWykres.Click += new System.EventHandler(this.pj_btnWykres_Click);
            // 
            // pj_lblWzorzec
            // 
            this.pj_lblWzorzec.AutoSize = true;
            this.pj_lblWzorzec.Location = new System.Drawing.Point(1102, 325);
            this.pj_lblWzorzec.Name = "pj_lblWzorzec";
            this.pj_lblWzorzec.Size = new System.Drawing.Size(134, 17);
            this.pj_lblWzorzec.TabIndex = 29;
            this.pj_lblWzorzec.Text = "Wziernik wzorca linii";
            this.pj_lblWzorzec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pj_panel
            // 
            this.pj_panel.Location = new System.Drawing.Point(1087, 345);
            this.pj_panel.Name = "pj_panel";
            this.pj_panel.Size = new System.Drawing.Size(166, 53);
            this.pj_panel.TabIndex = 30;
            this.pj_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.pj_panel_Paint);
            // 
            // pj_naglowek
            // 
            this.pj_naglowek.AutoSize = true;
            this.pj_naglowek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pj_naglowek.Location = new System.Drawing.Point(436, 40);
            this.pj_naglowek.Name = "pj_naglowek";
            this.pj_naglowek.Size = new System.Drawing.Size(456, 31);
            this.pj_naglowek.TabIndex = 31;
            this.pj_naglowek.Text = "Analizator algorytmów Sortowania";
            // 
            // pj_dGWTabelaprzed
            // 
            this.pj_dGWTabelaprzed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pj_dGWTabelaprzed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.pj_dGWTabelaprzed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pj_dGWTabelaprzed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pj_TabBefore,
            this.pj_TabAfter,
            this.pj_TabKosztA});
            this.pj_dGWTabelaprzed.Location = new System.Drawing.Point(259, 165);
            this.pj_dGWTabelaprzed.Name = "pj_dGWTabelaprzed";
            this.pj_dGWTabelaprzed.Size = new System.Drawing.Size(822, 587);
            this.pj_dGWTabelaprzed.TabIndex = 32;
            // 
            // pj_TabBefore
            // 
            this.pj_TabBefore.FillWeight = 80F;
            this.pj_TabBefore.HeaderText = "Tabela przed sortowaniem";
            this.pj_TabBefore.Name = "pj_TabBefore";
            // 
            // pj_TabAfter
            // 
            this.pj_TabAfter.HeaderText = "Tablica po sortowaniu";
            this.pj_TabAfter.Name = "pj_TabAfter";
            // 
            // pj_TabKosztA
            // 
            this.pj_TabKosztA.HeaderText = "Analityczny koszt czasowy";
            this.pj_TabKosztA.Name = "pj_TabKosztA";
            // 
            // pj_error
            // 
            this.pj_error.ContainerControl = this;
            // 
            // pj_lblKolorLini
            // 
            this.pj_lblKolorLini.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pj_lblKolorLini.Location = new System.Drawing.Point(149, 86);
            this.pj_lblKolorLini.Name = "pj_lblKolorLini";
            this.pj_lblKolorLini.Size = new System.Drawing.Size(78, 20);
            this.pj_lblKolorLini.TabIndex = 33;
            // 
            // pj_Wykres
            // 
            chartArea7.Name = "ChartArea1";
            this.pj_Wykres.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.pj_Wykres.Legends.Add(legend7);
            this.pj_Wykres.Location = new System.Drawing.Point(259, 187);
            this.pj_Wykres.Name = "pj_Wykres";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.pj_Wykres.Series.Add(series7);
            this.pj_Wykres.Size = new System.Drawing.Size(822, 565);
            this.pj_Wykres.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 44);
            this.button1.TabIndex = 36;
            this.button1.Text = "Wybierz kolor \r\nlinii drugiej";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pj_kolLini2
            // 
            this.pj_kolLini2.BackColor = System.Drawing.Color.Red;
            this.pj_kolLini2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pj_kolLini2.Location = new System.Drawing.Point(146, 148);
            this.pj_kolLini2.Name = "pj_kolLini2";
            this.pj_kolLini2.Size = new System.Drawing.Size(81, 20);
            this.pj_kolLini2.TabIndex = 38;
            // 
            // pj_infoo
            // 
            this.pj_infoo.AutoSize = true;
            this.pj_infoo.Location = new System.Drawing.Point(126, 131);
            this.pj_infoo.Name = "pj_infoo";
            this.pj_infoo.Size = new System.Drawing.Size(129, 17);
            this.pj_infoo.TabIndex = 37;
            this.pj_infoo.Text = "Wziernik koloru linii";
            // 
            // pj_zegar
            // 
            this.pj_zegar.Interval = 2000;
            this.pj_zegar.Tick += new System.EventHandler(this.pj_zegar_Tick);
            // 
            // pj_lbl1
            // 
            this.pj_lbl1.Location = new System.Drawing.Point(283, 267);
            this.pj_lbl1.Name = "pj_lbl1";
            this.pj_lbl1.Size = new System.Drawing.Size(46, 17);
            this.pj_lbl1.TabIndex = 39;
            // 
            // pj_lbl2
            // 
            this.pj_lbl2.Location = new System.Drawing.Point(350, 267);
            this.pj_lbl2.Name = "pj_lbl2";
            this.pj_lbl2.Size = new System.Drawing.Size(46, 17);
            this.pj_lbl2.TabIndex = 40;
            // 
            // pj_lbl3
            // 
            this.pj_lbl3.Location = new System.Drawing.Point(412, 267);
            this.pj_lbl3.Name = "pj_lbl3";
            this.pj_lbl3.Size = new System.Drawing.Size(46, 17);
            this.pj_lbl3.TabIndex = 41;
            // 
            // pj_lbl4
            // 
            this.pj_lbl4.Location = new System.Drawing.Point(478, 267);
            this.pj_lbl4.Name = "pj_lbl4";
            this.pj_lbl4.Size = new System.Drawing.Size(46, 17);
            this.pj_lbl4.TabIndex = 42;
            // 
            // pj_lbl5
            // 
            this.pj_lbl5.Location = new System.Drawing.Point(540, 267);
            this.pj_lbl5.Name = "pj_lbl5";
            this.pj_lbl5.Size = new System.Drawing.Size(46, 17);
            this.pj_lbl5.TabIndex = 43;
            // 
            // pj_lbl6
            // 
            this.pj_lbl6.Location = new System.Drawing.Point(602, 267);
            this.pj_lbl6.Name = "pj_lbl6";
            this.pj_lbl6.Size = new System.Drawing.Size(46, 17);
            this.pj_lbl6.TabIndex = 44;
            // 
            // pj_lbl7
            // 
            this.pj_lbl7.Location = new System.Drawing.Point(664, 267);
            this.pj_lbl7.Name = "pj_lbl7";
            this.pj_lbl7.Size = new System.Drawing.Size(46, 17);
            this.pj_lbl7.TabIndex = 45;
            // 
            // pj_lbl8
            // 
            this.pj_lbl8.Location = new System.Drawing.Point(727, 267);
            this.pj_lbl8.Name = "pj_lbl8";
            this.pj_lbl8.Size = new System.Drawing.Size(46, 17);
            this.pj_lbl8.TabIndex = 46;
            // 
            // pj_lbl9
            // 
            this.pj_lbl9.AutoSize = true;
            this.pj_lbl9.Location = new System.Drawing.Point(789, 267);
            this.pj_lbl9.Name = "pj_lbl9";
            this.pj_lbl9.Size = new System.Drawing.Size(0, 17);
            this.pj_lbl9.TabIndex = 47;
            // 
            // pj_lbl10
            // 
            this.pj_lbl10.Location = new System.Drawing.Point(851, 267);
            this.pj_lbl10.Name = "pj_lbl10";
            this.pj_lbl10.Size = new System.Drawing.Size(46, 17);
            this.pj_lbl10.TabIndex = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1274, 824);
            this.Controls.Add(this.pj_dGWTabelaprzed);
            this.Controls.Add(this.pj_Wykres);
            this.Controls.Add(this.pj_lbl9);
            this.Controls.Add(this.pj_kolLini2);
            this.Controls.Add(this.pj_infoo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pj_lblKolorLini);
            this.Controls.Add(this.pj_naglowek);
            this.Controls.Add(this.pj_panel);
            this.Controls.Add(this.pj_lblWzorzec);
            this.Controls.Add(this.pj_btnWykres);
            this.Controls.Add(this.pj_btnResetuj);
            this.Controls.Add(this.pj_btnDemo);
            this.Controls.Add(this.pj_btnTabela);
            this.Controls.Add(this.pj_btnWizPo);
            this.Controls.Add(this.pj_btnWizPrzed);
            this.Controls.Add(this.pj_cbAlgorytm);
            this.Controls.Add(this.pj_lblinfo3);
            this.Controls.Add(this.pj_txtGornaG);
            this.Controls.Add(this.pj_lblinfo4);
            this.Controls.Add(this.pj_txtDolnaG);
            this.Controls.Add(this.pj_lblinfo5);
            this.Controls.Add(this.pj_txtMax);
            this.Controls.Add(this.pj_lblinfo2);
            this.Controls.Add(this.pj_txtMin);
            this.Controls.Add(this.pj_lblinfo1);
            this.Controls.Add(this.pj_lblGruboscLiczbowo);
            this.Controls.Add(this.pj_numericGrubosc);
            this.Controls.Add(this.pj_tbGruboscLinii);
            this.Controls.Add(this.pj_lblGruboscLinii);
            this.Controls.Add(this.pj_cbStylLinii);
            this.Controls.Add(this.pj_lblStylLinii);
            this.Controls.Add(this.pj_lblWziernikLinii);
            this.Controls.Add(this.pj_lblKolorTla);
            this.Controls.Add(this.pj_lblWzierniktla);
            this.Controls.Add(this.pj_btnKolorTla);
            this.Controls.Add(this.pj_btnKolorLinii);
            this.Controls.Add(this.pj_lbl1);
            this.Controls.Add(this.pj_lbl2);
            this.Controls.Add(this.pj_lbl3);
            this.Controls.Add(this.pj_lbl4);
            this.Controls.Add(this.pj_lbl5);
            this.Controls.Add(this.pj_lbl6);
            this.Controls.Add(this.pj_lbl7);
            this.Controls.Add(this.pj_lbl8);
            this.Controls.Add(this.pj_lbl10);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(10, 10);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1290, 863);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analizator algorytmów sortowania";
            ((System.ComponentModel.ISupportInitialize)(this.pj_tbGruboscLinii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pj_numericGrubosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pj_dGWTabelaprzed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pj_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pj_Wykres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pj_btnKolorLinii;
        private System.Windows.Forms.Button pj_btnKolorTla;
        private System.Windows.Forms.Label pj_lblKolorTla;
        private System.Windows.Forms.Label pj_lblWzierniktla;
        private System.Windows.Forms.Label pj_lblWziernikLinii;
        private System.Windows.Forms.Label pj_lblStylLinii;
        private System.Windows.Forms.ComboBox pj_cbStylLinii;
        private System.Windows.Forms.Label pj_lblGruboscLinii;
        private System.Windows.Forms.TrackBar pj_tbGruboscLinii;
        private System.Windows.Forms.NumericUpDown pj_numericGrubosc;
        private System.Windows.Forms.Label pj_lblGruboscLiczbowo;
        private System.Windows.Forms.Label pj_lblinfo1;
        private System.Windows.Forms.TextBox pj_txtMin;
        private System.Windows.Forms.Label pj_lblinfo2;
        private System.Windows.Forms.TextBox pj_txtMax;
        private System.Windows.Forms.Label pj_lblinfo5;
        private System.Windows.Forms.TextBox pj_txtDolnaG;
        private System.Windows.Forms.TextBox pj_txtGornaG;
        private System.Windows.Forms.Label pj_lblinfo4;
        private System.Windows.Forms.Label pj_lblinfo3;
        private System.Windows.Forms.ComboBox pj_cbAlgorytm;
        private System.Windows.Forms.Button pj_btnWizPrzed;
        private System.Windows.Forms.Button pj_btnWizPo;
        private System.Windows.Forms.Button pj_btnTabela;
        private System.Windows.Forms.Button pj_btnDemo;
        private System.Windows.Forms.Button pj_btnResetuj;
        private System.Windows.Forms.Button pj_btnWykres;
        private System.Windows.Forms.Label pj_lblWzorzec;
        private System.Windows.Forms.ColorDialog pj_cdKolorLini;
        private System.Windows.Forms.Panel pj_panel;
        private System.Windows.Forms.Label pj_naglowek;
        private System.Windows.Forms.DataGridView pj_dGWTabelaprzed;
        private System.Windows.Forms.ErrorProvider pj_error;
        private System.Windows.Forms.Label pj_lblKolorLinii;
        private System.Windows.Forms.Label pj_lblKolorLini;
        private System.Windows.Forms.DataGridViewTextBoxColumn pj_TabBefore;
        private System.Windows.Forms.DataGridViewTextBoxColumn pj_TabAfter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pj_TabKosztA;
        private System.Windows.Forms.DataVisualization.Charting.Chart pj_Wykres;
        private System.Windows.Forms.Label pj_kolLini2;
        private System.Windows.Forms.Label pj_infoo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer pj_zegar;
        private System.Windows.Forms.Label pj_lbl10;
        private System.Windows.Forms.Label pj_lbl9;
        private System.Windows.Forms.Label pj_lbl8;
        private System.Windows.Forms.Label pj_lbl7;
        private System.Windows.Forms.Label pj_lbl6;
        private System.Windows.Forms.Label pj_lbl5;
        private System.Windows.Forms.Label pj_lbl4;
        private System.Windows.Forms.Label pj_lbl3;
        private System.Windows.Forms.Label pj_lbl2;
        private System.Windows.Forms.Label pj_lbl1;
    }
}

