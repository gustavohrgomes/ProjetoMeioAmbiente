namespace projetoMeioAmbiente
{
    partial class frmAviso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAviso));
            this.imgError = new System.Windows.Forms.PictureBox();
            this.imgOk = new System.Windows.Forms.PictureBox();
            this.imgQuestionMark = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuestionMark)).BeginInit();
            this.SuspendLayout();
            // 
            // imgError
            // 
            this.imgError.Image = ((System.Drawing.Image)(resources.GetObject("imgError.Image")));
            this.imgError.Location = new System.Drawing.Point(30, 30);
            this.imgError.Name = "imgError";
            this.imgError.Size = new System.Drawing.Size(100, 100);
            this.imgError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgError.TabIndex = 0;
            this.imgError.TabStop = false;
            this.imgError.Visible = false;
            // 
            // imgOk
            // 
            this.imgOk.Image = ((System.Drawing.Image)(resources.GetObject("imgOk.Image")));
            this.imgOk.Location = new System.Drawing.Point(30, 30);
            this.imgOk.Name = "imgOk";
            this.imgOk.Size = new System.Drawing.Size(100, 100);
            this.imgOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOk.TabIndex = 1;
            this.imgOk.TabStop = false;
            this.imgOk.Visible = false;
            // 
            // imgQuestionMark
            // 
            this.imgQuestionMark.Image = ((System.Drawing.Image)(resources.GetObject("imgQuestionMark.Image")));
            this.imgQuestionMark.Location = new System.Drawing.Point(30, 30);
            this.imgQuestionMark.Name = "imgQuestionMark";
            this.imgQuestionMark.Size = new System.Drawing.Size(100, 100);
            this.imgQuestionMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgQuestionMark.TabIndex = 1;
            this.imgQuestionMark.TabStop = false;
            this.imgQuestionMark.Visible = false;
            // 
            // frmAviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(474, 156);
            this.Controls.Add(this.imgQuestionMark);
            this.Controls.Add(this.imgOk);
            this.Controls.Add(this.imgError);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAviso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.imgError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuestionMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox imgError;
        public System.Windows.Forms.PictureBox imgOk;
        public System.Windows.Forms.PictureBox imgQuestionMark;

    }
}