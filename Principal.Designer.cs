namespace TP2_SIM
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbNormal = new System.Windows.Forms.GroupBox();
            this.rbConvolucion = new System.Windows.Forms.RadioButton();
            this.rbBoxMuller = new System.Windows.Forms.RadioButton();
            this.lblMediaNormal = new System.Windows.Forms.Label();
            this.numIntervalosNormal = new System.Windows.Forms.NumericUpDown();
            this.lblIntervalosNormal = new System.Windows.Forms.Label();
            this.numMuestraNormal = new System.Windows.Forms.NumericUpDown();
            this.numDesviacionNormal = new System.Windows.Forms.NumericUpDown();
            this.lblDesviacionNormal = new System.Windows.Forms.Label();
            this.numMediaNormal = new System.Windows.Forms.NumericUpDown();
            this.lblMuestraNormal = new System.Windows.Forms.Label();
            this.gbUniforme = new System.Windows.Forms.GroupBox();
            this.lblMinimoUniforme = new System.Windows.Forms.Label();
            this.numIntervalosUniforme = new System.Windows.Forms.NumericUpDown();
            this.lblIntervalosUniforme = new System.Windows.Forms.Label();
            this.numMuestraUniforme = new System.Windows.Forms.NumericUpDown();
            this.numMaximoUniforme = new System.Windows.Forms.NumericUpDown();
            this.lblMaximoUniforme = new System.Windows.Forms.Label();
            this.numMinimoUniforme = new System.Windows.Forms.NumericUpDown();
            this.lblMuestraUniforme = new System.Windows.Forms.Label();
            this.listaVariablesAleatorias = new System.Windows.Forms.ListBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbExponencialNegativa = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbUniforme = new System.Windows.Forms.RadioButton();
            this.gbExponencial = new System.Windows.Forms.GroupBox();
            this.numIntervalosExponencial = new System.Windows.Forms.NumericUpDown();
            this.lblIntervalosExponencial = new System.Windows.Forms.Label();
            this.numMuestraExponencial = new System.Windows.Forms.NumericUpDown();
            this.numLambdaExponencial = new System.Windows.Forms.NumericUpDown();
            this.lblLambdaExponencial = new System.Windows.Forms.Label();
            this.lblMuestraExponencial = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gbNormal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervalosNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMuestraNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesviacionNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMediaNormal)).BeginInit();
            this.gbUniforme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervalosUniforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMuestraUniforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximoUniforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimoUniforme)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbExponencial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervalosExponencial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMuestraExponencial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLambdaExponencial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.chart1);
            this.gbPrincipal.Controls.Add(this.dgvDatos);
            this.gbPrincipal.Controls.Add(this.gbNormal);
            this.gbPrincipal.Controls.Add(this.gbUniforme);
            this.gbPrincipal.Controls.Add(this.listaVariablesAleatorias);
            this.gbPrincipal.Controls.Add(this.btn_generar);
            this.gbPrincipal.Controls.Add(this.panel1);
            this.gbPrincipal.Controls.Add(this.gbExponencial);
            this.gbPrincipal.Location = new System.Drawing.Point(13, 13);
            this.gbPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Padding = new System.Windows.Forms.Padding(4);
            this.gbPrincipal.Size = new System.Drawing.Size(1559, 682);
            this.gbPrincipal.TabIndex = 2;
            this.gbPrincipal.TabStop = false;
            this.gbPrincipal.Text = "Generador y graficador de distribuciones";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvDatos.Location = new System.Drawing.Point(649, 340);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.Size = new System.Drawing.Size(639, 324);
            this.dgvDatos.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Desde";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hasta";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Marca de Clase";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fo";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fe";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fo Ac";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Fe Ac";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "C";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Cac";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // gbNormal
            // 
            this.gbNormal.Controls.Add(this.rbConvolucion);
            this.gbNormal.Controls.Add(this.rbBoxMuller);
            this.gbNormal.Controls.Add(this.lblMediaNormal);
            this.gbNormal.Controls.Add(this.numIntervalosNormal);
            this.gbNormal.Controls.Add(this.lblIntervalosNormal);
            this.gbNormal.Controls.Add(this.numMuestraNormal);
            this.gbNormal.Controls.Add(this.numDesviacionNormal);
            this.gbNormal.Controls.Add(this.lblDesviacionNormal);
            this.gbNormal.Controls.Add(this.numMediaNormal);
            this.gbNormal.Controls.Add(this.lblMuestraNormal);
            this.gbNormal.Location = new System.Drawing.Point(575, 102);
            this.gbNormal.Margin = new System.Windows.Forms.Padding(4);
            this.gbNormal.Name = "gbNormal";
            this.gbNormal.Padding = new System.Windows.Forms.Padding(4);
            this.gbNormal.Size = new System.Drawing.Size(352, 181);
            this.gbNormal.TabIndex = 15;
            this.gbNormal.TabStop = false;
            this.gbNormal.Text = "Distribución Normal";
            // 
            // rbConvolucion
            // 
            this.rbConvolucion.AutoSize = true;
            this.rbConvolucion.Location = new System.Drawing.Point(239, 103);
            this.rbConvolucion.Margin = new System.Windows.Forms.Padding(4);
            this.rbConvolucion.Name = "rbConvolucion";
            this.rbConvolucion.Size = new System.Drawing.Size(102, 20);
            this.rbConvolucion.TabIndex = 15;
            this.rbConvolucion.TabStop = true;
            this.rbConvolucion.Text = "Convolucion";
            this.rbConvolucion.UseVisualStyleBackColor = true;
            // 
            // rbBoxMuller
            // 
            this.rbBoxMuller.AutoSize = true;
            this.rbBoxMuller.Location = new System.Drawing.Point(239, 65);
            this.rbBoxMuller.Margin = new System.Windows.Forms.Padding(4);
            this.rbBoxMuller.Name = "rbBoxMuller";
            this.rbBoxMuller.Size = new System.Drawing.Size(90, 20);
            this.rbBoxMuller.TabIndex = 14;
            this.rbBoxMuller.TabStop = true;
            this.rbBoxMuller.Text = "Box Muller";
            this.rbBoxMuller.UseVisualStyleBackColor = true;
            // 
            // lblMediaNormal
            // 
            this.lblMediaNormal.AutoSize = true;
            this.lblMediaNormal.Location = new System.Drawing.Point(48, 38);
            this.lblMediaNormal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMediaNormal.Name = "lblMediaNormal";
            this.lblMediaNormal.Size = new System.Drawing.Size(48, 16);
            this.lblMediaNormal.TabIndex = 7;
            this.lblMediaNormal.Text = "Media:";
            // 
            // numIntervalosNormal
            // 
            this.numIntervalosNormal.Location = new System.Drawing.Point(116, 132);
            this.numIntervalosNormal.Margin = new System.Windows.Forms.Padding(4);
            this.numIntervalosNormal.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numIntervalosNormal.Name = "numIntervalosNormal";
            this.numIntervalosNormal.Size = new System.Drawing.Size(103, 22);
            this.numIntervalosNormal.TabIndex = 13;
            // 
            // lblIntervalosNormal
            // 
            this.lblIntervalosNormal.AutoSize = true;
            this.lblIntervalosNormal.Location = new System.Drawing.Point(33, 134);
            this.lblIntervalosNormal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntervalosNormal.Name = "lblIntervalosNormal";
            this.lblIntervalosNormal.Size = new System.Drawing.Size(68, 16);
            this.lblIntervalosNormal.TabIndex = 12;
            this.lblIntervalosNormal.Text = "Intervalos:";
            // 
            // numMuestraNormal
            // 
            this.numMuestraNormal.Location = new System.Drawing.Point(116, 100);
            this.numMuestraNormal.Margin = new System.Windows.Forms.Padding(4);
            this.numMuestraNormal.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numMuestraNormal.Name = "numMuestraNormal";
            this.numMuestraNormal.Size = new System.Drawing.Size(103, 22);
            this.numMuestraNormal.TabIndex = 3;
            // 
            // numDesviacionNormal
            // 
            this.numDesviacionNormal.Location = new System.Drawing.Point(116, 68);
            this.numDesviacionNormal.Margin = new System.Windows.Forms.Padding(4);
            this.numDesviacionNormal.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numDesviacionNormal.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numDesviacionNormal.Name = "numDesviacionNormal";
            this.numDesviacionNormal.Size = new System.Drawing.Size(103, 22);
            this.numDesviacionNormal.TabIndex = 11;
            // 
            // lblDesviacionNormal
            // 
            this.lblDesviacionNormal.AutoSize = true;
            this.lblDesviacionNormal.Location = new System.Drawing.Point(16, 70);
            this.lblDesviacionNormal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesviacionNormal.Name = "lblDesviacionNormal";
            this.lblDesviacionNormal.Size = new System.Drawing.Size(78, 16);
            this.lblDesviacionNormal.TabIndex = 8;
            this.lblDesviacionNormal.Text = "Desviación:";
            // 
            // numMediaNormal
            // 
            this.numMediaNormal.Location = new System.Drawing.Point(116, 36);
            this.numMediaNormal.Margin = new System.Windows.Forms.Padding(4);
            this.numMediaNormal.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numMediaNormal.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numMediaNormal.Name = "numMediaNormal";
            this.numMediaNormal.Size = new System.Drawing.Size(103, 22);
            this.numMediaNormal.TabIndex = 10;
            // 
            // lblMuestraNormal
            // 
            this.lblMuestraNormal.AutoSize = true;
            this.lblMuestraNormal.Location = new System.Drawing.Point(44, 102);
            this.lblMuestraNormal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMuestraNormal.Name = "lblMuestraNormal";
            this.lblMuestraNormal.Size = new System.Drawing.Size(58, 16);
            this.lblMuestraNormal.TabIndex = 9;
            this.lblMuestraNormal.Text = "Muestra:";
            // 
            // gbUniforme
            // 
            this.gbUniforme.Controls.Add(this.lblMinimoUniforme);
            this.gbUniforme.Controls.Add(this.numIntervalosUniforme);
            this.gbUniforme.Controls.Add(this.lblIntervalosUniforme);
            this.gbUniforme.Controls.Add(this.numMuestraUniforme);
            this.gbUniforme.Controls.Add(this.numMaximoUniforme);
            this.gbUniforme.Controls.Add(this.lblMaximoUniforme);
            this.gbUniforme.Controls.Add(this.numMinimoUniforme);
            this.gbUniforme.Controls.Add(this.lblMuestraUniforme);
            this.gbUniforme.Location = new System.Drawing.Point(9, 102);
            this.gbUniforme.Margin = new System.Windows.Forms.Padding(4);
            this.gbUniforme.Name = "gbUniforme";
            this.gbUniforme.Padding = new System.Windows.Forms.Padding(4);
            this.gbUniforme.Size = new System.Drawing.Size(240, 181);
            this.gbUniforme.TabIndex = 14;
            this.gbUniforme.TabStop = false;
            this.gbUniforme.Text = "Distribución Uniforme";
            // 
            // lblMinimoUniforme
            // 
            this.lblMinimoUniforme.AutoSize = true;
            this.lblMinimoUniforme.Location = new System.Drawing.Point(48, 41);
            this.lblMinimoUniforme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinimoUniforme.Name = "lblMinimoUniforme";
            this.lblMinimoUniforme.Size = new System.Drawing.Size(53, 16);
            this.lblMinimoUniforme.TabIndex = 7;
            this.lblMinimoUniforme.Text = "Minimo:";
            // 
            // numIntervalosUniforme
            // 
            this.numIntervalosUniforme.Location = new System.Drawing.Point(116, 134);
            this.numIntervalosUniforme.Margin = new System.Windows.Forms.Padding(4);
            this.numIntervalosUniforme.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numIntervalosUniforme.Name = "numIntervalosUniforme";
            this.numIntervalosUniforme.Size = new System.Drawing.Size(103, 22);
            this.numIntervalosUniforme.TabIndex = 13;
            // 
            // lblIntervalosUniforme
            // 
            this.lblIntervalosUniforme.AutoSize = true;
            this.lblIntervalosUniforme.Location = new System.Drawing.Point(33, 137);
            this.lblIntervalosUniforme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntervalosUniforme.Name = "lblIntervalosUniforme";
            this.lblIntervalosUniforme.Size = new System.Drawing.Size(68, 16);
            this.lblIntervalosUniforme.TabIndex = 12;
            this.lblIntervalosUniforme.Text = "Intervalos:";
            // 
            // numMuestraUniforme
            // 
            this.numMuestraUniforme.Location = new System.Drawing.Point(116, 102);
            this.numMuestraUniforme.Margin = new System.Windows.Forms.Padding(4);
            this.numMuestraUniforme.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numMuestraUniforme.Name = "numMuestraUniforme";
            this.numMuestraUniforme.Size = new System.Drawing.Size(103, 22);
            this.numMuestraUniforme.TabIndex = 3;
            // 
            // numMaximoUniforme
            // 
            this.numMaximoUniforme.Location = new System.Drawing.Point(116, 70);
            this.numMaximoUniforme.Margin = new System.Windows.Forms.Padding(4);
            this.numMaximoUniforme.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numMaximoUniforme.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numMaximoUniforme.Name = "numMaximoUniforme";
            this.numMaximoUniforme.Size = new System.Drawing.Size(103, 22);
            this.numMaximoUniforme.TabIndex = 11;
            // 
            // lblMaximoUniforme
            // 
            this.lblMaximoUniforme.AutoSize = true;
            this.lblMaximoUniforme.Location = new System.Drawing.Point(44, 73);
            this.lblMaximoUniforme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaximoUniforme.Name = "lblMaximoUniforme";
            this.lblMaximoUniforme.Size = new System.Drawing.Size(57, 16);
            this.lblMaximoUniforme.TabIndex = 8;
            this.lblMaximoUniforme.Text = "Maximo:";
            // 
            // numMinimoUniforme
            // 
            this.numMinimoUniforme.Location = new System.Drawing.Point(116, 38);
            this.numMinimoUniforme.Margin = new System.Windows.Forms.Padding(4);
            this.numMinimoUniforme.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numMinimoUniforme.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numMinimoUniforme.Name = "numMinimoUniforme";
            this.numMinimoUniforme.Size = new System.Drawing.Size(103, 22);
            this.numMinimoUniforme.TabIndex = 10;
            // 
            // lblMuestraUniforme
            // 
            this.lblMuestraUniforme.AutoSize = true;
            this.lblMuestraUniforme.Location = new System.Drawing.Point(44, 105);
            this.lblMuestraUniforme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMuestraUniforme.Name = "lblMuestraUniforme";
            this.lblMuestraUniforme.Size = new System.Drawing.Size(58, 16);
            this.lblMuestraUniforme.TabIndex = 9;
            this.lblMuestraUniforme.Text = "Muestra:";
            // 
            // listaVariablesAleatorias
            // 
            this.listaVariablesAleatorias.FormattingEnabled = true;
            this.listaVariablesAleatorias.ItemHeight = 16;
            this.listaVariablesAleatorias.Location = new System.Drawing.Point(1308, 25);
            this.listaVariablesAleatorias.Margin = new System.Windows.Forms.Padding(4);
            this.listaVariablesAleatorias.Name = "listaVariablesAleatorias";
            this.listaVariablesAleatorias.Size = new System.Drawing.Size(233, 644);
            this.listaVariablesAleatorias.TabIndex = 6;
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(9, 290);
            this.btn_generar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(169, 32);
            this.btn_generar.TabIndex = 0;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbExponencialNegativa);
            this.panel1.Controls.Add(this.rbNormal);
            this.panel1.Controls.Add(this.rbUniforme);
            this.panel1.Location = new System.Drawing.Point(9, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 52);
            this.panel1.TabIndex = 1;
            // 
            // rbExponencialNegativa
            // 
            this.rbExponencialNegativa.AutoSize = true;
            this.rbExponencialNegativa.Location = new System.Drawing.Point(309, 16);
            this.rbExponencialNegativa.Margin = new System.Windows.Forms.Padding(4);
            this.rbExponencialNegativa.Name = "rbExponencialNegativa";
            this.rbExponencialNegativa.Size = new System.Drawing.Size(160, 20);
            this.rbExponencialNegativa.TabIndex = 2;
            this.rbExponencialNegativa.TabStop = true;
            this.rbExponencialNegativa.Text = "Exponencial Negativa";
            this.rbExponencialNegativa.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(602, 16);
            this.rbNormal.Margin = new System.Windows.Forms.Padding(4);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(72, 20);
            this.rbNormal.TabIndex = 1;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbUniforme
            // 
            this.rbUniforme.AutoSize = true;
            this.rbUniforme.Location = new System.Drawing.Point(47, 16);
            this.rbUniforme.Margin = new System.Windows.Forms.Padding(4);
            this.rbUniforme.Name = "rbUniforme";
            this.rbUniforme.Size = new System.Drawing.Size(82, 20);
            this.rbUniforme.TabIndex = 0;
            this.rbUniforme.TabStop = true;
            this.rbUniforme.Text = "Uniforme";
            this.rbUniforme.UseVisualStyleBackColor = true;
            // 
            // gbExponencial
            // 
            this.gbExponencial.Controls.Add(this.numIntervalosExponencial);
            this.gbExponencial.Controls.Add(this.lblIntervalosExponencial);
            this.gbExponencial.Controls.Add(this.numMuestraExponencial);
            this.gbExponencial.Controls.Add(this.numLambdaExponencial);
            this.gbExponencial.Controls.Add(this.lblLambdaExponencial);
            this.gbExponencial.Controls.Add(this.lblMuestraExponencial);
            this.gbExponencial.Location = new System.Drawing.Point(283, 102);
            this.gbExponencial.Margin = new System.Windows.Forms.Padding(4);
            this.gbExponencial.Name = "gbExponencial";
            this.gbExponencial.Padding = new System.Windows.Forms.Padding(4);
            this.gbExponencial.Size = new System.Drawing.Size(257, 181);
            this.gbExponencial.TabIndex = 15;
            this.gbExponencial.TabStop = false;
            this.gbExponencial.Text = "Distribución Exponencial";
            // 
            // numIntervalosExponencial
            // 
            this.numIntervalosExponencial.Location = new System.Drawing.Point(115, 102);
            this.numIntervalosExponencial.Margin = new System.Windows.Forms.Padding(4);
            this.numIntervalosExponencial.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numIntervalosExponencial.Name = "numIntervalosExponencial";
            this.numIntervalosExponencial.Size = new System.Drawing.Size(103, 22);
            this.numIntervalosExponencial.TabIndex = 13;
            // 
            // lblIntervalosExponencial
            // 
            this.lblIntervalosExponencial.AutoSize = true;
            this.lblIntervalosExponencial.Location = new System.Drawing.Point(32, 105);
            this.lblIntervalosExponencial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntervalosExponencial.Name = "lblIntervalosExponencial";
            this.lblIntervalosExponencial.Size = new System.Drawing.Size(68, 16);
            this.lblIntervalosExponencial.TabIndex = 12;
            this.lblIntervalosExponencial.Text = "Intervalos:";
            // 
            // numMuestraExponencial
            // 
            this.numMuestraExponencial.Location = new System.Drawing.Point(115, 70);
            this.numMuestraExponencial.Margin = new System.Windows.Forms.Padding(4);
            this.numMuestraExponencial.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numMuestraExponencial.Name = "numMuestraExponencial";
            this.numMuestraExponencial.Size = new System.Drawing.Size(103, 22);
            this.numMuestraExponencial.TabIndex = 3;
            // 
            // numLambdaExponencial
            // 
            this.numLambdaExponencial.DecimalPlaces = 4;
            this.numLambdaExponencial.Location = new System.Drawing.Point(115, 38);
            this.numLambdaExponencial.Margin = new System.Windows.Forms.Padding(4);
            this.numLambdaExponencial.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numLambdaExponencial.Name = "numLambdaExponencial";
            this.numLambdaExponencial.Size = new System.Drawing.Size(103, 22);
            this.numLambdaExponencial.TabIndex = 11;
            // 
            // lblLambdaExponencial
            // 
            this.lblLambdaExponencial.AutoSize = true;
            this.lblLambdaExponencial.Location = new System.Drawing.Point(43, 41);
            this.lblLambdaExponencial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLambdaExponencial.Name = "lblLambdaExponencial";
            this.lblLambdaExponencial.Size = new System.Drawing.Size(60, 16);
            this.lblLambdaExponencial.TabIndex = 8;
            this.lblLambdaExponencial.Text = "Lambda:";
            // 
            // lblMuestraExponencial
            // 
            this.lblMuestraExponencial.AutoSize = true;
            this.lblMuestraExponencial.Location = new System.Drawing.Point(43, 73);
            this.lblMuestraExponencial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMuestraExponencial.Name = "lblMuestraExponencial";
            this.lblMuestraExponencial.Size = new System.Drawing.Size(58, 16);
            this.lblMuestraExponencial.TabIndex = 9;
            this.lblMuestraExponencial.Text = "Muestra:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(9, 340);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(633, 324);
            this.chart1.TabIndex = 27;
            this.chart1.Text = "chart1";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 707);
            this.Controls.Add(this.gbPrincipal);
            this.Name = "Principal";
            this.Text = "Form1";
            this.gbPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gbNormal.ResumeLayout(false);
            this.gbNormal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervalosNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMuestraNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesviacionNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMediaNormal)).EndInit();
            this.gbUniforme.ResumeLayout(false);
            this.gbUniforme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervalosUniforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMuestraUniforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximoUniforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimoUniforme)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbExponencial.ResumeLayout(false);
            this.gbExponencial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervalosExponencial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMuestraExponencial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLambdaExponencial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.GroupBox gbNormal;
        private System.Windows.Forms.RadioButton rbConvolucion;
        private System.Windows.Forms.RadioButton rbBoxMuller;
        private System.Windows.Forms.Label lblMediaNormal;
        private System.Windows.Forms.NumericUpDown numIntervalosNormal;
        private System.Windows.Forms.Label lblIntervalosNormal;
        private System.Windows.Forms.NumericUpDown numMuestraNormal;
        private System.Windows.Forms.NumericUpDown numDesviacionNormal;
        private System.Windows.Forms.Label lblDesviacionNormal;
        private System.Windows.Forms.NumericUpDown numMediaNormal;
        private System.Windows.Forms.Label lblMuestraNormal;
        private System.Windows.Forms.GroupBox gbUniforme;
        private System.Windows.Forms.Label lblMinimoUniforme;
        private System.Windows.Forms.NumericUpDown numIntervalosUniforme;
        private System.Windows.Forms.Label lblIntervalosUniforme;
        private System.Windows.Forms.NumericUpDown numMuestraUniforme;
        private System.Windows.Forms.NumericUpDown numMaximoUniforme;
        private System.Windows.Forms.Label lblMaximoUniforme;
        private System.Windows.Forms.NumericUpDown numMinimoUniforme;
        private System.Windows.Forms.Label lblMuestraUniforme;
        private System.Windows.Forms.ListBox listaVariablesAleatorias;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbExponencialNegativa;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbUniforme;
        private System.Windows.Forms.GroupBox gbExponencial;
        private System.Windows.Forms.NumericUpDown numIntervalosExponencial;
        private System.Windows.Forms.Label lblIntervalosExponencial;
        private System.Windows.Forms.NumericUpDown numMuestraExponencial;
        private System.Windows.Forms.NumericUpDown numLambdaExponencial;
        private System.Windows.Forms.Label lblLambdaExponencial;
        private System.Windows.Forms.Label lblMuestraExponencial;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

