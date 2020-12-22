using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ChildForm : Form
    {
        private readonly MenuStrip _menuStrip;

        public ChildForm()
        {
            InitializeComponent();

            _menuStrip = new MenuStrip();
            _menuStrip.Items.Add(new ToolStripMenuItem { Text = "Child" });
        }

        private frmMDI Parent => (frmMDI)MdiParent;

        private void btnOpenChild_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.MdiParent = MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void chkSetMenustrip_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSetMenustrip.Checked)
            {
                MainMenuStrip = _menuStrip;
            }
            else
            {
                MainMenuStrip = null;
            }
        }
        private void chkSetParentMenustrip_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSetParentMenustrip.Checked)
            {
                Parent.MainMenuStrip = Parent.MainMenu;
            }
            else
            {
                Parent.MainMenuStrip = null;
            }
        }


        private void chkAddMenustrip_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddMenustrip.Checked)
            {
                Controls.Add(_menuStrip);
            }
            else
            {
                Controls.Remove(_menuStrip);
            }
        }

        private void chkAddParentMenustrip_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddParentMenustrip.Checked)
            {
                Parent.Controls.Add(Parent.MainMenu);
            }
            else
            {
                Parent.Controls.Remove(Parent.MainMenu);
            }
        }
    }
}
