namespace Clock
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
            btn_baku = new Button();
            btn_london = new Button();
            btn_timer = new Label();
            SuspendLayout();
            // 
            // btn_baku
            // 
            btn_baku.Location = new Point(102, 213);
            btn_baku.Name = "btn_baku";
            btn_baku.Size = new Size(164, 46);
            btn_baku.TabIndex = 0;
            btn_baku.Text = "Baku";
            btn_baku.UseVisualStyleBackColor = true;
            btn_baku.Click += btn_baku_Click;
            // 
            // btn_london
            // 
            btn_london.Location = new Point(463, 213);
            btn_london.Name = "btn_london";
            btn_london.Size = new Size(164, 46);
            btn_london.TabIndex = 1;
            btn_london.Text = "London";
            btn_london.UseVisualStyleBackColor = true;
            btn_london.Click += btn_london_Click;
            // 
            // btn_timer
            // 
            btn_timer.AutoSize = true;
            btn_timer.Cursor = Cursors.No;
            btn_timer.FlatStyle = FlatStyle.System;
            btn_timer.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_timer.Location = new Point(346, 101);
            btn_timer.Name = "btn_timer";
            btn_timer.Size = new Size(101, 50);
            btn_timer.TabIndex = 2;
            btn_timer.Text = "Time";
            btn_timer.Click += timer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_timer);
            Controls.Add(btn_london);
            Controls.Add(btn_baku);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_baku;
        private Button btn_london;
        private Label btn_timer;
    }
}