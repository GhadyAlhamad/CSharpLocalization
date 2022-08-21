using DevExpress.XtraEditors;
using System;
using System.Globalization; 
using System.Resources; 
using System.Threading; 
using System.Windows.Forms; 

namespace TestWindowsApplication
{
    public partial class HomeForm : DevExpress.XtraEditors.XtraForm
    {
        // create login form
        LoginForm loginForm;
        // create login resource
        ResourceManager rm;
        // create culture info
        CultureInfo ci;

        public HomeForm(LoginForm loginForm)
        {  
            InitializeComponent();

            // assign login form
            this.loginForm = loginForm;

            // read current language
            var lang = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;

            // instantiate new login resource
            this.rm = new ResourceManager("TestWindowsApplication.Resources.HomeResource", typeof(HomeForm).Assembly);
            // instantiate new culture info
            this.ci = new CultureInfo(lang);
            // call update culture
            updateCulture(Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName);
        }
         
        private void logoutSimpleButton_Click(object sender, EventArgs e)
        { 
            // hide this form
            this.Close();
            // show choose language form
            loginForm.Show();
        }

        private void closeSimpleButton_Click(object sender, EventArgs e)
        {
            // application exit
            Application.Exit();
        }

        private void updateCulture(string lang)
        {
            // instantiate new culture info
            this.ci = new CultureInfo(lang);
            // update title string
            this.Text = rm.GetString("Title", ci);

            // update all controls
            foreach (Control Ctrl in this.Controls)
                Ctrl.Text = rm.GetString(Ctrl.Name, ci);

            // update gird column
            quantity.FieldName = rm.GetString("Quantity", ci);
            productID.FieldName = rm.GetString("ProductID", ci);
            productName.FieldName = rm.GetString("ProductName", ci);
            unitPrice.FieldName = rm.GetString("UnitPrice", ci);
            price.FieldName = rm.GetString("Price", ci);

            // activate arabic grid localizer : if you want to use custom localization
            //if(lang == "ar")
            //GridLocalizer.Active = new ArabicLocalization();

            // update layout direction
            this.RightToLeftLayout = lang == "en" ? false : true;
            this.RightToLeft = lang == "en" ? RightToLeft.No : RightToLeft.Yes;
        }
    }
}
 