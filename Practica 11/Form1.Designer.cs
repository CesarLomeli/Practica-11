namespace Practica_11
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button5 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            richTextBox1 = new RichTextBox();
            ocupado = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(button3, 0, 3);
            tableLayoutPanel1.Controls.Add(button2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(button4, 1, 1);
            tableLayoutPanel1.Controls.Add(button6, 1, 3);
            tableLayoutPanel1.Controls.Add(button7, 2, 1);
            tableLayoutPanel1.Controls.Add(button8, 2, 2);
            tableLayoutPanel1.Controls.Add(button9, 2, 3);
            tableLayoutPanel1.Controls.Add(button5, 1, 2);
            tableLayoutPanel1.Location = new Point(52, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(300, 174);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(3, 93);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 58);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Leer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 3;
            label1.Text = "Ventana 1";
            // 
            // button1
            // 
            button1.Location = new Point(3, 23);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Escribir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 4;
            label2.Text = "Ventana 2";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // button4
            // 
            button4.Location = new Point(103, 23);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 6;
            button4.Text = "Escribir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Location = new Point(103, 93);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 8;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(203, 23);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 9;
            button7.Text = "Escribir";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(203, 58);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 10;
            button8.Text = "Leer";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(203, 93);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 11;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(103, 58);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 7;
            button5.Text = "Leer";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(richTextBox1, 1, 0);
            tableLayoutPanel2.Location = new Point(16, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(811, 180);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(408, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(371, 173);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // ocupado
            // 
            ocupado.AutoSize = true;
            ocupado.Location = new Point(70, 198);
            ocupado.Name = "ocupado";
            ocupado.Size = new Size(0, 20);
            ocupado.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 244);
            Controls.Add(ocupado);
            Controls.Add(tableLayoutPanel2);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button4;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button5;
        private TableLayoutPanel tableLayoutPanel2;
        private RichTextBox richTextBox1;
        private Label ocupado;
    }
}
