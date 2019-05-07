namespace gra1
{
    partial class FormMenu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelGameName = new System.Windows.Forms.Label();
            this.buttonPlayGame = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.BackColor = System.Drawing.Color.Transparent;
            this.labelGameName.Font = new System.Drawing.Font("Power Red and Green", 39F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGameName.Location = new System.Drawing.Point(262, 31);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(344, 62);
            this.labelGameName.TabIndex = 3;
            this.labelGameName.Text = "Zombie Shelter";
            this.labelGameName.Click += new System.EventHandler(this.labelGameName_Click);
            // 
            // buttonPlayGame
            // 
            this.buttonPlayGame.Font = new System.Drawing.Font("Power Clear", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlayGame.Location = new System.Drawing.Point(367, 129);
            this.buttonPlayGame.Name = "buttonPlayGame";
            this.buttonPlayGame.Size = new System.Drawing.Size(132, 56);
            this.buttonPlayGame.TabIndex = 4;
            this.buttonPlayGame.Text = "PLAY";
            this.buttonPlayGame.UseVisualStyleBackColor = true;
            this.buttonPlayGame.Click += new System.EventHandler(this.buttonPlayGame_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Power Green", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.Location = new System.Drawing.Point(367, 214);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(132, 57);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gra1.Properties.Resources._1_pWB6Jb6uLWkPb56RJS82eA;
            this.ClientSize = new System.Drawing.Size(842, 509);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPlayGame);
            this.Controls.Add(this.labelGameName);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelGameName;
        private System.Windows.Forms.Button buttonPlayGame;
        private System.Windows.Forms.Button buttonExit;
    }
}

