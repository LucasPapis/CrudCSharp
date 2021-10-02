
namespace CrudEvento.Telas
{
    partial class frmInstituicoes
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
            this.btnAlterarI = new System.Windows.Forms.Button();
            this.btnExcluirI = new System.Windows.Forms.Button();
            this.btnCadastrarI = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeI = new System.Windows.Forms.TextBox();
            this.dgvInst = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInst)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterarI
            // 
            this.btnAlterarI.Location = new System.Drawing.Point(229, 91);
            this.btnAlterarI.Name = "btnAlterarI";
            this.btnAlterarI.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarI.TabIndex = 14;
            this.btnAlterarI.Text = "Alterar";
            this.btnAlterarI.UseVisualStyleBackColor = true;
            this.btnAlterarI.Click += new System.EventHandler(this.btnAlterarI_Click);
            // 
            // btnExcluirI
            // 
            this.btnExcluirI.Location = new System.Drawing.Point(229, 174);
            this.btnExcluirI.Name = "btnExcluirI";
            this.btnExcluirI.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirI.TabIndex = 13;
            this.btnExcluirI.Text = "Excluir";
            this.btnExcluirI.UseVisualStyleBackColor = true;
            this.btnExcluirI.Click += new System.EventHandler(this.btnExcluirI_Click);
            // 
            // btnCadastrarI
            // 
            this.btnCadastrarI.Location = new System.Drawing.Point(229, 21);
            this.btnCadastrarI.Name = "btnCadastrarI";
            this.btnCadastrarI.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarI.TabIndex = 12;
            this.btnCadastrarI.Text = "Cadastrar";
            this.btnCadastrarI.UseVisualStyleBackColor = true;
            this.btnCadastrarI.Click += new System.EventHandler(this.btnCadastrarI_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdI);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtUf);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNomeI);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 185);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da instituição";
            // 
            // txtIdI
            // 
            this.txtIdI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdI.Location = new System.Drawing.Point(118, 150);
            this.txtIdI.Name = "txtIdI";
            this.txtIdI.Size = new System.Drawing.Size(65, 21);
            this.txtIdI.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID:";
            // 
            // txtUf
            // 
            this.txtUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUf.Location = new System.Drawing.Point(6, 150);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(52, 21);
            this.txtUf.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "UF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(6, 98);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(177, 21);
            this.txtCidade.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome da instituição:";
            // 
            // txtNomeI
            // 
            this.txtNomeI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeI.Location = new System.Drawing.Point(6, 49);
            this.txtNomeI.Name = "txtNomeI";
            this.txtNomeI.Size = new System.Drawing.Size(177, 21);
            this.txtNomeI.TabIndex = 2;
            // 
            // dgvInst
            // 
            this.dgvInst.AllowUserToAddRows = false;
            this.dgvInst.AllowUserToDeleteRows = false;
            this.dgvInst.AllowUserToResizeColumns = false;
            this.dgvInst.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvInst.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInst.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInst.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInst.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInst.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInst.Location = new System.Drawing.Point(12, 216);
            this.dgvInst.MultiSelect = false;
            this.dgvInst.Name = "dgvInst";
            this.dgvInst.ReadOnly = true;
            this.dgvInst.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvInst.RowHeadersVisible = false;
            this.dgvInst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInst.Size = new System.Drawing.Size(533, 233);
            this.dgvInst.TabIndex = 10;
            this.dgvInst.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInst_RowEnter);
            // 
            // frmInstituicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 457);
            this.Controls.Add(this.btnAlterarI);
            this.Controls.Add(this.btnExcluirI);
            this.Controls.Add(this.btnCadastrarI);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvInst);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInstituicoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Instituições";
            this.Load += new System.EventHandler(this.frmInstituicoes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlterarI;
        private System.Windows.Forms.Button btnExcluirI;
        private System.Windows.Forms.Button btnCadastrarI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeI;
        private System.Windows.Forms.DataGridView dgvInst;
    }
}