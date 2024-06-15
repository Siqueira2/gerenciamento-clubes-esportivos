using GerenciamentoClubesEsportivos.Controllers;
using GerenciamentoClubesEsportivos.Models.Entities;
using GerenciamentoClubesEsportivos.Models.Repositories;
using System;
using System.Windows.Forms;

namespace GerenciamentoClubesEsportivos
{
    public partial class Form1 : Form
    {
        private MemberController _controller;

        public Form1()
        {
            InitializeComponent();
            _controller = new MemberController(new MemberRepository());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            LoadData();
        }

        private void DismissButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void SaveButton_Click(Object sender, EventArgs e)
        {
            SaveMember();
            LoadData();
            Clear();
        }

        public void Clear()
        {
            InputName.Text = InputEmail.Text = InputCPF.Text = InputCEP.Text = InputPhone.Text = "";
        }

        private void LoadData()
        {
            dataGridView1.DataSource = _controller.GetAllMembers();
        }

        private void SaveMember()
        {
            string Name, Email, CPF, CEP, PhoneNumber;

            Name = InputName.Text;
            Email = InputEmail.Text;
            CPF = InputCPF.Text;
            CEP = InputCEP.Text;
            PhoneNumber = InputPhone.Text;
            DateTime membershipDate = DateTime.Now;

            _controller.AddMember(Name, Email, CPF, CEP, PhoneNumber, membershipDate);
        }
    }
}
