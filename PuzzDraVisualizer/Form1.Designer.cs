namespace PuzzDraVisualizer
{
    partial class Form1
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
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.randomizeButton = new System.Windows.Forms.Label();
            this.moveFinishButton = new System.Windows.Forms.Label();
            this.autoMovementButton = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Location = new System.Drawing.Point(12, 9);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(310, 260);
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "右クリックでドロップ切り替え\r\n左クリックでドロップ選択\r\n矢印キーで選択したドロップを移動\r\n移動終了ボタン/別のドロップを選択で\r\n　コンボ評価";
            // 
            // randomizeButton
            // 
            this.randomizeButton.AutoSize = true;
            this.randomizeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.randomizeButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.randomizeButton.Location = new System.Drawing.Point(333, 128);
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(117, 14);
            this.randomizeButton.TabIndex = 3;
            this.randomizeButton.Text = "　盤面のランダム生成　";
            this.randomizeButton.Click += new System.EventHandler(this.randomizeButton_Click);
            // 
            // moveFinishButton
            // 
            this.moveFinishButton.AutoSize = true;
            this.moveFinishButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.moveFinishButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moveFinishButton.Location = new System.Drawing.Point(333, 160);
            this.moveFinishButton.Name = "moveFinishButton";
            this.moveFinishButton.Size = new System.Drawing.Size(119, 14);
            this.moveFinishButton.TabIndex = 4;
            this.moveFinishButton.Text = "　　　　移動終了　　　　";
            this.moveFinishButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveFinishButton_MouseUp);
            // 
            // autoMovementButton
            // 
            this.autoMovementButton.AutoSize = true;
            this.autoMovementButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.autoMovementButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autoMovementButton.Location = new System.Drawing.Point(333, 192);
            this.autoMovementButton.Name = "autoMovementButton";
            this.autoMovementButton.Size = new System.Drawing.Size(118, 14);
            this.autoMovementButton.TabIndex = 5;
            this.autoMovementButton.Text = "コンボ解析＆自動操作";
            this.autoMovementButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.autoMovementButton_MouseUp);
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.logTextBox.Location = new System.Drawing.Point(458, 86);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(212, 180);
            this.logTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 278);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.autoMovementButton);
            this.Controls.Add(this.moveFinishButton);
            this.Controls.Add(this.randomizeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PuzzDraVisualizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label randomizeButton;
        private System.Windows.Forms.Label moveFinishButton;
        private System.Windows.Forms.Label autoMovementButton;
        private System.Windows.Forms.TextBox logTextBox;
    }
}