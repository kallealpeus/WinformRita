namespace WinformRita
{
    partial class DrawForm
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
            pictureBox1 = new PictureBox();
            buttonCircle = new Button();
            buttonSqaure = new Button();
            label1 = new Label();
            buttonTriangle = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ColorButton = new Button();
            ClearButton1 = new Button();
            ClearButton2 = new Button();
            ClearButton3 = new Button();
            RegretButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(11, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(699, 231);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // buttonCircle
            // 
            buttonCircle.Font = new Font("Vladimir Script", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCircle.Location = new Point(115, 50);
            buttonCircle.Name = "buttonCircle";
            buttonCircle.Size = new Size(66, 66);
            buttonCircle.TabIndex = 1;
            buttonCircle.Text = "○";
            buttonCircle.UseVisualStyleBackColor = true;
            buttonCircle.Click += buttonCircle_Click;
            // 
            // buttonSqaure
            // 
            buttonSqaure.Font = new Font("Vladimir Script", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSqaure.Location = new Point(43, 50);
            buttonSqaure.Name = "buttonSqaure";
            buttonSqaure.Size = new Size(66, 66);
            buttonSqaure.TabIndex = 2;
            buttonSqaure.Text = "▢";
            buttonSqaure.UseVisualStyleBackColor = true;
            buttonSqaure.Click += buttonSqaure_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(214, 39);
            label1.TabIndex = 3;
            label1.Text = "Rita Med Krita©";
            // 
            // buttonTriangle
            // 
            buttonTriangle.Font = new Font("Vladimir Script", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTriangle.Location = new Point(187, 50);
            buttonTriangle.Name = "buttonTriangle";
            buttonTriangle.Size = new Size(66, 66);
            buttonTriangle.TabIndex = 4;
            buttonTriangle.Text = "△";
            buttonTriangle.UseVisualStyleBackColor = true;
            buttonTriangle.Click += buttonTriangle_Click;
            // 
            // ColorButton
            // 
            ColorButton.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ColorButton.Location = new Point(259, 50);
            ColorButton.Name = "ColorButton";
            ColorButton.Size = new Size(104, 66);
            ColorButton.TabIndex = 6;
            ColorButton.Text = "Colors!";
            ColorButton.UseVisualStyleBackColor = true;
            ColorButton.Click += ColorButton_Click;
            // 
            // ClearButton1
            // 
            ClearButton1.BackColor = Color.Yellow;
            ClearButton1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClearButton1.Location = new Point(579, 94);
            ClearButton1.Name = "ClearButton1";
            ClearButton1.Size = new Size(129, 55);
            ClearButton1.TabIndex = 7;
            ClearButton1.Text = "CLEAR";
            ClearButton1.UseVisualStyleBackColor = false;
            ClearButton1.Click += ClearButton1_Click;
            // 
            // ClearButton2
            // 
            ClearButton2.BackColor = Color.FromArgb(255, 128, 0);
            ClearButton2.Enabled = false;
            ClearButton2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClearButton2.Location = new Point(444, 33);
            ClearButton2.Name = "ClearButton2";
            ClearButton2.Size = new Size(129, 55);
            ClearButton2.TabIndex = 8;
            ClearButton2.Text = "CLEAR";
            ClearButton2.UseVisualStyleBackColor = false;
            ClearButton2.Visible = false;
            ClearButton2.Click += ClearButton2_Click;
            // 
            // ClearButton3
            // 
            ClearButton3.BackColor = Color.Red;
            ClearButton3.Enabled = false;
            ClearButton3.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClearButton3.Location = new Point(579, 33);
            ClearButton3.Name = "ClearButton3";
            ClearButton3.Size = new Size(129, 55);
            ClearButton3.TabIndex = 9;
            ClearButton3.Text = "CLEAR";
            ClearButton3.UseVisualStyleBackColor = false;
            ClearButton3.Visible = false;
            ClearButton3.Click += ClearButton3_Click;
            // 
            // RegretButton
            // 
            RegretButton.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegretButton.Location = new Point(444, 94);
            RegretButton.Name = "RegretButton";
            RegretButton.Size = new Size(129, 55);
            RegretButton.TabIndex = 10;
            RegretButton.Text = "↩";
            RegretButton.UseVisualStyleBackColor = true;
            RegretButton.Click += RegretButton_Click;
            // 
            // DrawForm
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(720, 396);
            Controls.Add(RegretButton);
            Controls.Add(ClearButton3);
            Controls.Add(ClearButton2);
            Controls.Add(ClearButton1);
            Controls.Add(ColorButton);
            Controls.Add(buttonTriangle);
            Controls.Add(label1);
            Controls.Add(buttonSqaure);
            Controls.Add(buttonCircle);
            Controls.Add(pictureBox1);
            Font = new Font("Vladimir Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "DrawForm";
            Text = "Rita Med Krita©";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonCircle;
        private Button buttonSqaure;
        private Label label1;
        private Button buttonTriangle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button ColorButton;
        private Button ClearButton1;
        private Button ClearButton2;
        private Button ClearButton3;
        private Button RegretButton;
    }
}
