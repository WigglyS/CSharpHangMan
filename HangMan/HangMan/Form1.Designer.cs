namespace HangMan
{
    partial class HangManMainWindow
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblUsedLetters = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txbUserInput = new System.Windows.Forms.TextBox();
            this.pnlWord = new System.Windows.Forms.Panel();
            this.flowLayUsedLetters = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlUsedLetters = new System.Windows.Forms.Panel();
            this.btnMakeGuess = new System.Windows.Forms.Button();
            this.flowLayUnderLines = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayLetters = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLives = new System.Windows.Forms.Panel();
            this.lblLives = new System.Windows.Forms.Label();
            this.btnSkip = new System.Windows.Forms.Button();
            this.pnlWord.SuspendLayout();
            this.pnlUsedLetters.SuspendLayout();
            this.pnlLives.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(194, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(436, 63);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hang Man Game";
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(340, 98);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(142, 20);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Click Start to begin";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUsedLetters
            // 
            this.lblUsedLetters.AutoSize = true;
            this.lblUsedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedLetters.Location = new System.Drawing.Point(15, 26);
            this.lblUsedLetters.Name = "lblUsedLetters";
            this.lblUsedLetters.Size = new System.Drawing.Size(101, 20);
            this.lblUsedLetters.TabIndex = 2;
            this.lblUsedLetters.Text = "Used Letters";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(374, 385);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.StartGame);
            // 
            // txbUserInput
            // 
            this.txbUserInput.Location = new System.Drawing.Point(39, 202);
            this.txbUserInput.MaxLength = 1;
            this.txbUserInput.Name = "txbUserInput";
            this.txbUserInput.Size = new System.Drawing.Size(29, 20);
            this.txbUserInput.TabIndex = 6;
            // 
            // pnlWord
            // 
            this.pnlWord.Controls.Add(this.btnSkip);
            this.pnlWord.Controls.Add(this.flowLayLetters);
            this.pnlWord.Controls.Add(this.flowLayUnderLines);
            this.pnlWord.Controls.Add(this.btnMakeGuess);
            this.pnlWord.Controls.Add(this.txbUserInput);
            this.pnlWord.Location = new System.Drawing.Point(205, 121);
            this.pnlWord.Name = "pnlWord";
            this.pnlWord.Size = new System.Drawing.Size(425, 237);
            this.pnlWord.TabIndex = 7;
            this.pnlWord.Visible = false;
            // 
            // flowLayUsedLetters
            // 
            this.flowLayUsedLetters.Location = new System.Drawing.Point(19, 49);
            this.flowLayUsedLetters.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flowLayUsedLetters.Name = "flowLayUsedLetters";
            this.flowLayUsedLetters.Size = new System.Drawing.Size(97, 211);
            this.flowLayUsedLetters.TabIndex = 6;
            // 
            // pnlUsedLetters
            // 
            this.pnlUsedLetters.Controls.Add(this.flowLayUsedLetters);
            this.pnlUsedLetters.Controls.Add(this.lblUsedLetters);
            this.pnlUsedLetters.Location = new System.Drawing.Point(13, 72);
            this.pnlUsedLetters.Name = "pnlUsedLetters";
            this.pnlUsedLetters.Size = new System.Drawing.Size(138, 286);
            this.pnlUsedLetters.TabIndex = 8;
            this.pnlUsedLetters.Visible = false;
            // 
            // btnMakeGuess
            // 
            this.btnMakeGuess.Location = new System.Drawing.Point(319, 202);
            this.btnMakeGuess.Name = "btnMakeGuess";
            this.btnMakeGuess.Size = new System.Drawing.Size(75, 23);
            this.btnMakeGuess.TabIndex = 7;
            this.btnMakeGuess.Text = "MakeGuess";
            this.btnMakeGuess.UseVisualStyleBackColor = true;
            this.btnMakeGuess.Click += new System.EventHandler(this.CheckInput);
            // 
            // flowLayUnderLines
            // 
            this.flowLayUnderLines.AutoSize = true;
            this.flowLayUnderLines.Location = new System.Drawing.Point(30, 174);
            this.flowLayUnderLines.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayUnderLines.Name = "flowLayUnderLines";
            this.flowLayUnderLines.Size = new System.Drawing.Size(364, 25);
            this.flowLayUnderLines.TabIndex = 8;
            // 
            // flowLayLetters
            // 
            this.flowLayLetters.AutoSize = true;
            this.flowLayLetters.Location = new System.Drawing.Point(30, 143);
            this.flowLayLetters.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayLetters.Name = "flowLayLetters";
            this.flowLayLetters.Size = new System.Drawing.Size(364, 25);
            this.flowLayLetters.TabIndex = 9;
            // 
            // pnlLives
            // 
            this.pnlLives.Controls.Add(this.lblLives);
            this.pnlLives.Location = new System.Drawing.Point(636, 72);
            this.pnlLives.Name = "pnlLives";
            this.pnlLives.Size = new System.Drawing.Size(131, 132);
            this.pnlLives.TabIndex = 9;
            this.pnlLives.Visible = false;
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.Location = new System.Drawing.Point(24, 32);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(66, 20);
            this.lblLives.TabIndex = 0;
            this.lblLives.Text = "Lives : 5";
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(319, 19);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(75, 23);
            this.btnSkip.TabIndex = 10;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.ResetGame);
            // 
            // HangManMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLives);
            this.Controls.Add(this.pnlUsedLetters);
            this.Controls.Add(this.pnlWord);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblTitle);
            this.Name = "HangManMainWindow";
            this.Text = "Hang Man Game";
            this.pnlWord.ResumeLayout(false);
            this.pnlWord.PerformLayout();
            this.pnlUsedLetters.ResumeLayout(false);
            this.pnlUsedLetters.PerformLayout();
            this.pnlLives.ResumeLayout(false);
            this.pnlLives.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblUsedLetters;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txbUserInput;
        private System.Windows.Forms.Panel pnlWord;
        private System.Windows.Forms.FlowLayoutPanel flowLayUsedLetters;
        private System.Windows.Forms.Panel pnlUsedLetters;
        private System.Windows.Forms.Button btnMakeGuess;
        private System.Windows.Forms.FlowLayoutPanel flowLayLetters;
        private System.Windows.Forms.FlowLayoutPanel flowLayUnderLines;
        private System.Windows.Forms.Panel pnlLives;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Button btnSkip;
    }
}

