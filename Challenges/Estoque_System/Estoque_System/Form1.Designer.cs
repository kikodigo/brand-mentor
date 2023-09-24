namespace Estoque_System
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
            button2 = new Button();
            txt_Cidade = new TextBox();
            txt_Clima = new TextBox();
            txt_Temp = new TextBox();
            txt_CidadeConsulta = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(128, 200);
            button1.Name = "button1";
            button1.Size = new Size(134, 47);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(147, 291);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txt_Cidade
            // 
            txt_Cidade.Location = new Point(465, 224);
            txt_Cidade.Name = "txt_Cidade";
            txt_Cidade.Size = new Size(282, 27);
            txt_Cidade.TabIndex = 2;
            // 
            // txt_Clima
            // 
            txt_Clima.Location = new Point(465, 290);
            txt_Clima.Name = "txt_Clima";
            txt_Clima.Size = new Size(282, 27);
            txt_Clima.TabIndex = 3;
            // 
            // txt_Temp
            // 
            txt_Temp.Location = new Point(465, 257);
            txt_Temp.Name = "txt_Temp";
            txt_Temp.Size = new Size(282, 27);
            txt_Temp.TabIndex = 4;
            // 
            // txt_CidadeConsulta
            // 
            txt_CidadeConsulta.Location = new Point(351, 90);
            txt_CidadeConsulta.Name = "txt_CidadeConsulta";
            txt_CidadeConsulta.Size = new Size(282, 27);
            txt_CidadeConsulta.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_CidadeConsulta);
            Controls.Add(txt_Temp);
            Controls.Add(txt_Clima);
            Controls.Add(txt_Cidade);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txt_Cidade;
        private TextBox txt_Clima;
        private TextBox txt_Temp;
        private TextBox txt_CidadeConsulta;
    }
}