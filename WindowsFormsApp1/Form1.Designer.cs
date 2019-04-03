namespace WindowsFormsApp1
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
            this.imgVideo = new System.Windows.Forms.PictureBox();
            this.bntCapture = new System.Windows.Forms.Button();
            this.exit_form = new System.Windows.Forms.Button();
            this.start_capture = new System.Windows.Forms.Button();
            this.dropdown = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.bntStop_Capture = new System.Windows.Forms.Button();
            this.text_Capturing = new System.Windows.Forms.Label();
            this.btnCapture_Image = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgVideo
            // 
            this.imgVideo.AccessibleDescription = "";
            this.imgVideo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imgVideo.Location = new System.Drawing.Point(12, 12);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(583, 358);
            this.imgVideo.TabIndex = 0;
            this.imgVideo.TabStop = false;
            // 
            // bntCapture
            // 
            this.bntCapture.Location = new System.Drawing.Point(12, 391);
            this.bntCapture.Name = "bntCapture";
            this.bntCapture.Size = new System.Drawing.Size(75, 35);
            this.bntCapture.TabIndex = 1;
            this.bntCapture.Text = "Capture";
            this.bntCapture.UseVisualStyleBackColor = true;
            this.bntCapture.Click += new System.EventHandler(this.Capture_Click);
            // 
            // exit_form
            // 
            this.exit_form.Location = new System.Drawing.Point(678, 387);
            this.exit_form.Name = "exit_form";
            this.exit_form.Size = new System.Drawing.Size(76, 31);
            this.exit_form.TabIndex = 2;
            this.exit_form.Text = "EXIT";
            this.exit_form.UseVisualStyleBackColor = true;
            this.exit_form.Click += new System.EventHandler(this.exit_form_Click);
            // 
            // start_capture
            // 
            this.start_capture.Location = new System.Drawing.Point(630, 100);
            this.start_capture.Name = "start_capture";
            this.start_capture.Size = new System.Drawing.Size(137, 29);
            this.start_capture.TabIndex = 3;
            this.start_capture.Text = "Start Camera";
            this.start_capture.UseVisualStyleBackColor = true;
            this.start_capture.Click += new System.EventHandler(this.start_capture_Click);
            // 
            // dropdown
            // 
            this.dropdown.FormattingEnabled = true;
            this.dropdown.Location = new System.Drawing.Point(630, 12);
            this.dropdown.Name = "dropdown";
            this.dropdown.Size = new System.Drawing.Size(137, 24);
            this.dropdown.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(630, 61);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(137, 33);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save Path";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveClick);
            // 
            // bntStop_Capture
            // 
            this.bntStop_Capture.Location = new System.Drawing.Point(93, 391);
            this.bntStop_Capture.Name = "bntStop_Capture";
            this.bntStop_Capture.Size = new System.Drawing.Size(122, 35);
            this.bntStop_Capture.TabIndex = 6;
            this.bntStop_Capture.Text = "Stop Capture";
            this.bntStop_Capture.UseVisualStyleBackColor = true;
            this.bntStop_Capture.Click += new System.EventHandler(this.Stop_Capture_Click);
            // 
            // text_Capturing
            // 
            this.text_Capturing.AutoSize = true;
            this.text_Capturing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Capturing.Location = new System.Drawing.Point(281, 393);
            this.text_Capturing.Name = "text_Capturing";
            this.text_Capturing.Size = new System.Drawing.Size(132, 25);
            this.text_Capturing.TabIndex = 7;
            this.text_Capturing.Text = "Not Capturing";
            // 
            // btnCapture_Image
            // 
            this.btnCapture_Image.Location = new System.Drawing.Point(482, 393);
            this.btnCapture_Image.Name = "btnCapture_Image";
            this.btnCapture_Image.Size = new System.Drawing.Size(113, 33);
            this.btnCapture_Image.TabIndex = 8;
            this.btnCapture_Image.Text = "Capture Image";
            this.btnCapture_Image.UseVisualStyleBackColor = true;
            this.btnCapture_Image.Click += new System.EventHandler(this.btnCapture_Image_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCapture_Image);
            this.Controls.Add(this.text_Capturing);
            this.Controls.Add(this.bntStop_Capture);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dropdown);
            this.Controls.Add(this.start_capture);
            this.Controls.Add(this.exit_form);
            this.Controls.Add(this.bntCapture);
            this.Controls.Add(this.imgVideo);
            this.Name = "Form1";
            this.Text = "exit_Click";
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgVideo;
        private System.Windows.Forms.Button bntCapture;
        private System.Windows.Forms.Button exit_form;
        private System.Windows.Forms.Button start_capture;
        private System.Windows.Forms.ComboBox dropdown;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button bntStop_Capture;
        private System.Windows.Forms.Label text_Capturing;
        private System.Windows.Forms.Button btnCapture_Image;
    }
}

