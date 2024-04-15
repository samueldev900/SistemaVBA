namespace SistemaVBA
{
    partial class editVenda
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
            name_textBox = new TextBox();
            name_label = new Label();
            modelo_label = new Label();
            textBox1 = new TextBox();
            dinheiro_radioButton = new RadioButton();
            credito_radioButton = new RadioButton();
            debito_radioButton = new RadioButton();
            pix_radioButton = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // name_textBox
            // 
            name_textBox.Location = new Point(12, 47);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(232, 23);
            name_textBox.TabIndex = 0;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(12, 29);
            name_label.Name = "name_label";
            name_label.Size = new Size(43, 15);
            name_label.TabIndex = 1;
            name_label.Text = "Nome:";
            // 
            // modelo_label
            // 
            modelo_label.AutoSize = true;
            modelo_label.Location = new Point(12, 87);
            modelo_label.Name = "modelo_label";
            modelo_label.Size = new Size(51, 15);
            modelo_label.TabIndex = 3;
            modelo_label.Text = "Modelo:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 23);
            textBox1.TabIndex = 2;
            // 
            // dinheiro_radioButton
            // 
            dinheiro_radioButton.AutoSize = true;
            dinheiro_radioButton.Location = new Point(12, 166);
            dinheiro_radioButton.Name = "dinheiro_radioButton";
            dinheiro_radioButton.Size = new Size(70, 19);
            dinheiro_radioButton.TabIndex = 4;
            dinheiro_radioButton.TabStop = true;
            dinheiro_radioButton.Text = "Dinheiro";
            dinheiro_radioButton.UseVisualStyleBackColor = true;
            // 
            // credito_radioButton
            // 
            credito_radioButton.AutoSize = true;
            credito_radioButton.Location = new Point(150, 166);
            credito_radioButton.Name = "credito_radioButton";
            credito_radioButton.Size = new Size(64, 19);
            credito_radioButton.TabIndex = 5;
            credito_radioButton.TabStop = true;
            credito_radioButton.Text = "Crédito";
            credito_radioButton.UseVisualStyleBackColor = true;
            // 
            // debito_radioButton
            // 
            debito_radioButton.AutoSize = true;
            debito_radioButton.Location = new Point(88, 166);
            debito_radioButton.Name = "debito_radioButton";
            debito_radioButton.Size = new Size(60, 19);
            debito_radioButton.TabIndex = 6;
            debito_radioButton.TabStop = true;
            debito_radioButton.Text = "Débito";
            debito_radioButton.UseVisualStyleBackColor = true;
            // 
            // pix_radioButton
            // 
            pix_radioButton.AutoSize = true;
            pix_radioButton.Location = new Point(220, 166);
            pix_radioButton.Name = "pix_radioButton";
            pix_radioButton.Size = new Size(41, 19);
            pix_radioButton.TabIndex = 7;
            pix_radioButton.TabStop = true;
            pix_radioButton.Text = "Pix";
            pix_radioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 148);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 8;
            label1.Text = "Metodo de Pagamento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 247);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 10;
            label2.Text = "Troco";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 265);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 23);
            textBox2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 303);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 12;
            label3.Text = "Preço:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 321);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(232, 23);
            textBox3.TabIndex = 11;
            // 
            // editVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 450);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(pix_radioButton);
            Controls.Add(debito_radioButton);
            Controls.Add(credito_radioButton);
            Controls.Add(dinheiro_radioButton);
            Controls.Add(modelo_label);
            Controls.Add(textBox1);
            Controls.Add(name_label);
            Controls.Add(name_textBox);
            Name = "editVenda";
            Text = "Editar Vendas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name_textBox;
        private Label name_label;
        private Label modelo_label;
        private TextBox textBox1;
        private RadioButton dinheiro_radioButton;
        private RadioButton credito_radioButton;
        private RadioButton debito_radioButton;
        private RadioButton pix_radioButton;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
    }
}