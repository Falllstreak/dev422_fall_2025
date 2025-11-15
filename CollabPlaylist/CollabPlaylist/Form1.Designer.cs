namespace CollabPlaylist
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
            this.button_PlaylistBuilder = new System.Windows.Forms.Button();
            this.label_Title1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_PlaylistBuilder
            // 
            this.button_PlaylistBuilder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_PlaylistBuilder.Location = new System.Drawing.Point(479, 130);
            this.button_PlaylistBuilder.Name = "button_PlaylistBuilder";
            this.button_PlaylistBuilder.Size = new System.Drawing.Size(197, 81);
            this.button_PlaylistBuilder.TabIndex = 0;
            this.button_PlaylistBuilder.Text = "Collaborative Playlist Builder";
            this.button_PlaylistBuilder.UseVisualStyleBackColor = true;
            this.button_PlaylistBuilder.Click += new System.EventHandler(this.button_EventTicketing_Click);
            // 
            // label_Title1
            // 
            this.label_Title1.AutoSize = true;
            this.label_Title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label_Title1.Location = new System.Drawing.Point(323, 22);
            this.label_Title1.Name = "label_Title1";
            this.label_Title1.Size = new System.Drawing.Size(123, 31);
            this.label_Title1.TabIndex = 1;
            this.label_Title1.Text = "VibeHive";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Title1);
            this.Controls.Add(this.button_PlaylistBuilder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_PlaylistBuilder;
        private System.Windows.Forms.Label label_Title1;
    }
}

