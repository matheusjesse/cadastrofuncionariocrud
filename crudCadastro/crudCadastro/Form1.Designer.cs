namespace crudCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_novo = new System.Windows.Forms.ToolStripButton();
            this.tsb_salvar = new System.Windows.Forms.ToolStripButton();
            this.tsb_editar = new System.Windows.Forms.ToolStripButton();
            this.tsb_cancelar = new System.Windows.Forms.ToolStripButton();
            this.tsb_apagar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tst_buscarId = new System.Windows.Forms.ToolStripTextBox();
            this.tsb_buscar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_uf = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.msk_rg = new System.Windows.Forms.MaskedTextBox();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.msk_cep = new System.Windows.Forms.MaskedTextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_novo,
            this.tsb_cancelar,
            this.tsb_salvar,
            this.tsb_editar,
            this.tsb_apagar,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tst_buscarId,
            this.tsb_buscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(426, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_novo
            // 
            this.tsb_novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_novo.Image = ((System.Drawing.Image)(resources.GetObject("tsb_novo.Image")));
            this.tsb_novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_novo.Name = "tsb_novo";
            this.tsb_novo.Size = new System.Drawing.Size(23, 22);
            this.tsb_novo.Text = "NOVO";
            this.tsb_novo.Click += new System.EventHandler(this.tsb_novo_Click);
            // 
            // tsb_salvar
            // 
            this.tsb_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_salvar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_salvar.Image")));
            this.tsb_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_salvar.Name = "tsb_salvar";
            this.tsb_salvar.Size = new System.Drawing.Size(23, 22);
            this.tsb_salvar.Text = "SALVAR";
            this.tsb_salvar.Click += new System.EventHandler(this.tsb_salvar_Click);
            // 
            // tsb_editar
            // 
            this.tsb_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_editar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_editar.Image")));
            this.tsb_editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_editar.Name = "tsb_editar";
            this.tsb_editar.Size = new System.Drawing.Size(23, 22);
            this.tsb_editar.Text = "EDITAR";
            this.tsb_editar.Click += new System.EventHandler(this.tsb_editar_Click);
            // 
            // tsb_cancelar
            // 
            this.tsb_cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_cancelar.Image")));
            this.tsb_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_cancelar.Name = "tsb_cancelar";
            this.tsb_cancelar.Size = new System.Drawing.Size(23, 22);
            this.tsb_cancelar.Text = "CANCELAR";
            this.tsb_cancelar.Click += new System.EventHandler(this.tsb_cancelar_Click);
            // 
            // tsb_apagar
            // 
            this.tsb_apagar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_apagar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_apagar.Image")));
            this.tsb_apagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_apagar.Name = "tsb_apagar";
            this.tsb_apagar.Size = new System.Drawing.Size(23, 22);
            this.tsb_apagar.Text = "APAGAR";
            this.tsb_apagar.Click += new System.EventHandler(this.tsb_apagar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel1.Text = "Buscar Id:";
            // 
            // tst_buscarId
            // 
            this.tst_buscarId.Name = "tst_buscarId";
            this.tst_buscarId.Size = new System.Drawing.Size(100, 25);
            // 
            // tsb_buscar
            // 
            this.tsb_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_buscar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_buscar.Image")));
            this.tsb_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_buscar.Name = "tsb_buscar";
            this.tsb_buscar.Size = new System.Drawing.Size(23, 22);
            this.tsb_buscar.Text = "BUSCAR";
            this.tsb_buscar.Click += new System.EventHandler(this.tsb_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "CEP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rua";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(184, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "UF";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(15, 54);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(55, 20);
            this.txt_id.TabIndex = 9;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(76, 54);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(339, 20);
            this.txt_nome.TabIndex = 10;
            // 
            // txt_uf
            // 
            this.txt_uf.Location = new System.Drawing.Point(182, 177);
            this.txt_uf.Name = "txt_uf";
            this.txt_uf.Size = new System.Drawing.Size(51, 20);
            this.txt_uf.TabIndex = 14;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(15, 218);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(218, 20);
            this.txt_bairro.TabIndex = 15;
            // 
            // txt_rua
            // 
            this.txt_rua.Location = new System.Drawing.Point(15, 259);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(266, 20);
            this.txt_rua.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "RG";
            // 
            // msk_rg
            // 
            this.msk_rg.Location = new System.Drawing.Point(111, 95);
            this.msk_rg.Mask = "00.000.000-0";
            this.msk_rg.Name = "msk_rg";
            this.msk_rg.Size = new System.Drawing.Size(100, 20);
            this.msk_rg.TabIndex = 18;
            // 
            // msk_cpf
            // 
            this.msk_cpf.Location = new System.Drawing.Point(15, 95);
            this.msk_cpf.Mask = "000.000.000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(90, 20);
            this.msk_cpf.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(214, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "E-mail";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(217, 95);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(197, 20);
            this.txt_email.TabIndex = 22;
            // 
            // msk_cep
            // 
            this.msk_cep.Location = new System.Drawing.Point(15, 136);
            this.msk_cep.Mask = "00000-000";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(90, 20);
            this.msk_cep.TabIndex = 23;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(15, 177);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(161, 20);
            this.txt_cidade.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 311);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.msk_cep);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.msk_cpf);
            this.Controls.Add(this.msk_rg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.txt_uf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_novo;
        private System.Windows.Forms.ToolStripButton tsb_salvar;
        private System.Windows.Forms.ToolStripButton tsb_editar;
        private System.Windows.Forms.ToolStripButton tsb_cancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tst_buscarId;
        private System.Windows.Forms.ToolStripButton tsb_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_uf;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox msk_rg;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.MaskedTextBox msk_cep;
        private System.Windows.Forms.ToolStripButton tsb_apagar;
        private System.Windows.Forms.TextBox txt_cidade;
    }
}

