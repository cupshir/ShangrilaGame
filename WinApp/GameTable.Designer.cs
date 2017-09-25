using System.Collections.Generic;
using GameCore;

namespace WinApp
{
    partial class GameTable
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
            this.pnlDiscardPile = new System.Windows.Forms.Panel();
            this.rtbDiscardPile = new System.Windows.Forms.RichTextBox();
            this.pnlPlayer7 = new System.Windows.Forms.Panel();
            this.rtbPlayer7Name = new System.Windows.Forms.RichTextBox();
            this.pnlPlayer6 = new System.Windows.Forms.Panel();
            this.rtbPlayer6Name = new System.Windows.Forms.RichTextBox();
            this.pnlPlayer5 = new System.Windows.Forms.Panel();
            this.rtbPlayer5Name = new System.Windows.Forms.RichTextBox();
            this.pnlPlayer4 = new System.Windows.Forms.Panel();
            this.rtbPlayer4Name = new System.Windows.Forms.RichTextBox();
            this.pnlPlayer3 = new System.Windows.Forms.Panel();
            this.rtbPlayer3Name = new System.Windows.Forms.RichTextBox();
            this.pnlPlayer2 = new System.Windows.Forms.Panel();
            this.rtbPlayer2Name = new System.Windows.Forms.RichTextBox();
            this.pnlPlayer1 = new System.Windows.Forms.Panel();
            this.rtbPlayer1Name = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRifleShuffle = new System.Windows.Forms.Button();
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnPickDealer = new System.Windows.Forms.Button();
            this.btnOverhandShuffle = new System.Windows.Forms.Button();
            this.flpPlayer3Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPlayer3Discard = new System.Windows.Forms.Button();
            this.btnPlayer3Draw = new System.Windows.Forms.Button();
            this.flpPlayer4Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPlayer5Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPlayer6Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPlayer7Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPlayer1Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPlayer2Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPlayer2Discard = new System.Windows.Forms.Button();
            this.btnPlayer1Discard = new System.Windows.Forms.Button();
            this.btnPlayer7Discard = new System.Windows.Forms.Button();
            this.btnPlayer6Discard = new System.Windows.Forms.Button();
            this.btnPlayer5Discard = new System.Windows.Forms.Button();
            this.btnPlayer4Discard = new System.Windows.Forms.Button();
            this.btnPlayer1Draw = new System.Windows.Forms.Button();
            this.btnPlayer2Draw = new System.Windows.Forms.Button();
            this.btnPlayer4Draw = new System.Windows.Forms.Button();
            this.btnPlayer5Draw = new System.Windows.Forms.Button();
            this.btnPlayer6Draw = new System.Windows.Forms.Button();
            this.btnPlayer7Draw = new System.Windows.Forms.Button();
            this.tlpPlayer1Hand = new System.Windows.Forms.TableLayoutPanel();
            this.rtbPlayer1Hand1 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer1Hand2 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer1Hand3 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer1Hand4 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer1Hand5 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer1Hand6 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer1Hand7 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer1Hand8 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer1Hand9 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer1Hand10 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer1Hand11 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer1Hand12 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer1Hand13 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer1Hand14 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer1Hand15 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer1Hand16 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer1Hand17 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer1Hand18 = new System.Windows.Forms.RichTextBox();
            this.tlpPlayer2Hand = new System.Windows.Forms.TableLayoutPanel();
            this.rtbPlayer2Hand1 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer2Hand2 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer2Hand3 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer2Hand4 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer2Hand5 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer2Hand6 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer2Hand7 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer2Hand8 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer2Hand9 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer2Hand10 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer2Hand11 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer2Hand12 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer2Hand13 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer2Hand14 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer2Hand15 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer2Hand16 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer2Hand17 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer2Hand18 = new System.Windows.Forms.RichTextBox();
            this.tlpPlayer3Hand = new System.Windows.Forms.TableLayoutPanel();
            this.rtbPlayer3Hand1 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer3Hand2 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer3Hand3 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer3Hand4 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer3Hand5 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer3Hand6 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer3Hand7 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer3Hand8 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer3Hand9 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer3Hand10 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer3Hand11 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer3Hand12 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer3Hand13 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer3Hand14 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer3Hand15 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer3Hand16 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer3Hand17 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer3Hand18 = new System.Windows.Forms.RichTextBox();
            this.tlpPlayer4Hand = new System.Windows.Forms.TableLayoutPanel();
            this.rtbPlayer4Hand1 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer4Hand2 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer4Hand3 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer4Hand4 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer4Hand5 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer4Hand6 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer4Hand7 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer4Hand8 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer4Hand9 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer4Hand10 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer4Hand11 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer4Hand12 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer4Hand13 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer4Hand14 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer4Hand15 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer4Hand16 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer4Hand17 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer4Hand18 = new System.Windows.Forms.RichTextBox();
            this.tlpPlayer5Hand = new System.Windows.Forms.TableLayoutPanel();
            this.rtbPlayer5Hand1 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer5Hand2 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer5Hand3 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer5Hand4 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer5Hand5 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer5Hand6 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer5Hand7 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer5Hand8 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer5Hand9 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer5Hand10 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer5Hand11 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer5Hand12 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer5Hand13 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer5Hand14 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer5Hand15 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer5Hand16 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer5Hand17 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer5Hand18 = new System.Windows.Forms.RichTextBox();
            this.tlpPlayer6Hand = new System.Windows.Forms.TableLayoutPanel();
            this.rtbPlayer6Hand1 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer6Hand2 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer6Hand3 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer6Hand4 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer6Hand5 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer6Hand6 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer6Hand7 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer6Hand8 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer6Hand9 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer6Hand10 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer6Hand11 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer6Hand12 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer6Hand13 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer6Hand14 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer6Hand15 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer6Hand16 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer6Hand17 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer6Hand18 = new System.Windows.Forms.RichTextBox();
            this.tlpPlayer7Hand = new System.Windows.Forms.TableLayoutPanel();
            this.rtbPlayer7Hand1 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer7Hand2 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer7Hand3 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer7Hand4 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer7Hand5 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer7Hand6 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer7Hand7 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer7Hand8 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer7Hand9 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer7Hand10 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer7Hand11 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer7Hand12 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer7Hand13 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer7Hand14 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer7Hand15 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer7Hand16 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer7Hand17 = new System.Windows.Forms.RichTextBox();
            this.rtbPlayer7Hand18 = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.rtbDeck = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlDiscardPile.SuspendLayout();
            this.pnlPlayer7.SuspendLayout();
            this.pnlPlayer6.SuspendLayout();
            this.pnlPlayer5.SuspendLayout();
            this.pnlPlayer4.SuspendLayout();
            this.pnlPlayer3.SuspendLayout();
            this.pnlPlayer2.SuspendLayout();
            this.pnlPlayer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flpPlayer3Buttons.SuspendLayout();
            this.flpPlayer4Buttons.SuspendLayout();
            this.flpPlayer5Buttons.SuspendLayout();
            this.flpPlayer6Buttons.SuspendLayout();
            this.flpPlayer7Buttons.SuspendLayout();
            this.flpPlayer1Buttons.SuspendLayout();
            this.flpPlayer2Buttons.SuspendLayout();
            this.tlpPlayer1Hand.SuspendLayout();
            this.tlpPlayer2Hand.SuspendLayout();
            this.tlpPlayer3Hand.SuspendLayout();
            this.tlpPlayer4Hand.SuspendLayout();
            this.tlpPlayer5Hand.SuspendLayout();
            this.tlpPlayer6Hand.SuspendLayout();
            this.tlpPlayer7Hand.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pnlDiscardPile, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlPlayer7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnlPlayer6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlPlayer5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlPlayer4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlPlayer3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlPlayer2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlPlayer1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1192, 797);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlDiscardPile
            // 
            this.pnlDiscardPile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDiscardPile.Controls.Add(this.rtbDiscardPile);
            this.pnlDiscardPile.Controls.Add(this.rtbDeck);
            this.pnlDiscardPile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDiscardPile.Location = new System.Drawing.Point(400, 268);
            this.pnlDiscardPile.Name = "pnlDiscardPile";
            this.pnlDiscardPile.Size = new System.Drawing.Size(391, 259);
            this.pnlDiscardPile.TabIndex = 10;
            // 
            // rtbDiscardPile
            // 
            this.rtbDiscardPile.BackColor = System.Drawing.SystemColors.Control;
            this.rtbDiscardPile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbDiscardPile.Location = new System.Drawing.Point(0, 141);
            this.rtbDiscardPile.Name = "rtbDiscardPile";
            this.rtbDiscardPile.Size = new System.Drawing.Size(387, 114);
            this.rtbDiscardPile.TabIndex = 3;
            this.rtbDiscardPile.Text = "Discard Pile";
            // 
            // pnlPlayer7
            // 
            this.pnlPlayer7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlayer7.Controls.Add(this.tlpPlayer7Hand);
            this.pnlPlayer7.Controls.Add(this.flpPlayer7Buttons);
            this.pnlPlayer7.Controls.Add(this.rtbPlayer7Name);
            this.pnlPlayer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlayer7.Location = new System.Drawing.Point(797, 533);
            this.pnlPlayer7.Name = "pnlPlayer7";
            this.pnlPlayer7.Size = new System.Drawing.Size(392, 261);
            this.pnlPlayer7.TabIndex = 11;
            // 
            // rtbPlayer7Name
            // 
            this.rtbPlayer7Name.BackColor = System.Drawing.SystemColors.Control;
            this.rtbPlayer7Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPlayer7Name.Location = new System.Drawing.Point(0, 5);
            this.rtbPlayer7Name.Name = "rtbPlayer7Name";
            this.rtbPlayer7Name.Size = new System.Drawing.Size(195, 16);
            this.rtbPlayer7Name.TabIndex = 0;
            this.rtbPlayer7Name.Text = "Player 7 Name";
            // 
            // pnlPlayer6
            // 
            this.pnlPlayer6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlayer6.Controls.Add(this.tlpPlayer6Hand);
            this.pnlPlayer6.Controls.Add(this.flpPlayer6Buttons);
            this.pnlPlayer6.Controls.Add(this.rtbPlayer6Name);
            this.pnlPlayer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlayer6.Location = new System.Drawing.Point(797, 268);
            this.pnlPlayer6.Name = "pnlPlayer6";
            this.pnlPlayer6.Size = new System.Drawing.Size(392, 259);
            this.pnlPlayer6.TabIndex = 12;
            // 
            // rtbPlayer6Name
            // 
            this.rtbPlayer6Name.BackColor = System.Drawing.SystemColors.Control;
            this.rtbPlayer6Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPlayer6Name.Location = new System.Drawing.Point(0, 5);
            this.rtbPlayer6Name.Name = "rtbPlayer6Name";
            this.rtbPlayer6Name.Size = new System.Drawing.Size(195, 16);
            this.rtbPlayer6Name.TabIndex = 0;
            this.rtbPlayer6Name.Text = "Player 6 Name";
            // 
            // pnlPlayer5
            // 
            this.pnlPlayer5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlayer5.Controls.Add(this.tlpPlayer5Hand);
            this.pnlPlayer5.Controls.Add(this.flpPlayer5Buttons);
            this.pnlPlayer5.Controls.Add(this.rtbPlayer5Name);
            this.pnlPlayer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlayer5.Location = new System.Drawing.Point(797, 3);
            this.pnlPlayer5.Name = "pnlPlayer5";
            this.pnlPlayer5.Size = new System.Drawing.Size(392, 259);
            this.pnlPlayer5.TabIndex = 13;
            // 
            // rtbPlayer5Name
            // 
            this.rtbPlayer5Name.BackColor = System.Drawing.SystemColors.Control;
            this.rtbPlayer5Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPlayer5Name.Location = new System.Drawing.Point(0, 5);
            this.rtbPlayer5Name.Name = "rtbPlayer5Name";
            this.rtbPlayer5Name.Size = new System.Drawing.Size(195, 16);
            this.rtbPlayer5Name.TabIndex = 0;
            this.rtbPlayer5Name.Text = "Player 5 Name";
            // 
            // pnlPlayer4
            // 
            this.pnlPlayer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlayer4.Controls.Add(this.tlpPlayer4Hand);
            this.pnlPlayer4.Controls.Add(this.flpPlayer4Buttons);
            this.pnlPlayer4.Controls.Add(this.rtbPlayer4Name);
            this.pnlPlayer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlayer4.Location = new System.Drawing.Point(400, 3);
            this.pnlPlayer4.Name = "pnlPlayer4";
            this.pnlPlayer4.Size = new System.Drawing.Size(391, 259);
            this.pnlPlayer4.TabIndex = 14;
            // 
            // rtbPlayer4Name
            // 
            this.rtbPlayer4Name.BackColor = System.Drawing.SystemColors.Control;
            this.rtbPlayer4Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPlayer4Name.Location = new System.Drawing.Point(0, 5);
            this.rtbPlayer4Name.Name = "rtbPlayer4Name";
            this.rtbPlayer4Name.Size = new System.Drawing.Size(195, 16);
            this.rtbPlayer4Name.TabIndex = 0;
            this.rtbPlayer4Name.Text = "Player 4 Name";
            // 
            // pnlPlayer3
            // 
            this.pnlPlayer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlayer3.Controls.Add(this.tlpPlayer3Hand);
            this.pnlPlayer3.Controls.Add(this.flpPlayer3Buttons);
            this.pnlPlayer3.Controls.Add(this.rtbPlayer3Name);
            this.pnlPlayer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlayer3.Location = new System.Drawing.Point(3, 3);
            this.pnlPlayer3.Name = "pnlPlayer3";
            this.pnlPlayer3.Size = new System.Drawing.Size(391, 259);
            this.pnlPlayer3.TabIndex = 15;
            // 
            // rtbPlayer3Name
            // 
            this.rtbPlayer3Name.BackColor = System.Drawing.SystemColors.Control;
            this.rtbPlayer3Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPlayer3Name.Location = new System.Drawing.Point(0, 5);
            this.rtbPlayer3Name.Name = "rtbPlayer3Name";
            this.rtbPlayer3Name.Size = new System.Drawing.Size(195, 16);
            this.rtbPlayer3Name.TabIndex = 0;
            this.rtbPlayer3Name.Text = "Player 3 Name";
            // 
            // pnlPlayer2
            // 
            this.pnlPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlayer2.Controls.Add(this.tlpPlayer2Hand);
            this.pnlPlayer2.Controls.Add(this.flpPlayer2Buttons);
            this.pnlPlayer2.Controls.Add(this.rtbPlayer2Name);
            this.pnlPlayer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlayer2.Location = new System.Drawing.Point(3, 268);
            this.pnlPlayer2.Name = "pnlPlayer2";
            this.pnlPlayer2.Size = new System.Drawing.Size(391, 259);
            this.pnlPlayer2.TabIndex = 16;
            // 
            // rtbPlayer2Name
            // 
            this.rtbPlayer2Name.BackColor = System.Drawing.SystemColors.Control;
            this.rtbPlayer2Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPlayer2Name.Location = new System.Drawing.Point(0, 5);
            this.rtbPlayer2Name.Name = "rtbPlayer2Name";
            this.rtbPlayer2Name.Size = new System.Drawing.Size(195, 16);
            this.rtbPlayer2Name.TabIndex = 0;
            this.rtbPlayer2Name.Text = "Player 2 Name";
            // 
            // pnlPlayer1
            // 
            this.pnlPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlayer1.Controls.Add(this.tlpPlayer1Hand);
            this.pnlPlayer1.Controls.Add(this.flpPlayer1Buttons);
            this.pnlPlayer1.Controls.Add(this.rtbPlayer1Name);
            this.pnlPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlayer1.Location = new System.Drawing.Point(3, 533);
            this.pnlPlayer1.Name = "pnlPlayer1";
            this.pnlPlayer1.Size = new System.Drawing.Size(391, 261);
            this.pnlPlayer1.TabIndex = 17;
            // 
            // rtbPlayer1Name
            // 
            this.rtbPlayer1Name.BackColor = System.Drawing.SystemColors.Control;
            this.rtbPlayer1Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPlayer1Name.Location = new System.Drawing.Point(0, 5);
            this.rtbPlayer1Name.Name = "rtbPlayer1Name";
            this.rtbPlayer1Name.Size = new System.Drawing.Size(195, 16);
            this.rtbPlayer1Name.TabIndex = 0;
            this.rtbPlayer1Name.Text = "Player 1 Name";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnRifleShuffle);
            this.flowLayoutPanel1.Controls.Add(this.btnOverhandShuffle);
            this.flowLayoutPanel1.Controls.Add(this.btnDeal);
            this.flowLayoutPanel1.Controls.Add(this.btnPickDealer);
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(400, 733);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(391, 61);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // btnRifleShuffle
            // 
            this.btnRifleShuffle.Location = new System.Drawing.Point(3, 3);
            this.btnRifleShuffle.Name = "btnRifleShuffle";
            this.btnRifleShuffle.Size = new System.Drawing.Size(75, 25);
            this.btnRifleShuffle.TabIndex = 0;
            this.btnRifleShuffle.Text = "Riffle Shuffle";
            this.btnRifleShuffle.UseVisualStyleBackColor = true;
            this.btnRifleShuffle.Click += new System.EventHandler(this.btnRiffleShuffle_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(190, 3);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(75, 25);
            this.btnDeal.TabIndex = 1;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // btnPickDealer
            // 
            this.btnPickDealer.Location = new System.Drawing.Point(271, 3);
            this.btnPickDealer.Name = "btnPickDealer";
            this.btnPickDealer.Size = new System.Drawing.Size(75, 25);
            this.btnPickDealer.TabIndex = 2;
            this.btnPickDealer.Text = "Pick Dealer";
            this.btnPickDealer.UseVisualStyleBackColor = true;
            this.btnPickDealer.Click += new System.EventHandler(this.btnPickDealer_Click);
            // 
            // btnOverhandShuffle
            // 
            this.btnOverhandShuffle.AutoSize = true;
            this.btnOverhandShuffle.Location = new System.Drawing.Point(84, 3);
            this.btnOverhandShuffle.Name = "btnOverhandShuffle";
            this.btnOverhandShuffle.Size = new System.Drawing.Size(100, 23);
            this.btnOverhandShuffle.TabIndex = 3;
            this.btnOverhandShuffle.Text = "Overhand Shuffle";
            this.btnOverhandShuffle.UseVisualStyleBackColor = true;
            this.btnOverhandShuffle.Click += new System.EventHandler(this.btnOverhandShuffle_Click);
            // 
            // flpPlayer3Buttons
            // 
            this.flpPlayer3Buttons.Controls.Add(this.btnPlayer3Discard);
            this.flpPlayer3Buttons.Controls.Add(this.btnPlayer3Draw);
            this.flpPlayer3Buttons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpPlayer3Buttons.Location = new System.Drawing.Point(212, 0);
            this.flpPlayer3Buttons.Name = "flpPlayer3Buttons";
            this.flpPlayer3Buttons.Size = new System.Drawing.Size(164, 29);
            this.flpPlayer3Buttons.TabIndex = 4;
            // 
            // btnPlayer3Discard
            // 
            this.btnPlayer3Discard.Location = new System.Drawing.Point(86, 3);
            this.btnPlayer3Discard.Name = "btnPlayer3Discard";
            this.btnPlayer3Discard.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer3Discard.TabIndex = 0;
            this.btnPlayer3Discard.Text = "Discard";
            this.btnPlayer3Discard.UseVisualStyleBackColor = true;
            this.btnPlayer3Discard.Visible = false;
            // 
            // btnPlayer3Draw
            // 
            this.btnPlayer3Draw.Location = new System.Drawing.Point(5, 3);
            this.btnPlayer3Draw.Name = "btnPlayer3Draw";
            this.btnPlayer3Draw.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer3Draw.TabIndex = 1;
            this.btnPlayer3Draw.Text = "Draw";
            this.btnPlayer3Draw.UseVisualStyleBackColor = true;
            this.btnPlayer3Draw.Visible = false;
            this.btnPlayer3Draw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // flpPlayer4Buttons
            // 
            this.flpPlayer4Buttons.Controls.Add(this.btnPlayer4Discard);
            this.flpPlayer4Buttons.Controls.Add(this.btnPlayer4Draw);
            this.flpPlayer4Buttons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpPlayer4Buttons.Location = new System.Drawing.Point(212, 0);
            this.flpPlayer4Buttons.Name = "flpPlayer4Buttons";
            this.flpPlayer4Buttons.Size = new System.Drawing.Size(164, 29);
            this.flpPlayer4Buttons.TabIndex = 2;
            // 
            // flpPlayer5Buttons
            // 
            this.flpPlayer5Buttons.Controls.Add(this.btnPlayer5Discard);
            this.flpPlayer5Buttons.Controls.Add(this.btnPlayer5Draw);
            this.flpPlayer5Buttons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpPlayer5Buttons.Location = new System.Drawing.Point(212, 0);
            this.flpPlayer5Buttons.Name = "flpPlayer5Buttons";
            this.flpPlayer5Buttons.Size = new System.Drawing.Size(164, 29);
            this.flpPlayer5Buttons.TabIndex = 3;
            // 
            // flpPlayer6Buttons
            // 
            this.flpPlayer6Buttons.Controls.Add(this.btnPlayer6Discard);
            this.flpPlayer6Buttons.Controls.Add(this.btnPlayer6Draw);
            this.flpPlayer6Buttons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpPlayer6Buttons.Location = new System.Drawing.Point(212, 0);
            this.flpPlayer6Buttons.Name = "flpPlayer6Buttons";
            this.flpPlayer6Buttons.Size = new System.Drawing.Size(164, 29);
            this.flpPlayer6Buttons.TabIndex = 3;
            // 
            // flpPlayer7Buttons
            // 
            this.flpPlayer7Buttons.Controls.Add(this.btnPlayer7Discard);
            this.flpPlayer7Buttons.Controls.Add(this.btnPlayer7Draw);
            this.flpPlayer7Buttons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpPlayer7Buttons.Location = new System.Drawing.Point(212, 0);
            this.flpPlayer7Buttons.Name = "flpPlayer7Buttons";
            this.flpPlayer7Buttons.Size = new System.Drawing.Size(164, 29);
            this.flpPlayer7Buttons.TabIndex = 3;
            // 
            // flpPlayer1Buttons
            // 
            this.flpPlayer1Buttons.Controls.Add(this.btnPlayer1Discard);
            this.flpPlayer1Buttons.Controls.Add(this.btnPlayer1Draw);
            this.flpPlayer1Buttons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpPlayer1Buttons.Location = new System.Drawing.Point(212, 0);
            this.flpPlayer1Buttons.Name = "flpPlayer1Buttons";
            this.flpPlayer1Buttons.Size = new System.Drawing.Size(164, 29);
            this.flpPlayer1Buttons.TabIndex = 3;
            // 
            // flpPlayer2Buttons
            // 
            this.flpPlayer2Buttons.Controls.Add(this.btnPlayer2Discard);
            this.flpPlayer2Buttons.Controls.Add(this.btnPlayer2Draw);
            this.flpPlayer2Buttons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpPlayer2Buttons.Location = new System.Drawing.Point(212, 0);
            this.flpPlayer2Buttons.Name = "flpPlayer2Buttons";
            this.flpPlayer2Buttons.Size = new System.Drawing.Size(164, 29);
            this.flpPlayer2Buttons.TabIndex = 3;
            // 
            // btnPlayer2Discard
            // 
            this.btnPlayer2Discard.Location = new System.Drawing.Point(86, 3);
            this.btnPlayer2Discard.Name = "btnPlayer2Discard";
            this.btnPlayer2Discard.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer2Discard.TabIndex = 1;
            this.btnPlayer2Discard.Text = "Discard";
            this.btnPlayer2Discard.UseVisualStyleBackColor = true;
            this.btnPlayer2Discard.Visible = false;
            // 
            // btnPlayer1Discard
            // 
            this.btnPlayer1Discard.Location = new System.Drawing.Point(86, 3);
            this.btnPlayer1Discard.Name = "btnPlayer1Discard";
            this.btnPlayer1Discard.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer1Discard.TabIndex = 1;
            this.btnPlayer1Discard.Text = "Discard";
            this.btnPlayer1Discard.UseVisualStyleBackColor = true;
            this.btnPlayer1Discard.Visible = false;
            // 
            // btnPlayer7Discard
            // 
            this.btnPlayer7Discard.Location = new System.Drawing.Point(86, 3);
            this.btnPlayer7Discard.Name = "btnPlayer7Discard";
            this.btnPlayer7Discard.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer7Discard.TabIndex = 1;
            this.btnPlayer7Discard.Text = "Discard";
            this.btnPlayer7Discard.UseVisualStyleBackColor = true;
            this.btnPlayer7Discard.Visible = false;
            // 
            // btnPlayer6Discard
            // 
            this.btnPlayer6Discard.Location = new System.Drawing.Point(86, 3);
            this.btnPlayer6Discard.Name = "btnPlayer6Discard";
            this.btnPlayer6Discard.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer6Discard.TabIndex = 1;
            this.btnPlayer6Discard.Text = "Discard";
            this.btnPlayer6Discard.UseVisualStyleBackColor = true;
            this.btnPlayer6Discard.Visible = false;
            // 
            // btnPlayer5Discard
            // 
            this.btnPlayer5Discard.Location = new System.Drawing.Point(86, 3);
            this.btnPlayer5Discard.Name = "btnPlayer5Discard";
            this.btnPlayer5Discard.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer5Discard.TabIndex = 1;
            this.btnPlayer5Discard.Text = "Discard";
            this.btnPlayer5Discard.UseVisualStyleBackColor = true;
            this.btnPlayer5Discard.Visible = false;
            // 
            // btnPlayer4Discard
            // 
            this.btnPlayer4Discard.Location = new System.Drawing.Point(86, 3);
            this.btnPlayer4Discard.Name = "btnPlayer4Discard";
            this.btnPlayer4Discard.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer4Discard.TabIndex = 1;
            this.btnPlayer4Discard.Text = "Discard";
            this.btnPlayer4Discard.UseVisualStyleBackColor = true;
            this.btnPlayer4Discard.Visible = false;
            // 
            // btnPlayer1Draw
            // 
            this.btnPlayer1Draw.Location = new System.Drawing.Point(5, 3);
            this.btnPlayer1Draw.Name = "btnPlayer1Draw";
            this.btnPlayer1Draw.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer1Draw.TabIndex = 2;
            this.btnPlayer1Draw.Text = "Draw";
            this.btnPlayer1Draw.UseVisualStyleBackColor = true;
            this.btnPlayer1Draw.Visible = false;
            this.btnPlayer1Draw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnPlayer2Draw
            // 
            this.btnPlayer2Draw.Location = new System.Drawing.Point(5, 3);
            this.btnPlayer2Draw.Name = "btnPlayer2Draw";
            this.btnPlayer2Draw.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer2Draw.TabIndex = 2;
            this.btnPlayer2Draw.Text = "Draw";
            this.btnPlayer2Draw.UseVisualStyleBackColor = true;
            this.btnPlayer2Draw.Visible = false;
            this.btnPlayer2Draw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnPlayer4Draw
            // 
            this.btnPlayer4Draw.Location = new System.Drawing.Point(5, 3);
            this.btnPlayer4Draw.Name = "btnPlayer4Draw";
            this.btnPlayer4Draw.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer4Draw.TabIndex = 2;
            this.btnPlayer4Draw.Text = "Draw";
            this.btnPlayer4Draw.UseVisualStyleBackColor = true;
            this.btnPlayer4Draw.Visible = false;
            this.btnPlayer4Draw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnPlayer5Draw
            // 
            this.btnPlayer5Draw.Location = new System.Drawing.Point(5, 3);
            this.btnPlayer5Draw.Name = "btnPlayer5Draw";
            this.btnPlayer5Draw.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer5Draw.TabIndex = 2;
            this.btnPlayer5Draw.Text = "Draw";
            this.btnPlayer5Draw.UseVisualStyleBackColor = true;
            this.btnPlayer5Draw.Visible = false;
            this.btnPlayer5Draw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnPlayer6Draw
            // 
            this.btnPlayer6Draw.Location = new System.Drawing.Point(5, 3);
            this.btnPlayer6Draw.Name = "btnPlayer6Draw";
            this.btnPlayer6Draw.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer6Draw.TabIndex = 2;
            this.btnPlayer6Draw.Text = "Draw";
            this.btnPlayer6Draw.UseVisualStyleBackColor = true;
            this.btnPlayer6Draw.Visible = false;
            this.btnPlayer6Draw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnPlayer7Draw
            // 
            this.btnPlayer7Draw.Location = new System.Drawing.Point(5, 3);
            this.btnPlayer7Draw.Name = "btnPlayer7Draw";
            this.btnPlayer7Draw.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer7Draw.TabIndex = 2;
            this.btnPlayer7Draw.Text = "Draw";
            this.btnPlayer7Draw.UseVisualStyleBackColor = true;
            this.btnPlayer7Draw.Visible = false;
            this.btnPlayer7Draw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // tlpPlayer1Hand
            // 
            this.tlpPlayer1Hand.ColumnCount = 9;
            this.tlpPlayer1Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer1Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer1Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer1Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer1Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer1Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer1Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer1Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer1Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer1Hand.Controls.Add(this.rtbPlayer1Hand1, 0, 0);
            this.tlpPlayer1Hand.Controls.Add(this.rtbPlayer1Hand2, 1, 0);
            this.tlpPlayer1Hand.Controls.Add(this.rtbPlayer1Hand3, 2, 0);
            this.tlpPlayer1Hand.Controls.Add(this.rtbPlayer1Hand4, 3, 0);
            this.tlpPlayer1Hand.Controls.Add(this.rtbPlayer1Hand5, 4, 0);
            this.tlpPlayer1Hand.Controls.Add(this.rtbPlayer1Hand6, 5, 0);
            this.tlpPlayer1Hand.Controls.Add(this.rtbPlayer1Hand7, 6, 0);
            this.tlpPlayer1Hand.Controls.Add(this.rtbPlayer1Hand8, 7, 0);
            this.tlpPlayer1Hand.Controls.Add(this.rtbPlayer1Hand9, 8, 0);
            this.tlpPlayer1Hand.Controls.Add(this.rtbPlayer1Hand10, 0, 1);
            this.tlpPlayer1Hand.Controls.Add(this.rtbPlayer1Hand11, 1, 1);
            this.tlpPlayer1Hand.Controls.Add(this.rtbPlayer1Hand12, 2, 1);
            this.tlpPlayer1Hand.Controls.Add(this.rtbPlayer1Hand13, 3, 1);
            this.tlpPlayer1Hand.Controls.Add(this.rtbPlayer1Hand14, 4, 1);
            this.tlpPlayer1Hand.Controls.Add(this.rtbPlayer1Hand15, 5, 1);
            this.tlpPlayer1Hand.Controls.Add(this.rtbPlayer1Hand16, 6, 1);
            this.tlpPlayer1Hand.Controls.Add(this.rtbPlayer1Hand17, 7, 1);
            this.tlpPlayer1Hand.Controls.Add(this.rtbPlayer1Hand18, 8, 1);
            this.tlpPlayer1Hand.Location = new System.Drawing.Point(2, 35);
            this.tlpPlayer1Hand.Name = "tlpPlayer1Hand";
            this.tlpPlayer1Hand.RowCount = 2;
            this.tlpPlayer1Hand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlayer1Hand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlayer1Hand.Size = new System.Drawing.Size(360, 100);
            this.tlpPlayer1Hand.TabIndex = 4;
            // 
            // rtbPlayer1Hand1
            // 
            this.rtbPlayer1Hand1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer1Hand1.Location = new System.Drawing.Point(3, 3);
            this.rtbPlayer1Hand1.Name = "rtbPlayer1Hand1";
            this.rtbPlayer1Hand1.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer1Hand1.TabIndex = 0;
            this.rtbPlayer1Hand1.Text = "";
            // 
            // rtbPlayer1Hand2
            // 
            this.rtbPlayer1Hand2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer1Hand2.Location = new System.Drawing.Point(42, 3);
            this.rtbPlayer1Hand2.Name = "rtbPlayer1Hand2";
            this.rtbPlayer1Hand2.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer1Hand2.TabIndex = 1;
            this.rtbPlayer1Hand2.Text = "";
            // 
            // rtbPlayer1Hand3
            // 
            this.rtbPlayer1Hand3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer1Hand3.Location = new System.Drawing.Point(81, 3);
            this.rtbPlayer1Hand3.Name = "rtbPlayer1Hand3";
            this.rtbPlayer1Hand3.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer1Hand3.TabIndex = 2;
            this.rtbPlayer1Hand3.Text = "";
            // 
            // rtbPlayer1Hand4
            // 
            this.rtbPlayer1Hand4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer1Hand4.Location = new System.Drawing.Point(120, 3);
            this.rtbPlayer1Hand4.Name = "rtbPlayer1Hand4";
            this.rtbPlayer1Hand4.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer1Hand4.TabIndex = 3;
            this.rtbPlayer1Hand4.Text = "";
            // 
            // rtbPlayer1Hand5
            // 
            this.rtbPlayer1Hand5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer1Hand5.Location = new System.Drawing.Point(159, 3);
            this.rtbPlayer1Hand5.Name = "rtbPlayer1Hand5";
            this.rtbPlayer1Hand5.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer1Hand5.TabIndex = 4;
            this.rtbPlayer1Hand5.Text = "";
            // 
            // rtbPlayer1Hand6
            // 
            this.rtbPlayer1Hand6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer1Hand6.Location = new System.Drawing.Point(198, 3);
            this.rtbPlayer1Hand6.Name = "rtbPlayer1Hand6";
            this.rtbPlayer1Hand6.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer1Hand6.TabIndex = 5;
            this.rtbPlayer1Hand6.Text = "";
            // 
            // rtbPlayer1Hand7
            // 
            this.rtbPlayer1Hand7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer1Hand7.Location = new System.Drawing.Point(237, 3);
            this.rtbPlayer1Hand7.Name = "rtbPlayer1Hand7";
            this.rtbPlayer1Hand7.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer1Hand7.TabIndex = 6;
            this.rtbPlayer1Hand7.Text = "";
            // 
            // rtbPlayer1Hand8
            // 
            this.rtbPlayer1Hand8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer1Hand8.Location = new System.Drawing.Point(276, 3);
            this.rtbPlayer1Hand8.Name = "rtbPlayer1Hand8";
            this.rtbPlayer1Hand8.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer1Hand8.TabIndex = 7;
            this.rtbPlayer1Hand8.Text = "";
            // 
            // rtbPlayer1Hand9
            // 
            this.rtbPlayer1Hand9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer1Hand9.Location = new System.Drawing.Point(315, 3);
            this.rtbPlayer1Hand9.Name = "rtbPlayer1Hand9";
            this.rtbPlayer1Hand9.Size = new System.Drawing.Size(42, 44);
            this.rtbPlayer1Hand9.TabIndex = 8;
            this.rtbPlayer1Hand9.Text = "";
            // 
            // rtbPlayer1Hand10
            // 
            this.rtbPlayer1Hand10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer1Hand10.Location = new System.Drawing.Point(3, 53);
            this.rtbPlayer1Hand10.Name = "rtbPlayer1Hand10";
            this.rtbPlayer1Hand10.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer1Hand10.TabIndex = 9;
            this.rtbPlayer1Hand10.Text = "";
            // 
            // rtbPlayer1Hand11
            // 
            this.rtbPlayer1Hand11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer1Hand11.Location = new System.Drawing.Point(42, 53);
            this.rtbPlayer1Hand11.Name = "rtbPlayer1Hand11";
            this.rtbPlayer1Hand11.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer1Hand11.TabIndex = 10;
            this.rtbPlayer1Hand11.Text = "";
            // 
            // rtbPlayer1Hand12
            // 
            this.rtbPlayer1Hand12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer1Hand12.Location = new System.Drawing.Point(81, 53);
            this.rtbPlayer1Hand12.Name = "rtbPlayer1Hand12";
            this.rtbPlayer1Hand12.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer1Hand12.TabIndex = 11;
            this.rtbPlayer1Hand12.Text = "";
            // 
            // rtbPlayer1Hand13
            // 
            this.rtbPlayer1Hand13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer1Hand13.Location = new System.Drawing.Point(120, 53);
            this.rtbPlayer1Hand13.Name = "rtbPlayer1Hand13";
            this.rtbPlayer1Hand13.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer1Hand13.TabIndex = 12;
            this.rtbPlayer1Hand13.Text = "";
            // 
            // rtbPlayer1Hand14
            // 
            this.rtbPlayer1Hand14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer1Hand14.Location = new System.Drawing.Point(159, 53);
            this.rtbPlayer1Hand14.Name = "rtbPlayer1Hand14";
            this.rtbPlayer1Hand14.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer1Hand14.TabIndex = 13;
            this.rtbPlayer1Hand14.Text = "";
            // 
            // rtbPlayer1Hand15
            // 
            this.rtbPlayer1Hand15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer1Hand15.Location = new System.Drawing.Point(198, 53);
            this.rtbPlayer1Hand15.Name = "rtbPlayer1Hand15";
            this.rtbPlayer1Hand15.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer1Hand15.TabIndex = 14;
            this.rtbPlayer1Hand15.Text = "";
            // 
            // rtbPlayer1Hand16
            // 
            this.rtbPlayer1Hand16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer1Hand16.Location = new System.Drawing.Point(237, 53);
            this.rtbPlayer1Hand16.Name = "rtbPlayer1Hand16";
            this.rtbPlayer1Hand16.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer1Hand16.TabIndex = 15;
            this.rtbPlayer1Hand16.Text = "";
            // 
            // rtbPlayer1Hand17
            // 
            this.rtbPlayer1Hand17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer1Hand17.Location = new System.Drawing.Point(276, 53);
            this.rtbPlayer1Hand17.Name = "rtbPlayer1Hand17";
            this.rtbPlayer1Hand17.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer1Hand17.TabIndex = 16;
            this.rtbPlayer1Hand17.Text = "";
            // 
            // rtbPlayer1Hand18
            // 
            this.rtbPlayer1Hand18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer1Hand18.Location = new System.Drawing.Point(315, 53);
            this.rtbPlayer1Hand18.Name = "rtbPlayer1Hand18";
            this.rtbPlayer1Hand18.Size = new System.Drawing.Size(42, 44);
            this.rtbPlayer1Hand18.TabIndex = 17;
            this.rtbPlayer1Hand18.Text = "";
            // 
            // tlpPlayer2Hand
            // 
            this.tlpPlayer2Hand.ColumnCount = 9;
            this.tlpPlayer2Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer2Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer2Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer2Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer2Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer2Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer2Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer2Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer2Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer2Hand.Controls.Add(this.rtbPlayer2Hand1, 0, 0);
            this.tlpPlayer2Hand.Controls.Add(this.rtbPlayer2Hand2, 1, 0);
            this.tlpPlayer2Hand.Controls.Add(this.rtbPlayer2Hand3, 2, 0);
            this.tlpPlayer2Hand.Controls.Add(this.rtbPlayer2Hand4, 3, 0);
            this.tlpPlayer2Hand.Controls.Add(this.rtbPlayer2Hand5, 4, 0);
            this.tlpPlayer2Hand.Controls.Add(this.rtbPlayer2Hand6, 5, 0);
            this.tlpPlayer2Hand.Controls.Add(this.rtbPlayer2Hand7, 6, 0);
            this.tlpPlayer2Hand.Controls.Add(this.rtbPlayer2Hand8, 7, 0);
            this.tlpPlayer2Hand.Controls.Add(this.rtbPlayer2Hand9, 8, 0);
            this.tlpPlayer2Hand.Controls.Add(this.rtbPlayer2Hand10, 0, 1);
            this.tlpPlayer2Hand.Controls.Add(this.rtbPlayer2Hand11, 1, 1);
            this.tlpPlayer2Hand.Controls.Add(this.rtbPlayer2Hand12, 2, 1);
            this.tlpPlayer2Hand.Controls.Add(this.rtbPlayer2Hand13, 3, 1);
            this.tlpPlayer2Hand.Controls.Add(this.rtbPlayer2Hand14, 4, 1);
            this.tlpPlayer2Hand.Controls.Add(this.rtbPlayer2Hand15, 5, 1);
            this.tlpPlayer2Hand.Controls.Add(this.rtbPlayer2Hand16, 6, 1);
            this.tlpPlayer2Hand.Controls.Add(this.rtbPlayer2Hand17, 7, 1);
            this.tlpPlayer2Hand.Controls.Add(this.rtbPlayer2Hand18, 8, 1);
            this.tlpPlayer2Hand.Location = new System.Drawing.Point(3, 32);
            this.tlpPlayer2Hand.Name = "tlpPlayer2Hand";
            this.tlpPlayer2Hand.RowCount = 2;
            this.tlpPlayer2Hand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlayer2Hand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlayer2Hand.Size = new System.Drawing.Size(360, 100);
            this.tlpPlayer2Hand.TabIndex = 5;
            // 
            // rtbPlayer2Hand1
            // 
            this.rtbPlayer2Hand1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer2Hand1.Location = new System.Drawing.Point(3, 3);
            this.rtbPlayer2Hand1.Name = "rtbPlayer2Hand1";
            this.rtbPlayer2Hand1.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer2Hand1.TabIndex = 0;
            this.rtbPlayer2Hand1.Text = "";
            // 
            // rtbPlayer2Hand2
            // 
            this.rtbPlayer2Hand2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer2Hand2.Location = new System.Drawing.Point(42, 3);
            this.rtbPlayer2Hand2.Name = "rtbPlayer2Hand2";
            this.rtbPlayer2Hand2.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer2Hand2.TabIndex = 1;
            this.rtbPlayer2Hand2.Text = "";
            // 
            // rtbPlayer2Hand3
            // 
            this.rtbPlayer2Hand3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer2Hand3.Location = new System.Drawing.Point(81, 3);
            this.rtbPlayer2Hand3.Name = "rtbPlayer2Hand3";
            this.rtbPlayer2Hand3.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer2Hand3.TabIndex = 2;
            this.rtbPlayer2Hand3.Text = "";
            // 
            // rtbPlayer2Hand4
            // 
            this.rtbPlayer2Hand4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer2Hand4.Location = new System.Drawing.Point(120, 3);
            this.rtbPlayer2Hand4.Name = "rtbPlayer2Hand4";
            this.rtbPlayer2Hand4.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer2Hand4.TabIndex = 3;
            this.rtbPlayer2Hand4.Text = "";
            // 
            // rtbPlayer2Hand5
            // 
            this.rtbPlayer2Hand5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer2Hand5.Location = new System.Drawing.Point(159, 3);
            this.rtbPlayer2Hand5.Name = "rtbPlayer2Hand5";
            this.rtbPlayer2Hand5.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer2Hand5.TabIndex = 4;
            this.rtbPlayer2Hand5.Text = "";
            // 
            // rtbPlayer2Hand6
            // 
            this.rtbPlayer2Hand6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer2Hand6.Location = new System.Drawing.Point(198, 3);
            this.rtbPlayer2Hand6.Name = "rtbPlayer2Hand6";
            this.rtbPlayer2Hand6.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer2Hand6.TabIndex = 5;
            this.rtbPlayer2Hand6.Text = "";
            // 
            // rtbPlayer2Hand7
            // 
            this.rtbPlayer2Hand7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer2Hand7.Location = new System.Drawing.Point(237, 3);
            this.rtbPlayer2Hand7.Name = "rtbPlayer2Hand7";
            this.rtbPlayer2Hand7.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer2Hand7.TabIndex = 6;
            this.rtbPlayer2Hand7.Text = "";
            // 
            // rtbPlayer2Hand8
            // 
            this.rtbPlayer2Hand8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer2Hand8.Location = new System.Drawing.Point(276, 3);
            this.rtbPlayer2Hand8.Name = "rtbPlayer2Hand8";
            this.rtbPlayer2Hand8.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer2Hand8.TabIndex = 7;
            this.rtbPlayer2Hand8.Text = "";
            // 
            // rtbPlayer2Hand9
            // 
            this.rtbPlayer2Hand9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer2Hand9.Location = new System.Drawing.Point(315, 3);
            this.rtbPlayer2Hand9.Name = "rtbPlayer2Hand9";
            this.rtbPlayer2Hand9.Size = new System.Drawing.Size(42, 44);
            this.rtbPlayer2Hand9.TabIndex = 8;
            this.rtbPlayer2Hand9.Text = "";
            // 
            // rtbPlayer2Hand10
            // 
            this.rtbPlayer2Hand10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer2Hand10.Location = new System.Drawing.Point(3, 53);
            this.rtbPlayer2Hand10.Name = "rtbPlayer2Hand10";
            this.rtbPlayer2Hand10.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer2Hand10.TabIndex = 9;
            this.rtbPlayer2Hand10.Text = "";
            // 
            // rtbPlayer2Hand11
            // 
            this.rtbPlayer2Hand11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer2Hand11.Location = new System.Drawing.Point(42, 53);
            this.rtbPlayer2Hand11.Name = "rtbPlayer2Hand11";
            this.rtbPlayer2Hand11.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer2Hand11.TabIndex = 10;
            this.rtbPlayer2Hand11.Text = "";
            // 
            // rtbPlayer2Hand12
            // 
            this.rtbPlayer2Hand12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer2Hand12.Location = new System.Drawing.Point(81, 53);
            this.rtbPlayer2Hand12.Name = "rtbPlayer2Hand12";
            this.rtbPlayer2Hand12.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer2Hand12.TabIndex = 11;
            this.rtbPlayer2Hand12.Text = "";
            // 
            // rtbPlayer2Hand13
            // 
            this.rtbPlayer2Hand13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer2Hand13.Location = new System.Drawing.Point(120, 53);
            this.rtbPlayer2Hand13.Name = "rtbPlayer2Hand13";
            this.rtbPlayer2Hand13.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer2Hand13.TabIndex = 12;
            this.rtbPlayer2Hand13.Text = "";
            // 
            // rtbPlayer2Hand14
            // 
            this.rtbPlayer2Hand14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer2Hand14.Location = new System.Drawing.Point(159, 53);
            this.rtbPlayer2Hand14.Name = "rtbPlayer2Hand14";
            this.rtbPlayer2Hand14.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer2Hand14.TabIndex = 13;
            this.rtbPlayer2Hand14.Text = "";
            // 
            // rtbPlayer2Hand15
            // 
            this.rtbPlayer2Hand15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer2Hand15.Location = new System.Drawing.Point(198, 53);
            this.rtbPlayer2Hand15.Name = "rtbPlayer2Hand15";
            this.rtbPlayer2Hand15.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer2Hand15.TabIndex = 14;
            this.rtbPlayer2Hand15.Text = "";
            // 
            // rtbPlayer2Hand16
            // 
            this.rtbPlayer2Hand16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer2Hand16.Location = new System.Drawing.Point(237, 53);
            this.rtbPlayer2Hand16.Name = "rtbPlayer2Hand16";
            this.rtbPlayer2Hand16.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer2Hand16.TabIndex = 15;
            this.rtbPlayer2Hand16.Text = "";
            // 
            // rtbPlayer2Hand17
            // 
            this.rtbPlayer2Hand17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer2Hand17.Location = new System.Drawing.Point(276, 53);
            this.rtbPlayer2Hand17.Name = "rtbPlayer2Hand17";
            this.rtbPlayer2Hand17.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer2Hand17.TabIndex = 16;
            this.rtbPlayer2Hand17.Text = "";
            // 
            // rtbPlayer2Hand18
            // 
            this.rtbPlayer2Hand18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer2Hand18.Location = new System.Drawing.Point(315, 53);
            this.rtbPlayer2Hand18.Name = "rtbPlayer2Hand18";
            this.rtbPlayer2Hand18.Size = new System.Drawing.Size(42, 44);
            this.rtbPlayer2Hand18.TabIndex = 17;
            this.rtbPlayer2Hand18.Text = "";
            // 
            // tlpPlayer3Hand
            // 
            this.tlpPlayer3Hand.ColumnCount = 9;
            this.tlpPlayer3Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer3Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer3Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer3Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer3Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer3Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer3Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer3Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer3Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer3Hand.Controls.Add(this.rtbPlayer3Hand1, 0, 0);
            this.tlpPlayer3Hand.Controls.Add(this.rtbPlayer3Hand2, 1, 0);
            this.tlpPlayer3Hand.Controls.Add(this.rtbPlayer3Hand3, 2, 0);
            this.tlpPlayer3Hand.Controls.Add(this.rtbPlayer3Hand4, 3, 0);
            this.tlpPlayer3Hand.Controls.Add(this.rtbPlayer3Hand5, 4, 0);
            this.tlpPlayer3Hand.Controls.Add(this.rtbPlayer3Hand6, 5, 0);
            this.tlpPlayer3Hand.Controls.Add(this.rtbPlayer3Hand7, 6, 0);
            this.tlpPlayer3Hand.Controls.Add(this.rtbPlayer3Hand8, 7, 0);
            this.tlpPlayer3Hand.Controls.Add(this.rtbPlayer3Hand9, 8, 0);
            this.tlpPlayer3Hand.Controls.Add(this.rtbPlayer3Hand10, 0, 1);
            this.tlpPlayer3Hand.Controls.Add(this.rtbPlayer3Hand11, 1, 1);
            this.tlpPlayer3Hand.Controls.Add(this.rtbPlayer3Hand12, 2, 1);
            this.tlpPlayer3Hand.Controls.Add(this.rtbPlayer3Hand13, 3, 1);
            this.tlpPlayer3Hand.Controls.Add(this.rtbPlayer3Hand14, 4, 1);
            this.tlpPlayer3Hand.Controls.Add(this.rtbPlayer3Hand15, 5, 1);
            this.tlpPlayer3Hand.Controls.Add(this.rtbPlayer3Hand16, 6, 1);
            this.tlpPlayer3Hand.Controls.Add(this.rtbPlayer3Hand17, 7, 1);
            this.tlpPlayer3Hand.Controls.Add(this.rtbPlayer3Hand18, 8, 1);
            this.tlpPlayer3Hand.Location = new System.Drawing.Point(3, 35);
            this.tlpPlayer3Hand.Name = "tlpPlayer3Hand";
            this.tlpPlayer3Hand.RowCount = 2;
            this.tlpPlayer3Hand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlayer3Hand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlayer3Hand.Size = new System.Drawing.Size(360, 100);
            this.tlpPlayer3Hand.TabIndex = 5;
            // 
            // rtbPlayer3Hand1
            // 
            this.rtbPlayer3Hand1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer3Hand1.Location = new System.Drawing.Point(3, 3);
            this.rtbPlayer3Hand1.Name = "rtbPlayer3Hand1";
            this.rtbPlayer3Hand1.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer3Hand1.TabIndex = 0;
            this.rtbPlayer3Hand1.Text = "";
            // 
            // rtbPlayer3Hand2
            // 
            this.rtbPlayer3Hand2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer3Hand2.Location = new System.Drawing.Point(42, 3);
            this.rtbPlayer3Hand2.Name = "rtbPlayer3Hand2";
            this.rtbPlayer3Hand2.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer3Hand2.TabIndex = 1;
            this.rtbPlayer3Hand2.Text = "";
            // 
            // rtbPlayer3Hand3
            // 
            this.rtbPlayer3Hand3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer3Hand3.Location = new System.Drawing.Point(81, 3);
            this.rtbPlayer3Hand3.Name = "rtbPlayer3Hand3";
            this.rtbPlayer3Hand3.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer3Hand3.TabIndex = 2;
            this.rtbPlayer3Hand3.Text = "";
            // 
            // rtbPlayer3Hand4
            // 
            this.rtbPlayer3Hand4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer3Hand4.Location = new System.Drawing.Point(120, 3);
            this.rtbPlayer3Hand4.Name = "rtbPlayer3Hand4";
            this.rtbPlayer3Hand4.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer3Hand4.TabIndex = 3;
            this.rtbPlayer3Hand4.Text = "";
            // 
            // rtbPlayer3Hand5
            // 
            this.rtbPlayer3Hand5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer3Hand5.Location = new System.Drawing.Point(159, 3);
            this.rtbPlayer3Hand5.Name = "rtbPlayer3Hand5";
            this.rtbPlayer3Hand5.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer3Hand5.TabIndex = 4;
            this.rtbPlayer3Hand5.Text = "";
            // 
            // rtbPlayer3Hand6
            // 
            this.rtbPlayer3Hand6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer3Hand6.Location = new System.Drawing.Point(198, 3);
            this.rtbPlayer3Hand6.Name = "rtbPlayer3Hand6";
            this.rtbPlayer3Hand6.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer3Hand6.TabIndex = 5;
            this.rtbPlayer3Hand6.Text = "";
            // 
            // rtbPlayer3Hand7
            // 
            this.rtbPlayer3Hand7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer3Hand7.Location = new System.Drawing.Point(237, 3);
            this.rtbPlayer3Hand7.Name = "rtbPlayer3Hand7";
            this.rtbPlayer3Hand7.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer3Hand7.TabIndex = 6;
            this.rtbPlayer3Hand7.Text = "";
            // 
            // rtbPlayer3Hand8
            // 
            this.rtbPlayer3Hand8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer3Hand8.Location = new System.Drawing.Point(276, 3);
            this.rtbPlayer3Hand8.Name = "rtbPlayer3Hand8";
            this.rtbPlayer3Hand8.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer3Hand8.TabIndex = 7;
            this.rtbPlayer3Hand8.Text = "";
            // 
            // rtbPlayer3Hand9
            // 
            this.rtbPlayer3Hand9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer3Hand9.Location = new System.Drawing.Point(315, 3);
            this.rtbPlayer3Hand9.Name = "rtbPlayer3Hand9";
            this.rtbPlayer3Hand9.Size = new System.Drawing.Size(42, 44);
            this.rtbPlayer3Hand9.TabIndex = 8;
            this.rtbPlayer3Hand9.Text = "";
            // 
            // rtbPlayer3Hand10
            // 
            this.rtbPlayer3Hand10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer3Hand10.Location = new System.Drawing.Point(3, 53);
            this.rtbPlayer3Hand10.Name = "rtbPlayer3Hand10";
            this.rtbPlayer3Hand10.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer3Hand10.TabIndex = 9;
            this.rtbPlayer3Hand10.Text = "";
            // 
            // rtbPlayer3Hand11
            // 
            this.rtbPlayer3Hand11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer3Hand11.Location = new System.Drawing.Point(42, 53);
            this.rtbPlayer3Hand11.Name = "rtbPlayer3Hand11";
            this.rtbPlayer3Hand11.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer3Hand11.TabIndex = 10;
            this.rtbPlayer3Hand11.Text = "";
            // 
            // rtbPlayer3Hand12
            // 
            this.rtbPlayer3Hand12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer3Hand12.Location = new System.Drawing.Point(81, 53);
            this.rtbPlayer3Hand12.Name = "rtbPlayer3Hand12";
            this.rtbPlayer3Hand12.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer3Hand12.TabIndex = 11;
            this.rtbPlayer3Hand12.Text = "";
            // 
            // rtbPlayer3Hand13
            // 
            this.rtbPlayer3Hand13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer3Hand13.Location = new System.Drawing.Point(120, 53);
            this.rtbPlayer3Hand13.Name = "rtbPlayer3Hand13";
            this.rtbPlayer3Hand13.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer3Hand13.TabIndex = 12;
            this.rtbPlayer3Hand13.Text = "";
            // 
            // rtbPlayer3Hand14
            // 
            this.rtbPlayer3Hand14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer3Hand14.Location = new System.Drawing.Point(159, 53);
            this.rtbPlayer3Hand14.Name = "rtbPlayer3Hand14";
            this.rtbPlayer3Hand14.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer3Hand14.TabIndex = 13;
            this.rtbPlayer3Hand14.Text = "";
            // 
            // rtbPlayer3Hand15
            // 
            this.rtbPlayer3Hand15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer3Hand15.Location = new System.Drawing.Point(198, 53);
            this.rtbPlayer3Hand15.Name = "rtbPlayer3Hand15";
            this.rtbPlayer3Hand15.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer3Hand15.TabIndex = 14;
            this.rtbPlayer3Hand15.Text = "";
            // 
            // rtbPlayer3Hand16
            // 
            this.rtbPlayer3Hand16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer3Hand16.Location = new System.Drawing.Point(237, 53);
            this.rtbPlayer3Hand16.Name = "rtbPlayer3Hand16";
            this.rtbPlayer3Hand16.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer3Hand16.TabIndex = 15;
            this.rtbPlayer3Hand16.Text = "";
            // 
            // rtbPlayer3Hand17
            // 
            this.rtbPlayer3Hand17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer3Hand17.Location = new System.Drawing.Point(276, 53);
            this.rtbPlayer3Hand17.Name = "rtbPlayer3Hand17";
            this.rtbPlayer3Hand17.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer3Hand17.TabIndex = 16;
            this.rtbPlayer3Hand17.Text = "";
            // 
            // rtbPlayer3Hand18
            // 
            this.rtbPlayer3Hand18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer3Hand18.Location = new System.Drawing.Point(315, 53);
            this.rtbPlayer3Hand18.Name = "rtbPlayer3Hand18";
            this.rtbPlayer3Hand18.Size = new System.Drawing.Size(42, 44);
            this.rtbPlayer3Hand18.TabIndex = 17;
            this.rtbPlayer3Hand18.Text = "";
            // 
            // tlpPlayer4Hand
            // 
            this.tlpPlayer4Hand.ColumnCount = 9;
            this.tlpPlayer4Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer4Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer4Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer4Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer4Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer4Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer4Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer4Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer4Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer4Hand.Controls.Add(this.rtbPlayer4Hand1, 0, 0);
            this.tlpPlayer4Hand.Controls.Add(this.rtbPlayer4Hand2, 1, 0);
            this.tlpPlayer4Hand.Controls.Add(this.rtbPlayer4Hand3, 2, 0);
            this.tlpPlayer4Hand.Controls.Add(this.rtbPlayer4Hand4, 3, 0);
            this.tlpPlayer4Hand.Controls.Add(this.rtbPlayer4Hand5, 4, 0);
            this.tlpPlayer4Hand.Controls.Add(this.rtbPlayer4Hand6, 5, 0);
            this.tlpPlayer4Hand.Controls.Add(this.rtbPlayer4Hand7, 6, 0);
            this.tlpPlayer4Hand.Controls.Add(this.rtbPlayer4Hand8, 7, 0);
            this.tlpPlayer4Hand.Controls.Add(this.rtbPlayer4Hand9, 8, 0);
            this.tlpPlayer4Hand.Controls.Add(this.rtbPlayer4Hand10, 0, 1);
            this.tlpPlayer4Hand.Controls.Add(this.rtbPlayer4Hand11, 1, 1);
            this.tlpPlayer4Hand.Controls.Add(this.rtbPlayer4Hand12, 2, 1);
            this.tlpPlayer4Hand.Controls.Add(this.rtbPlayer4Hand13, 3, 1);
            this.tlpPlayer4Hand.Controls.Add(this.rtbPlayer4Hand14, 4, 1);
            this.tlpPlayer4Hand.Controls.Add(this.rtbPlayer4Hand15, 5, 1);
            this.tlpPlayer4Hand.Controls.Add(this.rtbPlayer4Hand16, 6, 1);
            this.tlpPlayer4Hand.Controls.Add(this.rtbPlayer4Hand17, 7, 1);
            this.tlpPlayer4Hand.Controls.Add(this.rtbPlayer4Hand18, 8, 1);
            this.tlpPlayer4Hand.Location = new System.Drawing.Point(3, 36);
            this.tlpPlayer4Hand.Name = "tlpPlayer4Hand";
            this.tlpPlayer4Hand.RowCount = 2;
            this.tlpPlayer4Hand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlayer4Hand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlayer4Hand.Size = new System.Drawing.Size(360, 100);
            this.tlpPlayer4Hand.TabIndex = 5;
            // 
            // rtbPlayer4Hand1
            // 
            this.rtbPlayer4Hand1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer4Hand1.Location = new System.Drawing.Point(3, 3);
            this.rtbPlayer4Hand1.Name = "rtbPlayer4Hand1";
            this.rtbPlayer4Hand1.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer4Hand1.TabIndex = 0;
            this.rtbPlayer4Hand1.Text = "";
            // 
            // rtbPlayer4Hand2
            // 
            this.rtbPlayer4Hand2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer4Hand2.Location = new System.Drawing.Point(42, 3);
            this.rtbPlayer4Hand2.Name = "rtbPlayer4Hand2";
            this.rtbPlayer4Hand2.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer4Hand2.TabIndex = 1;
            this.rtbPlayer4Hand2.Text = "";
            // 
            // rtbPlayer4Hand3
            // 
            this.rtbPlayer4Hand3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer4Hand3.Location = new System.Drawing.Point(81, 3);
            this.rtbPlayer4Hand3.Name = "rtbPlayer4Hand3";
            this.rtbPlayer4Hand3.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer4Hand3.TabIndex = 2;
            this.rtbPlayer4Hand3.Text = "";
            // 
            // rtbPlayer4Hand4
            // 
            this.rtbPlayer4Hand4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer4Hand4.Location = new System.Drawing.Point(120, 3);
            this.rtbPlayer4Hand4.Name = "rtbPlayer4Hand4";
            this.rtbPlayer4Hand4.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer4Hand4.TabIndex = 3;
            this.rtbPlayer4Hand4.Text = "";
            // 
            // rtbPlayer4Hand5
            // 
            this.rtbPlayer4Hand5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer4Hand5.Location = new System.Drawing.Point(159, 3);
            this.rtbPlayer4Hand5.Name = "rtbPlayer4Hand5";
            this.rtbPlayer4Hand5.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer4Hand5.TabIndex = 4;
            this.rtbPlayer4Hand5.Text = "";
            // 
            // rtbPlayer4Hand6
            // 
            this.rtbPlayer4Hand6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer4Hand6.Location = new System.Drawing.Point(198, 3);
            this.rtbPlayer4Hand6.Name = "rtbPlayer4Hand6";
            this.rtbPlayer4Hand6.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer4Hand6.TabIndex = 5;
            this.rtbPlayer4Hand6.Text = "";
            // 
            // rtbPlayer4Hand7
            // 
            this.rtbPlayer4Hand7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer4Hand7.Location = new System.Drawing.Point(237, 3);
            this.rtbPlayer4Hand7.Name = "rtbPlayer4Hand7";
            this.rtbPlayer4Hand7.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer4Hand7.TabIndex = 6;
            this.rtbPlayer4Hand7.Text = "";
            // 
            // rtbPlayer4Hand8
            // 
            this.rtbPlayer4Hand8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer4Hand8.Location = new System.Drawing.Point(276, 3);
            this.rtbPlayer4Hand8.Name = "rtbPlayer4Hand8";
            this.rtbPlayer4Hand8.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer4Hand8.TabIndex = 7;
            this.rtbPlayer4Hand8.Text = "";
            // 
            // rtbPlayer4Hand9
            // 
            this.rtbPlayer4Hand9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer4Hand9.Location = new System.Drawing.Point(315, 3);
            this.rtbPlayer4Hand9.Name = "rtbPlayer4Hand9";
            this.rtbPlayer4Hand9.Size = new System.Drawing.Size(42, 44);
            this.rtbPlayer4Hand9.TabIndex = 8;
            this.rtbPlayer4Hand9.Text = "";
            // 
            // rtbPlayer4Hand10
            // 
            this.rtbPlayer4Hand10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer4Hand10.Location = new System.Drawing.Point(3, 53);
            this.rtbPlayer4Hand10.Name = "rtbPlayer4Hand10";
            this.rtbPlayer4Hand10.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer4Hand10.TabIndex = 9;
            this.rtbPlayer4Hand10.Text = "";
            // 
            // rtbPlayer4Hand11
            // 
            this.rtbPlayer4Hand11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer4Hand11.Location = new System.Drawing.Point(42, 53);
            this.rtbPlayer4Hand11.Name = "rtbPlayer4Hand11";
            this.rtbPlayer4Hand11.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer4Hand11.TabIndex = 10;
            this.rtbPlayer4Hand11.Text = "";
            // 
            // rtbPlayer4Hand12
            // 
            this.rtbPlayer4Hand12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer4Hand12.Location = new System.Drawing.Point(81, 53);
            this.rtbPlayer4Hand12.Name = "rtbPlayer4Hand12";
            this.rtbPlayer4Hand12.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer4Hand12.TabIndex = 11;
            this.rtbPlayer4Hand12.Text = "";
            // 
            // rtbPlayer4Hand13
            // 
            this.rtbPlayer4Hand13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer4Hand13.Location = new System.Drawing.Point(120, 53);
            this.rtbPlayer4Hand13.Name = "rtbPlayer4Hand13";
            this.rtbPlayer4Hand13.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer4Hand13.TabIndex = 12;
            this.rtbPlayer4Hand13.Text = "";
            // 
            // rtbPlayer4Hand14
            // 
            this.rtbPlayer4Hand14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer4Hand14.Location = new System.Drawing.Point(159, 53);
            this.rtbPlayer4Hand14.Name = "rtbPlayer4Hand14";
            this.rtbPlayer4Hand14.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer4Hand14.TabIndex = 13;
            this.rtbPlayer4Hand14.Text = "";
            // 
            // rtbPlayer4Hand15
            // 
            this.rtbPlayer4Hand15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer4Hand15.Location = new System.Drawing.Point(198, 53);
            this.rtbPlayer4Hand15.Name = "rtbPlayer4Hand15";
            this.rtbPlayer4Hand15.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer4Hand15.TabIndex = 14;
            this.rtbPlayer4Hand15.Text = "";
            // 
            // rtbPlayer4Hand16
            // 
            this.rtbPlayer4Hand16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer4Hand16.Location = new System.Drawing.Point(237, 53);
            this.rtbPlayer4Hand16.Name = "rtbPlayer4Hand16";
            this.rtbPlayer4Hand16.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer4Hand16.TabIndex = 15;
            this.rtbPlayer4Hand16.Text = "";
            // 
            // rtbPlayer4Hand17
            // 
            this.rtbPlayer4Hand17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer4Hand17.Location = new System.Drawing.Point(276, 53);
            this.rtbPlayer4Hand17.Name = "rtbPlayer4Hand17";
            this.rtbPlayer4Hand17.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer4Hand17.TabIndex = 16;
            this.rtbPlayer4Hand17.Text = "";
            // 
            // rtbPlayer4Hand18
            // 
            this.rtbPlayer4Hand18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer4Hand18.Location = new System.Drawing.Point(315, 53);
            this.rtbPlayer4Hand18.Name = "rtbPlayer4Hand18";
            this.rtbPlayer4Hand18.Size = new System.Drawing.Size(42, 44);
            this.rtbPlayer4Hand18.TabIndex = 17;
            this.rtbPlayer4Hand18.Text = "";
            // 
            // tlpPlayer5Hand
            // 
            this.tlpPlayer5Hand.ColumnCount = 9;
            this.tlpPlayer5Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer5Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer5Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer5Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer5Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer5Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer5Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer5Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer5Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer5Hand.Controls.Add(this.rtbPlayer5Hand1, 0, 0);
            this.tlpPlayer5Hand.Controls.Add(this.rtbPlayer5Hand2, 1, 0);
            this.tlpPlayer5Hand.Controls.Add(this.rtbPlayer5Hand3, 2, 0);
            this.tlpPlayer5Hand.Controls.Add(this.rtbPlayer5Hand4, 3, 0);
            this.tlpPlayer5Hand.Controls.Add(this.rtbPlayer5Hand5, 4, 0);
            this.tlpPlayer5Hand.Controls.Add(this.rtbPlayer5Hand6, 5, 0);
            this.tlpPlayer5Hand.Controls.Add(this.rtbPlayer5Hand7, 6, 0);
            this.tlpPlayer5Hand.Controls.Add(this.rtbPlayer5Hand8, 7, 0);
            this.tlpPlayer5Hand.Controls.Add(this.rtbPlayer5Hand9, 8, 0);
            this.tlpPlayer5Hand.Controls.Add(this.rtbPlayer5Hand10, 0, 1);
            this.tlpPlayer5Hand.Controls.Add(this.rtbPlayer5Hand11, 1, 1);
            this.tlpPlayer5Hand.Controls.Add(this.rtbPlayer5Hand12, 2, 1);
            this.tlpPlayer5Hand.Controls.Add(this.rtbPlayer5Hand13, 3, 1);
            this.tlpPlayer5Hand.Controls.Add(this.rtbPlayer5Hand14, 4, 1);
            this.tlpPlayer5Hand.Controls.Add(this.rtbPlayer5Hand15, 5, 1);
            this.tlpPlayer5Hand.Controls.Add(this.rtbPlayer5Hand16, 6, 1);
            this.tlpPlayer5Hand.Controls.Add(this.rtbPlayer5Hand17, 7, 1);
            this.tlpPlayer5Hand.Controls.Add(this.rtbPlayer5Hand18, 8, 1);
            this.tlpPlayer5Hand.Location = new System.Drawing.Point(3, 35);
            this.tlpPlayer5Hand.Name = "tlpPlayer5Hand";
            this.tlpPlayer5Hand.RowCount = 2;
            this.tlpPlayer5Hand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlayer5Hand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlayer5Hand.Size = new System.Drawing.Size(360, 100);
            this.tlpPlayer5Hand.TabIndex = 5;
            // 
            // rtbPlayer5Hand1
            // 
            this.rtbPlayer5Hand1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer5Hand1.Location = new System.Drawing.Point(3, 3);
            this.rtbPlayer5Hand1.Name = "rtbPlayer5Hand1";
            this.rtbPlayer5Hand1.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer5Hand1.TabIndex = 0;
            this.rtbPlayer5Hand1.Text = "";
            // 
            // rtbPlayer5Hand2
            // 
            this.rtbPlayer5Hand2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer5Hand2.Location = new System.Drawing.Point(42, 3);
            this.rtbPlayer5Hand2.Name = "rtbPlayer5Hand2";
            this.rtbPlayer5Hand2.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer5Hand2.TabIndex = 1;
            this.rtbPlayer5Hand2.Text = "";
            // 
            // rtbPlayer5Hand3
            // 
            this.rtbPlayer5Hand3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer5Hand3.Location = new System.Drawing.Point(81, 3);
            this.rtbPlayer5Hand3.Name = "rtbPlayer5Hand3";
            this.rtbPlayer5Hand3.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer5Hand3.TabIndex = 2;
            this.rtbPlayer5Hand3.Text = "";
            // 
            // rtbPlayer5Hand4
            // 
            this.rtbPlayer5Hand4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer5Hand4.Location = new System.Drawing.Point(120, 3);
            this.rtbPlayer5Hand4.Name = "rtbPlayer5Hand4";
            this.rtbPlayer5Hand4.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer5Hand4.TabIndex = 3;
            this.rtbPlayer5Hand4.Text = "";
            // 
            // rtbPlayer5Hand5
            // 
            this.rtbPlayer5Hand5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer5Hand5.Location = new System.Drawing.Point(159, 3);
            this.rtbPlayer5Hand5.Name = "rtbPlayer5Hand5";
            this.rtbPlayer5Hand5.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer5Hand5.TabIndex = 4;
            this.rtbPlayer5Hand5.Text = "";
            // 
            // rtbPlayer5Hand6
            // 
            this.rtbPlayer5Hand6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer5Hand6.Location = new System.Drawing.Point(198, 3);
            this.rtbPlayer5Hand6.Name = "rtbPlayer5Hand6";
            this.rtbPlayer5Hand6.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer5Hand6.TabIndex = 5;
            this.rtbPlayer5Hand6.Text = "";
            // 
            // rtbPlayer5Hand7
            // 
            this.rtbPlayer5Hand7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer5Hand7.Location = new System.Drawing.Point(237, 3);
            this.rtbPlayer5Hand7.Name = "rtbPlayer5Hand7";
            this.rtbPlayer5Hand7.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer5Hand7.TabIndex = 6;
            this.rtbPlayer5Hand7.Text = "";
            // 
            // rtbPlayer5Hand8
            // 
            this.rtbPlayer5Hand8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer5Hand8.Location = new System.Drawing.Point(276, 3);
            this.rtbPlayer5Hand8.Name = "rtbPlayer5Hand8";
            this.rtbPlayer5Hand8.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer5Hand8.TabIndex = 7;
            this.rtbPlayer5Hand8.Text = "";
            // 
            // rtbPlayer5Hand9
            // 
            this.rtbPlayer5Hand9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer5Hand9.Location = new System.Drawing.Point(315, 3);
            this.rtbPlayer5Hand9.Name = "rtbPlayer5Hand9";
            this.rtbPlayer5Hand9.Size = new System.Drawing.Size(42, 44);
            this.rtbPlayer5Hand9.TabIndex = 8;
            this.rtbPlayer5Hand9.Text = "";
            // 
            // rtbPlayer5Hand10
            // 
            this.rtbPlayer5Hand10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer5Hand10.Location = new System.Drawing.Point(3, 53);
            this.rtbPlayer5Hand10.Name = "rtbPlayer5Hand10";
            this.rtbPlayer5Hand10.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer5Hand10.TabIndex = 9;
            this.rtbPlayer5Hand10.Text = "";
            // 
            // rtbPlayer5Hand11
            // 
            this.rtbPlayer5Hand11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer5Hand11.Location = new System.Drawing.Point(42, 53);
            this.rtbPlayer5Hand11.Name = "rtbPlayer5Hand11";
            this.rtbPlayer5Hand11.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer5Hand11.TabIndex = 10;
            this.rtbPlayer5Hand11.Text = "";
            // 
            // rtbPlayer5Hand12
            // 
            this.rtbPlayer5Hand12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer5Hand12.Location = new System.Drawing.Point(81, 53);
            this.rtbPlayer5Hand12.Name = "rtbPlayer5Hand12";
            this.rtbPlayer5Hand12.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer5Hand12.TabIndex = 11;
            this.rtbPlayer5Hand12.Text = "";
            // 
            // rtbPlayer5Hand13
            // 
            this.rtbPlayer5Hand13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer5Hand13.Location = new System.Drawing.Point(120, 53);
            this.rtbPlayer5Hand13.Name = "rtbPlayer5Hand13";
            this.rtbPlayer5Hand13.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer5Hand13.TabIndex = 12;
            this.rtbPlayer5Hand13.Text = "";
            // 
            // rtbPlayer5Hand14
            // 
            this.rtbPlayer5Hand14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer5Hand14.Location = new System.Drawing.Point(159, 53);
            this.rtbPlayer5Hand14.Name = "rtbPlayer5Hand14";
            this.rtbPlayer5Hand14.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer5Hand14.TabIndex = 13;
            this.rtbPlayer5Hand14.Text = "";
            // 
            // rtbPlayer5Hand15
            // 
            this.rtbPlayer5Hand15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer5Hand15.Location = new System.Drawing.Point(198, 53);
            this.rtbPlayer5Hand15.Name = "rtbPlayer5Hand15";
            this.rtbPlayer5Hand15.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer5Hand15.TabIndex = 14;
            this.rtbPlayer5Hand15.Text = "";
            // 
            // rtbPlayer5Hand16
            // 
            this.rtbPlayer5Hand16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer5Hand16.Location = new System.Drawing.Point(237, 53);
            this.rtbPlayer5Hand16.Name = "rtbPlayer5Hand16";
            this.rtbPlayer5Hand16.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer5Hand16.TabIndex = 15;
            this.rtbPlayer5Hand16.Text = "";
            // 
            // rtbPlayer5Hand17
            // 
            this.rtbPlayer5Hand17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer5Hand17.Location = new System.Drawing.Point(276, 53);
            this.rtbPlayer5Hand17.Name = "rtbPlayer5Hand17";
            this.rtbPlayer5Hand17.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer5Hand17.TabIndex = 16;
            this.rtbPlayer5Hand17.Text = "";
            // 
            // rtbPlayer5Hand18
            // 
            this.rtbPlayer5Hand18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer5Hand18.Location = new System.Drawing.Point(315, 53);
            this.rtbPlayer5Hand18.Name = "rtbPlayer5Hand18";
            this.rtbPlayer5Hand18.Size = new System.Drawing.Size(42, 44);
            this.rtbPlayer5Hand18.TabIndex = 17;
            this.rtbPlayer5Hand18.Text = "";
            // 
            // tlpPlayer6Hand
            // 
            this.tlpPlayer6Hand.ColumnCount = 9;
            this.tlpPlayer6Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer6Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer6Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer6Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer6Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer6Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer6Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer6Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer6Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer6Hand.Controls.Add(this.rtbPlayer6Hand1, 0, 0);
            this.tlpPlayer6Hand.Controls.Add(this.rtbPlayer6Hand2, 1, 0);
            this.tlpPlayer6Hand.Controls.Add(this.rtbPlayer6Hand3, 2, 0);
            this.tlpPlayer6Hand.Controls.Add(this.rtbPlayer6Hand4, 3, 0);
            this.tlpPlayer6Hand.Controls.Add(this.rtbPlayer6Hand5, 4, 0);
            this.tlpPlayer6Hand.Controls.Add(this.rtbPlayer6Hand6, 5, 0);
            this.tlpPlayer6Hand.Controls.Add(this.rtbPlayer6Hand7, 6, 0);
            this.tlpPlayer6Hand.Controls.Add(this.rtbPlayer6Hand8, 7, 0);
            this.tlpPlayer6Hand.Controls.Add(this.rtbPlayer6Hand9, 8, 0);
            this.tlpPlayer6Hand.Controls.Add(this.rtbPlayer6Hand10, 0, 1);
            this.tlpPlayer6Hand.Controls.Add(this.rtbPlayer6Hand11, 1, 1);
            this.tlpPlayer6Hand.Controls.Add(this.rtbPlayer6Hand12, 2, 1);
            this.tlpPlayer6Hand.Controls.Add(this.rtbPlayer6Hand13, 3, 1);
            this.tlpPlayer6Hand.Controls.Add(this.rtbPlayer6Hand14, 4, 1);
            this.tlpPlayer6Hand.Controls.Add(this.rtbPlayer6Hand15, 5, 1);
            this.tlpPlayer6Hand.Controls.Add(this.rtbPlayer6Hand16, 6, 1);
            this.tlpPlayer6Hand.Controls.Add(this.rtbPlayer6Hand17, 7, 1);
            this.tlpPlayer6Hand.Controls.Add(this.rtbPlayer6Hand18, 8, 1);
            this.tlpPlayer6Hand.Location = new System.Drawing.Point(3, 35);
            this.tlpPlayer6Hand.Name = "tlpPlayer6Hand";
            this.tlpPlayer6Hand.RowCount = 2;
            this.tlpPlayer6Hand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlayer6Hand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlayer6Hand.Size = new System.Drawing.Size(360, 100);
            this.tlpPlayer6Hand.TabIndex = 5;
            // 
            // rtbPlayer6Hand1
            // 
            this.rtbPlayer6Hand1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer6Hand1.Location = new System.Drawing.Point(3, 3);
            this.rtbPlayer6Hand1.Name = "rtbPlayer6Hand1";
            this.rtbPlayer6Hand1.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer6Hand1.TabIndex = 0;
            this.rtbPlayer6Hand1.Text = "";
            // 
            // rtbPlayer6Hand2
            // 
            this.rtbPlayer6Hand2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer6Hand2.Location = new System.Drawing.Point(42, 3);
            this.rtbPlayer6Hand2.Name = "rtbPlayer6Hand2";
            this.rtbPlayer6Hand2.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer6Hand2.TabIndex = 1;
            this.rtbPlayer6Hand2.Text = "";
            // 
            // rtbPlayer6Hand3
            // 
            this.rtbPlayer6Hand3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer6Hand3.Location = new System.Drawing.Point(81, 3);
            this.rtbPlayer6Hand3.Name = "rtbPlayer6Hand3";
            this.rtbPlayer6Hand3.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer6Hand3.TabIndex = 2;
            this.rtbPlayer6Hand3.Text = "";
            // 
            // rtbPlayer6Hand4
            // 
            this.rtbPlayer6Hand4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer6Hand4.Location = new System.Drawing.Point(120, 3);
            this.rtbPlayer6Hand4.Name = "rtbPlayer6Hand4";
            this.rtbPlayer6Hand4.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer6Hand4.TabIndex = 3;
            this.rtbPlayer6Hand4.Text = "";
            // 
            // rtbPlayer6Hand5
            // 
            this.rtbPlayer6Hand5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer6Hand5.Location = new System.Drawing.Point(159, 3);
            this.rtbPlayer6Hand5.Name = "rtbPlayer6Hand5";
            this.rtbPlayer6Hand5.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer6Hand5.TabIndex = 4;
            this.rtbPlayer6Hand5.Text = "";
            // 
            // rtbPlayer6Hand6
            // 
            this.rtbPlayer6Hand6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer6Hand6.Location = new System.Drawing.Point(198, 3);
            this.rtbPlayer6Hand6.Name = "rtbPlayer6Hand6";
            this.rtbPlayer6Hand6.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer6Hand6.TabIndex = 5;
            this.rtbPlayer6Hand6.Text = "";
            // 
            // rtbPlayer6Hand7
            // 
            this.rtbPlayer6Hand7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer6Hand7.Location = new System.Drawing.Point(237, 3);
            this.rtbPlayer6Hand7.Name = "rtbPlayer6Hand7";
            this.rtbPlayer6Hand7.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer6Hand7.TabIndex = 6;
            this.rtbPlayer6Hand7.Text = "";
            // 
            // rtbPlayer6Hand8
            // 
            this.rtbPlayer6Hand8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer6Hand8.Location = new System.Drawing.Point(276, 3);
            this.rtbPlayer6Hand8.Name = "rtbPlayer6Hand8";
            this.rtbPlayer6Hand8.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer6Hand8.TabIndex = 7;
            this.rtbPlayer6Hand8.Text = "";
            // 
            // rtbPlayer6Hand9
            // 
            this.rtbPlayer6Hand9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer6Hand9.Location = new System.Drawing.Point(315, 3);
            this.rtbPlayer6Hand9.Name = "rtbPlayer6Hand9";
            this.rtbPlayer6Hand9.Size = new System.Drawing.Size(42, 44);
            this.rtbPlayer6Hand9.TabIndex = 8;
            this.rtbPlayer6Hand9.Text = "";
            // 
            // rtbPlayer6Hand10
            // 
            this.rtbPlayer6Hand10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer6Hand10.Location = new System.Drawing.Point(3, 53);
            this.rtbPlayer6Hand10.Name = "rtbPlayer6Hand10";
            this.rtbPlayer6Hand10.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer6Hand10.TabIndex = 9;
            this.rtbPlayer6Hand10.Text = "";
            // 
            // rtbPlayer6Hand11
            // 
            this.rtbPlayer6Hand11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer6Hand11.Location = new System.Drawing.Point(42, 53);
            this.rtbPlayer6Hand11.Name = "rtbPlayer6Hand11";
            this.rtbPlayer6Hand11.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer6Hand11.TabIndex = 10;
            this.rtbPlayer6Hand11.Text = "";
            // 
            // rtbPlayer6Hand12
            // 
            this.rtbPlayer6Hand12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer6Hand12.Location = new System.Drawing.Point(81, 53);
            this.rtbPlayer6Hand12.Name = "rtbPlayer6Hand12";
            this.rtbPlayer6Hand12.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer6Hand12.TabIndex = 11;
            this.rtbPlayer6Hand12.Text = "";
            // 
            // rtbPlayer6Hand13
            // 
            this.rtbPlayer6Hand13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer6Hand13.Location = new System.Drawing.Point(120, 53);
            this.rtbPlayer6Hand13.Name = "rtbPlayer6Hand13";
            this.rtbPlayer6Hand13.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer6Hand13.TabIndex = 12;
            this.rtbPlayer6Hand13.Text = "";
            // 
            // rtbPlayer6Hand14
            // 
            this.rtbPlayer6Hand14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer6Hand14.Location = new System.Drawing.Point(159, 53);
            this.rtbPlayer6Hand14.Name = "rtbPlayer6Hand14";
            this.rtbPlayer6Hand14.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer6Hand14.TabIndex = 13;
            this.rtbPlayer6Hand14.Text = "";
            // 
            // rtbPlayer6Hand15
            // 
            this.rtbPlayer6Hand15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer6Hand15.Location = new System.Drawing.Point(198, 53);
            this.rtbPlayer6Hand15.Name = "rtbPlayer6Hand15";
            this.rtbPlayer6Hand15.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer6Hand15.TabIndex = 14;
            this.rtbPlayer6Hand15.Text = "";
            // 
            // rtbPlayer6Hand16
            // 
            this.rtbPlayer6Hand16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer6Hand16.Location = new System.Drawing.Point(237, 53);
            this.rtbPlayer6Hand16.Name = "rtbPlayer6Hand16";
            this.rtbPlayer6Hand16.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer6Hand16.TabIndex = 15;
            this.rtbPlayer6Hand16.Text = "";
            // 
            // rtbPlayer6Hand17
            // 
            this.rtbPlayer6Hand17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer6Hand17.Location = new System.Drawing.Point(276, 53);
            this.rtbPlayer6Hand17.Name = "rtbPlayer6Hand17";
            this.rtbPlayer6Hand17.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer6Hand17.TabIndex = 16;
            this.rtbPlayer6Hand17.Text = "";
            // 
            // rtbPlayer6Hand18
            // 
            this.rtbPlayer6Hand18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer6Hand18.Location = new System.Drawing.Point(315, 53);
            this.rtbPlayer6Hand18.Name = "rtbPlayer6Hand18";
            this.rtbPlayer6Hand18.Size = new System.Drawing.Size(42, 44);
            this.rtbPlayer6Hand18.TabIndex = 17;
            this.rtbPlayer6Hand18.Text = "";
            // 
            // tlpPlayer7Hand
            // 
            this.tlpPlayer7Hand.ColumnCount = 9;
            this.tlpPlayer7Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer7Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer7Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer7Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer7Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer7Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer7Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer7Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer7Hand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPlayer7Hand.Controls.Add(this.rtbPlayer7Hand1, 0, 0);
            this.tlpPlayer7Hand.Controls.Add(this.rtbPlayer7Hand2, 1, 0);
            this.tlpPlayer7Hand.Controls.Add(this.rtbPlayer7Hand3, 2, 0);
            this.tlpPlayer7Hand.Controls.Add(this.rtbPlayer7Hand4, 3, 0);
            this.tlpPlayer7Hand.Controls.Add(this.rtbPlayer7Hand5, 4, 0);
            this.tlpPlayer7Hand.Controls.Add(this.rtbPlayer7Hand6, 5, 0);
            this.tlpPlayer7Hand.Controls.Add(this.rtbPlayer7Hand7, 6, 0);
            this.tlpPlayer7Hand.Controls.Add(this.rtbPlayer7Hand8, 7, 0);
            this.tlpPlayer7Hand.Controls.Add(this.rtbPlayer7Hand9, 8, 0);
            this.tlpPlayer7Hand.Controls.Add(this.rtbPlayer7Hand10, 0, 1);
            this.tlpPlayer7Hand.Controls.Add(this.rtbPlayer7Hand11, 1, 1);
            this.tlpPlayer7Hand.Controls.Add(this.rtbPlayer7Hand12, 2, 1);
            this.tlpPlayer7Hand.Controls.Add(this.rtbPlayer7Hand13, 3, 1);
            this.tlpPlayer7Hand.Controls.Add(this.rtbPlayer7Hand14, 4, 1);
            this.tlpPlayer7Hand.Controls.Add(this.rtbPlayer7Hand15, 5, 1);
            this.tlpPlayer7Hand.Controls.Add(this.rtbPlayer7Hand16, 6, 1);
            this.tlpPlayer7Hand.Controls.Add(this.rtbPlayer7Hand17, 7, 1);
            this.tlpPlayer7Hand.Controls.Add(this.rtbPlayer7Hand18, 8, 1);
            this.tlpPlayer7Hand.Location = new System.Drawing.Point(3, 35);
            this.tlpPlayer7Hand.Name = "tlpPlayer7Hand";
            this.tlpPlayer7Hand.RowCount = 2;
            this.tlpPlayer7Hand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlayer7Hand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlayer7Hand.Size = new System.Drawing.Size(360, 100);
            this.tlpPlayer7Hand.TabIndex = 5;
            // 
            // rtbPlayer7Hand1
            // 
            this.rtbPlayer7Hand1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer7Hand1.Location = new System.Drawing.Point(3, 3);
            this.rtbPlayer7Hand1.Name = "rtbPlayer7Hand1";
            this.rtbPlayer7Hand1.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer7Hand1.TabIndex = 0;
            this.rtbPlayer7Hand1.Text = "";
            // 
            // rtbPlayer7Hand2
            // 
            this.rtbPlayer7Hand2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer7Hand2.Location = new System.Drawing.Point(42, 3);
            this.rtbPlayer7Hand2.Name = "rtbPlayer7Hand2";
            this.rtbPlayer7Hand2.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer7Hand2.TabIndex = 1;
            this.rtbPlayer7Hand2.Text = "";
            // 
            // rtbPlayer7Hand3
            // 
            this.rtbPlayer7Hand3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer7Hand3.Location = new System.Drawing.Point(81, 3);
            this.rtbPlayer7Hand3.Name = "rtbPlayer7Hand3";
            this.rtbPlayer7Hand3.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer7Hand3.TabIndex = 2;
            this.rtbPlayer7Hand3.Text = "";
            // 
            // rtbPlayer7Hand4
            // 
            this.rtbPlayer7Hand4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer7Hand4.Location = new System.Drawing.Point(120, 3);
            this.rtbPlayer7Hand4.Name = "rtbPlayer7Hand4";
            this.rtbPlayer7Hand4.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer7Hand4.TabIndex = 3;
            this.rtbPlayer7Hand4.Text = "";
            // 
            // rtbPlayer7Hand5
            // 
            this.rtbPlayer7Hand5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer7Hand5.Location = new System.Drawing.Point(159, 3);
            this.rtbPlayer7Hand5.Name = "rtbPlayer7Hand5";
            this.rtbPlayer7Hand5.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer7Hand5.TabIndex = 4;
            this.rtbPlayer7Hand5.Text = "";
            // 
            // rtbPlayer7Hand6
            // 
            this.rtbPlayer7Hand6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer7Hand6.Location = new System.Drawing.Point(198, 3);
            this.rtbPlayer7Hand6.Name = "rtbPlayer7Hand6";
            this.rtbPlayer7Hand6.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer7Hand6.TabIndex = 5;
            this.rtbPlayer7Hand6.Text = "";
            // 
            // rtbPlayer7Hand7
            // 
            this.rtbPlayer7Hand7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer7Hand7.Location = new System.Drawing.Point(237, 3);
            this.rtbPlayer7Hand7.Name = "rtbPlayer7Hand7";
            this.rtbPlayer7Hand7.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer7Hand7.TabIndex = 6;
            this.rtbPlayer7Hand7.Text = "";
            // 
            // rtbPlayer7Hand8
            // 
            this.rtbPlayer7Hand8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer7Hand8.Location = new System.Drawing.Point(276, 3);
            this.rtbPlayer7Hand8.Name = "rtbPlayer7Hand8";
            this.rtbPlayer7Hand8.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer7Hand8.TabIndex = 7;
            this.rtbPlayer7Hand8.Text = "";
            // 
            // rtbPlayer7Hand9
            // 
            this.rtbPlayer7Hand9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer7Hand9.Location = new System.Drawing.Point(315, 3);
            this.rtbPlayer7Hand9.Name = "rtbPlayer7Hand9";
            this.rtbPlayer7Hand9.Size = new System.Drawing.Size(42, 44);
            this.rtbPlayer7Hand9.TabIndex = 8;
            this.rtbPlayer7Hand9.Text = "";
            // 
            // rtbPlayer7Hand10
            // 
            this.rtbPlayer7Hand10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer7Hand10.Location = new System.Drawing.Point(3, 53);
            this.rtbPlayer7Hand10.Name = "rtbPlayer7Hand10";
            this.rtbPlayer7Hand10.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer7Hand10.TabIndex = 9;
            this.rtbPlayer7Hand10.Text = "";
            // 
            // rtbPlayer7Hand11
            // 
            this.rtbPlayer7Hand11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer7Hand11.Location = new System.Drawing.Point(42, 53);
            this.rtbPlayer7Hand11.Name = "rtbPlayer7Hand11";
            this.rtbPlayer7Hand11.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer7Hand11.TabIndex = 10;
            this.rtbPlayer7Hand11.Text = "";
            // 
            // rtbPlayer7Hand12
            // 
            this.rtbPlayer7Hand12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer7Hand12.Location = new System.Drawing.Point(81, 53);
            this.rtbPlayer7Hand12.Name = "rtbPlayer7Hand12";
            this.rtbPlayer7Hand12.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer7Hand12.TabIndex = 11;
            this.rtbPlayer7Hand12.Text = "";
            // 
            // rtbPlayer7Hand13
            // 
            this.rtbPlayer7Hand13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer7Hand13.Location = new System.Drawing.Point(120, 53);
            this.rtbPlayer7Hand13.Name = "rtbPlayer7Hand13";
            this.rtbPlayer7Hand13.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer7Hand13.TabIndex = 12;
            this.rtbPlayer7Hand13.Text = "";
            // 
            // rtbPlayer7Hand14
            // 
            this.rtbPlayer7Hand14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer7Hand14.Location = new System.Drawing.Point(159, 53);
            this.rtbPlayer7Hand14.Name = "rtbPlayer7Hand14";
            this.rtbPlayer7Hand14.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer7Hand14.TabIndex = 13;
            this.rtbPlayer7Hand14.Text = "";
            // 
            // rtbPlayer7Hand15
            // 
            this.rtbPlayer7Hand15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer7Hand15.Location = new System.Drawing.Point(198, 53);
            this.rtbPlayer7Hand15.Name = "rtbPlayer7Hand15";
            this.rtbPlayer7Hand15.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer7Hand15.TabIndex = 14;
            this.rtbPlayer7Hand15.Text = "";
            // 
            // rtbPlayer7Hand16
            // 
            this.rtbPlayer7Hand16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer7Hand16.Location = new System.Drawing.Point(237, 53);
            this.rtbPlayer7Hand16.Name = "rtbPlayer7Hand16";
            this.rtbPlayer7Hand16.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer7Hand16.TabIndex = 15;
            this.rtbPlayer7Hand16.Text = "";
            // 
            // rtbPlayer7Hand17
            // 
            this.rtbPlayer7Hand17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer7Hand17.Location = new System.Drawing.Point(276, 53);
            this.rtbPlayer7Hand17.Name = "rtbPlayer7Hand17";
            this.rtbPlayer7Hand17.Size = new System.Drawing.Size(33, 44);
            this.rtbPlayer7Hand17.TabIndex = 16;
            this.rtbPlayer7Hand17.Text = "";
            // 
            // rtbPlayer7Hand18
            // 
            this.rtbPlayer7Hand18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlayer7Hand18.Location = new System.Drawing.Point(315, 53);
            this.rtbPlayer7Hand18.Name = "rtbPlayer7Hand18";
            this.rtbPlayer7Hand18.Size = new System.Drawing.Size(42, 44);
            this.rtbPlayer7Hand18.TabIndex = 17;
            this.rtbPlayer7Hand18.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(3, 34);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rtbDeck
            // 
            this.rtbDeck.BackColor = System.Drawing.SystemColors.Control;
            this.rtbDeck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDeck.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbDeck.Location = new System.Drawing.Point(0, 0);
            this.rtbDeck.Name = "rtbDeck";
            this.rtbDeck.Size = new System.Drawing.Size(387, 135);
            this.rtbDeck.TabIndex = 2;
            this.rtbDeck.Text = "Deck";
            // 
            // GameTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 797);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GameTable";
            this.Text = "GameTable";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlDiscardPile.ResumeLayout(false);
            this.pnlPlayer7.ResumeLayout(false);
            this.pnlPlayer6.ResumeLayout(false);
            this.pnlPlayer5.ResumeLayout(false);
            this.pnlPlayer4.ResumeLayout(false);
            this.pnlPlayer3.ResumeLayout(false);
            this.pnlPlayer2.ResumeLayout(false);
            this.pnlPlayer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flpPlayer3Buttons.ResumeLayout(false);
            this.flpPlayer4Buttons.ResumeLayout(false);
            this.flpPlayer5Buttons.ResumeLayout(false);
            this.flpPlayer6Buttons.ResumeLayout(false);
            this.flpPlayer7Buttons.ResumeLayout(false);
            this.flpPlayer1Buttons.ResumeLayout(false);
            this.flpPlayer2Buttons.ResumeLayout(false);
            this.tlpPlayer1Hand.ResumeLayout(false);
            this.tlpPlayer2Hand.ResumeLayout(false);
            this.tlpPlayer3Hand.ResumeLayout(false);
            this.tlpPlayer4Hand.ResumeLayout(false);
            this.tlpPlayer5Hand.ResumeLayout(false);
            this.tlpPlayer6Hand.ResumeLayout(false);
            this.tlpPlayer7Hand.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlDiscardPile;
        private System.Windows.Forms.Panel pnlPlayer7;
        private System.Windows.Forms.Panel pnlPlayer6;
        private System.Windows.Forms.Panel pnlPlayer5;
        private System.Windows.Forms.Panel pnlPlayer4;
        private System.Windows.Forms.Panel pnlPlayer3;
        private System.Windows.Forms.Panel pnlPlayer2;
        private System.Windows.Forms.Panel pnlPlayer1;
        private System.Windows.Forms.RichTextBox rtbDiscardPile;
        private System.Windows.Forms.RichTextBox rtbPlayer1Name;
        private System.Windows.Forms.RichTextBox rtbPlayer2Name;
        private System.Windows.Forms.RichTextBox rtbPlayer7Name;
        private System.Windows.Forms.RichTextBox rtbPlayer6Name;
        private System.Windows.Forms.RichTextBox rtbPlayer5Name;
        private System.Windows.Forms.RichTextBox rtbPlayer4Name;
        private System.Windows.Forms.RichTextBox rtbPlayer3Name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRifleShuffle;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnPickDealer;
        private System.Windows.Forms.Button btnOverhandShuffle;
        private System.Windows.Forms.FlowLayoutPanel flpPlayer3Buttons;
        private System.Windows.Forms.Button btnPlayer3Discard;
        private System.Windows.Forms.Button btnPlayer3Draw;
        private System.Windows.Forms.FlowLayoutPanel flpPlayer7Buttons;
        private System.Windows.Forms.FlowLayoutPanel flpPlayer6Buttons;
        private System.Windows.Forms.FlowLayoutPanel flpPlayer5Buttons;
        private System.Windows.Forms.FlowLayoutPanel flpPlayer4Buttons;
        private System.Windows.Forms.FlowLayoutPanel flpPlayer2Buttons;
        private System.Windows.Forms.FlowLayoutPanel flpPlayer1Buttons;
        private System.Windows.Forms.Button btnPlayer7Discard;
        private System.Windows.Forms.Button btnPlayer7Draw;
        private System.Windows.Forms.Button btnPlayer6Discard;
        private System.Windows.Forms.Button btnPlayer6Draw;
        private System.Windows.Forms.Button btnPlayer5Discard;
        private System.Windows.Forms.Button btnPlayer5Draw;
        private System.Windows.Forms.Button btnPlayer4Discard;
        private System.Windows.Forms.Button btnPlayer4Draw;
        private System.Windows.Forms.Button btnPlayer2Discard;
        private System.Windows.Forms.Button btnPlayer2Draw;
        private System.Windows.Forms.Button btnPlayer1Discard;
        private System.Windows.Forms.Button btnPlayer1Draw;
        private System.Windows.Forms.TableLayoutPanel tlpPlayer1Hand;
        private System.Windows.Forms.RichTextBox rtbPlayer1Hand1;
        private System.Windows.Forms.RichTextBox rtbPlayer1Hand2;
        private System.Windows.Forms.RichTextBox rtbPlayer1Hand3;
        private System.Windows.Forms.RichTextBox rtbPlayer1Hand4;
        private System.Windows.Forms.RichTextBox rtbPlayer1Hand5;
        private System.Windows.Forms.RichTextBox rtbPlayer1Hand6;
        private System.Windows.Forms.RichTextBox rtbPlayer1Hand7;
        private System.Windows.Forms.RichTextBox rtbPlayer1Hand8;
        private System.Windows.Forms.RichTextBox rtbPlayer1Hand9;
        private System.Windows.Forms.RichTextBox rtbPlayer1Hand10;
        private System.Windows.Forms.RichTextBox rtbPlayer1Hand11;
        private System.Windows.Forms.RichTextBox rtbPlayer1Hand12;
        private System.Windows.Forms.RichTextBox rtbPlayer1Hand13;
        private System.Windows.Forms.RichTextBox rtbPlayer1Hand14;
        private System.Windows.Forms.RichTextBox rtbPlayer1Hand15;
        private System.Windows.Forms.RichTextBox rtbPlayer1Hand16;
        private System.Windows.Forms.RichTextBox rtbPlayer1Hand17;
        private System.Windows.Forms.RichTextBox rtbPlayer1Hand18;
        private System.Windows.Forms.TableLayoutPanel tlpPlayer7Hand;
        private System.Windows.Forms.RichTextBox rtbPlayer7Hand1;
        private System.Windows.Forms.RichTextBox rtbPlayer7Hand2;
        private System.Windows.Forms.RichTextBox rtbPlayer7Hand3;
        private System.Windows.Forms.RichTextBox rtbPlayer7Hand4;
        private System.Windows.Forms.RichTextBox rtbPlayer7Hand5;
        private System.Windows.Forms.RichTextBox rtbPlayer7Hand6;
        private System.Windows.Forms.RichTextBox rtbPlayer7Hand7;
        private System.Windows.Forms.RichTextBox rtbPlayer7Hand8;
        private System.Windows.Forms.RichTextBox rtbPlayer7Hand9;
        private System.Windows.Forms.RichTextBox rtbPlayer7Hand10;
        private System.Windows.Forms.RichTextBox rtbPlayer7Hand11;
        private System.Windows.Forms.RichTextBox rtbPlayer7Hand12;
        private System.Windows.Forms.RichTextBox rtbPlayer7Hand13;
        private System.Windows.Forms.RichTextBox rtbPlayer7Hand14;
        private System.Windows.Forms.RichTextBox rtbPlayer7Hand15;
        private System.Windows.Forms.RichTextBox rtbPlayer7Hand16;
        private System.Windows.Forms.RichTextBox rtbPlayer7Hand17;
        private System.Windows.Forms.RichTextBox rtbPlayer7Hand18;
        private System.Windows.Forms.TableLayoutPanel tlpPlayer6Hand;
        private System.Windows.Forms.RichTextBox rtbPlayer6Hand1;
        private System.Windows.Forms.RichTextBox rtbPlayer6Hand2;
        private System.Windows.Forms.RichTextBox rtbPlayer6Hand3;
        private System.Windows.Forms.RichTextBox rtbPlayer6Hand4;
        private System.Windows.Forms.RichTextBox rtbPlayer6Hand5;
        private System.Windows.Forms.RichTextBox rtbPlayer6Hand6;
        private System.Windows.Forms.RichTextBox rtbPlayer6Hand7;
        private System.Windows.Forms.RichTextBox rtbPlayer6Hand8;
        private System.Windows.Forms.RichTextBox rtbPlayer6Hand9;
        private System.Windows.Forms.RichTextBox rtbPlayer6Hand10;
        private System.Windows.Forms.RichTextBox rtbPlayer6Hand11;
        private System.Windows.Forms.RichTextBox rtbPlayer6Hand12;
        private System.Windows.Forms.RichTextBox rtbPlayer6Hand13;
        private System.Windows.Forms.RichTextBox rtbPlayer6Hand14;
        private System.Windows.Forms.RichTextBox rtbPlayer6Hand15;
        private System.Windows.Forms.RichTextBox rtbPlayer6Hand16;
        private System.Windows.Forms.RichTextBox rtbPlayer6Hand17;
        private System.Windows.Forms.RichTextBox rtbPlayer6Hand18;
        private System.Windows.Forms.TableLayoutPanel tlpPlayer5Hand;
        private System.Windows.Forms.RichTextBox rtbPlayer5Hand1;
        private System.Windows.Forms.RichTextBox rtbPlayer5Hand2;
        private System.Windows.Forms.RichTextBox rtbPlayer5Hand3;
        private System.Windows.Forms.RichTextBox rtbPlayer5Hand4;
        private System.Windows.Forms.RichTextBox rtbPlayer5Hand5;
        private System.Windows.Forms.RichTextBox rtbPlayer5Hand6;
        private System.Windows.Forms.RichTextBox rtbPlayer5Hand7;
        private System.Windows.Forms.RichTextBox rtbPlayer5Hand8;
        private System.Windows.Forms.RichTextBox rtbPlayer5Hand9;
        private System.Windows.Forms.RichTextBox rtbPlayer5Hand10;
        private System.Windows.Forms.RichTextBox rtbPlayer5Hand11;
        private System.Windows.Forms.RichTextBox rtbPlayer5Hand12;
        private System.Windows.Forms.RichTextBox rtbPlayer5Hand13;
        private System.Windows.Forms.RichTextBox rtbPlayer5Hand14;
        private System.Windows.Forms.RichTextBox rtbPlayer5Hand15;
        private System.Windows.Forms.RichTextBox rtbPlayer5Hand16;
        private System.Windows.Forms.RichTextBox rtbPlayer5Hand17;
        private System.Windows.Forms.RichTextBox rtbPlayer5Hand18;
        private System.Windows.Forms.TableLayoutPanel tlpPlayer4Hand;
        private System.Windows.Forms.RichTextBox rtbPlayer4Hand1;
        private System.Windows.Forms.RichTextBox rtbPlayer4Hand2;
        private System.Windows.Forms.RichTextBox rtbPlayer4Hand3;
        private System.Windows.Forms.RichTextBox rtbPlayer4Hand4;
        private System.Windows.Forms.RichTextBox rtbPlayer4Hand5;
        private System.Windows.Forms.RichTextBox rtbPlayer4Hand6;
        private System.Windows.Forms.RichTextBox rtbPlayer4Hand7;
        private System.Windows.Forms.RichTextBox rtbPlayer4Hand8;
        private System.Windows.Forms.RichTextBox rtbPlayer4Hand9;
        private System.Windows.Forms.RichTextBox rtbPlayer4Hand10;
        private System.Windows.Forms.RichTextBox rtbPlayer4Hand11;
        private System.Windows.Forms.RichTextBox rtbPlayer4Hand12;
        private System.Windows.Forms.RichTextBox rtbPlayer4Hand13;
        private System.Windows.Forms.RichTextBox rtbPlayer4Hand14;
        private System.Windows.Forms.RichTextBox rtbPlayer4Hand15;
        private System.Windows.Forms.RichTextBox rtbPlayer4Hand16;
        private System.Windows.Forms.RichTextBox rtbPlayer4Hand17;
        private System.Windows.Forms.RichTextBox rtbPlayer4Hand18;
        private System.Windows.Forms.TableLayoutPanel tlpPlayer3Hand;
        private System.Windows.Forms.RichTextBox rtbPlayer3Hand1;
        private System.Windows.Forms.RichTextBox rtbPlayer3Hand2;
        private System.Windows.Forms.RichTextBox rtbPlayer3Hand3;
        private System.Windows.Forms.RichTextBox rtbPlayer3Hand4;
        private System.Windows.Forms.RichTextBox rtbPlayer3Hand5;
        private System.Windows.Forms.RichTextBox rtbPlayer3Hand6;
        private System.Windows.Forms.RichTextBox rtbPlayer3Hand7;
        private System.Windows.Forms.RichTextBox rtbPlayer3Hand8;
        private System.Windows.Forms.RichTextBox rtbPlayer3Hand9;
        private System.Windows.Forms.RichTextBox rtbPlayer3Hand10;
        private System.Windows.Forms.RichTextBox rtbPlayer3Hand11;
        private System.Windows.Forms.RichTextBox rtbPlayer3Hand12;
        private System.Windows.Forms.RichTextBox rtbPlayer3Hand13;
        private System.Windows.Forms.RichTextBox rtbPlayer3Hand14;
        private System.Windows.Forms.RichTextBox rtbPlayer3Hand15;
        private System.Windows.Forms.RichTextBox rtbPlayer3Hand16;
        private System.Windows.Forms.RichTextBox rtbPlayer3Hand17;
        private System.Windows.Forms.RichTextBox rtbPlayer3Hand18;
        private System.Windows.Forms.TableLayoutPanel tlpPlayer2Hand;
        private System.Windows.Forms.RichTextBox rtbPlayer2Hand1;
        private System.Windows.Forms.RichTextBox rtbPlayer2Hand2;
        private System.Windows.Forms.RichTextBox rtbPlayer2Hand3;
        private System.Windows.Forms.RichTextBox rtbPlayer2Hand4;
        private System.Windows.Forms.RichTextBox rtbPlayer2Hand5;
        private System.Windows.Forms.RichTextBox rtbPlayer2Hand6;
        private System.Windows.Forms.RichTextBox rtbPlayer2Hand7;
        private System.Windows.Forms.RichTextBox rtbPlayer2Hand8;
        private System.Windows.Forms.RichTextBox rtbPlayer2Hand9;
        private System.Windows.Forms.RichTextBox rtbPlayer2Hand10;
        private System.Windows.Forms.RichTextBox rtbPlayer2Hand11;
        private System.Windows.Forms.RichTextBox rtbPlayer2Hand12;
        private System.Windows.Forms.RichTextBox rtbPlayer2Hand13;
        private System.Windows.Forms.RichTextBox rtbPlayer2Hand14;
        private System.Windows.Forms.RichTextBox rtbPlayer2Hand15;
        private System.Windows.Forms.RichTextBox rtbPlayer2Hand16;
        private System.Windows.Forms.RichTextBox rtbPlayer2Hand17;
        private System.Windows.Forms.RichTextBox rtbPlayer2Hand18;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox rtbDeck;
    }
}