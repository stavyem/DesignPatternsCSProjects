namespace BasicFacebookFeatures.UI
{
    partial class FormFavouritePlaces
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
            this.labelFavouritePlaces = new System.Windows.Forms.Label();
            this.pictureBoxFavPlaces = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFavouritePlaces
            // 
            this.labelFavouritePlaces.AutoSize = true;
            this.labelFavouritePlaces.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFavouritePlaces.Location = new System.Drawing.Point(25, 9);
            this.labelFavouritePlaces.Name = "labelFavouritePlaces";
            this.labelFavouritePlaces.Size = new System.Drawing.Size(227, 28);
            this.labelFavouritePlaces.TabIndex = 1;
            this.labelFavouritePlaces.Text = "All Your Favourite Places:";
            // 
            // pictureBoxFavPlaces
            // 
            this.pictureBoxFavPlaces.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBoxFavPlaces.Location = new System.Drawing.Point(311, 209);
            this.pictureBoxFavPlaces.Name = "pictureBoxFavPlaces";
            this.pictureBoxFavPlaces.Size = new System.Drawing.Size(135, 112);
            this.pictureBoxFavPlaces.TabIndex = 0;
            this.pictureBoxFavPlaces.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(30, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(416, 238);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(30, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "(Ranked from highest to lowest)";
            // 
            // FormFavouritePlaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 355);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBoxFavPlaces);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelFavouritePlaces);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormFavouritePlaces";
            this.Text = "FormFavouritePlaces";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavPlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFavouritePlaces;
        private System.Windows.Forms.PictureBox pictureBoxFavPlaces;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}