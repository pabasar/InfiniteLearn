namespace InfiniteLearn
{
    partial class frmMain
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
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.btnRegisterMain = new System.Windows.Forms.Button();
            this.btnLoginMain = new System.Windows.Forms.Button();
            this.grpLevel = new System.Windows.Forms.GroupBox();
            this.rdoAdvanced = new System.Windows.Forms.RadioButton();
            this.rdoIntermediate = new System.Windows.Forms.RadioButton();
            this.rdoBeginner = new System.Windows.Forms.RadioButton();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.lstAvailable = new System.Windows.Forms.ListBox();
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.grpUser.SuspendLayout();
            this.grpLevel.SuspendLayout();
            this.grpCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.btnRegisterMain);
            this.grpUser.Controls.Add(this.btnLoginMain);
            this.grpUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUser.Location = new System.Drawing.Point(397, 12);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(267, 100);
            this.grpUser.TabIndex = 0;
            this.grpUser.TabStop = false;
            this.grpUser.Text = "Unregistered User";
            // 
            // btnRegisterMain
            // 
            this.btnRegisterMain.Location = new System.Drawing.Point(139, 40);
            this.btnRegisterMain.Name = "btnRegisterMain";
            this.btnRegisterMain.Size = new System.Drawing.Size(109, 33);
            this.btnRegisterMain.TabIndex = 1;
            this.btnRegisterMain.Text = "Register";
            this.btnRegisterMain.UseVisualStyleBackColor = true;
            this.btnRegisterMain.Click += new System.EventHandler(this.btnRegisterMain_Click);
            // 
            // btnLoginMain
            // 
            this.btnLoginMain.Location = new System.Drawing.Point(17, 40);
            this.btnLoginMain.Name = "btnLoginMain";
            this.btnLoginMain.Size = new System.Drawing.Size(109, 33);
            this.btnLoginMain.TabIndex = 0;
            this.btnLoginMain.Text = "Login";
            this.btnLoginMain.UseVisualStyleBackColor = true;
            this.btnLoginMain.Click += new System.EventHandler(this.btnLoginMain_Click);
            // 
            // grpLevel
            // 
            this.grpLevel.Controls.Add(this.rdoAdvanced);
            this.grpLevel.Controls.Add(this.rdoIntermediate);
            this.grpLevel.Controls.Add(this.rdoBeginner);
            this.grpLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLevel.Location = new System.Drawing.Point(13, 13);
            this.grpLevel.Name = "grpLevel";
            this.grpLevel.Size = new System.Drawing.Size(378, 100);
            this.grpLevel.TabIndex = 1;
            this.grpLevel.TabStop = false;
            this.grpLevel.Text = "Level";
            // 
            // rdoAdvanced
            // 
            this.rdoAdvanced.AutoSize = true;
            this.rdoAdvanced.Location = new System.Drawing.Point(262, 39);
            this.rdoAdvanced.Name = "rdoAdvanced";
            this.rdoAdvanced.Size = new System.Drawing.Size(103, 24);
            this.rdoAdvanced.TabIndex = 2;
            this.rdoAdvanced.TabStop = true;
            this.rdoAdvanced.Text = "Advanced";
            this.rdoAdvanced.UseVisualStyleBackColor = true;
            this.rdoAdvanced.CheckedChanged += new System.EventHandler(this.rdoAdvanced_CheckedChanged);
            // 
            // rdoIntermediate
            // 
            this.rdoIntermediate.AutoSize = true;
            this.rdoIntermediate.Location = new System.Drawing.Point(127, 39);
            this.rdoIntermediate.Name = "rdoIntermediate";
            this.rdoIntermediate.Size = new System.Drawing.Size(122, 24);
            this.rdoIntermediate.TabIndex = 1;
            this.rdoIntermediate.TabStop = true;
            this.rdoIntermediate.Text = "Intermediate";
            this.rdoIntermediate.UseVisualStyleBackColor = true;
            this.rdoIntermediate.CheckedChanged += new System.EventHandler(this.rdoIntermediate_CheckedChanged);
            // 
            // rdoBeginner
            // 
            this.rdoBeginner.AutoSize = true;
            this.rdoBeginner.Location = new System.Drawing.Point(22, 39);
            this.rdoBeginner.Name = "rdoBeginner";
            this.rdoBeginner.Size = new System.Drawing.Size(97, 24);
            this.rdoBeginner.TabIndex = 0;
            this.rdoBeginner.TabStop = true;
            this.rdoBeginner.Text = "Beginner";
            this.rdoBeginner.UseVisualStyleBackColor = true;
            this.rdoBeginner.CheckedChanged += new System.EventHandler(this.rdoBeginner_CheckedChanged);
            // 
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.lstAvailable);
            this.grpCategory.Controls.Add(this.lstCategory);
            this.grpCategory.Controls.Add(this.label2);
            this.grpCategory.Controls.Add(this.label1);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.Location = new System.Drawing.Point(13, 120);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(651, 280);
            this.grpCategory.TabIndex = 2;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Courses";
            // 
            // lstAvailable
            // 
            this.lstAvailable.FormattingEnabled = true;
            this.lstAvailable.ItemHeight = 20;
            this.lstAvailable.Location = new System.Drawing.Point(222, 73);
            this.lstAvailable.Name = "lstAvailable";
            this.lstAvailable.Size = new System.Drawing.Size(410, 184);
            this.lstAvailable.TabIndex = 3;
            // 
            // lstCategory
            // 
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.ItemHeight = 20;
            this.lstCategory.Location = new System.Drawing.Point(26, 73);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(180, 184);
            this.lstCategory.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Available Courses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // btnEnroll
            // 
            this.btnEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.Location = new System.Drawing.Point(262, 416);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(151, 36);
            this.btnEnroll.TabIndex = 3;
            this.btnEnroll.Text = "Enroll Now";
            this.btnEnroll.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 475);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.grpLevel);
            this.Controls.Add(this.grpUser);
            this.Name = "frmMain";
            this.Text = "Infinite Learn";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpUser.ResumeLayout(false);
            this.grpLevel.ResumeLayout(false);
            this.grpLevel.PerformLayout();
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUser;
        private System.Windows.Forms.Button btnRegisterMain;
        private System.Windows.Forms.Button btnLoginMain;
        private System.Windows.Forms.GroupBox grpLevel;
        private System.Windows.Forms.RadioButton rdoAdvanced;
        private System.Windows.Forms.RadioButton rdoIntermediate;
        private System.Windows.Forms.RadioButton rdoBeginner;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.ListBox lstAvailable;
        private System.Windows.Forms.ListBox lstCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnroll;
    }
}

