using System.Security.Cryptography;

namespace EmployeeManagementSystem
{
    public partial class FrmMotherForm : Form
    {
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public FrmMotherForm()
        {
            InitializeComponent();
        }

        private void FrmMotherForm_Load(object sender, EventArgs e)
        {
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            lblFullName.Text = frmLoginForm.fullName;
            lblSection.Text = frmLoginForm.section;
            lblAge.Text = frmLoginForm.age;

        }

        private void pnlSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CenterLabelInPanel()
        {
            int totalHeight = lblEms.Height + lblSub.Height;

            int centerX = (pnlStage.Width - Math.Max(lblEms.Width, lblSub.Width)) / 2;
            int startY = (pnlStage.Height - totalHeight) / 2;

            lblEms.Left = centerX;
            lblEms.Top = startY;

            lblSub.Left = (pnlStage.Width - lblSub.Width) / 2;
            lblSub.Top = lblEms.Bottom + 10;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }



        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Common.ReleaseCapture();
                Common.SendMessage(Handle, Common.WM_NCLBUTTONDOWN, Common.HT_CAPTION, 0);
            }
        }


        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlStage.Controls.Add(childForm);
            pnlStage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnMasterData_Click(object sender, EventArgs e)
        {
            clearAllDetails();
            OpenChildForm(new frmMasterData());
        }

        private void pnlStage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            clearAllDetails();
            OpenChildForm(new frmAddEmployee());
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void clearAllDetails()
        {
            frmMasterData.selectedTransaction = "";
            frmMasterData.EmployeeNumber = "";
            frmMasterData.RequestorName = "";
            frmMasterData.Section = "";
            frmMasterData.LocalNumber = "";
            frmMasterData.EmailAddress = "";

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSettings());
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
