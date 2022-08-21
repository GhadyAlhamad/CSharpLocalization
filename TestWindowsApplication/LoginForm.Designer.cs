
namespace TestWindowsApplication
{
    partial class LoginForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.languageLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.userTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.loginSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.arSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.enSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.loginValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.passwordLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.usernameLabelControl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // languageLabelControl
            // 
            this.languageLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.languageLabelControl.Appearance.Options.UseFont = true;
            this.languageLabelControl.Location = new System.Drawing.Point(294, 63);
            this.languageLabelControl.Name = "languageLabelControl";
            this.languageLabelControl.Size = new System.Drawing.Size(185, 40);
            this.languageLabelControl.TabIndex = 1;
            this.languageLabelControl.Text = "Login Form";
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.EditValue = "";
            this.passwordTextEdit.Location = new System.Drawing.Point(45, 287);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Properties.NullText = "Enter Password";
            this.passwordTextEdit.Properties.NullValuePrompt = "Enter Password";
            this.passwordTextEdit.Properties.PasswordChar = '*';
            this.passwordTextEdit.Size = new System.Drawing.Size(703, 50);
            this.passwordTextEdit.TabIndex = 9;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This username field is required.";
            this.loginValidationProvider.SetValidationRule(this.passwordTextEdit, conditionValidationRule1);
            // 
            // userTextEdit
            // 
            this.userTextEdit.EditValue = "";
            this.userTextEdit.Location = new System.Drawing.Point(45, 177);
            this.userTextEdit.Name = "userTextEdit";
            this.userTextEdit.Properties.NullText = "Enter User name";
            this.userTextEdit.Properties.NullValuePrompt = "Enter User name";
            this.userTextEdit.Size = new System.Drawing.Size(706, 50);
            this.userTextEdit.TabIndex = 8;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This username field is required.";
            this.loginValidationProvider.SetValidationRule(this.userTextEdit, conditionValidationRule2);
            // 
            // loginSimpleButton
            // 
            this.loginSimpleButton.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.loginSimpleButton.Appearance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.loginSimpleButton.Appearance.BorderColor = System.Drawing.Color.White;
            this.loginSimpleButton.Appearance.Options.UseBackColor = true;
            this.loginSimpleButton.Appearance.Options.UseBorderColor = true;
            this.loginSimpleButton.Location = new System.Drawing.Point(45, 365);
            this.loginSimpleButton.Name = "loginSimpleButton";
            this.loginSimpleButton.Size = new System.Drawing.Size(706, 57);
            this.loginSimpleButton.TabIndex = 7;
            this.loginSimpleButton.Text = "Login";
            this.loginSimpleButton.Click += new System.EventHandler(this.loginSimpleButton_Click);
            // 
            // arSimpleButton
            // 
            this.arSimpleButton.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.arSimpleButton.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.arSimpleButton.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.arSimpleButton.Appearance.Options.UseBackColor = true;
            this.arSimpleButton.Appearance.Options.UseBorderColor = true;
            this.arSimpleButton.AppearancePressed.BorderColor = System.Drawing.Color.Blue;
            this.arSimpleButton.AppearancePressed.Options.UseBorderColor = true;
            this.arSimpleButton.ImageOptions.Image = global::TestWindowsApplication.Properties.Resources.sy;
            this.arSimpleButton.Location = new System.Drawing.Point(607, 12);
            this.arSimpleButton.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.arSimpleButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.arSimpleButton.LookAndFeel.UseWindowsXPTheme = true;
            this.arSimpleButton.Name = "arSimpleButton";
            this.arSimpleButton.Size = new System.Drawing.Size(69, 57);
            this.arSimpleButton.TabIndex = 11;
            this.arSimpleButton.Click += new System.EventHandler(this.arSimpleButton_Click);
            // 
            // enSimpleButton
            // 
            this.enSimpleButton.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.enSimpleButton.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.enSimpleButton.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.enSimpleButton.Appearance.Options.UseBackColor = true;
            this.enSimpleButton.Appearance.Options.UseBorderColor = true;
            this.enSimpleButton.ImageOptions.Image = global::TestWindowsApplication.Properties.Resources.US;
            this.enSimpleButton.Location = new System.Drawing.Point(682, 12);
            this.enSimpleButton.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.enSimpleButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.enSimpleButton.LookAndFeel.UseWindowsXPTheme = true;
            this.enSimpleButton.Name = "enSimpleButton";
            this.enSimpleButton.Size = new System.Drawing.Size(69, 57);
            this.enSimpleButton.TabIndex = 10;
            this.enSimpleButton.Click += new System.EventHandler(this.enSimpleButton_Click);
            // 
            // passwordLabelControl
            // 
            this.passwordLabelControl.Location = new System.Drawing.Point(48, 248);
            this.passwordLabelControl.Name = "passwordLabelControl";
            this.passwordLabelControl.Size = new System.Drawing.Size(113, 33);
            this.passwordLabelControl.TabIndex = 12;
            this.passwordLabelControl.Text = "Password";
            // 
            // usernameLabelControl
            // 
            this.usernameLabelControl.Location = new System.Drawing.Point(48, 138);
            this.usernameLabelControl.Name = "usernameLabelControl";
            this.usernameLabelControl.Size = new System.Drawing.Size(120, 33);
            this.usernameLabelControl.TabIndex = 13;
            this.usernameLabelControl.Text = "Username";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 469);
            this.Controls.Add(this.usernameLabelControl);
            this.Controls.Add(this.passwordLabelControl);
            this.Controls.Add(this.arSimpleButton);
            this.Controls.Add(this.enSimpleButton);
            this.Controls.Add(this.passwordTextEdit);
            this.Controls.Add(this.userTextEdit);
            this.Controls.Add(this.loginSimpleButton);
            this.Controls.Add(this.languageLabelControl);
            this.IconOptions.Image = global::TestWindowsApplication.Properties.Resources.settings;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl languageLabelControl;
        private DevExpress.XtraEditors.TextEdit passwordTextEdit;
        private DevExpress.XtraEditors.TextEdit userTextEdit;
        private DevExpress.XtraEditors.SimpleButton loginSimpleButton;
        private DevExpress.XtraEditors.SimpleButton enSimpleButton;
        private DevExpress.XtraEditors.SimpleButton arSimpleButton;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider loginValidationProvider;
        private DevExpress.XtraEditors.LabelControl passwordLabelControl;
        private DevExpress.XtraEditors.LabelControl usernameLabelControl;
    }
}