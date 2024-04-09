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
            radioButton1 = new RadioButton();
            credito_radioButton = new RadioButton();
            pix_radioButton = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            valorRecebidoTextBox = new TextBox();
            trocoLabel = new Label();
            labelValorRecebido = new Label();
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
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(22, 172);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Débito";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
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
            // NovaVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelValorRecebido);
            Controls.Add(trocoLabel);
            Controls.Add(valorRecebidoTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pix_radioButton);
            Controls.Add(credito_radioButton);
            Controls.Add(radioButton1);
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
        private RadioButton radioButton1;
        private RadioButton credito_radioButton;
        private RadioButton pix_radioButton;
        private Label label1;
        private Label label2;
        private TextBox valorRecebidoTextBox;
        private Label trocoLabel;
        private Label labelValorRecebido;
    }
}