namespace Loja_de_Discos
{
    partial class Form2
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
            this.nomeform = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtLoginn = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtviewusuario = new System.Windows.Forms.DataGridView();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtviewusuario)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeform
            // 
            this.nomeform.AutoSize = true;
            this.nomeform.Location = new System.Drawing.Point(570, 87);
            this.nomeform.MaximumSize = new System.Drawing.Size(80, 36);
            this.nomeform.Name = "nomeform";
            this.nomeform.Size = new System.Drawing.Size(66, 13);
            this.nomeform.TabIndex = 0;
            this.nomeform.Text = "CADASTRO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 138);
            this.label1.MaximumSize = new System.Drawing.Size(80, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 190);
            this.label2.MaximumSize = new System.Drawing.Size(80, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "EMAIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 164);
            this.label3.MaximumSize = new System.Drawing.Size(80, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SENHA";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(516, 135);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(180, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtLoginn
            // 
            this.txtLoginn.Location = new System.Drawing.Point(516, 213);
            this.txtLoginn.Name = "txtLoginn";
            this.txtLoginn.Size = new System.Drawing.Size(180, 20);
            this.txtLoginn.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(516, 161);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(180, 20);
            this.txtSenha.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "CADASTRE-SE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(516, 187);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtLogin
            // 
            this.txtLogin.AutoSize = true;
            this.txtLogin.Location = new System.Drawing.Point(459, 216);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(40, 13);
            this.txtLogin.TabIndex = 8;
            this.txtLogin.Text = "LOGIN";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(516, 239);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(800, 115);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(448, 205);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtviewusuario);
            this.tabPage1.Controls.Add(this.Pesquisar);
            this.tabPage1.Controls.Add(this.txtPesquisar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(440, 179);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "pesquisa";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dtviewusuario
            // 
            this.dtviewusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtviewusuario.Location = new System.Drawing.Point(6, 40);
            this.dtviewusuario.Name = "dtviewusuario";
            this.dtviewusuario.Size = new System.Drawing.Size(431, 143);
            this.dtviewusuario.TabIndex = 2;
            // 
            // Pesquisar
            // 
            this.Pesquisar.Location = new System.Drawing.Point(112, 8);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.Pesquisar.TabIndex = 1;
            this.Pesquisar.Text = "pesquisar";
            this.Pesquisar.UseVisualStyleBackColor = true;
            this.Pesquisar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(6, 10);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisar.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(440, 179);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "dados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 33);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(431, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1041);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLoginn);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeform);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtviewusuario)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtLoginn;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label txtLogin;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtviewusuario;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}