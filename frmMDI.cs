using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMDI : Form
    {
        private readonly MenuStrip _menuStrip;

        public frmMDI()
        {
            InitializeComponent();

            Text = RuntimeInformation.FrameworkDescription;

            _menuStrip = new MenuStrip();
            _menuStrip.Items.Add(new ToolStripMenuItem { Text = "Parent" });
        }

        public MenuStrip MainMenu => _menuStrip;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ChildForm frm = new ChildForm();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
