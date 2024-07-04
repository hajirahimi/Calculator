namespace AhmadConverter
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
            txbMm = new TextBox();
            txbIn = new TextBox();
            SuspendLayout();
            // 
            // txbMm
            // 
            txbMm.Location = new Point(44, 30);
            txbMm.Name = "txbMm";
            txbMm.Size = new Size(125, 27);
            txbMm.TabIndex = 0;
            txbMm.TextChanged += txbMm_TextChanged;
            // 
            // txbIn
            // 
            txbIn.Location = new Point(44, 93);
            txbIn.Name = "txbIn";
            txbIn.Size = new Size(125, 27);
            txbIn.TabIndex = 1;
            txbIn.TextChanged += txbIn_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 445);
            Controls.Add(txbIn);
            Controls.Add(txbMm);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbMm;
        private TextBox txbIn;
    }
}
