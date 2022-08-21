using System; 
using System.Globalization; 
using System.Windows.Forms;
using System.Resources;
using System.Threading; 

namespace TestWindowsApplication
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        // create login resource
        ResourceManager rm;
        // create culture info
        CultureInfo ci;

        public LoginForm()
        {
            InitializeComponent();

            // instantiate new login resource
            rm = new ResourceManager("TestWindowsApplication.Resources.LoginResource", typeof(LoginForm).Assembly);
            // instantiate new culture info
            ci = new CultureInfo(Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName);
        }
        // login event 
        private void loginSimpleButton_Click(object sender, EventArgs e)
        {
            // validate form
            bool isValid = loginValidationProvider.Validate();
            
            if (isValid)
            {
                if (userTextEdit.Text == "admin" && passwordTextEdit.Text == "123")
                {
                    // hide this form
                    this.Hide();
                     
                    // reset text values
                    userTextEdit.Text = "";
                    passwordTextEdit.Text = "";

                    // create new instance of home form
                    HomeForm homeForm = new HomeForm(this);
                    // show home form
                    homeForm.Show();
                }
                else
                {
                    MessageBox.Show(rm.GetString("LoginFailed", ci));
                }
            }
        }

        // english language
        private void enSimpleButton_Click(object sender, EventArgs e)
        { 
            // update controls culture
            updateCulture("en");
        }

        // arabic language
        private void arSimpleButton_Click(object sender, EventArgs e)
        {
            // update controls culture
            updateCulture("ar");
        }

        private void updateCulture(string lang)
        {
            // instantiate new culture info
            ci = new CultureInfo(lang);

            // set current culture
            Thread.CurrentThread.CurrentCulture = this.ci;
            Thread.CurrentThread.CurrentUICulture = this.ci;

            // update title string
            this.Text = rm.GetString("Title", ci);

            // update all controls
            foreach (Control Ctrl in this.Controls)
               if(Ctrl.Name != this.userTextEdit.Name && Ctrl.Name != this.passwordTextEdit.Name)
                  Ctrl.Text = rm.GetString(Ctrl.Name, ci);

            // update placeholders
            this.userTextEdit.Properties.NullText = rm.GetString(this.userTextEdit.Name, ci);
            this.userTextEdit.Properties.NullValuePrompt = rm.GetString(this.userTextEdit.Name, ci);
            this.passwordTextEdit.Properties.NullValuePrompt = rm.GetString(this.passwordTextEdit.Name, ci);

            // update error messages and reset them
            var userTextEditErrorText = loginValidationProvider.GetValidationRule(this.userTextEdit);
            userTextEditErrorText.ErrorText = rm.GetString("usernameErrorText", ci);
            loginValidationProvider.RemoveControlError(this.userTextEdit);

            var passwordTextEditErrorText = loginValidationProvider.GetValidationRule(this.passwordTextEdit);
            passwordTextEditErrorText.ErrorText = rm.GetString("passwordErrorText", ci);
            loginValidationProvider.RemoveControlError(this.passwordTextEdit);

            // update layout direction
            RightToLeftLayout = lang == "en" ? false : true;
            RightToLeft = lang == "en" ? RightToLeft.No : RightToLeft.Yes;
             
        }

    }
}