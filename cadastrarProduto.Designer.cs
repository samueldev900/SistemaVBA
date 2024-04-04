namespace SistemaVBA
{
    partial class cadastrarProduto
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
            button1 = new Button();
            ProdutoTextBox = new TextBox();
            MarcaTextBox = new TextBox();
            label2 = new Label();
            ModeloTextBox = new TextBox();
            label3 = new Label();
            costPriceTextBox = new TextBox();
            label4 = new Label();
            finalPricetextBox = new TextBox();
            label5 = new Label();
            IDtextBox = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do Produto";
            // 
            // button1
            // 
            button1.Location = new Point(12, 358);
            button1.Name = "button1";
            button1.Size = new Size(189, 49);
            button1.TabIndex = 1;
            button1.Text = "Cadastrar Produto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProdutoTextBox
            // 
            ProdutoTextBox.Location = new Point(12, 39);
            ProdutoTextBox.Name = "ProdutoTextBox";
            ProdutoTextBox.Size = new Size(189, 23);
            ProdutoTextBox.TabIndex = 2;
            // 
            // MarcaTextBox
            // 
            MarcaTextBox.Location = new Point(12, 83);
            MarcaTextBox.Name = "MarcaTextBox";
            MarcaTextBox.Size = new Size(189, 23);
            MarcaTextBox.TabIndex = 4;
            MarcaTextBox.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Marca";
            label2.Click += label2_Click;
            // 
            // ModeloTextBox
            // 
            ModeloTextBox.Location = new Point(12, 127);
            ModeloTextBox.Name = "ModeloTextBox";
            ModeloTextBox.Size = new Size(189, 23);
            ModeloTextBox.TabIndex = 6;
            ModeloTextBox.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 109);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 5;
            label3.Text = "Modelo";
            // 
            // costPriceTextBox
            // 
            costPriceTextBox.Location = new Point(12, 185);
            costPriceTextBox.Name = "costPriceTextBox";
            costPriceTextBox.Size = new Size(189, 23);
            costPriceTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 167);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 7;
            label4.Text = "Preço de Custo";
            // 
            // finalPricetextBox
            // 
            finalPricetextBox.Location = new Point(12, 235);
            finalPricetextBox.Name = "finalPricetextBox";
            finalPricetextBox.Size = new Size(189, 23);
            finalPricetextBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 217);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 9;
            label5.Text = "Preço Final";
            // 
            // IDtextBox
            // 
            IDtextBox.Location = new Point(12, 284);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.Size = new Size(189, 23);
            IDtextBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 266);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 11;
            label6.Text = "Código de Barras";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(306, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(641, 427);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(949, 441);
            Controls.Add(dataGridView1);
            Controls.Add(IDtextBox);
            Controls.Add(label6);
            Controls.Add(finalPricetextBox);
            Controls.Add(label5);
            Controls.Add(costPriceTextBox);
            Controls.Add(label4);
            Controls.Add(ModeloTextBox);
            Controls.Add(label3);
            Controls.Add(MarcaTextBox);
            Controls.Add(label2);
            Controls.Add(ProdutoTextBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "cadastrarProduto";
            Text = "SistemaVBA";
            Load += cadastrarProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox ProdutoTextBox;
        private TextBox MarcaTextBox;
        private Label label2;
        private TextBox ModeloTextBox;
        private Label label3;
        private TextBox costPriceTextBox;
        private Label label4;
        private TextBox finalPricetextBox;
        private Label label5;
        private TextBox IDtextBox;
        private Label label6;
        private DataGridView dataGridView1;
    }
}
