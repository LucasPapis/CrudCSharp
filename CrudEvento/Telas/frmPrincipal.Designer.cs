﻿
namespace CrudEvento
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instituiçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventosToolStripMenuItem,
            this.instituiçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarToolStripMenuItem});
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.eventosToolStripMenuItem.Text = "Eventos";
            // 
            // gerenciarToolStripMenuItem
            // 
            this.gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            this.gerenciarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerenciarToolStripMenuItem.Text = "Gerenciar";
            this.gerenciarToolStripMenuItem.Click += new System.EventHandler(this.gerenciarToolStripMenuItem_Click);
            // 
            // instituiçõesToolStripMenuItem
            // 
            this.instituiçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarToolStripMenuItem1});
            this.instituiçõesToolStripMenuItem.Name = "instituiçõesToolStripMenuItem";
            this.instituiçõesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.instituiçõesToolStripMenuItem.Text = "Instituições";
            // 
            // gerenciarToolStripMenuItem1
            // 
            this.gerenciarToolStripMenuItem1.Name = "gerenciarToolStripMenuItem1";
            this.gerenciarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.gerenciarToolStripMenuItem1.Text = "Gerenciar";
            this.gerenciarToolStripMenuItem1.Click += new System.EventHandler(this.gerenciarToolStripMenuItem1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instituiçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem1;
    }
}
