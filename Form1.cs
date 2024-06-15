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
        private int _selectedMemberId;

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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int cell_index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(cell_index);
                _controller.DeleteMember(_selectedMemberId);
                LoadData();
                Clear();
                LogMessage("Membro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                LogMessage(ex.Message);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveMember();
            LoadData();
            Clear();
        }

        public void Clear()
        {
            InputName.Text = InputEmail.Text = InputCPF.Text = InputCEP.Text = InputPhone.Text = "";
            DeleteButton.Enabled = false;
        }

        private void LoadData()
        {
            var members = _controller.GetAllMembers();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = members;

            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Name"].HeaderText = "Nome";
            dataGridView1.Columns["Email"].HeaderText = "Email";
            dataGridView1.Columns["CPF"].HeaderText = "CPF";
            dataGridView1.Columns["CEP"].HeaderText = "CEP";
            dataGridView1.Columns["PhoneNumber"].HeaderText = "Telefone";
            dataGridView1.Columns["MembershipDate"].HeaderText = "Data de Associação";
        }

        private void SaveMember()
        {
            try
            {
                string name = InputName.Text;
                string email = InputEmail.Text;
                string cpf = InputCPF.Text;
                string cep = InputCEP.Text;
                string phoneNumber = InputPhone.Text;
                DateTime membershipDate = DateTime.Now;

                _controller.AddMember(name, email, cpf, cep, phoneNumber, membershipDate);

                LogMessage("Sócio cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                LogMessage(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0 && dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["Id"].Value != null)
                {
                    _selectedMemberId = (int)row.Cells["Id"].Value;
                    DeleteButton.Enabled = true;
                }
            }
        }

        private void LogMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}

