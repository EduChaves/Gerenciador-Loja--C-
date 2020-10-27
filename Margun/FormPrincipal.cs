using Margun.Controller;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Margun
{
    public partial class FormPrincipal : Form
    {
        int posicaoX, posicaoY;
        int auxHeigth, auxWidth;
        
        EstoqueController ctrll = new EstoqueController();

        /*[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRigthRect, int nBottomRect,
                                                        int WidthEllipse, int nHeightEllipse);*/

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FormPrincipal()
        {
            InitializeComponent();            
        }
        #region Funcionalidades do Formulario
        
        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            posicaoX = this.Location.X;
            posicaoY = this.Location.Y;

            auxHeigth = this.Size.Height;
            auxWidth = this.Size.Width;

            btnMaxMin.Visible = false;
            btnMinMax.Visible = true;


            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void panelBarraSup_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();

            Button btn = sender as Button;
            FormEstoque frm1= new FormEstoque();

            panelForms.Controls.Add(null);
                
            frm1.TopLevel = false;
            panelForms.Controls.Add(frm1);
            frm1.FormBorderStyle = FormBorderStyle.None;
            frm1.Show();                
                
        }
        private void btnCaixa_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();

            panelForms.Controls.Add(null);
            FormCaixa frm = new FormCaixa();
            frm.TopLevel = false;
            panelForms.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }
        private void btnTroca_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();

            panelForms.Controls.Add(null);
            FormTroca frm = new FormTroca();
            frm.TopLevel = false;
            panelForms.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }
        private void btnMinMax_Click(object sender, EventArgs e)
        {
            btnMaxMin.Visible = true;
            btnMinMax.Visible = false;

            this.Size = new Size(auxHeigth, auxWidth);
            this.Location = new Point(posicaoX, posicaoY);
        }
        #endregion
    }
}
