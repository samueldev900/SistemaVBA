namespace SistemaVBA
{
    partial class TelaPrincipal
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
            label1 = new Label();
            label2 = new Label();
            novaVenda_button = new Button();
            cadastroProduto_button = new Button();
            dataGridView1 = new DataGridView();
            deleteVenda_button = new Button();
            editVenda_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(575, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 37);
            label1.TabIndex = 0;
            label1.Text = "Total de vendas Hoje:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 40F);
            label2.Location = new Point(575, 46);
            label2.Name = "label2";
            label2.Size = new Size(234, 72);
            label2.TabIndex = 1;
            label2.Text = "R$ 19.90";
            // 
            // novaVenda_button
            // 
            novaVenda_button.Location = new Point(33, 29);
            novaVenda_button.Name = "novaVenda_button";
            novaVenda_button.Size = new Size(144, 45);
            novaVenda_button.TabIndex = 2;
            novaVenda_button.Text = "Nova Venda";
            novaVenda_button.UseVisualStyleBackColor = true;
            novaVenda_button.Click += novaVenda_button_Click;
            // 
            // cadastroProduto_button
            // 
            cadastroProduto_button.Location = new Point(197, 29);
            cadastroProduto_button.Name = "cadastroProduto_button";
            cadastroProduto_button.Size = new Size(170, 45);
            cadastroProduto_button.TabIndex = 3;
            cadastroProduto_button.Text = "Cadastrar Produto";
            cadastroProduto_button.UseVisualStyleBackColor = true;
            cadastroProduto_button.Click += cadastroProduto_button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(824, 330);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // deleteVenda_button
            // 
            deleteVenda_button.Location = new Point(33, 89);
            deleteVenda_button.Name = "deleteVenda_button";
            deleteVenda_button.Size = new Size(144, 45);
            deleteVenda_button.TabIndex = 5;
            deleteVenda_button.Text = "Excluir Venda";
            deleteVenda_button.UseVisualStyleBackColor = true;
            deleteVenda_button.Click += deleteVenda_button_Click;
            // 
            // editVenda_button
            // 
            editVenda_button.Location = new Point(197, 89);
            editVenda_button.Name = "editVenda_button";
            editVenda_button.Size = new Size(170, 45);
            editVenda_button.TabIndex = 6;
            editVenda_button.Text = "Editar Venda";
            editVenda_button.UseVisualStyleBackColor = true;
            editVenda_button.Click += editVenda_button_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 518);
            Controls.Add(editVenda_button);
            Controls.Add(deleteVenda_button);
            Controls.Add(dataGridView1);
            Controls.Add(cadastroProduto_button);
            Controls.Add(novaVenda_button);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "TelaPrincipal";
            Text = "Tela Principal";
            TopMost = true;
            Load += TelaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button novaVenda_button;
        private Button cadastroProduto_button;
        private DataGridView dataGridView1;
        private Button deleteVenda_button;
        private Button editVenda_button;
    }
}