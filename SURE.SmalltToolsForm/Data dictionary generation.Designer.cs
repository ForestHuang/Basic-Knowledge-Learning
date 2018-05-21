namespace SURE.SmalltToolsForm
{
    partial class DataDictionaryGeneration
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labServerAddress = new System.Windows.Forms.Label();
            this.labUser = new System.Windows.Forms.Label();
            this.labPwd = new System.Windows.Forms.Label();
            this.textServerAddress = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.butLogin = new System.Windows.Forms.Button();
            this.labSavePath = new System.Windows.Forms.Label();
            this.butSelectionPath = new System.Windows.Forms.Button();
            this.labSavePathExhibition = new System.Windows.Forms.Label();
            this.labLoginMessage = new System.Windows.Forms.Label();
            this.labDataBase = new System.Windows.Forms.Label();
            this.comboxDataBase = new System.Windows.Forms.ComboBox();
            this.butGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labServerAddress
            // 
            this.labServerAddress.AutoSize = true;
            this.labServerAddress.Location = new System.Drawing.Point(1, 11);
            this.labServerAddress.Name = "labServerAddress";
            this.labServerAddress.Size = new System.Drawing.Size(101, 12);
            this.labServerAddress.TabIndex = 0;
            this.labServerAddress.Text = "Server Address：";
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Location = new System.Drawing.Point(61, 44);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(41, 12);
            this.labUser.TabIndex = 0;
            this.labUser.Text = "User：";
            // 
            // labPwd
            // 
            this.labPwd.AutoSize = true;
            this.labPwd.Location = new System.Drawing.Point(37, 71);
            this.labPwd.Name = "labPwd";
            this.labPwd.Size = new System.Drawing.Size(65, 12);
            this.labPwd.TabIndex = 0;
            this.labPwd.Text = "PassWord：";
            // 
            // textServerAddress
            // 
            this.textServerAddress.Location = new System.Drawing.Point(104, 7);
            this.textServerAddress.Name = "textServerAddress";
            this.textServerAddress.Size = new System.Drawing.Size(170, 21);
            this.textServerAddress.TabIndex = 0;
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(104, 40);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(170, 21);
            this.textUser.TabIndex = 1;
            // 
            // textPwd
            // 
            this.textPwd.Location = new System.Drawing.Point(104, 67);
            this.textPwd.Name = "textPwd";
            this.textPwd.Size = new System.Drawing.Size(170, 21);
            this.textPwd.TabIndex = 2;
            // 
            // butLogin
            // 
            this.butLogin.Location = new System.Drawing.Point(288, 66);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(75, 23);
            this.butLogin.TabIndex = 3;
            this.butLogin.Text = "Login";
            this.butLogin.UseVisualStyleBackColor = true;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // labSavePath
            // 
            this.labSavePath.AutoSize = true;
            this.labSavePath.Location = new System.Drawing.Point(31, 147);
            this.labSavePath.Name = "labSavePath";
            this.labSavePath.Size = new System.Drawing.Size(71, 12);
            this.labSavePath.TabIndex = 3;
            this.labSavePath.Text = "Save Path：";
            // 
            // butSelectionPath
            // 
            this.butSelectionPath.Location = new System.Drawing.Point(104, 142);
            this.butSelectionPath.Name = "butSelectionPath";
            this.butSelectionPath.Size = new System.Drawing.Size(170, 23);
            this.butSelectionPath.TabIndex = 5;
            this.butSelectionPath.Text = "Selection Path";
            this.butSelectionPath.UseVisualStyleBackColor = true;
            this.butSelectionPath.Click += new System.EventHandler(this.butSelectionPath_Click);
            // 
            // labSavePathExhibition
            // 
            this.labSavePathExhibition.AllowDrop = true;
            this.labSavePathExhibition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labSavePathExhibition.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSavePathExhibition.ForeColor = System.Drawing.Color.Red;
            this.labSavePathExhibition.Location = new System.Drawing.Point(23, 184);
            this.labSavePathExhibition.Name = "labSavePathExhibition";
            this.labSavePathExhibition.Size = new System.Drawing.Size(340, 23);
            this.labSavePathExhibition.TabIndex = 5;
            this.labSavePathExhibition.Text = "labelSavePath";
            // 
            // labLoginMessage
            // 
            this.labLoginMessage.AllowDrop = true;
            this.labLoginMessage.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLoginMessage.ForeColor = System.Drawing.Color.Red;
            this.labLoginMessage.Location = new System.Drawing.Point(261, 92);
            this.labLoginMessage.Name = "labLoginMessage";
            this.labLoginMessage.Size = new System.Drawing.Size(98, 23);
            this.labLoginMessage.TabIndex = 5;
            this.labLoginMessage.Text = "Not logged in";
            // 
            // labDataBase
            // 
            this.labDataBase.AutoSize = true;
            this.labDataBase.Location = new System.Drawing.Point(31, 117);
            this.labDataBase.Name = "labDataBase";
            this.labDataBase.Size = new System.Drawing.Size(71, 12);
            this.labDataBase.TabIndex = 6;
            this.labDataBase.Text = "Data Base：";
            // 
            // comboxDataBase
            // 
            this.comboxDataBase.FormattingEnabled = true;
            this.comboxDataBase.Location = new System.Drawing.Point(104, 113);
            this.comboxDataBase.Name = "comboxDataBase";
            this.comboxDataBase.Size = new System.Drawing.Size(169, 20);
            this.comboxDataBase.TabIndex = 4;
            this.comboxDataBase.TextUpdate += new System.EventHandler(this.comboxDataBase_TextUpdate);
            // 
            // butGenerate
            // 
            this.butGenerate.Location = new System.Drawing.Point(288, 142);
            this.butGenerate.Name = "butGenerate";
            this.butGenerate.Size = new System.Drawing.Size(75, 23);
            this.butGenerate.TabIndex = 6;
            this.butGenerate.Text = "Generate";
            this.butGenerate.UseVisualStyleBackColor = true;
            this.butGenerate.Click += new System.EventHandler(this.butGenerate_Click);
            // 
            // DataDictionaryGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 226);
            this.Controls.Add(this.butGenerate);
            this.Controls.Add(this.comboxDataBase);
            this.Controls.Add(this.labDataBase);
            this.Controls.Add(this.labLoginMessage);
            this.Controls.Add(this.labSavePathExhibition);
            this.Controls.Add(this.butSelectionPath);
            this.Controls.Add(this.labSavePath);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.textPwd);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.textServerAddress);
            this.Controls.Add(this.labPwd);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.labServerAddress);
            this.Name = "DataDictionaryGeneration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data dictionary generation";
            this.Load += new System.EventHandler(this.DataDictionaryGeneration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labServerAddress;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.Label labPwd;
        private System.Windows.Forms.TextBox textServerAddress;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPwd;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Label labSavePath;
        private System.Windows.Forms.Button butSelectionPath;
        private System.Windows.Forms.Label labSavePathExhibition;
        private System.Windows.Forms.Label labLoginMessage;
        private System.Windows.Forms.Label labDataBase;
        private System.Windows.Forms.ComboBox comboxDataBase;
        private System.Windows.Forms.Button butGenerate;
    }
}

