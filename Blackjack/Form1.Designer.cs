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
            lbl = new Label();
            DeelKaart = new Button();
            Player = new ListBox();
            buttonReset = new Button();
            Player2 = new ListBox();
            scoreTotaal = new Label();
            scoreTotaal2 = new Label();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(377, 254);
            lbl.Name = "lbl";
            lbl.Size = new Size(0, 20);
            lbl.TabIndex = 1;
            // 
            // DeelKaart
            // 
            DeelKaart.Location = new Point(58, 377);
            DeelKaart.Name = "DeelKaart";
            DeelKaart.Size = new Size(94, 29);
            DeelKaart.TabIndex = 2;
            DeelKaart.Text = "Deal";
            DeelKaart.UseVisualStyleBackColor = true;
            DeelKaart.Click += DeelKaart_Click;
            // 
            // Player
            // 
            Player.BackColor = Color.White;
            Player.FormattingEnabled = true;
            Player.Location = new Point(58, 38);
            Player.Name = "Player";
            Player.Size = new Size(150, 264);
            Player.TabIndex = 3;
            Player.SelectedIndexChanged += Player_SelectedIndexChanged;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(191, 377);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 5;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // Player2
            // 
            Player2.BackColor = Color.White;
            Player2.FormattingEnabled = true;
            Player2.Location = new Point(266, 38);
            Player2.Name = "Player2";
            Player2.Size = new Size(150, 264);
            Player2.TabIndex = 6;
            Player2.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // scoreTotaal
            // 
            scoreTotaal.AutoSize = true;
            scoreTotaal.Location = new Point(58, 305);
            scoreTotaal.Name = "scoreTotaal";
            scoreTotaal.Size = new Size(53, 20);
            scoreTotaal.TabIndex = 4;
            scoreTotaal.Text = "Score: ";
            scoreTotaal.Click += scoreTotaal_Click;
            // 
            // scoreTotaal2
            // 
            scoreTotaal2.AutoSize = true;
            scoreTotaal2.Location = new Point(266, 305);
            scoreTotaal2.Name = "scoreTotaal2";
            scoreTotaal2.Size = new Size(53, 20);
            scoreTotaal2.TabIndex = 7;
            scoreTotaal2.Text = "Score: ";
            scoreTotaal2.Click += scoreTotaal2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 458);
            Controls.Add(scoreTotaal2);
            Controls.Add(Player2);
            Controls.Add(buttonReset);
            Controls.Add(scoreTotaal);
            Controls.Add(Player);
            Controls.Add(DeelKaart);
            Controls.Add(lbl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl;
        private Button DeelKaart;
        private ListBox Player;
        private Button buttonReset;
        private ListBox Player2;
        private Label scoreTotaal;
        private Label scoreTotaal2;
    }
}
