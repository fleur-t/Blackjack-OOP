namespace Blackjack
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
            btnClickHere = new Button();
            lbl = new Label();
            SuspendLayout();
            // 
            // btnClickHere
            // 
            btnClickHere.Location = new Point(329, 165);
            btnClickHere.Name = "btnClickHere";
            btnClickHere.Size = new Size(145, 65);
            btnClickHere.TabIndex = 0;
            btnClickHere.Text = "Start";
            btnClickHere.UseVisualStyleBackColor = true;
            btnClickHere.Click += button1_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(377, 254);
            lbl.Name = "lbl";
            lbl.Size = new Size(0, 20);
            lbl.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 483);
            Controls.Add(lbl);
            Controls.Add(btnClickHere);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClickHere;
        private Label lbl;
    }
}
