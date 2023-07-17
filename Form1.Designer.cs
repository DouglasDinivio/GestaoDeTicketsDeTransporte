namespace GestaoDeTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNome = new TextBox();
            txtDestino = new TextBox();
            txtPartida = new TextBox();
            txtCondicaoEspecial = new ComboBox();
            label6 = new Label();
            txtRota = new ComboBox();
            label7 = new Label();
            dateTime = new DateTimePicker();
            AdicionarBtn = new Button();
            dataGridView1 = new DataGridView();
            txtGenero = new ComboBox();
            btnActualizar = new Button();
            txtAssento = new TextBox();
            label8 = new Label();
            txtID = new TextBox();
            label9 = new Label();
            btnApagar = new Button();
            Matricula = new Label();
            btnMapp = new Button();
            txtMatricula = new ComboBox();
            button1 = new Button();
            txtPhoneNumber = new TextBox();
            label10 = new Label();
            label11 = new Label();
            button2 = new Button();
            button3 = new Button();
            txtCount = new Label();
            txtRestantes = new Label();
            label12 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(223, 214);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(223, 262);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Rota";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(223, 302);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Ponto Partida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(223, 350);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 3;
            label4.Text = "Destino";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(223, 406);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 4;
            label5.Text = "Condicao especial";
            label5.Click += label5_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(369, 214);
            txtNome.Margin = new Padding(1, 2, 1, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(255, 27);
            txtNome.TabIndex = 5;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(369, 350);
            txtDestino.Margin = new Padding(1, 2, 1, 2);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(255, 27);
            txtDestino.TabIndex = 7;
            // 
            // txtPartida
            // 
            txtPartida.Location = new Point(369, 302);
            txtPartida.Margin = new Padding(1, 2, 1, 2);
            txtPartida.Name = "txtPartida";
            txtPartida.Size = new Size(255, 27);
            txtPartida.TabIndex = 8;
            // 
            // txtCondicaoEspecial
            // 
            txtCondicaoEspecial.FormattingEnabled = true;
            txtCondicaoEspecial.Items.AddRange(new object[] { "Idoso", "Deficiente", "Mulher Gravida", "Cadeirante", "Nenhuma" });
            txtCondicaoEspecial.Location = new Point(369, 406);
            txtCondicaoEspecial.Margin = new Padding(1, 2, 1, 2);
            txtCondicaoEspecial.Name = "txtCondicaoEspecial";
            txtCondicaoEspecial.Size = new Size(255, 28);
            txtCondicaoEspecial.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(223, 466);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 11;
            label6.Text = "Genero";
            label6.Click += label6_Click;
            // 
            // txtRota
            // 
            txtRota.FormattingEnabled = true;
            txtRota.Items.AddRange(new object[] { "Museu-Albasine", "Museu-Magoanine", "Museu-Zimpeto", "Muse-Matola Gare", "Museu-Malhazine", "Museu-Marracuene", "Museu-Matendene" });
            txtRota.Location = new Point(369, 262);
            txtRota.Margin = new Padding(1, 2, 1, 2);
            txtRota.Name = "txtRota";
            txtRota.Size = new Size(255, 28);
            txtRota.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(224, 558);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 17;
            label7.Text = "Data";
            label7.Click += label7_Click;
            // 
            // dateTime
            // 
            dateTime.Format = DateTimePickerFormat.Short;
            dateTime.Location = new Point(369, 558);
            dateTime.Margin = new Padding(1, 2, 1, 2);
            dateTime.MaxDate = new DateTime(2023, 5, 31, 0, 0, 0, 0);
            dateTime.MinDate = new DateTime(2023, 5, 19, 0, 0, 0, 0);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(255, 27);
            dateTime.TabIndex = 18;
            dateTime.Value = new DateTime(2023, 5, 19, 0, 0, 0, 0);
            dateTime.ValueChanged += dateTime_ValueChanged;
            // 
            // AdicionarBtn
            // 
            AdicionarBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AdicionarBtn.Image = (Image)resources.GetObject("AdicionarBtn.Image");
            AdicionarBtn.Location = new Point(35, 618);
            AdicionarBtn.Margin = new Padding(1, 2, 1, 2);
            AdicionarBtn.Name = "AdicionarBtn";
            AdicionarBtn.Size = new Size(149, 52);
            AdicionarBtn.TabIndex = 19;
            AdicionarBtn.Text = "Adicionar";
            AdicionarBtn.TextAlign = ContentAlignment.MiddleRight;
            AdicionarBtn.UseVisualStyleBackColor = true;
            AdicionarBtn.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-7, 698);
            dataGridView1.Margin = new Padding(1, 2, 1, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1295, 300);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtGenero
            // 
            txtGenero.FormattingEnabled = true;
            txtGenero.Items.AddRange(new object[] { "Masculino", "Feminino" });
            txtGenero.Location = new Point(369, 462);
            txtGenero.Margin = new Padding(1, 2, 1, 2);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(255, 28);
            txtGenero.TabIndex = 21;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.Location = new Point(240, 618);
            btnActualizar.Margin = new Padding(1, 2, 1, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(146, 52);
            btnActualizar.TabIndex = 22;
            btnActualizar.Text = "   Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtAssento
            // 
            txtAssento.Location = new Point(223, 166);
            txtAssento.Margin = new Padding(1, 2, 1, 2);
            txtAssento.Name = "txtAssento";
            txtAssento.Size = new Size(119, 27);
            txtAssento.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(223, 144);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 23;
            label8.Text = "Assento";
            label8.Click += label8_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(411, 166);
            txtID.Margin = new Padding(1, 2, 1, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(133, 27);
            txtID.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(411, 144);
            label9.Margin = new Padding(1, 0, 1, 0);
            label9.Name = "label9";
            label9.Size = new Size(25, 20);
            label9.TabIndex = 25;
            label9.Text = "ID";
            label9.Click += label9_Click;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.Red;
            btnApagar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnApagar.Image = (Image)resources.GetObject("btnApagar.Image");
            btnApagar.Location = new Point(429, 618);
            btnApagar.Margin = new Padding(1, 2, 1, 2);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(149, 52);
            btnApagar.TabIndex = 27;
            btnApagar.Text = "Apagar   ";
            btnApagar.TextAlign = ContentAlignment.MiddleRight;
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // Matricula
            // 
            Matricula.AutoSize = true;
            Matricula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Matricula.Location = new Point(592, 142);
            Matricula.Margin = new Padding(1, 0, 1, 0);
            Matricula.Name = "Matricula";
            Matricula.Size = new Size(75, 20);
            Matricula.TabIndex = 28;
            Matricula.Text = "Matricula";
            Matricula.Click += label10_Click;
            // 
            // btnMapp
            // 
            btnMapp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMapp.Image = (Image)resources.GetObject("btnMapp.Image");
            btnMapp.Location = new Point(830, 618);
            btnMapp.Margin = new Padding(1, 2, 1, 2);
            btnMapp.Name = "btnMapp";
            btnMapp.Size = new Size(241, 52);
            btnMapp.TabIndex = 30;
            btnMapp.Text = "Enviar Ticket por SMS";
            btnMapp.TextAlign = ContentAlignment.MiddleRight;
            btnMapp.UseVisualStyleBackColor = true;
            btnMapp.Click += btnMapp_Click;
            // 
            // txtMatricula
            // 
            txtMatricula.FormattingEnabled = true;
            txtMatricula.Items.AddRange(new object[] { "AGI 692 MP", "DDB 123 MP", "EDF 654 MP", "CMV 852 MP" });
            txtMatricula.Location = new Point(592, 162);
            txtMatricula.Margin = new Padding(1, 2, 1, 2);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(129, 28);
            txtMatricula.TabIndex = 31;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(606, 618);
            button1.Margin = new Padding(1, 2, 1, 2);
            button1.Name = "button1";
            button1.Size = new Size(186, 52);
            button1.TabIndex = 32;
            button1.Text = "   Limpar Campos";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(369, 510);
            txtPhoneNumber.Margin = new Padding(2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(177, 27);
            txtPhoneNumber.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(226, 510);
            label10.Margin = new Padding(1, 0, 1, 0);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 34;
            label10.Text = "Contacto";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(938, 153);
            label11.Margin = new Padding(1, 0, 1, 0);
            label11.Name = "label11";
            label11.Size = new Size(169, 28);
            label11.TabIndex = 35;
            label11.Text = "Estado do Ticket";
            // 
            // button2
            // 
            button2.BackColor = Color.LawnGreen;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(830, 211);
            button2.Margin = new Padding(1, 2, 1, 2);
            button2.Name = "button2";
            button2.Size = new Size(142, 40);
            button2.TabIndex = 36;
            button2.Text = "   Pago";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(1051, 211);
            button3.Margin = new Padding(1, 2, 1, 2);
            button3.Name = "button3";
            button3.Size = new Size(135, 40);
            button3.TabIndex = 37;
            button3.Text = "   Nao Pago";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txtCount
            // 
            txtCount.AutoSize = true;
            txtCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtCount.Location = new Point(1001, 300);
            txtCount.Margin = new Padding(2, 0, 2, 0);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(0, 25);
            txtCount.TabIndex = 38;
            // 
            // txtRestantes
            // 
            txtRestantes.AutoSize = true;
            txtRestantes.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtRestantes.Location = new Point(1001, 350);
            txtRestantes.Margin = new Padding(2, 0, 2, 0);
            txtRestantes.Name = "txtRestantes";
            txtRestantes.Size = new Size(0, 25);
            txtRestantes.TabIndex = 39;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Red;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(830, 304);
            label12.Name = "label12";
            label12.Size = new Size(163, 23);
            label12.TabIndex = 40;
            label12.Text = "Assentos Coupados";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Lime;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(830, 354);
            label13.Name = "label13";
            label13.Size = new Size(130, 23);
            label13.TabIndex = 41;
            label13.Text = "Assentos Livres";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1282, 844);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtRestantes);
            Controls.Add(txtCount);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtPhoneNumber);
            Controls.Add(button1);
            Controls.Add(txtMatricula);
            Controls.Add(btnMapp);
            Controls.Add(Matricula);
            Controls.Add(btnApagar);
            Controls.Add(txtID);
            Controls.Add(label9);
            Controls.Add(txtAssento);
            Controls.Add(label8);
            Controls.Add(btnActualizar);
            Controls.Add(txtGenero);
            Controls.Add(dataGridView1);
            Controls.Add(AdicionarBtn);
            Controls.Add(dateTime);
            Controls.Add(label7);
            Controls.Add(txtRota);
            Controls.Add(label6);
            Controls.Add(txtCondicaoEspecial);
            Controls.Add(txtPartida);
            Controls.Add(txtDestino);
            Controls.Add(txtNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1, 2, 1, 2);
            MaximumSize = new Size(1300, 1000);
            MinimumSize = new Size(1022, 566);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNome;
        private TextBox txtDestino;
        private TextBox txtPartida;
        private ComboBox txtCondicaoEspecial;
        private Label label6;
        private ComboBox txtRota;
        private Label label7;
        private DateTimePicker dateTime;
        private Button AdicionarBtn;
        private DataGridView dataGridView1;
        private ComboBox txtGenero;
        private Button btnActualizar;
        private TextBox txtAssento;
        private Label label8;
        private TextBox txtID;
        private Label label9;
        private Button btnApagar;
        private Label Matricula;
        private Button btnMapp;
        private ComboBox txtMatricula;
        private Button button1;
        private TextBox txtPhoneNumber;
        private Label label10;
        private Label label11;
        private Button button2;
        private Button button3;
        private Label txtCount;
        private Label txtRestantes;
        private Label label12;
        private Label label13;
    }
}