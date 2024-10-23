namespace Assignment1
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(89, 104);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 109);
            label1.Name = "label1";
            label1.Size = new Size(285, 20);
            label1.TabIndex = 1;
            label1.Text = "This textbox will display an error message";
            // 
            // button1
            // 
            button1.Location = new Point(210, 104);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 2;
            button1.Text = "click button";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(594, 111);
            label2.Name = "label2";
            label2.Size = new Size(372, 20);
            label2.TabIndex = 3;
            label2.Text = "Will display what has been clicked on the message box";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(89, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(210, 177);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 5;
            button2.Text = "click button";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 184);
            label3.Name = "label3";
            label3.Size = new Size(189, 20);
            label3.TabIndex = 6;
            label3.Text = "Display system information";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(594, 184);
            label4.Name = "label4";
            label4.Size = new Size(372, 20);
            label4.TabIndex = 7;
            label4.Text = "Will display what has been clicked on the message box";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(89, 242);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 27);
            textBox3.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(210, 242);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 9;
            button3.Text = "click button";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(303, 247);
            label5.Name = "label5";
            label5.Size = new Size(192, 20);
            label5.TabIndex = 10;
            label5.Text = "Displays cancel try continue\nWill also change colors";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(594, 253);
            label6.Name = "label6";
            label6.Size = new Size(372, 20);
            label6.TabIndex = 11;
            label6.Text = "Will display what has been clicked on the message box";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 600);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private Button button2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Button button3;
        private Label label5;
        private Label label6;
    }
}
