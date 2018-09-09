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
            this.btn_indexar = new System.Windows.Forms.Button();
            this.btn_coleccion = new System.Windows.Forms.Button();
            this.btn_stopwords = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_buscador = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.entrada_consulta = new System.Windows.Forms.TextBox();
            this.tab_inspector = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.rbtn_vec = new System.Windows.Forms.RadioButton();
            this.rbtn_bm25 = new System.Windows.Forms.RadioButton();
            this.btn_indice = new System.Windows.Forms.Button();
            this.btn_escalafon = new System.Windows.Forms.Button();
            this.btn_html = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_consultar_doc = new System.Windows.Forms.Button();
            this.btn_consultar_term = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tab_indexer.SuspendLayout();
            this.tab_buscador.SuspendLayout();
            this.tab_inspector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tab_indexer.Controls.Add(this.btn_indexar);
            this.tab_indexer.Controls.Add(this.btn_coleccion);
            this.tab_indexer.Controls.Add(this.btn_stopwords);
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
            // btn_indexar
            // 
            this.btn_indexar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_indexar.Location = new System.Drawing.Point(53, 119);
            this.btn_indexar.Name = "btn_indexar";
            this.btn_indexar.Size = new System.Drawing.Size(110, 44);
            this.btn_indexar.TabIndex = 4;
            this.btn_indexar.Text = "Indexar";
            this.btn_indexar.UseVisualStyleBackColor = true;
            // 
            // btn_coleccion
            // 
            this.btn_coleccion.Location = new System.Drawing.Point(146, 68);
            this.btn_coleccion.Name = "btn_coleccion";
            this.btn_coleccion.Size = new System.Drawing.Size(32, 23);
            this.btn_coleccion.TabIndex = 3;
            this.btn_coleccion.Text = "...";
            this.btn_coleccion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_coleccion.UseVisualStyleBackColor = true;
            this.btn_coleccion.Click += new System.EventHandler(this.btn_coleccion_Click);
            // 
            // btn_stopwords
            // 
            this.btn_stopwords.Location = new System.Drawing.Point(146, 19);
            this.btn_stopwords.Name = "btn_stopwords";
            this.btn_stopwords.Size = new System.Drawing.Size(32, 23);
            this.btn_stopwords.TabIndex = 2;
            this.btn_stopwords.Text = "...";
            this.btn_stopwords.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_stopwords.UseVisualStyleBackColor = true;
            this.btn_stopwords.Click += new System.EventHandler(this.btn_stopwords_Click);
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
            // tab_buscador
            // 
            this.tab_buscador.Controls.Add(this.textBox3);
            this.tab_buscador.Controls.Add(this.btn_html);
            this.tab_buscador.Controls.Add(this.btn_escalafon);
            this.tab_buscador.Controls.Add(this.btn_indice);
            this.tab_buscador.Controls.Add(this.rbtn_bm25);
            this.tab_buscador.Controls.Add(this.rbtn_vec);
            this.tab_buscador.Controls.Add(this.label8);
            this.tab_buscador.Controls.Add(this.label7);
            this.tab_buscador.Controls.Add(this.label6);
            this.tab_buscador.Controls.Add(this.label5);
            this.tab_buscador.Controls.Add(this.label4);
            this.tab_buscador.Controls.Add(this.label3);
            this.tab_buscador.Controls.Add(this.entrada_consulta);
            this.tab_buscador.Location = new System.Drawing.Point(4, 22);
            this.tab_buscador.Name = "tab_buscador";
            this.tab_buscador.Padding = new System.Windows.Forms.Padding(3);
            this.tab_buscador.Size = new System.Drawing.Size(743, 501);
            this.tab_buscador.TabIndex = 1;
            this.tab_buscador.Text = "Buscador";
            this.tab_buscador.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "HTML";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Escalafón";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Número Documentos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Índice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Modalidad:";
            // 
            // entrada_consulta
            // 
            this.entrada_consulta.Location = new System.Drawing.Point(90, 20);
            this.entrada_consulta.Name = "entrada_consulta";
            this.entrada_consulta.Size = new System.Drawing.Size(366, 20);
            this.entrada_consulta.TabIndex = 0;
            // 
            // tab_inspector
            // 
            this.tab_inspector.Controls.Add(this.btn_consultar_term);
            this.tab_inspector.Controls.Add(this.btn_consultar_doc);
            this.tab_inspector.Controls.Add(this.textBox2);
            this.tab_inspector.Controls.Add(this.textBox1);
            this.tab_inspector.Controls.Add(this.label10);
            this.tab_inspector.Controls.Add(this.label9);
            this.tab_inspector.Controls.Add(this.dataGridView1);
            this.tab_inspector.Location = new System.Drawing.Point(4, 22);
            this.tab_inspector.Name = "tab_inspector";
            this.tab_inspector.Size = new System.Drawing.Size(743, 501);
            this.tab_inspector.TabIndex = 2;
            this.tab_inspector.Text = "Inspector";
            this.tab_inspector.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Consulta";
            // 
            // rbtn_vec
            // 
            this.rbtn_vec.AutoSize = true;
            this.rbtn_vec.Location = new System.Drawing.Point(161, 62);
            this.rbtn_vec.Name = "rbtn_vec";
            this.rbtn_vec.Size = new System.Drawing.Size(66, 17);
            this.rbtn_vec.TabIndex = 7;
            this.rbtn_vec.TabStop = true;
            this.rbtn_vec.Text = "Vectorial";
            this.rbtn_vec.UseVisualStyleBackColor = true;
            this.rbtn_vec.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtn_bm25
            // 
            this.rbtn_bm25.AutoSize = true;
            this.rbtn_bm25.Location = new System.Drawing.Point(233, 62);
            this.rbtn_bm25.Name = "rbtn_bm25";
            this.rbtn_bm25.Size = new System.Drawing.Size(53, 17);
            this.rbtn_bm25.TabIndex = 8;
            this.rbtn_bm25.TabStop = true;
            this.rbtn_bm25.Text = "BM25";
            this.rbtn_bm25.UseVisualStyleBackColor = true;
            this.rbtn_bm25.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btn_indice
            // 
            this.btn_indice.Location = new System.Drawing.Point(161, 92);
            this.btn_indice.Name = "btn_indice";
            this.btn_indice.Size = new System.Drawing.Size(54, 23);
            this.btn_indice.TabIndex = 9;
            this.btn_indice.Text = "...";
            this.btn_indice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_indice.UseVisualStyleBackColor = true;
            this.btn_indice.Click += new System.EventHandler(this.btn_indice_Click);
            // 
            // btn_escalafon
            // 
            this.btn_escalafon.Location = new System.Drawing.Point(161, 154);
            this.btn_escalafon.Name = "btn_escalafon";
            this.btn_escalafon.Size = new System.Drawing.Size(54, 23);
            this.btn_escalafon.TabIndex = 11;
            this.btn_escalafon.Text = "...";
            this.btn_escalafon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_escalafon.UseVisualStyleBackColor = true;
            this.btn_escalafon.Click += new System.EventHandler(this.btn_escalafon_Click);
            // 
            // btn_html
            // 
            this.btn_html.Location = new System.Drawing.Point(161, 190);
            this.btn_html.Name = "btn_html";
            this.btn_html.Size = new System.Drawing.Size(54, 23);
            this.btn_html.TabIndex = 12;
            this.btn_html.Text = "...";
            this.btn_html.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_html.UseVisualStyleBackColor = true;
            this.btn_html.Click += new System.EventHandler(this.btn_html_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 430);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Documento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Término";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(473, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 4;
            // 
            // btn_consultar_doc
            // 
            this.btn_consultar_doc.Location = new System.Drawing.Point(256, 9);
            this.btn_consultar_doc.Name = "btn_consultar_doc";
            this.btn_consultar_doc.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar_doc.TabIndex = 5;
            this.btn_consultar_doc.Text = "Consultar";
            this.btn_consultar_doc.UseVisualStyleBackColor = true;
            this.btn_consultar_doc.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_consultar_term
            // 
            this.btn_consultar_term.Location = new System.Drawing.Point(646, 10);
            this.btn_consultar_term.Name = "btn_consultar_term";
            this.btn_consultar_term.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar_term.TabIndex = 6;
            this.btn_consultar_term.Text = "Consultar";
            this.btn_consultar_term.UseVisualStyleBackColor = true;
            this.btn_consultar_term.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(161, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 20);
            this.textBox3.TabIndex = 13;
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
            this.tab_buscador.ResumeLayout(false);
            this.tab_buscador.PerformLayout();
            this.tab_inspector.ResumeLayout(false);
            this.tab_inspector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_indexer;
        private System.Windows.Forms.TabPage tab_buscador;
        private System.Windows.Forms.TabPage tab_inspector;
        private System.Windows.Forms.Button btn_coleccion;
        private System.Windows.Forms.Button btn_stopwords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_indexar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox entrada_consulta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbtn_bm25;
        private System.Windows.Forms.RadioButton rbtn_vec;
        private System.Windows.Forms.Button btn_indice;
        private System.Windows.Forms.Button btn_escalafon;
        private System.Windows.Forms.Button btn_html;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_consultar_term;
        private System.Windows.Forms.Button btn_consultar_doc;
        private System.Windows.Forms.TextBox textBox3;
    }
}

