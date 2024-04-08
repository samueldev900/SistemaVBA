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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(556, 240);
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
            label2.Location = new Point(565, 168);
            label2.Name = "label2";
            label2.Size = new Size(234, 72);
            label2.TabIndex = 1;
            label2.Text = "R$ 19.90";
            // 
            // button1
            // 
            button1.Location = new Point(49, 418);
            button1.Name = "button1";
            button1.Size = new Size(144, 45);
            button1.TabIndex = 2;
            button1.Text = "Nova Venda";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(220, 418);
            button2.Name = "button2";
            button2.Size = new Size(170, 45);
            button2.TabIndex = 3;
            button2.Text = "Cadastrar Produto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 518);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "TelaPrincipal";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}