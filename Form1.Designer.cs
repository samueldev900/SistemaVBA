namespace SistemaVBA
{
    partial class Form1
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
            button1 = new Button();
            label1 = new Label();
            nameTextBox = new TextBox();
            marcaTextBox = new TextBox();
            label2 = new Label();
            modeloTextBox3 = new TextBox();
            label3 = new Label();
            precoCustotextBox = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 428);
            button1.Name = "button1";
            button1.Size = new Size(345, 49);
            button1.TabIndex = 1;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do Produto";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 49);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(345, 23);
            nameTextBox.TabIndex = 2;
            // 
            // marcaTextBox
            // 
            marcaTextBox.Location = new Point(12, 107);
            marcaTextBox.Name = "marcaTextBox";
            marcaTextBox.Size = new Size(345, 23);
            marcaTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Marca";
            // 
            // modeloTextBox3
            // 
            modeloTextBox3.Location = new Point(12, 169);
            modeloTextBox3.Name = "modeloTextBox3";
            modeloTextBox3.Size = new Size(345, 23);
            modeloTextBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 142);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 5;
            label3.Text = "Modelo";
            // 
            // precoCustotextBox
            // 
            precoCustotextBox.Location = new Point(12, 232);
            precoCustotextBox.Name = "precoCustotextBox";
            precoCustotextBox.Size = new Size(345, 23);
            precoCustotextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 205);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 7;
            label4.Text = "Preço de Custo";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 294);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(345, 23);
            textBox5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 267);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 9;
            label5.Text = "Preço Final";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 353);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(345, 23);
            textBox6.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 326);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 11;
            label6.Text = "Código de barras";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(369, 513);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(precoCustotextBox);
            Controls.Add(label4);
            Controls.Add(modeloTextBox3);
            Controls.Add(label3);
            Controls.Add(marcaTextBox);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "SistemaVBA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private TextBox nameTextBox;
        private TextBox marcaTextBox;
        private Label label2;
        private TextBox modeloTextBox3;
        private Label label3;
        private TextBox precoCustotextBox;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
    }
}
