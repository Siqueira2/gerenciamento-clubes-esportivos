using GerenciamentoClubesEsportivos.Controllers;
using GerenciamentoClubesEsportivos.Models.Repositories;
using GerenciamentoClubesEsportivos.Views;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GerenciamentoClubesEsportivos
{
    public partial class MainForm : Form
    {
        private MemberView? memberView;
        private DependentView? dependentView;
        public MainForm()
        {
            InitializeComponent();
            memberView = new MemberView(new MemberController(new MemberRepository()));
            dependentView = new DependentView(new DependentController(new DependentRepository()));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AddUserControl(memberView!);
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            tabControl1.SelectedTab!.Controls.Add(userControl);
        }

        private void Members_Click(object sender, EventArgs e)
        {
            AddUserControl(memberView!);
        }

        private void Dependents_Click(object sender, EventArgs e)
        {
            AddUserControl(dependentView!);
        }
    }
}
