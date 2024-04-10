namespace SistemaVBA
{
    partial class NovaVenda
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            dinheiro_radio = new RadioButton();
            textBox1 = new TextBox();
            debitoButton1 = new RadioButton();
            credito_radioButton = new RadioButton();
            pix_radioButton = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            valorRecebidoTextBox = new TextBox();
            trocoLabel = new Label();
            labelValorRecebido = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label3 = new Label();
            nomeProduto_label = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(284, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(504, 357);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(41, 388);
            button1.Name = "button1";
            button1.Size = new Size(152, 50);
            button1.TabIndex = 1;
            button1.Text = "Efetuar Venda";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dinheiro_radio
            // 
            dinheiro_radio.AutoSize = true;
            dinheiro_radio.Location = new Point(22, 81);
            dinheiro_radio.Name = "dinheiro_radio";
            dinheiro_radio.Size = new Size(70, 19);
            dinheiro_radio.TabIndex = 2;
            dinheiro_radio.TabStop = true;
            dinheiro_radio.Text = "Dinheiro";
            dinheiro_radio.UseVisualStyleBackColor = true;
            dinheiro_radio.CheckedChanged += dinheiro_radio_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(284, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(504, 23);
            textBox1.TabIndex = 3;
            // 
            // debitoButton1
            // 
            debitoButton1.AutoSize = true;
            debitoButton1.Location = new Point(22, 172);
            debitoButton1.Name = "debitoButton1";
            debitoButton1.Size = new Size(60, 19);
            debitoButton1.TabIndex = 4;
            debitoButton1.TabStop = true;
            debitoButton1.Text = "Débito";
            debitoButton1.UseVisualStyleBackColor = true;
            debitoButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // credito_radioButton
            // 
            credito_radioButton.AutoSize = true;
            credito_radioButton.Location = new Point(22, 197);
            credito_radioButton.Name = "credito_radioButton";
            credito_radioButton.Size = new Size(64, 19);
            credito_radioButton.TabIndex = 5;
            credito_radioButton.TabStop = true;
            credito_radioButton.Text = "Crédito";
            credito_radioButton.UseVisualStyleBackColor = true;
            credito_radioButton.CheckedChanged += credito_radioButton_CheckedChanged;
            // 
            // pix_radioButton
            // 
            pix_radioButton.AutoSize = true;
            pix_radioButton.Location = new Point(22, 222);
            pix_radioButton.Name = "pix_radioButton";
            pix_radioButton.Size = new Size(41, 19);
            pix_radioButton.TabIndex = 6;
            pix_radioButton.TabStop = true;
            pix_radioButton.Text = "Pix";
            pix_radioButton.UseVisualStyleBackColor = true;
            pix_radioButton.CheckedChanged += pix_radioButton_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 41);
            label1.Name = "label1";
            label1.Size = new Size(195, 15);
            label1.TabIndex = 7;
            label1.Text = "Selecione o Método de Pagamento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 23);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 8;
            label2.Text = "Pesquisar Produto:";
            // 
            // valorRecebidoTextBox
            // 
            valorRecebidoTextBox.Location = new Point(22, 125);
            valorRecebidoTextBox.Name = "valorRecebidoTextBox";
            valorRecebidoTextBox.Size = new Size(100, 23);
            valorRecebidoTextBox.TabIndex = 9;
            // 
            // trocoLabel
            // 
            trocoLabel.AutoSize = true;
            trocoLabel.Location = new Point(22, 151);
            trocoLabel.Name = "trocoLabel";
            trocoLabel.Size = new Size(39, 15);
            trocoLabel.TabIndex = 10;
            trocoLabel.Text = "Troco:";
            trocoLabel.Click += trocoLabel_Click;
            // 
            // labelValorRecebido
            // 
            labelValorRecebido.AutoSize = true;
            labelValorRecebido.Location = new Point(22, 107);
            labelValorRecebido.Name = "labelValorRecebido";
            labelValorRecebido.Size = new Size(88, 15);
            labelValorRecebido.TabIndex = 11;
            labelValorRecebido.Text = "Valor Recebido:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(813, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(813, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(813, 168);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(177, 23);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(813, 197);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(177, 23);
            textBox5.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(813, 303);
            label3.Name = "label3";
            label3.Size = new Size(80, 37);
            label3.TabIndex = 16;
            label3.Text = "Total:";
            label3.Click += label3_Click;
            // 
            // nomeProduto_label
            // 
            nomeProduto_label.AutoSize = true;
            nomeProduto_label.Font = new Font("Segoe UI", 20F);
            nomeProduto_label.Location = new Point(813, 266);
            nomeProduto_label.Name = "nomeProduto_label";
            nomeProduto_label.Size = new Size(119, 37);
            nomeProduto_label.TabIndex = 17;
            nomeProduto_label.Text = "Produto:";
            // 
            // NovaVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 450);
            Controls.Add(nomeProduto_label);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(labelValorRecebido);
            Controls.Add(trocoLabel);
            Controls.Add(valorRecebidoTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pix_radioButton);
            Controls.Add(credito_radioButton);
            Controls.Add(debitoButton1);
            Controls.Add(textBox1);
            Controls.Add(dinheiro_radio);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "NovaVenda";
            Text = "Nova Venda";
            Load += NovaVenda_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private RadioButton dinheiro_radio;
        private TextBox textBox1;
        private RadioButton debitoButton1;
        private RadioButton credito_radioButton;
        private RadioButton pix_radioButton;
        private Label label1;
        private Label label2;
        private TextBox valorRecebidoTextBox;
        private Label trocoLabel;
        private Label labelValorRecebido;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label3;
        private Label nomeProduto_label;
    }
}