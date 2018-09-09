namespace AplicacionBusqueda
{
    partial class Principal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_indexer = new System.Windows.Forms.TabPage();
            this.tab_buscador = new System.Windows.Forms.TabPage();
            this.tab_inspector = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_indexer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_indexer);
            this.tabControl1.Controls.Add(this.tab_buscador);
            this.tabControl1.Controls.Add(this.tab_inspector);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(751, 527);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_indexer
            // 
            this.tab_indexer.Controls.Add(this.button3);
            this.tab_indexer.Controls.Add(this.button2);
            this.tab_indexer.Controls.Add(this.button1);
            this.tab_indexer.Controls.Add(this.label2);
            this.tab_indexer.Controls.Add(this.label1);
            this.tab_indexer.Location = new System.Drawing.Point(4, 22);
            this.tab_indexer.Name = "tab_indexer";
            this.tab_indexer.Padding = new System.Windows.Forms.Padding(3);
            this.tab_indexer.Size = new System.Drawing.Size(743, 501);
            this.tab_indexer.TabIndex = 0;
            this.tab_indexer.Text = "Indexer";
            this.tab_indexer.UseVisualStyleBackColor = true;
            // 
            // tab_buscador
            // 
            this.tab_buscador.Location = new System.Drawing.Point(4, 22);
            this.tab_buscador.Name = "tab_buscador";
            this.tab_buscador.Padding = new System.Windows.Forms.Padding(3);
            this.tab_buscador.Size = new System.Drawing.Size(743, 501);
            this.tab_buscador.TabIndex = 1;
            this.tab_buscador.Text = "Buscador";
            this.tab_buscador.UseVisualStyleBackColor = true;
            // 
            // tab_inspector
            // 
            this.tab_inspector.Location = new System.Drawing.Point(4, 22);
            this.tab_inspector.Name = "tab_inspector";
            this.tab_inspector.Size = new System.Drawing.Size(743, 501);
            this.tab_inspector.TabIndex = 2;
            this.tab_inspector.Text = "Inspector";
            this.tab_inspector.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stopwords";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Colección";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "...";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(53, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "Indexar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 551);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Principal";
            this.Text = "Herramientas de Busqueda";
            this.tabControl1.ResumeLayout(false);
            this.tab_indexer.ResumeLayout(false);
            this.tab_indexer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_indexer;
        private System.Windows.Forms.TabPage tab_buscador;
        private System.Windows.Forms.TabPage tab_inspector;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}

