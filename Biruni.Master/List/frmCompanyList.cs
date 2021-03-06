using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biruni.Reports;
using Biruni.Shared;
using Biruni.Shared.Logging;
using Biruni.Master.Entry;

namespace Biruni.Master.List
{
    public partial class frmCompanyList : Biruni.Shared.Templates.frmList
    {
        CompanyTypes type;

        public frmCompanyList(CompanyTypes type)
        {
            InitializeComponent();
            InitializeForm(type);
            InitializeData(type);
        }

        private void InitializeData(CompanyTypes type)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                dsCore1.EnforceConstraints = false;
                daCompanies1.Connection = AppHelper.GetDbConnection();
                daCompanies1.ClearBeforeFill = true;
                if (type == CompanyTypes.Customer)
                    daCompanies1.FillCustomer(dsCore1.Companies);
                else
                    daCompanies1.FillVendor(dsCore1.Companies);
            }
            catch (Exception ex)
            {
                Logger.ErrorRoutine(ex);
                RibbonMessageBox.Show("ERROR Loading Data!\n" + ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void InitializeForm(CompanyTypes type)
        {
            this.type = type;
            if (type == CompanyTypes.Customer)
            {
                this.Text = "Customer List";
                this._grid.Caption = "Customer List";
            }
            else
            {
                this.Text = "Vendor List";
                this._grid.Caption = "Vendor List";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            Form fx = new frmCompanyEntry(type);
            fx.ShowDialog();
            btnRefresh.PerformClick();
            Cursor = Cursors.Default;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            try
            {
                Form fx = new frmCompanyEntry(type, (int)_grid.Columns["id"].Value);
                fx.ShowDialog();
                btnRefresh.PerformClick();
            }
            catch
            {
                RibbonMessageBox.Show("No data selected for editing\n",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Cursor = Cursors.Default;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            DialogResult dr;
            try
            {
                string deleted = "[" + this._grid.Columns["code"].Text + "] " + this._grid.Columns["name"].Text;
                try
                {
                    dr = RibbonMessageBox.Show("Do you really want to delete data " + deleted,
                        Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        this.BindingContext[this.dsCore1, "Companies"].RemoveAt(this.BindingContext[this.dsCore1, "Companies"].Position);
                        this.daCompanies1.Update(this.dsCore1.Companies);
                        this.dsCore1.AcceptChanges();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                        RibbonMessageBox.Show("Data " + deleted + " can't be deleted because it's already used as reference",
                            Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                        RibbonMessageBox.Show("Error deleting data\nDetails: " + ex.Message,
                            Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dsCore1.RejectChanges();
                    btnRefresh.PerformClick();
                }
                catch (System.Exception ex)
                {
                    RibbonMessageBox.Show("Error deleting data\n" + ex.Message,
                        Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dsCore1.RejectChanges();
                    btnRefresh.PerformClick();
                }
            }
            catch
            {
                RibbonMessageBox.Show("No data selected for deletion\n",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Cursor = Cursors.Default;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            int pos = _grid.Bookmark;
            if (type == CompanyTypes.Customer)
                daCompanies1.FillCustomer(dsCore1.Companies);
            else
                daCompanies1.FillVendor(dsCore1.Companies);
            _grid.Bookmark = pos;
            Cursor = Cursors.Default;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            Form fx;
            if (type == CompanyTypes.Customer)
                fx = new frmReportViewer1(ReportHelper1.LoadCustomerList());
            else
                fx = new frmReportViewer1(ReportHelper1.LoadVendorList());
            fx.WindowState = FormWindowState.Maximized;
            fx.ShowDialog();
            Cursor = Cursors.Default;
            /*
              * old print using c1report
              * **************************
            Cursor = Cursors.AppStarting;

            // hide unecessary column
            this._grid.Caption = "";

            // page setting
            C1.Win.C1TrueDBGrid.Style headerstyle = new C1.Win.C1TrueDBGrid.Style();
            headerstyle.Font = new Font("Tahome", 18, FontStyle.Bold);
            headerstyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center;
            this._grid.PrintInfo.PageHeader = this.Text;
            this._grid.PrintInfo.PageHeaderStyle = headerstyle;
            this._grid.PrintInfo.PageHeaderHeight = 50;
            this._grid.PrintInfo.PageSettings.Landscape = true;
            this._grid.PrintInfo.PageSettings.Margins.Top = 30;
            this._grid.PrintInfo.PageSettings.Margins.Left = 30;
            this._grid.PrintInfo.PageSettings.Margins.Bottom = 30;
            this._grid.PrintInfo.PageSettings.Margins.Right = 30;
            this._grid.PreviewInfo.Size = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

            // Column headers will be on every page.
            this._grid.PrintInfo.RepeatColumnHeaders = true;

            // Display page numbers (centered).
            this._grid.PrintInfo.PageFooter = @"Page: \p\t";
            this._grid.PrintInfo.PageFooter += Reports.ReportHelper1.GenerateFooter();

            // Invoke print preview.
            this._grid.PrintInfo.UseGridColors = false;
            this._grid.PrintInfo.PrintPreview();

            // unhide unecessary column
            this._grid.Caption = this.Text;

            Cursor = Cursors.Default;
             * */
        }
    }
}

