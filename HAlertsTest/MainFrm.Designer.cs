namespace HAlertsTest
{
    partial class MainFrm
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
            this.SendAlertBtn = new System.Windows.Forms.Button();
            this.MessageTxt = new System.Windows.Forms.RichTextBox();
            this.TitleTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MessageLbl = new System.Windows.Forms.Label();
            this.EventTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PopUpAlertCbx = new System.Windows.Forms.RadioButton();
            this.BubbleAlertCbx = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.ImageTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EventTitleTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendAlertBtn
            // 
            this.SendAlertBtn.Location = new System.Drawing.Point(15, 344);
            this.SendAlertBtn.Name = "SendAlertBtn";
            this.SendAlertBtn.Size = new System.Drawing.Size(181, 37);
            this.SendAlertBtn.TabIndex = 0;
            this.SendAlertBtn.Text = "Send Alert";
            this.SendAlertBtn.UseVisualStyleBackColor = true;
            this.SendAlertBtn.Click += new System.EventHandler(this.SendAlertBtn_Click);
            // 
            // MessageTxt
            // 
            this.MessageTxt.Location = new System.Drawing.Point(15, 65);
            this.MessageTxt.Name = "MessageTxt";
            this.MessageTxt.Size = new System.Drawing.Size(290, 138);
            this.MessageTxt.TabIndex = 1;
            this.MessageTxt.Text = "";
            // 
            // TitleTxt
            // 
            this.TitleTxt.Location = new System.Drawing.Point(15, 25);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(290, 20);
            this.TitleTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alert Title";
            // 
            // MessageLbl
            // 
            this.MessageLbl.AutoSize = true;
            this.MessageLbl.Location = new System.Drawing.Point(12, 48);
            this.MessageLbl.Name = "MessageLbl";
            this.MessageLbl.Size = new System.Drawing.Size(184, 13);
            this.MessageLbl.TabIndex = 4;
            this.MessageLbl.Text = "Alert Message (supports basic HTML)";
            // 
            // EventTxt
            // 
            this.EventTxt.Location = new System.Drawing.Point(15, 223);
            this.EventTxt.Name = "EventTxt";
            this.EventTxt.Size = new System.Drawing.Size(290, 20);
            this.EventTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Event URL (see HabboEvents class for built-in Habbo events)";
            // 
            // PopUpAlertCbx
            // 
            this.PopUpAlertCbx.AutoSize = true;
            this.PopUpAlertCbx.Checked = true;
            this.PopUpAlertCbx.Location = new System.Drawing.Point(202, 344);
            this.PopUpAlertCbx.Name = "PopUpAlertCbx";
            this.PopUpAlertCbx.Size = new System.Drawing.Size(82, 17);
            this.PopUpAlertCbx.TabIndex = 7;
            this.PopUpAlertCbx.TabStop = true;
            this.PopUpAlertCbx.Text = "PopUp Alert";
            this.PopUpAlertCbx.UseVisualStyleBackColor = true;
            this.PopUpAlertCbx.CheckedChanged += new System.EventHandler(this.PopUpAlertCbx_CheckedChanged);
            // 
            // BubbleAlertCbx
            // 
            this.BubbleAlertCbx.AutoSize = true;
            this.BubbleAlertCbx.Location = new System.Drawing.Point(202, 361);
            this.BubbleAlertCbx.Name = "BubbleAlertCbx";
            this.BubbleAlertCbx.Size = new System.Drawing.Size(82, 17);
            this.BubbleAlertCbx.TabIndex = 8;
            this.BubbleAlertCbx.Text = "Bubble Alert";
            this.BubbleAlertCbx.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Image URL (Not all images will work 😢) ";
            // 
            // ImageTxt
            // 
            this.ImageTxt.Location = new System.Drawing.Point(15, 311);
            this.ImageTxt.Name = "ImageTxt";
            this.ImageTxt.Size = new System.Drawing.Size(290, 20);
            this.ImageTxt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Event Title (Text that appears on button)";
            // 
            // EventTitleTxt
            // 
            this.EventTitleTxt.Location = new System.Drawing.Point(15, 267);
            this.EventTitleTxt.Name = "EventTitleTxt";
            this.EventTitleTxt.Size = new System.Drawing.Size(290, 20);
            this.EventTitleTxt.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EventTitleTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ImageTxt);
            this.Controls.Add(this.BubbleAlertCbx);
            this.Controls.Add(this.PopUpAlertCbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EventTxt);
            this.Controls.Add(this.MessageLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleTxt);
            this.Controls.Add(this.MessageTxt);
            this.Controls.Add(this.SendAlertBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "HAlerts Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendAlertBtn;
        private System.Windows.Forms.RichTextBox MessageTxt;
        private System.Windows.Forms.TextBox TitleTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MessageLbl;
        private System.Windows.Forms.TextBox EventTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton PopUpAlertCbx;
        private System.Windows.Forms.RadioButton BubbleAlertCbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ImageTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EventTitleTxt;
    }
}

