
namespace RecorridoMatriz
{
    partial class frmLenguaje
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rtxbSentencias = new System.Windows.Forms.RichTextBox();
            this.rtxbTokens = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgIden = new System.Windows.Forms.DataGridView();
            this.rtxbNombreError = new System.Windows.Forms.RichTextBox();
            this.rtxbNumError = new System.Windows.Forms.RichTextBox();
            this.dtgTablaDeSimbolos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtxbLineasCodigo = new System.Windows.Forms.RichTextBox();
            this.rtxbLineasTokens = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.lblTotalErrores = new System.Windows.Forms.Label();
            this.lblNumErrores = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RbtnNuevo = new RecorridoMatriz.RJButton();
            this.btnEjecutar = new RecorridoMatriz.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTablaDeSimbolos)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxbSentencias
            // 
            this.rtxbSentencias.AcceptsTab = true;
            this.rtxbSentencias.BackColor = System.Drawing.Color.DimGray;
            this.rtxbSentencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxbSentencias.Font = new System.Drawing.Font("Consolas", 9.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbSentencias.ForeColor = System.Drawing.Color.Black;
            this.rtxbSentencias.Location = new System.Drawing.Point(95, 80);
            this.rtxbSentencias.Name = "rtxbSentencias";
            this.rtxbSentencias.Size = new System.Drawing.Size(710, 348);
            this.rtxbSentencias.TabIndex = 0;
            this.rtxbSentencias.Text = "";
            this.rtxbSentencias.Click += new System.EventHandler(this.rtxbSentencias_Click);
            this.rtxbSentencias.TextChanged += new System.EventHandler(this.rtxbSentencias_TextChanged);
            // 
            // rtxbTokens
            // 
            this.rtxbTokens.BackColor = System.Drawing.Color.DimGray;
            this.rtxbTokens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxbTokens.Font = new System.Drawing.Font("Consolas", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbTokens.ForeColor = System.Drawing.Color.Black;
            this.rtxbTokens.Location = new System.Drawing.Point(905, 80);
            this.rtxbTokens.Name = "rtxbTokens";
            this.rtxbTokens.ReadOnly = true;
            this.rtxbTokens.Size = new System.Drawing.Size(338, 348);
            this.rtxbTokens.TabIndex = 4;
            this.rtxbTokens.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sentencias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(841, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tokens";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Línea";
            // 
            // dtgIden
            // 
            this.dtgIden.BackgroundColor = System.Drawing.Color.DimGray;
            this.dtgIden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgIden.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgIden.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgIden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgIden.ColumnHeadersHeight = 25;
            this.dtgIden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgIden.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgIden.EnableHeadersVisualStyles = false;
            this.dtgIden.Location = new System.Drawing.Point(22, 748);
            this.dtgIden.Margin = new System.Windows.Forms.Padding(2);
            this.dtgIden.Name = "dtgIden";
            this.dtgIden.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgIden.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgIden.RowHeadersWidth = 72;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dtgIden.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgIden.RowTemplate.Height = 31;
            this.dtgIden.Size = new System.Drawing.Size(1281, 212);
            this.dtgIden.TabIndex = 10;
            // 
            // rtxbNombreError
            // 
            this.rtxbNombreError.BackColor = System.Drawing.Color.DimGray;
            this.rtxbNombreError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxbNombreError.Font = new System.Drawing.Font("Consolas", 9.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbNombreError.ForeColor = System.Drawing.Color.Black;
            this.rtxbNombreError.Location = new System.Drawing.Point(95, 466);
            this.rtxbNombreError.Name = "rtxbNombreError";
            this.rtxbNombreError.ReadOnly = true;
            this.rtxbNombreError.Size = new System.Drawing.Size(538, 212);
            this.rtxbNombreError.TabIndex = 12;
            this.rtxbNombreError.Text = "";
            // 
            // rtxbNumError
            // 
            this.rtxbNumError.BackColor = System.Drawing.Color.DimGray;
            this.rtxbNumError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxbNumError.Font = new System.Drawing.Font("Consolas", 9.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbNumError.ForeColor = System.Drawing.Color.Black;
            this.rtxbNumError.Location = new System.Drawing.Point(20, 467);
            this.rtxbNumError.Name = "rtxbNumError";
            this.rtxbNumError.ReadOnly = true;
            this.rtxbNumError.Size = new System.Drawing.Size(69, 212);
            this.rtxbNumError.TabIndex = 13;
            this.rtxbNumError.Text = "";
            // 
            // dtgTablaDeSimbolos
            // 
            this.dtgTablaDeSimbolos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgTablaDeSimbolos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgTablaDeSimbolos.BackgroundColor = System.Drawing.Color.DimGray;
            this.dtgTablaDeSimbolos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTablaDeSimbolos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgTablaDeSimbolos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTablaDeSimbolos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgTablaDeSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTablaDeSimbolos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgTablaDeSimbolos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgTablaDeSimbolos.EnableHeadersVisualStyles = false;
            this.dtgTablaDeSimbolos.Location = new System.Drawing.Point(682, 466);
            this.dtgTablaDeSimbolos.Margin = new System.Windows.Forms.Padding(2);
            this.dtgTablaDeSimbolos.Name = "dtgTablaDeSimbolos";
            this.dtgTablaDeSimbolos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTablaDeSimbolos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgTablaDeSimbolos.RowHeadersWidth = 72;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dtgTablaDeSimbolos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgTablaDeSimbolos.RowTemplate.Height = 31;
            this.dtgTablaDeSimbolos.Size = new System.Drawing.Size(613, 212);
            this.dtgTablaDeSimbolos.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "# Identificador";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 98;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 67;
            // 
            // rtxbLineasCodigo
            // 
            this.rtxbLineasCodigo.AcceptsTab = true;
            this.rtxbLineasCodigo.BackColor = System.Drawing.Color.DimGray;
            this.rtxbLineasCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxbLineasCodigo.Font = new System.Drawing.Font("Consolas", 9.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbLineasCodigo.ForeColor = System.Drawing.Color.Black;
            this.rtxbLineasCodigo.Location = new System.Drawing.Point(20, 80);
            this.rtxbLineasCodigo.Name = "rtxbLineasCodigo";
            this.rtxbLineasCodigo.Size = new System.Drawing.Size(70, 348);
            this.rtxbLineasCodigo.TabIndex = 15;
            this.rtxbLineasCodigo.Text = "1";
            // 
            // rtxbLineasTokens
            // 
            this.rtxbLineasTokens.BackColor = System.Drawing.Color.DimGray;
            this.rtxbLineasTokens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxbLineasTokens.Font = new System.Drawing.Font("Consolas", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbLineasTokens.ForeColor = System.Drawing.Color.Black;
            this.rtxbLineasTokens.Location = new System.Drawing.Point(831, 80);
            this.rtxbLineasTokens.Name = "rtxbLineasTokens";
            this.rtxbLineasTokens.ReadOnly = true;
            this.rtxbLineasTokens.Size = new System.Drawing.Size(68, 348);
            this.rtxbLineasTokens.TabIndex = 16;
            this.rtxbLineasTokens.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(90, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Errores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(677, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tabla de símbolos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 721);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Matríz de transición";
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(61)))), ((int)(((byte)(153)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(1211, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(25, 15);
            this.iconButton1.TabIndex = 22;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(61)))), ((int)(((byte)(153)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 20;
            this.iconButton3.Location = new System.Drawing.Point(1242, 12);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(25, 25);
            this.iconButton3.TabIndex = 24;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(61)))), ((int)(((byte)(153)))));
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 20;
            this.iconButton4.Location = new System.Drawing.Point(1273, 12);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(25, 25);
            this.iconButton4.TabIndex = 25;
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // lblTotalErrores
            // 
            this.lblTotalErrores.AutoSize = true;
            this.lblTotalErrores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalErrores.ForeColor = System.Drawing.Color.Black;
            this.lblTotalErrores.Location = new System.Drawing.Point(17, 692);
            this.lblTotalErrores.Name = "lblTotalErrores";
            this.lblTotalErrores.Size = new System.Drawing.Size(106, 13);
            this.lblTotalErrores.TabIndex = 31;
            this.lblTotalErrores.Text = "Total de Errores: ";
            // 
            // lblNumErrores
            // 
            this.lblNumErrores.AutoSize = true;
            this.lblNumErrores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumErrores.ForeColor = System.Drawing.Color.Black;
            this.lblNumErrores.Location = new System.Drawing.Point(195, 692);
            this.lblNumErrores.Name = "lblNumErrores";
            this.lblNumErrores.Size = new System.Drawing.Size(14, 13);
            this.lblNumErrores.TabIndex = 32;
            this.lblNumErrores.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20F);
            this.label7.ForeColor = System.Drawing.Color.DarkViolet;
            this.label7.Location = new System.Drawing.Point(0, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 34);
            this.label7.TabIndex = 33;
            this.label7.Text = "lowlang";
            // 
            // RbtnNuevo
            // 
            this.RbtnNuevo.BackColor = System.Drawing.Color.DarkViolet;
            this.RbtnNuevo.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.RbtnNuevo.BorderColor = System.Drawing.Color.MidnightBlue;
            this.RbtnNuevo.BorderRadius = 10;
            this.RbtnNuevo.BorderSize = 0;
            this.RbtnNuevo.FlatAppearance.BorderSize = 0;
            this.RbtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RbtnNuevo.ForeColor = System.Drawing.Color.White;
            this.RbtnNuevo.Location = new System.Drawing.Point(682, 19);
            this.RbtnNuevo.Name = "RbtnNuevo";
            this.RbtnNuevo.Size = new System.Drawing.Size(123, 56);
            this.RbtnNuevo.TabIndex = 27;
            this.RbtnNuevo.Text = "Reiniciar";
            this.RbtnNuevo.TextColor = System.Drawing.Color.White;
            this.RbtnNuevo.UseVisualStyleBackColor = false;
            this.RbtnNuevo.Click += new System.EventHandler(this.RbtnNuevo_Click);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.BackColor = System.Drawing.Color.DarkViolet;
            this.btnEjecutar.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.btnEjecutar.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnEjecutar.BorderRadius = 10;
            this.btnEjecutar.BorderSize = 0;
            this.btnEjecutar.FlatAppearance.BorderSize = 0;
            this.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnEjecutar.ForeColor = System.Drawing.Color.White;
            this.btnEjecutar.Location = new System.Drawing.Point(553, 19);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(123, 56);
            this.btnEjecutar.TabIndex = 26;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.TextColor = System.Drawing.Color.White;
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // frmLenguaje
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1321, 964);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNumErrores);
            this.Controls.Add(this.lblTotalErrores);
            this.Controls.Add(this.RbtnNuevo);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtxbLineasTokens);
            this.Controls.Add(this.rtxbLineasCodigo);
            this.Controls.Add(this.dtgTablaDeSimbolos);
            this.Controls.Add(this.rtxbNumError);
            this.Controls.Add(this.rtxbNombreError);
            this.Controls.Add(this.dtgIden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxbTokens);
            this.Controls.Add(this.rtxbSentencias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLenguaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lenguaje 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLenguaje_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTablaDeSimbolos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxbSentencias;
        private System.Windows.Forms.RichTextBox rtxbTokens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgIden;
        private System.Windows.Forms.RichTextBox rtxbNombreError;
        private System.Windows.Forms.RichTextBox rtxbNumError;
        private System.Windows.Forms.DataGridView dtgTablaDeSimbolos;
        private System.Windows.Forms.RichTextBox rtxbLineasCodigo;
        private System.Windows.Forms.RichTextBox rtxbLineasTokens;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private RJButton btnEjecutar;
        private RJButton RbtnNuevo;
        private System.Windows.Forms.Label lblTotalErrores;
        private System.Windows.Forms.Label lblNumErrores;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

