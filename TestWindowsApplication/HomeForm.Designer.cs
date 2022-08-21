
namespace TestWindowsApplication
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.closeSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.logoutSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.productGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.productID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeSimpleButton
            // 
            this.closeSimpleButton.Appearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.closeSimpleButton.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.closeSimpleButton.Appearance.Options.UseBorderColor = true;
            this.closeSimpleButton.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this.closeSimpleButton, "closeSimpleButton");
            this.closeSimpleButton.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.closeSimpleButton.Name = "closeSimpleButton";
            this.closeSimpleButton.Click += new System.EventHandler(this.closeSimpleButton_Click);
            // 
            // logoutSimpleButton
            // 
            this.logoutSimpleButton.Appearance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.logoutSimpleButton.Appearance.BackColor2 = ((System.Drawing.Color)(resources.GetObject("logoutSimpleButton.Appearance.BackColor2")));
            this.logoutSimpleButton.Appearance.BorderColor = System.Drawing.Color.White;
            this.logoutSimpleButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.logoutSimpleButton.Appearance.Options.UseBackColor = true;
            this.logoutSimpleButton.Appearance.Options.UseBorderColor = true;
            this.logoutSimpleButton.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this.logoutSimpleButton, "logoutSimpleButton");
            this.logoutSimpleButton.Name = "logoutSimpleButton";
            this.logoutSimpleButton.Click += new System.EventHandler(this.logoutSimpleButton_Click);
            // 
            // productGridControl
            // 
            resources.ApplyResources(this.productGridControl, "productGridControl");
            this.productGridControl.MainView = this.gridView1;
            this.productGridControl.Name = "productGridControl";
            this.productGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.productID,
            this.productName,
            this.price,
            this.unitPrice,
            this.quantity});
            this.gridView1.GridControl = this.productGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // productID
            // 
            this.productID.FieldName = "Product ID";
            this.productID.MinWidth = 50;
            this.productID.Name = "productID";
            resources.ApplyResources(this.productID, "productID");
            // 
            // productName
            // 
            this.productName.FieldName = "Product Name";
            this.productName.MinWidth = 50;
            this.productName.Name = "productName";
            resources.ApplyResources(this.productName, "productName");
            // 
            // price
            // 
            this.price.FieldName = "Price";
            this.price.MinWidth = 50;
            this.price.Name = "price";
            resources.ApplyResources(this.price, "price");
            // 
            // unitPrice
            // 
            this.unitPrice.FieldName = "Unit Product";
            this.unitPrice.MinWidth = 50;
            this.unitPrice.Name = "unitPrice";
            resources.ApplyResources(this.unitPrice, "unitPrice");
            // 
            // quantity
            // 
            this.quantity.FieldName = "Quantity";
            this.quantity.MinWidth = 50;
            this.quantity.Name = "quantity";
            resources.ApplyResources(this.quantity, "quantity");
            // 
            // HomeForm
            // 
            this.ActiveGlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productGridControl);
            this.Controls.Add(this.logoutSimpleButton);
            this.Controls.Add(this.closeSimpleButton);
            this.IconOptions.Image = global::TestWindowsApplication.Properties.Resources.settings;
            this.Name = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton closeSimpleButton;
        private DevExpress.XtraEditors.SimpleButton logoutSimpleButton;
        private DevExpress.XtraGrid.GridControl productGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn productID;
        private DevExpress.XtraGrid.Columns.GridColumn productName;
        private DevExpress.XtraGrid.Columns.GridColumn price;
        private DevExpress.XtraGrid.Columns.GridColumn unitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn quantity;
    }
}