
namespace HowIII
{
    partial class Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.label1 = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLuxuoso = new System.Windows.Forms.RadioButton();
            this.rbCompleto = new System.Windows.Forms.RadioButton();
            this.rbBasico = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgPrincipal = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbModelo
            // 
            resources.ApplyResources(this.tbModelo, "tbModelo");
            this.tbModelo.Name = "tbModelo";
            // 
            // tbAno
            // 
            resources.ApplyResources(this.tbAno, "tbAno");
            this.tbAno.Name = "tbAno";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tbPreco
            // 
            resources.ApplyResources(this.tbPreco, "tbPreco");
            this.tbPreco.Name = "tbPreco";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tbMarca
            // 
            resources.ApplyResources(this.tbMarca, "tbMarca");
            this.tbMarca.Name = "tbMarca";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tbDescricao
            // 
            resources.ApplyResources(this.tbDescricao, "tbDescricao");
            this.tbDescricao.Name = "tbDescricao";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.rbLuxuoso);
            this.groupBox1.Controls.Add(this.rbCompleto);
            this.groupBox1.Controls.Add(this.rbBasico);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // rbLuxuoso
            // 
            resources.ApplyResources(this.rbLuxuoso, "rbLuxuoso");
            this.rbLuxuoso.Name = "rbLuxuoso";
            this.rbLuxuoso.TabStop = true;
            this.rbLuxuoso.UseVisualStyleBackColor = true;
            this.rbLuxuoso.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbCompleto
            // 
            resources.ApplyResources(this.rbCompleto, "rbCompleto");
            this.rbCompleto.Name = "rbCompleto";
            this.rbCompleto.TabStop = true;
            this.rbCompleto.UseVisualStyleBackColor = true;
            this.rbCompleto.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbBasico
            // 
            resources.ApplyResources(this.rbBasico, "rbBasico");
            this.rbBasico.Name = "rbBasico";
            this.rbBasico.TabStop = true;
            this.rbBasico.UseVisualStyleBackColor = true;
            this.rbBasico.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // cbCor
            // 
            resources.ApplyResources(this.cbCor, "cbCor");
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Items.AddRange(new object[] {
            resources.GetString("cbCor.Items"),
            resources.GetString("cbCor.Items1"),
            resources.GetString("cbCor.Items2"),
            resources.GetString("cbCor.Items3"),
            resources.GetString("cbCor.Items4"),
            resources.GetString("cbCor.Items5"),
            resources.GetString("cbCor.Items6"),
            resources.GetString("cbCor.Items7")});
            this.cbCor.Name = "cbCor";
            // 
            // btnExcluir
            // 
            resources.ApplyResources(this.btnExcluir, "btnExcluir");
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            resources.ApplyResources(this.btnAlterar, "btnAlterar");
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dgPrincipal
            // 
            resources.ApplyResources(this.dgPrincipal, "dgPrincipal");
            this.dgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colModelo,
            this.colAno,
            this.colTipo,
            this.colPreco,
            this.colMarca,
            this.colCor,
            this.colDescricao});
            this.dgPrincipal.Name = "dgPrincipal";
            this.dgPrincipal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPrincipal_CellDoubleClick);
            // 
            // colId
            // 
            resources.ApplyResources(this.colId, "colId");
            this.colId.Name = "colId";
            // 
            // colModelo
            // 
            resources.ApplyResources(this.colModelo, "colModelo");
            this.colModelo.Name = "colModelo";
            // 
            // colAno
            // 
            resources.ApplyResources(this.colAno, "colAno");
            this.colAno.Name = "colAno";
            // 
            // colTipo
            // 
            resources.ApplyResources(this.colTipo, "colTipo");
            this.colTipo.Name = "colTipo";
            // 
            // colPreco
            // 
            resources.ApplyResources(this.colPreco, "colPreco");
            this.colPreco.Name = "colPreco";
            // 
            // colMarca
            // 
            resources.ApplyResources(this.colMarca, "colMarca");
            this.colMarca.Name = "colMarca";
            // 
            // colCor
            // 
            resources.ApplyResources(this.colCor, "colCor");
            this.colCor.Name = "colCor";
            // 
            // colDescricao
            // 
            resources.ApplyResources(this.colDescricao, "colDescricao");
            this.colDescricao.Name = "colDescricao";
            // 
            // btnInserir
            // 
            resources.ApplyResources(this.btnInserir, "btnInserir");
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnLimpar
            // 
            resources.ApplyResources(this.btnLimpar, "btnLimpar");
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tbId
            // 
            resources.ApplyResources(this.tbId, "tbId");
            this.tbId.Name = "tbId";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // Formulario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dgPrincipal);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.cbCor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPreco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLuxuoso;
        private System.Windows.Forms.RadioButton rbCompleto;
        private System.Windows.Forms.RadioButton rbBasico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dgPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label7;
    }
}

