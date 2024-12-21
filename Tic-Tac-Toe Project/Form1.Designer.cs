namespace Tic_Tac_Toe_Project
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
            lblStatus = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btn_restart = new Button();
            checkedListBox1 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            btm_start = new Button();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(386, 9);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(75, 15);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Game status:";
            // 
            // button1
            // 
            button1.Location = new Point(149, 123);
            button1.Name = "button1";
            button1.Size = new Size(143, 113);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += PlayerMove;
            // 
            // button2
            // 
            button2.Location = new Point(350, 123);
            button2.Name = "button2";
            button2.Size = new Size(143, 113);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += PlayerMove;
            // 
            // button3
            // 
            button3.Location = new Point(547, 123);
            button3.Name = "button3";
            button3.Size = new Size(143, 113);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += PlayerMove;
            // 
            // button4
            // 
            button4.Location = new Point(149, 286);
            button4.Name = "button4";
            button4.Size = new Size(143, 113);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += PlayerMove;
            // 
            // button5
            // 
            button5.Location = new Point(350, 286);
            button5.Name = "button5";
            button5.Size = new Size(143, 113);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += PlayerMove;
            // 
            // button6
            // 
            button6.Location = new Point(547, 286);
            button6.Name = "button6";
            button6.Size = new Size(143, 113);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = true;
            button6.Click += PlayerMove;
            // 
            // button7
            // 
            button7.Location = new Point(149, 448);
            button7.Name = "button7";
            button7.Size = new Size(143, 113);
            button7.TabIndex = 7;
            button7.UseVisualStyleBackColor = true;
            button7.Click += PlayerMove;
            // 
            // button8
            // 
            button8.Location = new Point(350, 448);
            button8.Name = "button8";
            button8.Size = new Size(143, 113);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = true;
            button8.Click += PlayerMove;
            // 
            // button9
            // 
            button9.Location = new Point(547, 448);
            button9.Name = "button9";
            button9.Size = new Size(143, 113);
            button9.TabIndex = 9;
            button9.UseVisualStyleBackColor = true;
            button9.Click += PlayerMove;
            // 
            // btn_restart
            // 
            btn_restart.Location = new Point(375, 616);
            btn_restart.Name = "btn_restart";
            btn_restart.Size = new Size(98, 28);
            btn_restart.TabIndex = 10;
            btn_restart.Text = "Restart game";
            btn_restart.UseVisualStyleBackColor = true;
            btn_restart.Click += btn_restart_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Difficulty - easy", "Difficulty - hard" });
            checkedListBox1.Location = new Point(732, 50);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(112, 40);
            checkedListBox1.TabIndex = 11;
            //checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Choose - X", "Choose - O" });
            checkedListBox2.Location = new Point(24, 50);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(112, 40);
            checkedListBox2.TabIndex = 12;
            //checkedListBox2.ItemCheck += checkedListBox2_ItemCheck;
            // 
            // btm_start
            // 
            btm_start.Location = new Point(353, 58);
            btm_start.Name = "btm_start";
            btm_start.Size = new Size(140, 32);
            btm_start.TabIndex = 13;
            btm_start.Text = "start game";
            btm_start.UseVisualStyleBackColor = true;
            btm_start.Click += btm_start_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 670);
            Controls.Add(btm_start);
            Controls.Add(checkedListBox2);
            Controls.Add(checkedListBox1);
            Controls.Add(btn_restart);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblStatus);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btn_restart;
        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
        private Button btm_start;
    }
}
