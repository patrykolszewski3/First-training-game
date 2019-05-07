namespace gra1
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            this.labelWeapon = new System.Windows.Forms.Label();
            this.labelFood = new System.Windows.Forms.Label();
            this.labelWorkForce = new System.Windows.Forms.Label();
            this.labelMorale = new System.Windows.Forms.Label();
            this.labelTools = new System.Windows.Forms.Label();
            this.labelArchitecture = new System.Windows.Forms.Label();
            this.labelWeaponDescription = new System.Windows.Forms.Label();
            this.labelWorkForceDescription = new System.Windows.Forms.Label();
            this.labelFoodDescription = new System.Windows.Forms.Label();
            this.labelMoraleDescription = new System.Windows.Forms.Label();
            this.labelArchitectureDescription = new System.Windows.Forms.Label();
            this.labelToolsDescription = new System.Windows.Forms.Label();
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.labelDay = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.buttonAddMorale = new System.Windows.Forms.Button();
            this.buttonAddTools = new System.Windows.Forms.Button();
            this.buttonAddWeapon = new System.Windows.Forms.Button();
            this.buttonAddArchitecture = new System.Windows.Forms.Button();
            this.buttonAddFood = new System.Windows.Forms.Button();
            this.textBoxFoodLvl = new System.Windows.Forms.TextBox();
            this.textBoxArchitectureLvl = new System.Windows.Forms.TextBox();
            this.textBoxWeaponLvl = new System.Windows.Forms.TextBox();
            this.textBoxToolsLvl = new System.Windows.Forms.TextBox();
            this.textBoxMoraleLvl = new System.Windows.Forms.TextBox();
            this.textBoxNews = new System.Windows.Forms.TextBox();
            this.pictureBoxAdvisor = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdvisor)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWeapon
            // 
            this.labelWeapon.AutoSize = true;
            this.labelWeapon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWeapon.Location = new System.Drawing.Point(236, 20);
            this.labelWeapon.Name = "labelWeapon";
            this.labelWeapon.Size = new System.Drawing.Size(38, 27);
            this.labelWeapon.TabIndex = 0;
            this.labelWeapon.Text = "50";
            this.labelWeapon.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFood.Location = new System.Drawing.Point(415, 20);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(38, 27);
            this.labelFood.TabIndex = 1;
            this.labelFood.Text = "50";
            this.labelFood.Click += new System.EventHandler(this.labelFood_Click);
            // 
            // labelWorkForce
            // 
            this.labelWorkForce.AutoSize = true;
            this.labelWorkForce.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWorkForce.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWorkForce.Location = new System.Drawing.Point(433, 153);
            this.labelWorkForce.Name = "labelWorkForce";
            this.labelWorkForce.Size = new System.Drawing.Size(38, 27);
            this.labelWorkForce.TabIndex = 2;
            this.labelWorkForce.Text = "20";
            this.labelWorkForce.Click += new System.EventHandler(this.labelPeople_Click);
            // 
            // labelMorale
            // 
            this.labelMorale.AutoSize = true;
            this.labelMorale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMorale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMorale.Location = new System.Drawing.Point(56, 20);
            this.labelMorale.Name = "labelMorale";
            this.labelMorale.Size = new System.Drawing.Size(38, 27);
            this.labelMorale.TabIndex = 3;
            this.labelMorale.Text = "75";
            this.labelMorale.Click += new System.EventHandler(this.labelMorale_Click);
            // 
            // labelTools
            // 
            this.labelTools.AutoSize = true;
            this.labelTools.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTools.Location = new System.Drawing.Point(137, 20);
            this.labelTools.Name = "labelTools";
            this.labelTools.Size = new System.Drawing.Size(50, 27);
            this.labelTools.TabIndex = 4;
            this.labelTools.Text = "100";
            this.labelTools.Click += new System.EventHandler(this.labelShelterLifepoints_Click);
            // 
            // labelArchitecture
            // 
            this.labelArchitecture.AutoSize = true;
            this.labelArchitecture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelArchitecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelArchitecture.Location = new System.Drawing.Point(313, 20);
            this.labelArchitecture.Name = "labelArchitecture";
            this.labelArchitecture.Size = new System.Drawing.Size(38, 27);
            this.labelArchitecture.TabIndex = 5;
            this.labelArchitecture.Text = "50";
            this.labelArchitecture.Click += new System.EventHandler(this.labelArchitecture_Click);
            // 
            // labelWeaponDescription
            // 
            this.labelWeaponDescription.AutoSize = true;
            this.labelWeaponDescription.Location = new System.Drawing.Point(238, 50);
            this.labelWeaponDescription.Name = "labelWeaponDescription";
            this.labelWeaponDescription.Size = new System.Drawing.Size(29, 13);
            this.labelWeaponDescription.TabIndex = 6;
            this.labelWeaponDescription.Text = "Broń";
            this.labelWeaponDescription.Click += new System.EventHandler(this.labelWeaponDescription_Click);
            // 
            // labelWorkForceDescription
            // 
            this.labelWorkForceDescription.Location = new System.Drawing.Point(417, 185);
            this.labelWorkForceDescription.Name = "labelWorkForceDescription";
            this.labelWorkForceDescription.Size = new System.Drawing.Size(70, 13);
            this.labelWorkForceDescription.TabIndex = 7;
            this.labelWorkForceDescription.Text = "Siła robocza";
            this.labelWorkForceDescription.Click += new System.EventHandler(this.labelWorkForceDescription_Click);
            // 
            // labelFoodDescription
            // 
            this.labelFoodDescription.AutoSize = true;
            this.labelFoodDescription.Location = new System.Drawing.Point(417, 50);
            this.labelFoodDescription.Name = "labelFoodDescription";
            this.labelFoodDescription.Size = new System.Drawing.Size(50, 13);
            this.labelFoodDescription.TabIndex = 8;
            this.labelFoodDescription.Text = "Żywność";
            this.labelFoodDescription.Click += new System.EventHandler(this.labelFoodDescription_Click);
            // 
            // labelMoraleDescription
            // 
            this.labelMoraleDescription.AutoSize = true;
            this.labelMoraleDescription.Location = new System.Drawing.Point(55, 50);
            this.labelMoraleDescription.Name = "labelMoraleDescription";
            this.labelMoraleDescription.Size = new System.Drawing.Size(39, 13);
            this.labelMoraleDescription.TabIndex = 9;
            this.labelMoraleDescription.Text = "Morale";
            this.labelMoraleDescription.Click += new System.EventHandler(this.labelMoraleDescription_Click);
            // 
            // labelArchitectureDescription
            // 
            this.labelArchitectureDescription.AutoSize = true;
            this.labelArchitectureDescription.Location = new System.Drawing.Point(315, 50);
            this.labelArchitectureDescription.Name = "labelArchitectureDescription";
            this.labelArchitectureDescription.Size = new System.Drawing.Size(64, 13);
            this.labelArchitectureDescription.TabIndex = 10;
            this.labelArchitectureDescription.Text = "Architektura";
            this.labelArchitectureDescription.Click += new System.EventHandler(this.labelArchitectureDescription_Click);
            // 
            // labelToolsDescription
            // 
            this.labelToolsDescription.AutoSize = true;
            this.labelToolsDescription.Location = new System.Drawing.Point(138, 50);
            this.labelToolsDescription.Name = "labelToolsDescription";
            this.labelToolsDescription.Size = new System.Drawing.Size(54, 13);
            this.labelToolsDescription.TabIndex = 11;
            this.labelToolsDescription.Text = "Narzędzia";
            this.labelToolsDescription.Click += new System.EventHandler(this.labelTechniqueDescription_Click);
            // 
            // timerCounter
            // 
            this.timerCounter.Interval = 1000;
            this.timerCounter.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(433, 247);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(34, 13);
            this.labelDay.TabIndex = 12;
            this.labelDay.Text = "Dzień";
            this.labelDay.Click += new System.EventHandler(this.labelDay_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimer.Location = new System.Drawing.Point(433, 212);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(26, 27);
            this.labelTimer.TabIndex = 13;
            this.labelTimer.Text = "0";
            this.labelTimer.Click += new System.EventHandler(this.labelTimer_Click);
            // 
            // buttonAddMorale
            // 
            this.buttonAddMorale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddMorale.Location = new System.Drawing.Point(58, 68);
            this.buttonAddMorale.Name = "buttonAddMorale";
            this.buttonAddMorale.Size = new System.Drawing.Size(22, 22);
            this.buttonAddMorale.TabIndex = 15;
            this.buttonAddMorale.Text = "+";
            this.buttonAddMorale.UseVisualStyleBackColor = true;
            this.buttonAddMorale.Click += new System.EventHandler(this.buttonAddMorale_Click);
            // 
            // buttonAddTools
            // 
            this.buttonAddTools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddTools.Location = new System.Drawing.Point(142, 68);
            this.buttonAddTools.Name = "buttonAddTools";
            this.buttonAddTools.Size = new System.Drawing.Size(22, 22);
            this.buttonAddTools.TabIndex = 16;
            this.buttonAddTools.Text = "+";
            this.buttonAddTools.UseVisualStyleBackColor = true;
            this.buttonAddTools.Click += new System.EventHandler(this.buttonAddTechnique_Click);
            // 
            // buttonAddWeapon
            // 
            this.buttonAddWeapon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddWeapon.Location = new System.Drawing.Point(229, 68);
            this.buttonAddWeapon.Name = "buttonAddWeapon";
            this.buttonAddWeapon.Size = new System.Drawing.Size(22, 22);
            this.buttonAddWeapon.TabIndex = 17;
            this.buttonAddWeapon.Text = "+";
            this.buttonAddWeapon.UseVisualStyleBackColor = true;
            this.buttonAddWeapon.Click += new System.EventHandler(this.buttonAddWeapon_Click);
            // 
            // buttonAddArchitecture
            // 
            this.buttonAddArchitecture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddArchitecture.Location = new System.Drawing.Point(318, 68);
            this.buttonAddArchitecture.Name = "buttonAddArchitecture";
            this.buttonAddArchitecture.Size = new System.Drawing.Size(22, 22);
            this.buttonAddArchitecture.TabIndex = 18;
            this.buttonAddArchitecture.Text = "+";
            this.buttonAddArchitecture.UseVisualStyleBackColor = true;
            this.buttonAddArchitecture.Click += new System.EventHandler(this.buttonAddArchitecture_Click);
            // 
            // buttonAddFood
            // 
            this.buttonAddFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddFood.Location = new System.Drawing.Point(420, 68);
            this.buttonAddFood.Name = "buttonAddFood";
            this.buttonAddFood.Size = new System.Drawing.Size(22, 22);
            this.buttonAddFood.TabIndex = 19;
            this.buttonAddFood.Text = "+";
            this.buttonAddFood.UseVisualStyleBackColor = true;
            this.buttonAddFood.Click += new System.EventHandler(this.buttonAddFood_Click);
            // 
            // textBoxFoodLvl
            // 
            this.textBoxFoodLvl.Location = new System.Drawing.Point(448, 70);
            this.textBoxFoodLvl.Name = "textBoxFoodLvl";
            this.textBoxFoodLvl.Size = new System.Drawing.Size(22, 20);
            this.textBoxFoodLvl.TabIndex = 20;
            this.textBoxFoodLvl.Text = "1";
            this.textBoxFoodLvl.TextChanged += new System.EventHandler(this.textBoxFoodLvl_TextChanged);
            // 
            // textBoxArchitectureLvl
            // 
            this.textBoxArchitectureLvl.Location = new System.Drawing.Point(346, 70);
            this.textBoxArchitectureLvl.Name = "textBoxArchitectureLvl";
            this.textBoxArchitectureLvl.Size = new System.Drawing.Size(22, 20);
            this.textBoxArchitectureLvl.TabIndex = 21;
            this.textBoxArchitectureLvl.Text = "1";
            this.textBoxArchitectureLvl.TextChanged += new System.EventHandler(this.textBoxArchitectureLvl_TextChanged);
            // 
            // textBoxWeaponLvl
            // 
            this.textBoxWeaponLvl.Location = new System.Drawing.Point(257, 70);
            this.textBoxWeaponLvl.Name = "textBoxWeaponLvl";
            this.textBoxWeaponLvl.Size = new System.Drawing.Size(22, 20);
            this.textBoxWeaponLvl.TabIndex = 22;
            this.textBoxWeaponLvl.Text = "1";
            this.textBoxWeaponLvl.TextChanged += new System.EventHandler(this.textBoxWeaponLvl_TextChanged);
            // 
            // textBoxToolsLvl
            // 
            this.textBoxToolsLvl.Location = new System.Drawing.Point(170, 70);
            this.textBoxToolsLvl.Name = "textBoxToolsLvl";
            this.textBoxToolsLvl.Size = new System.Drawing.Size(22, 20);
            this.textBoxToolsLvl.TabIndex = 23;
            this.textBoxToolsLvl.Text = "1";
            this.textBoxToolsLvl.TextChanged += new System.EventHandler(this.textBoxToolsLvl_TextChanged);
            // 
            // textBoxMoraleLvl
            // 
            this.textBoxMoraleLvl.Location = new System.Drawing.Point(86, 70);
            this.textBoxMoraleLvl.Name = "textBoxMoraleLvl";
            this.textBoxMoraleLvl.Size = new System.Drawing.Size(22, 20);
            this.textBoxMoraleLvl.TabIndex = 24;
            this.textBoxMoraleLvl.Text = "1";
            this.textBoxMoraleLvl.TextChanged += new System.EventHandler(this.textBoxMoraleLvl_TextChanged);
            // 
            // textBoxNews
            // 
            this.textBoxNews.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNews.Location = new System.Drawing.Point(209, 153);
            this.textBoxNews.Multiline = true;
            this.textBoxNews.Name = "textBoxNews";
            this.textBoxNews.Size = new System.Drawing.Size(193, 124);
            this.textBoxNews.TabIndex = 25;
            this.textBoxNews.TextChanged += new System.EventHandler(this.textBoxNews_TextChanged);
            // 
            // pictureBoxAdvisor
            // 
            this.pictureBoxAdvisor.Image = global::gra1.Properties.Resources.advisor;
            this.pictureBoxAdvisor.Location = new System.Drawing.Point(22, 119);
            this.pictureBoxAdvisor.Name = "pictureBoxAdvisor";
            this.pictureBoxAdvisor.Size = new System.Drawing.Size(170, 185);
            this.pictureBoxAdvisor.TabIndex = 26;
            this.pictureBoxAdvisor.TabStop = false;
            this.pictureBoxAdvisor.Click += new System.EventHandler(this.pictureBoxAdvisor_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(431, 311);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 27;
            this.buttonClose.Text = "Zamknij";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.Location = new System.Drawing.Point(346, 311);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonBackToMenu.TabIndex = 28;
            this.buttonBackToMenu.Text = "Menu";
            this.buttonBackToMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMenu.Click += new System.EventHandler(this.buttonBackToMenu_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gra1.Properties.Resources.gameBackground;
            this.ClientSize = new System.Drawing.Size(518, 346);
            this.Controls.Add(this.buttonBackToMenu);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxAdvisor);
            this.Controls.Add(this.textBoxNews);
            this.Controls.Add(this.textBoxMoraleLvl);
            this.Controls.Add(this.textBoxToolsLvl);
            this.Controls.Add(this.textBoxWeaponLvl);
            this.Controls.Add(this.textBoxArchitectureLvl);
            this.Controls.Add(this.textBoxFoodLvl);
            this.Controls.Add(this.buttonAddFood);
            this.Controls.Add(this.buttonAddArchitecture);
            this.Controls.Add(this.buttonAddWeapon);
            this.Controls.Add(this.buttonAddTools);
            this.Controls.Add(this.buttonAddMorale);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelToolsDescription);
            this.Controls.Add(this.labelArchitectureDescription);
            this.Controls.Add(this.labelMoraleDescription);
            this.Controls.Add(this.labelFoodDescription);
            this.Controls.Add(this.labelWorkForceDescription);
            this.Controls.Add(this.labelWeaponDescription);
            this.Controls.Add(this.labelArchitecture);
            this.Controls.Add(this.labelTools);
            this.Controls.Add(this.labelMorale);
            this.Controls.Add(this.labelWorkForce);
            this.Controls.Add(this.labelFood);
            this.Controls.Add(this.labelWeapon);
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdvisor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWeapon;
        private System.Windows.Forms.Label labelFood;
        private System.Windows.Forms.Label labelWorkForce;
        private System.Windows.Forms.Label labelMorale;
        private System.Windows.Forms.Label labelTools;
        private System.Windows.Forms.Label labelArchitecture;
        private System.Windows.Forms.Label labelWeaponDescription;
        private System.Windows.Forms.Label labelWorkForceDescription;
        private System.Windows.Forms.Label labelFoodDescription;
        private System.Windows.Forms.Label labelMoraleDescription;
        private System.Windows.Forms.Label labelArchitectureDescription;
        private System.Windows.Forms.Label labelToolsDescription;
        private System.Windows.Forms.Timer timerCounter;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Button buttonAddMorale;
        private System.Windows.Forms.Button buttonAddTools;
        private System.Windows.Forms.Button buttonAddWeapon;
        private System.Windows.Forms.Button buttonAddArchitecture;
        private System.Windows.Forms.Button buttonAddFood;
        private System.Windows.Forms.TextBox textBoxFoodLvl;
        private System.Windows.Forms.TextBox textBoxArchitectureLvl;
        private System.Windows.Forms.TextBox textBoxWeaponLvl;
        private System.Windows.Forms.TextBox textBoxToolsLvl;
        private System.Windows.Forms.TextBox textBoxMoraleLvl;
        private System.Windows.Forms.TextBox textBoxNews;
        private System.Windows.Forms.PictureBox pictureBoxAdvisor;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonBackToMenu;
    }
}