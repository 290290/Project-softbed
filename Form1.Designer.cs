namespace Parte1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.ComboEC = new System.Windows.Forms.ComboBox();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.checkcasa = new System.Windows.Forms.CheckBox();
            this.checkcarro = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioO = new System.Windows.Forms.RadioButton();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.lista = new System.Windows.Forms.ListBox();
            this.CadastrarBTN = new System.Windows.Forms.Button();
            this.ExcluirBTN = new System.Windows.Forms.Button();
            this.LimparBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboQuarto = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.InserirDatas = new System.Windows.Forms.Button();
            this.Qtdias = new System.Windows.Forms.TextBox();
            this.DataCheckOut = new System.Windows.Forms.DateTimePicker();
            this.DataCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado Civil:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(126, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(220, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(126, 47);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(220, 20);
            this.txtData.TabIndex = 5;
            // 
            // ComboEC
            // 
            this.ComboEC.FormattingEnabled = true;
            this.ComboEC.Location = new System.Drawing.Point(126, 85);
            this.ComboEC.Name = "ComboEC";
            this.ComboEC.Size = new System.Drawing.Size(220, 21);
            this.ComboEC.TabIndex = 6;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(126, 123);
            this.txttelefone.Mask = "(00)00000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(220, 20);
            this.txttelefone.TabIndex = 7;
            this.txttelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Txttelefone_MaskInputRejected);
            // 
            // checkcasa
            // 
            this.checkcasa.AutoSize = true;
            this.checkcasa.Location = new System.Drawing.Point(126, 211);
            this.checkcasa.Name = "checkcasa";
            this.checkcasa.Size = new System.Drawing.Size(124, 17);
            this.checkcasa.TabIndex = 8;
            this.checkcasa.Text = "Possui casa propria?";
            this.checkcasa.UseVisualStyleBackColor = true;
            // 
            // checkcarro
            // 
            this.checkcarro.AutoSize = true;
            this.checkcarro.Location = new System.Drawing.Point(126, 234);
            this.checkcarro.Name = "checkcarro";
            this.checkcarro.Size = new System.Drawing.Size(138, 17);
            this.checkcarro.TabIndex = 9;
            this.checkcarro.Text = "Possui Veículo proprio?";
            this.checkcarro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioO);
            this.groupBox1.Controls.Add(this.radioF);
            this.groupBox1.Controls.Add(this.radioM);
            this.groupBox1.Location = new System.Drawing.Point(112, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radioO
            // 
            this.radioO.AutoSize = true;
            this.radioO.Location = new System.Drawing.Point(16, 66);
            this.radioO.Name = "radioO";
            this.radioO.Size = new System.Drawing.Size(51, 17);
            this.radioO.TabIndex = 2;
            this.radioO.TabStop = true;
            this.radioO.Text = "Outro";
            this.radioO.UseVisualStyleBackColor = true;
            this.radioO.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Location = new System.Drawing.Point(16, 42);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(67, 17);
            this.radioF.TabIndex = 1;
            this.radioF.TabStop = true;
            this.radioF.Text = "Feminino";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Checked = true;
            this.radioM.Location = new System.Drawing.Point(16, 19);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(73, 17);
            this.radioM.TabIndex = 0;
            this.radioM.TabStop = true;
            this.radioM.Text = "Masculino";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(12, 431);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(704, 108);
            this.lista.TabIndex = 11;
            this.lista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Lista_MouseDoubleClick);
            // 
            // CadastrarBTN
            // 
            this.CadastrarBTN.Location = new System.Drawing.Point(16, 373);
            this.CadastrarBTN.Name = "CadastrarBTN";
            this.CadastrarBTN.Size = new System.Drawing.Size(140, 41);
            this.CadastrarBTN.TabIndex = 12;
            this.CadastrarBTN.Text = "Cadastrar/Alterar";
            this.CadastrarBTN.UseVisualStyleBackColor = true;
            this.CadastrarBTN.Click += new System.EventHandler(this.CadastrarBTN_Click);
            // 
            // ExcluirBTN
            // 
            this.ExcluirBTN.Location = new System.Drawing.Point(225, 373);
            this.ExcluirBTN.Name = "ExcluirBTN";
            this.ExcluirBTN.Size = new System.Drawing.Size(151, 41);
            this.ExcluirBTN.TabIndex = 13;
            this.ExcluirBTN.Text = "Excluir";
            this.ExcluirBTN.UseVisualStyleBackColor = true;
            this.ExcluirBTN.Click += new System.EventHandler(this.ExcluirBTN_Click);
            // 
            // LimparBTN
            // 
            this.LimparBTN.Location = new System.Drawing.Point(452, 373);
            this.LimparBTN.Name = "LimparBTN";
            this.LimparBTN.Size = new System.Drawing.Size(156, 41);
            this.LimparBTN.TabIndex = 14;
            this.LimparBTN.Text = "Limpar";
            this.LimparBTN.UseVisualStyleBackColor = true;
            this.LimparBTN.Click += new System.EventHandler(this.LimparBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quartos Disponíveis:";
            // 
            // comboQuarto
            // 
            this.comboQuarto.FormattingEnabled = true;
            this.comboQuarto.Items.AddRange(new object[] {
            "Quarto de Solteiro",
            "Quarto Duplo ",
            "Suíte"});
            this.comboQuarto.Location = new System.Drawing.Point(514, 9);
            this.comboQuarto.Name = "comboQuarto";
            this.comboQuarto.Size = new System.Drawing.Size(235, 21);
            this.comboQuarto.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.InserirDatas);
            this.groupBox2.Controls.Add(this.Qtdias);
            this.groupBox2.Controls.Add(this.DataCheckOut);
            this.groupBox2.Controls.Add(this.DataCheckIn);
            this.groupBox2.Location = new System.Drawing.Point(382, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 156);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data de Viagem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Total de Dias:";
            // 
            // InserirDatas
            // 
            this.InserirDatas.Location = new System.Drawing.Point(242, 16);
            this.InserirDatas.Name = "InserirDatas";
            this.InserirDatas.Size = new System.Drawing.Size(220, 62);
            this.InserirDatas.TabIndex = 20;
            this.InserirDatas.Text = "Inserir";
            this.InserirDatas.UseVisualStyleBackColor = true;
            this.InserirDatas.Click += new System.EventHandler(this.InserirDatas_Click);
            // 
            // Qtdias
            // 
            this.Qtdias.Location = new System.Drawing.Point(6, 113);
            this.Qtdias.Name = "Qtdias";
            this.Qtdias.Size = new System.Drawing.Size(220, 20);
            this.Qtdias.TabIndex = 18;
            // 
            // DataCheckOut
            // 
            this.DataCheckOut.Location = new System.Drawing.Point(6, 58);
            this.DataCheckOut.Name = "DataCheckOut";
            this.DataCheckOut.Size = new System.Drawing.Size(220, 20);
            this.DataCheckOut.TabIndex = 19;
            // 
            // DataCheckIn
            // 
            this.DataCheckIn.Location = new System.Drawing.Point(6, 19);
            this.DataCheckIn.Name = "DataCheckIn";
            this.DataCheckIn.Size = new System.Drawing.Size(220, 20);
            this.DataCheckIn.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "CPF:";
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(126, 157);
            this.txtcpf.Mask = "000.000.000/00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(220, 20);
            this.txtcpf.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 551);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboQuarto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LimparBTN);
            this.Controls.Add(this.ExcluirBTN);
            this.Controls.Add(this.CadastrarBTN);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkcarro);
            this.Controls.Add(this.checkcasa);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.ComboEC);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Soft-Bed";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.ComboBox ComboEC;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.CheckBox checkcasa;
        private System.Windows.Forms.CheckBox checkcarro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioO;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button CadastrarBTN;
        private System.Windows.Forms.Button ExcluirBTN;
        private System.Windows.Forms.Button LimparBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboQuarto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Qtdias;
        private System.Windows.Forms.DateTimePicker DataCheckOut;
        private System.Windows.Forms.DateTimePicker DataCheckIn;
        private System.Windows.Forms.Button InserirDatas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtcpf;
    }
}

