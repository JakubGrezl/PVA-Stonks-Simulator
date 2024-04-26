namespace StonksSimulator
{
    partial class StonksForm
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
            numericUpDown1 = new NumericUpDown();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            cheatmodeBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(339, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Vlož Akcie!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(321, 386);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(3, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(785, 356);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Location = new Point(613, 386);
            label1.Name = "label1";
            label1.Size = new Size(175, 23);
            label1.TabIndex = 3;
            label1.Text = "Peníze: 5$";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cheatmodeBox
            // 
            cheatmodeBox.AutoSize = true;
            cheatmodeBox.Location = new Point(17, 385);
            cheatmodeBox.Name = "cheatmodeBox";
            cheatmodeBox.Size = new Size(89, 19);
            cheatmodeBox.TabIndex = 4;
            cheatmodeBox.Text = "cheat mode";
            cheatmodeBox.UseVisualStyleBackColor = true;
            cheatmodeBox.CheckedChanged += cheatmodeBox_CheckedChanged;
            // 
            // StonksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 450);
            Controls.Add(cheatmodeBox);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Name = "StonksForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private NumericUpDown numericUpDown1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private CheckBox cheatmodeBox;
    }
}
