namespace WinApp
{
    partial class StartGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTestFill = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblStartGame = new System.Windows.Forms.Label();
            this.flpForm = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpInputForm = new System.Windows.Forms.TableLayoutPanel();
            this.lblInputPlayer1 = new System.Windows.Forms.Label();
            this.tbPlayer1Name = new System.Windows.Forms.TextBox();
            this.lblInputPlayer2 = new System.Windows.Forms.Label();
            this.lblInputPlayer3 = new System.Windows.Forms.Label();
            this.lblInputPlayer4 = new System.Windows.Forms.Label();
            this.lblInputPlayer5 = new System.Windows.Forms.Label();
            this.lblInputPlayer6 = new System.Windows.Forms.Label();
            this.lblInputPlayer7 = new System.Windows.Forms.Label();
            this.tbPlayer2Name = new System.Windows.Forms.TextBox();
            this.tbPlayer3Name = new System.Windows.Forms.TextBox();
            this.tbPlayer4Name = new System.Windows.Forms.TextBox();
            this.tbPlayer5Name = new System.Windows.Forms.TextBox();
            this.tbPlayer6Name = new System.Windows.Forms.TextBox();
            this.tbPlayer7Name = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flpButtons.SuspendLayout();
            this.flpForm.SuspendLayout();
            this.tlpInputForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.15194F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.21555F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.72085F));
            this.tableLayoutPanel1.Controls.Add(this.flpButtons, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblStartGame, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flpForm, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1195, 811);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flpButtons
            // 
            this.flpButtons.Controls.Add(this.btnCancel);
            this.flpButtons.Controls.Add(this.btnTestFill);
            this.flpButtons.Controls.Add(this.btnStart);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpButtons.Location = new System.Drawing.Point(351, 651);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(390, 157);
            this.flpButtons.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(312, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnTestFill
            // 
            this.btnTestFill.Location = new System.Drawing.Point(231, 3);
            this.btnTestFill.Name = "btnTestFill";
            this.btnTestFill.Size = new System.Drawing.Size(75, 23);
            this.btnTestFill.TabIndex = 2;
            this.btnTestFill.Text = "Fill Form";
            this.btnTestFill.UseVisualStyleBackColor = true;
            this.btnTestFill.Click += new System.EventHandler(this.btnTestFill_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(150, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblStartGame
            // 
            this.lblStartGame.AutoSize = true;
            this.lblStartGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStartGame.Location = new System.Drawing.Point(351, 0);
            this.lblStartGame.Name = "lblStartGame";
            this.lblStartGame.Size = new System.Drawing.Size(390, 81);
            this.lblStartGame.TabIndex = 1;
            this.lblStartGame.Text = "Start a New Game";
            this.lblStartGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpForm
            // 
            this.flpForm.Controls.Add(this.tlpInputForm);
            this.flpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpForm.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpForm.Location = new System.Drawing.Point(351, 84);
            this.flpForm.Name = "flpForm";
            this.flpForm.Size = new System.Drawing.Size(390, 561);
            this.flpForm.TabIndex = 4;
            // 
            // tlpInputForm
            // 
            this.tlpInputForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpInputForm.ColumnCount = 2;
            this.tlpInputForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpInputForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tlpInputForm.Controls.Add(this.lblInputPlayer1, 0, 0);
            this.tlpInputForm.Controls.Add(this.tbPlayer1Name, 1, 0);
            this.tlpInputForm.Controls.Add(this.lblInputPlayer2, 0, 1);
            this.tlpInputForm.Controls.Add(this.lblInputPlayer3, 0, 2);
            this.tlpInputForm.Controls.Add(this.lblInputPlayer4, 0, 3);
            this.tlpInputForm.Controls.Add(this.lblInputPlayer5, 0, 4);
            this.tlpInputForm.Controls.Add(this.lblInputPlayer6, 0, 5);
            this.tlpInputForm.Controls.Add(this.lblInputPlayer7, 0, 6);
            this.tlpInputForm.Controls.Add(this.tbPlayer2Name, 1, 1);
            this.tlpInputForm.Controls.Add(this.tbPlayer3Name, 1, 2);
            this.tlpInputForm.Controls.Add(this.tbPlayer4Name, 1, 3);
            this.tlpInputForm.Controls.Add(this.tbPlayer5Name, 1, 4);
            this.tlpInputForm.Controls.Add(this.tbPlayer6Name, 1, 5);
            this.tlpInputForm.Controls.Add(this.tbPlayer7Name, 1, 6);
            this.tlpInputForm.Location = new System.Drawing.Point(3, 3);
            this.tlpInputForm.Name = "tlpInputForm";
            this.tlpInputForm.RowCount = 8;
            this.tlpInputForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpInputForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpInputForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpInputForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpInputForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpInputForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpInputForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpInputForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpInputForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInputForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInputForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInputForm.Size = new System.Drawing.Size(362, 200);
            this.tlpInputForm.TabIndex = 2;
            // 
            // lblInputPlayer1
            // 
            this.lblInputPlayer1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInputPlayer1.AutoSize = true;
            this.lblInputPlayer1.Location = new System.Drawing.Point(72, 7);
            this.lblInputPlayer1.Name = "lblInputPlayer1";
            this.lblInputPlayer1.Size = new System.Drawing.Size(45, 13);
            this.lblInputPlayer1.TabIndex = 0;
            this.lblInputPlayer1.Text = "Player 1";
            // 
            // tbPlayer1Name
            // 
            this.tbPlayer1Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlayer1Name.Location = new System.Drawing.Point(123, 4);
            this.tbPlayer1Name.Name = "tbPlayer1Name";
            this.tbPlayer1Name.Size = new System.Drawing.Size(236, 20);
            this.tbPlayer1Name.TabIndex = 1;
            // 
            // lblInputPlayer2
            // 
            this.lblInputPlayer2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInputPlayer2.AutoSize = true;
            this.lblInputPlayer2.Location = new System.Drawing.Point(72, 35);
            this.lblInputPlayer2.Name = "lblInputPlayer2";
            this.lblInputPlayer2.Size = new System.Drawing.Size(45, 13);
            this.lblInputPlayer2.TabIndex = 2;
            this.lblInputPlayer2.Text = "Player 2";
            // 
            // lblInputPlayer3
            // 
            this.lblInputPlayer3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInputPlayer3.AutoSize = true;
            this.lblInputPlayer3.Location = new System.Drawing.Point(72, 63);
            this.lblInputPlayer3.Name = "lblInputPlayer3";
            this.lblInputPlayer3.Size = new System.Drawing.Size(45, 13);
            this.lblInputPlayer3.TabIndex = 3;
            this.lblInputPlayer3.Text = "Player 3";
            // 
            // lblInputPlayer4
            // 
            this.lblInputPlayer4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInputPlayer4.AutoSize = true;
            this.lblInputPlayer4.Location = new System.Drawing.Point(72, 91);
            this.lblInputPlayer4.Name = "lblInputPlayer4";
            this.lblInputPlayer4.Size = new System.Drawing.Size(45, 13);
            this.lblInputPlayer4.TabIndex = 4;
            this.lblInputPlayer4.Text = "Player 4";
            // 
            // lblInputPlayer5
            // 
            this.lblInputPlayer5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInputPlayer5.AutoSize = true;
            this.lblInputPlayer5.Location = new System.Drawing.Point(72, 119);
            this.lblInputPlayer5.Name = "lblInputPlayer5";
            this.lblInputPlayer5.Size = new System.Drawing.Size(45, 13);
            this.lblInputPlayer5.TabIndex = 5;
            this.lblInputPlayer5.Text = "Player 5";
            // 
            // lblInputPlayer6
            // 
            this.lblInputPlayer6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInputPlayer6.AutoSize = true;
            this.lblInputPlayer6.Location = new System.Drawing.Point(72, 147);
            this.lblInputPlayer6.Name = "lblInputPlayer6";
            this.lblInputPlayer6.Size = new System.Drawing.Size(45, 13);
            this.lblInputPlayer6.TabIndex = 6;
            this.lblInputPlayer6.Text = "Player 6";
            // 
            // lblInputPlayer7
            // 
            this.lblInputPlayer7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInputPlayer7.AutoSize = true;
            this.lblInputPlayer7.Location = new System.Drawing.Point(72, 175);
            this.lblInputPlayer7.Name = "lblInputPlayer7";
            this.lblInputPlayer7.Size = new System.Drawing.Size(45, 13);
            this.lblInputPlayer7.TabIndex = 7;
            this.lblInputPlayer7.Text = "Player 7";
            // 
            // tbPlayer2Name
            // 
            this.tbPlayer2Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlayer2Name.Location = new System.Drawing.Point(123, 32);
            this.tbPlayer2Name.Name = "tbPlayer2Name";
            this.tbPlayer2Name.Size = new System.Drawing.Size(236, 20);
            this.tbPlayer2Name.TabIndex = 8;
            // 
            // tbPlayer3Name
            // 
            this.tbPlayer3Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlayer3Name.Location = new System.Drawing.Point(123, 60);
            this.tbPlayer3Name.Name = "tbPlayer3Name";
            this.tbPlayer3Name.Size = new System.Drawing.Size(236, 20);
            this.tbPlayer3Name.TabIndex = 9;
            // 
            // tbPlayer4Name
            // 
            this.tbPlayer4Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlayer4Name.Location = new System.Drawing.Point(123, 88);
            this.tbPlayer4Name.Name = "tbPlayer4Name";
            this.tbPlayer4Name.Size = new System.Drawing.Size(236, 20);
            this.tbPlayer4Name.TabIndex = 10;
            // 
            // tbPlayer5Name
            // 
            this.tbPlayer5Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlayer5Name.Location = new System.Drawing.Point(123, 116);
            this.tbPlayer5Name.Name = "tbPlayer5Name";
            this.tbPlayer5Name.Size = new System.Drawing.Size(236, 20);
            this.tbPlayer5Name.TabIndex = 11;
            // 
            // tbPlayer6Name
            // 
            this.tbPlayer6Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlayer6Name.Location = new System.Drawing.Point(123, 144);
            this.tbPlayer6Name.Name = "tbPlayer6Name";
            this.tbPlayer6Name.Size = new System.Drawing.Size(236, 20);
            this.tbPlayer6Name.TabIndex = 12;
            // 
            // tbPlayer7Name
            // 
            this.tbPlayer7Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlayer7Name.Location = new System.Drawing.Point(123, 172);
            this.tbPlayer7Name.Name = "tbPlayer7Name";
            this.tbPlayer7Name.Size = new System.Drawing.Size(236, 20);
            this.tbPlayer7Name.TabIndex = 13;
            // 
            // StartGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 811);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StartGameForm";
            this.Text = "Start New Game";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flpButtons.ResumeLayout(false);
            this.flpForm.ResumeLayout(false);
            this.tlpInputForm.ResumeLayout(false);
            this.tlpInputForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Label lblStartGame;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTestFill;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.FlowLayoutPanel flpForm;
        private System.Windows.Forms.TableLayoutPanel tlpInputForm;
        private System.Windows.Forms.Label lblInputPlayer1;
        private System.Windows.Forms.TextBox tbPlayer1Name;
        private System.Windows.Forms.Label lblInputPlayer2;
        private System.Windows.Forms.Label lblInputPlayer3;
        private System.Windows.Forms.Label lblInputPlayer4;
        private System.Windows.Forms.Label lblInputPlayer5;
        private System.Windows.Forms.Label lblInputPlayer6;
        private System.Windows.Forms.Label lblInputPlayer7;
        private System.Windows.Forms.TextBox tbPlayer2Name;
        private System.Windows.Forms.TextBox tbPlayer3Name;
        private System.Windows.Forms.TextBox tbPlayer4Name;
        private System.Windows.Forms.TextBox tbPlayer5Name;
        private System.Windows.Forms.TextBox tbPlayer6Name;
        private System.Windows.Forms.TextBox tbPlayer7Name;
    }
}