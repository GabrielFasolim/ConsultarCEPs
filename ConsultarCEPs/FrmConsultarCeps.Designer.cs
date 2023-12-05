namespace ConsultarCEPs
{
    partial class FrmConsultarCeps
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
            label1 = new Label();
            txtCEP = new TextBox();
            label2 = new Label();
            Resultado = new GroupBox();
            btnSair = new Button();
            btnLimpar = new Button();
            txtRua = new TextBox();
            label7 = new Label();
            txtBairro = new TextBox();
            label6 = new Label();
            txtCidade = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtEstado = new TextBox();
            label3 = new Label();
            btnConsultar = new Button();
            Resultado.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "CEP:";
            label1.Click += label1_Click;
            // 
            // txtCEP
            // 
            txtCEP.BackColor = SystemColors.Info;
            txtCEP.Location = new Point(25, 48);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(148, 23);
            txtCEP.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 203);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // Resultado
            // 
            Resultado.Controls.Add(btnSair);
            Resultado.Controls.Add(btnLimpar);
            Resultado.Controls.Add(txtRua);
            Resultado.Controls.Add(label7);
            Resultado.Controls.Add(txtBairro);
            Resultado.Controls.Add(label6);
            Resultado.Controls.Add(txtCidade);
            Resultado.Controls.Add(label5);
            Resultado.Controls.Add(label4);
            Resultado.Controls.Add(txtEstado);
            Resultado.Controls.Add(label3);
            Resultado.Location = new Point(25, 117);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(529, 292);
            Resultado.TabIndex = 3;
            Resultado.TabStop = false;
            Resultado.Text = "Resultado";
            // 
            // btnSair
            // 
            btnSair.Location = new Point(409, 234);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(99, 36);
            btnSair.TabIndex = 13;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += button3_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(288, 234);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(90, 36);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtRua
            // 
            txtRua.BackColor = SystemColors.ControlLight;
            txtRua.Location = new Point(6, 205);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(503, 23);
            txtRua.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 187);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 11;
            label7.Text = "Rua";
            // 
            // txtBairro
            // 
            txtBairro.BackColor = SystemColors.ControlLight;
            txtBairro.Location = new Point(6, 157);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(503, 23);
            txtBairro.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 139);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 9;
            label6.Text = "Bairro";
            // 
            // txtCidade
            // 
            txtCidade.BackColor = SystemColors.ControlLight;
            txtCidade.Location = new Point(6, 104);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(503, 23);
            txtCidade.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 86);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 7;
            label5.Text = "Cidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 139);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 6;
            // 
            // txtEstado
            // 
            txtEstado.BackColor = SystemColors.ControlLight;
            txtEstado.Location = new Point(6, 56);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(503, 23);
            txtEstado.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 38);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Estado";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(322, 24);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(232, 68);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // FrmConsultarCeps
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 421);
            Controls.Add(btnConsultar);
            Controls.Add(Resultado);
            Controls.Add(label2);
            Controls.Add(txtCEP);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConsultarCeps";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar CEPs";
            Resultado.ResumeLayout(false);
            Resultado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCEP;
        private Label label2;
        private GroupBox Resultado;
        private TextBox txtRua;
        private Label label7;
        private TextBox txtBairro;
        private Label label6;
        private TextBox txtCidade;
        private Label label5;
        private Label label4;
        private TextBox txtEstado;
        private Label label3;
        private Button btnSair;
        private Button btnLimpar;
        private Button btnConsultar;
    }
}
