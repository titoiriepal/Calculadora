
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.etPantalla = new System.Windows.Forms.Label();
            this.bt7n = new System.Windows.Forms.Button();
            this.bt8n = new System.Windows.Forms.Button();
            this.bt9n = new System.Windows.Forms.Button();
            this.bt4n = new System.Windows.Forms.Button();
            this.bt5n = new System.Windows.Forms.Button();
            this.bt6n = new System.Windows.Forms.Button();
            this.bt1n = new System.Windows.Forms.Button();
            this.bt2n = new System.Windows.Forms.Button();
            this.bt3n = new System.Windows.Forms.Button();
            this.btComaDec = new System.Windows.Forms.Button();
            this.bt0n = new System.Windows.Forms.Button();
            this.btIniciar = new System.Windows.Forms.Button();
            this.btBorrarEntrada = new System.Windows.Forms.Button();
            this.btDividir = new System.Windows.Forms.Button();
            this.dbtMenos = new System.Windows.Forms.Button();
            this.btPor = new System.Windows.Forms.Button();
            this.btMas = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.btTantoPorCiento = new System.Windows.Forms.Button();
            this.btMasMenos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btMemorySum = new System.Windows.Forms.Button();
            this.btMemoryRead = new System.Windows.Forms.Button();
            this.btMemoryCopy = new System.Windows.Forms.Button();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // etPantalla
            // 
            this.etPantalla.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.etPantalla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.etPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.etPantalla.Location = new System.Drawing.Point(26, 9);
            this.etPantalla.Name = "etPantalla";
            this.etPantalla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.etPantalla.Size = new System.Drawing.Size(320, 46);
            this.etPantalla.TabIndex = 0;
            this.etPantalla.Text = "0,";
            this.etPantalla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.etPantalla.Visible = false;
            // 
            // bt7n
            // 
            this.bt7n.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt7n.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt7n.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt7n.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt7n.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt7n.Location = new System.Drawing.Point(26, 123);
            this.bt7n.Name = "bt7n";
            this.bt7n.Size = new System.Drawing.Size(53, 56);
            this.bt7n.TabIndex = 1;
            this.bt7n.Text = "7";
            this.bt7n.UseVisualStyleBackColor = false;
            this.bt7n.Click += new System.EventHandler(this.BtDigito_Click);
            this.bt7n.MouseHover += new System.EventHandler(this.bt7n_MouseHover);
            // 
            // bt8n
            // 
            this.bt8n.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt8n.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt8n.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt8n.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt8n.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt8n.Location = new System.Drawing.Point(85, 123);
            this.bt8n.Name = "bt8n";
            this.bt8n.Size = new System.Drawing.Size(53, 56);
            this.bt8n.TabIndex = 2;
            this.bt8n.Text = "8";
            this.bt8n.UseVisualStyleBackColor = false;
            this.bt8n.Click += new System.EventHandler(this.BtDigito_Click);
            // 
            // bt9n
            // 
            this.bt9n.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt9n.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt9n.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt9n.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt9n.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt9n.Location = new System.Drawing.Point(144, 123);
            this.bt9n.Name = "bt9n";
            this.bt9n.Size = new System.Drawing.Size(53, 56);
            this.bt9n.TabIndex = 3;
            this.bt9n.Text = "9";
            this.bt9n.UseVisualStyleBackColor = false;
            this.bt9n.Click += new System.EventHandler(this.BtDigito_Click);
            // 
            // bt4n
            // 
            this.bt4n.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt4n.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt4n.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt4n.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt4n.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt4n.Location = new System.Drawing.Point(26, 185);
            this.bt4n.Name = "bt4n";
            this.bt4n.Size = new System.Drawing.Size(53, 56);
            this.bt4n.TabIndex = 4;
            this.bt4n.Text = "4";
            this.bt4n.UseVisualStyleBackColor = false;
            this.bt4n.Click += new System.EventHandler(this.BtDigito_Click);
            // 
            // bt5n
            // 
            this.bt5n.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt5n.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt5n.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt5n.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt5n.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt5n.Location = new System.Drawing.Point(85, 185);
            this.bt5n.Name = "bt5n";
            this.bt5n.Size = new System.Drawing.Size(53, 56);
            this.bt5n.TabIndex = 5;
            this.bt5n.Text = "5";
            this.bt5n.UseVisualStyleBackColor = false;
            this.bt5n.Click += new System.EventHandler(this.BtDigito_Click);
            // 
            // bt6n
            // 
            this.bt6n.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt6n.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt6n.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt6n.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt6n.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt6n.Location = new System.Drawing.Point(144, 185);
            this.bt6n.Name = "bt6n";
            this.bt6n.Size = new System.Drawing.Size(53, 56);
            this.bt6n.TabIndex = 6;
            this.bt6n.Text = "6";
            this.bt6n.UseVisualStyleBackColor = false;
            this.bt6n.Click += new System.EventHandler(this.BtDigito_Click);
            // 
            // bt1n
            // 
            this.bt1n.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt1n.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt1n.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt1n.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt1n.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt1n.Location = new System.Drawing.Point(26, 247);
            this.bt1n.Name = "bt1n";
            this.bt1n.Size = new System.Drawing.Size(53, 56);
            this.bt1n.TabIndex = 7;
            this.bt1n.Text = "1";
            this.bt1n.UseVisualStyleBackColor = false;
            this.bt1n.Click += new System.EventHandler(this.BtDigito_Click);
            // 
            // bt2n
            // 
            this.bt2n.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt2n.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt2n.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt2n.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt2n.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt2n.Location = new System.Drawing.Point(85, 247);
            this.bt2n.Name = "bt2n";
            this.bt2n.Size = new System.Drawing.Size(53, 56);
            this.bt2n.TabIndex = 8;
            this.bt2n.Text = "2";
            this.bt2n.UseVisualStyleBackColor = false;
            this.bt2n.Click += new System.EventHandler(this.BtDigito_Click);
            // 
            // bt3n
            // 
            this.bt3n.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt3n.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt3n.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt3n.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt3n.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt3n.Location = new System.Drawing.Point(144, 247);
            this.bt3n.Name = "bt3n";
            this.bt3n.Size = new System.Drawing.Size(53, 56);
            this.bt3n.TabIndex = 9;
            this.bt3n.Text = "3";
            this.bt3n.UseVisualStyleBackColor = false;
            this.bt3n.Click += new System.EventHandler(this.BtDigito_Click);
            // 
            // btComaDec
            // 
            this.btComaDec.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btComaDec.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btComaDec.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btComaDec.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btComaDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btComaDec.Location = new System.Drawing.Point(144, 309);
            this.btComaDec.Name = "btComaDec";
            this.btComaDec.Size = new System.Drawing.Size(53, 56);
            this.btComaDec.TabIndex = 10;
            this.btComaDec.Text = ",";
            this.btComaDec.UseVisualStyleBackColor = false;
            this.btComaDec.Click += new System.EventHandler(this.btComaDec_Click);
            // 
            // bt0n
            // 
            this.bt0n.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt0n.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt0n.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt0n.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt0n.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt0n.Location = new System.Drawing.Point(26, 309);
            this.bt0n.Name = "bt0n";
            this.bt0n.Size = new System.Drawing.Size(112, 56);
            this.bt0n.TabIndex = 11;
            this.bt0n.Text = "0";
            this.bt0n.UseVisualStyleBackColor = false;
            this.bt0n.Click += new System.EventHandler(this.BtDigito_Click);
            // 
            // btIniciar
            // 
            this.btIniciar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btIniciar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btIniciar.Location = new System.Drawing.Point(237, 123);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(53, 56);
            this.btIniciar.TabIndex = 12;
            this.btIniciar.Text = "C";
            this.btIniciar.UseVisualStyleBackColor = false;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // btBorrarEntrada
            // 
            this.btBorrarEntrada.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btBorrarEntrada.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btBorrarEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btBorrarEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btBorrarEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btBorrarEntrada.Location = new System.Drawing.Point(296, 123);
            this.btBorrarEntrada.Name = "btBorrarEntrada";
            this.btBorrarEntrada.Size = new System.Drawing.Size(53, 56);
            this.btBorrarEntrada.TabIndex = 13;
            this.btBorrarEntrada.Text = "CE";
            this.btBorrarEntrada.UseVisualStyleBackColor = false;
            this.btBorrarEntrada.Click += new System.EventHandler(this.btBorrarEntrada_Click);
            // 
            // btDividir
            // 
            this.btDividir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btDividir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btDividir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btDividir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDividir.Location = new System.Drawing.Point(237, 185);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(53, 56);
            this.btDividir.TabIndex = 14;
            this.btDividir.Text = "/";
            this.btDividir.UseVisualStyleBackColor = false;
            this.btDividir.Click += new System.EventHandler(this.BtOperation_Click);
            // 
            // dbtMenos
            // 
            this.dbtMenos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dbtMenos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dbtMenos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.dbtMenos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.dbtMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dbtMenos.Location = new System.Drawing.Point(296, 185);
            this.dbtMenos.Name = "dbtMenos";
            this.dbtMenos.Size = new System.Drawing.Size(53, 56);
            this.dbtMenos.TabIndex = 15;
            this.dbtMenos.Text = "-";
            this.dbtMenos.UseVisualStyleBackColor = false;
            this.dbtMenos.Click += new System.EventHandler(this.BtOperation_Click);
            // 
            // btPor
            // 
            this.btPor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btPor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btPor.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btPor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPor.Location = new System.Drawing.Point(237, 247);
            this.btPor.Name = "btPor";
            this.btPor.Size = new System.Drawing.Size(53, 56);
            this.btPor.TabIndex = 16;
            this.btPor.Text = "x";
            this.btPor.UseVisualStyleBackColor = false;
            this.btPor.Click += new System.EventHandler(this.BtOperation_Click);
            // 
            // btMas
            // 
            this.btMas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btMas.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btMas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btMas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btMas.Location = new System.Drawing.Point(296, 247);
            this.btMas.Name = "btMas";
            this.btMas.Size = new System.Drawing.Size(53, 56);
            this.btMas.TabIndex = 17;
            this.btMas.Text = "+";
            this.btMas.UseVisualStyleBackColor = false;
            this.btMas.Click += new System.EventHandler(this.BtOperation_Click);
            // 
            // btIgual
            // 
            this.btIgual.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btIgual.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btIgual.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btIgual.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btIgual.Location = new System.Drawing.Point(237, 309);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(53, 56);
            this.btIgual.TabIndex = 18;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = false;
            this.btIgual.Click += new System.EventHandler(this.BtOperation_Click);
            // 
            // btTantoPorCiento
            // 
            this.btTantoPorCiento.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btTantoPorCiento.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btTantoPorCiento.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btTantoPorCiento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btTantoPorCiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btTantoPorCiento.Location = new System.Drawing.Point(296, 309);
            this.btTantoPorCiento.Name = "btTantoPorCiento";
            this.btTantoPorCiento.Size = new System.Drawing.Size(53, 56);
            this.btTantoPorCiento.TabIndex = 19;
            this.btTantoPorCiento.Text = "%";
            this.btTantoPorCiento.UseVisualStyleBackColor = false;
            this.btTantoPorCiento.Click += new System.EventHandler(this.btTantoPorCiento_Click);
            // 
            // btMasMenos
            // 
            this.btMasMenos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btMasMenos.Location = new System.Drawing.Point(296, 61);
            this.btMasMenos.Name = "btMasMenos";
            this.btMasMenos.Size = new System.Drawing.Size(50, 56);
            this.btMasMenos.TabIndex = 20;
            this.btMasMenos.Text = "+/-";
            this.btMasMenos.UseVisualStyleBackColor = false;
            this.btMasMenos.Click += new System.EventHandler(this.btMasMenos_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(237, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 56);
            this.button1.TabIndex = 21;
            this.button1.Text = "Raiz";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btMemorySum
            // 
            this.btMemorySum.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btMemorySum.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btMemorySum.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btMemorySum.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btMemorySum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btMemorySum.Location = new System.Drawing.Point(144, 61);
            this.btMemorySum.Name = "btMemorySum";
            this.btMemorySum.Size = new System.Drawing.Size(53, 56);
            this.btMemorySum.TabIndex = 22;
            this.btMemorySum.Text = "M+";
            this.btMemorySum.UseVisualStyleBackColor = false;
            // 
            // btMemoryRead
            // 
            this.btMemoryRead.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btMemoryRead.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btMemoryRead.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btMemoryRead.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btMemoryRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btMemoryRead.Location = new System.Drawing.Point(85, 61);
            this.btMemoryRead.Name = "btMemoryRead";
            this.btMemoryRead.Size = new System.Drawing.Size(53, 56);
            this.btMemoryRead.TabIndex = 23;
            this.btMemoryRead.Text = "MR";
            this.btMemoryRead.UseVisualStyleBackColor = false;
            // 
            // btMemoryCopy
            // 
            this.btMemoryCopy.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btMemoryCopy.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btMemoryCopy.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btMemoryCopy.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btMemoryCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btMemoryCopy.Location = new System.Drawing.Point(26, 61);
            this.btMemoryCopy.Name = "btMemoryCopy";
            this.btMemoryCopy.Size = new System.Drawing.Size(53, 56);
            this.btMemoryCopy.TabIndex = 24;
            this.btMemoryCopy.Text = "MC";
            this.btMemoryCopy.UseVisualStyleBackColor = false;
            // 
            // txtPantalla
            // 
            this.txtPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPantalla.Location = new System.Drawing.Point(26, 12);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.Size = new System.Drawing.Size(320, 31);
            this.txtPantalla.TabIndex = 25;
            this.txtPantalla.Text = "0,";
            this.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPantalla.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPantalla_KeyDown);
            this.txtPantalla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPantalla_KeyPress);
            this.txtPantalla.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPantalla_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(374, 377);
            this.Controls.Add(this.txtPantalla);
            this.Controls.Add(this.btMemoryCopy);
            this.Controls.Add(this.btMemoryRead);
            this.Controls.Add(this.btMemorySum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btMasMenos);
            this.Controls.Add(this.btTantoPorCiento);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btMas);
            this.Controls.Add(this.btPor);
            this.Controls.Add(this.dbtMenos);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.btBorrarEntrada);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.bt0n);
            this.Controls.Add(this.btComaDec);
            this.Controls.Add(this.bt3n);
            this.Controls.Add(this.bt2n);
            this.Controls.Add(this.bt1n);
            this.Controls.Add(this.bt6n);
            this.Controls.Add(this.bt5n);
            this.Controls.Add(this.bt4n);
            this.Controls.Add(this.bt9n);
            this.Controls.Add(this.bt8n);
            this.Controls.Add(this.bt7n);
            this.Controls.Add(this.etPantalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etPantalla;
        private System.Windows.Forms.Button bt7n;
        private System.Windows.Forms.Button bt8n;
        private System.Windows.Forms.Button bt9n;
        private System.Windows.Forms.Button bt4n;
        private System.Windows.Forms.Button bt5n;
        private System.Windows.Forms.Button bt6n;
        private System.Windows.Forms.Button bt1n;
        private System.Windows.Forms.Button bt2n;
        private System.Windows.Forms.Button bt3n;
        private System.Windows.Forms.Button btComaDec;
        private System.Windows.Forms.Button bt0n;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Button btBorrarEntrada;
        private System.Windows.Forms.Button btDividir;
        private System.Windows.Forms.Button dbtMenos;
        private System.Windows.Forms.Button btPor;
        private System.Windows.Forms.Button btMas;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button btTantoPorCiento;
        private System.Windows.Forms.Button btMasMenos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btMemorySum;
        private System.Windows.Forms.Button btMemoryRead;
        private System.Windows.Forms.Button btMemoryCopy;
        private System.Windows.Forms.TextBox txtPantalla;
    }
}

