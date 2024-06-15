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
            var members = _controller.GetAllMembers();
            dataGridView1.DataSource = null; // Limpa o DataGridView primeiro
            dataGridView1.DataSource = members;
        }

        private void SaveMember()
        {
            string name = InputName.Text;
            string email = InputEmail.Text;
            string cpf = InputCPF.Text;
            string cep = InputCEP.Text;
            string phoneNumber = InputPhone.Text;
            DateTime membershipDate = DateTime.Now;

            _controller.AddMember(name, email, cpf, cep, phoneNumber, membershipDate);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implemente este método se necessário
        }
    }
}
