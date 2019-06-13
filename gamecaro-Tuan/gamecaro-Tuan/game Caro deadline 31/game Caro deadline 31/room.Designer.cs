namespace game_Caro_deadline_31
{
    partial class room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(room));
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_PlayerOnline = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(517, 25);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPlayerName.Size = new System.Drawing.Size(183, 88);
            this.lblPlayerName.TabIndex = 4;
            this.lblPlayerName.Text = "Xin chào ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Danh sách người chơi online";
            // 
            // btn_PlayerOnline
            // 
            this.btn_PlayerOnline.AutoSize = true;
            this.btn_PlayerOnline.BackColor = System.Drawing.Color.Coral;
            this.btn_PlayerOnline.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayerOnline.Location = new System.Drawing.Point(520, 302);
            this.btn_PlayerOnline.Name = "btn_PlayerOnline";
            this.btn_PlayerOnline.Size = new System.Drawing.Size(180, 36);
            this.btn_PlayerOnline.TabIndex = 8;
            this.btn_PlayerOnline.Text = "Người chơi đang online";
            this.btn_PlayerOnline.UseVisualStyleBackColor = false;
            this.btn_PlayerOnline.Click += new System.EventHandler(this.btn_PlayerOnline_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Arial", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(12, 88);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(157, 250);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 370);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_PlayerOnline);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayerName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "room";
            this.Text = "room";
            this.Load += new System.EventHandler(this.room_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_PlayerOnline;
        private System.Windows.Forms.ListView listView1;
    }
}