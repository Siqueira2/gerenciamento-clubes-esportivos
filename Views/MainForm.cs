using GerenciamentoClubesEsportivos.Controllers;
using GerenciamentoClubesEsportivos.Models.Entities;
using GerenciamentoClubesEsportivos.Models.Repositories;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GerenciamentoClubesEsportivos
{
    public partial class MainForm : Form
    {
        private readonly MemberController controller;

        private BindingList<Member>? bindingMembers;

        private int selectedMemberId;


        //metodos de inicialização/atualização
        public MainForm(MemberController controller)
        {
            InitializeComponent();
            this.controller = controller;


            UpdateDataGridView(controller.GetAllMembers());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            UpdateDataGridView(controller.GetAllMembers());
        }
        private void UpdateDataGridView(List<Member> members)
        {
            bindingMembers = new BindingList<Member>(members);
            dataGridView1.DataSource = bindingMembers.Select(member =>
                new { member.Id, member.Name, member.Email, member.CPF, member.CEP, member.PhoneNumber, member.MembershipDate }
            ).ToList();
            dataGridView1.Refresh();
        }


        //metodos de handle de eventos
        private void DismissButton_Click(object sender, EventArgs e)
        {
            Clear();
            dataGridView1.ClearSelection();
            DisableUpdateOrDelete();
        }
        private void SaveButton_Click(Object sender, EventArgs e)
        {
            SaveMember();
            UpdateDataGridView(controller.GetAllMembers());
            Clear();
        }
        private void EditButton_Click(Object sender, EventArgs e)
        {
            string name = InputName.Text;
            string email = InputEmail.Text;
            string cpf = InputCPF.Text;
            string cep = InputCEP.Text;
            string phoneNumber = InputPhone.Text;

            Member member = controller.GetMemberByID(selectedMemberId);

            controller.UpdateMember(selectedMemberId, name, cpf, email, phoneNumber, cep, member.MembershipDate);
            UpdateDataGridView(controller.GetAllMembers());
            Clear();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleCellClick(e);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleCellClick(e);
        }


        //metodos adicionais/dependentes
        public void Clear()
        {
            InputName.Text = InputEmail.Text = InputCPF.Text = InputCEP.Text = InputPhone.Text = "";
        }
        private void SaveMember()
        {
            string name = InputName.Text;
            string email = InputEmail.Text;
            string cpf = InputCPF.Text;
            string cep = InputCEP.Text;
            string phoneNumber = InputPhone.Text;
            DateTime membershipDate = DateTime.Now;

            controller.AddMember(name, email, cpf, cep, phoneNumber, membershipDate);
        }
        private void HandleCellClick(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            selectedMemberId = int.Parse(row.Cells[0].Value.ToString()!);
            InputName.Text = row.Cells[1].Value.ToString();
            InputEmail.Text = row.Cells[2].Value.ToString();
            InputCPF.Text = row.Cells[3].Value.ToString();
            InputCEP.Text = row.Cells[4].Value.ToString();
            InputPhone.Text = row.Cells[5].Value.ToString();

            dataGridView1.ClearSelection();

            EnableUpdateOrDelete();
        }
        private void EnableUpdateOrDelete()
        {
            SaveButton.Enabled = false;
            DeleteButton.Visible = true;
            DeleteButton.Enabled = true;
            EditButton.Visible = true;
            EditButton.Enabled = true;
        }
        private void DisableUpdateOrDelete()
        {
            SaveButton.Enabled = true;
            DeleteButton.Visible = false;
            DeleteButton.Enabled = false;
            EditButton.Visible = false;
            EditButton.Enabled = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Member member = controller.GetMemberByID(selectedMemberId);
            controller.DeleteMember(selectedMemberId);
            UpdateDataGridView(controller.GetAllMembers());
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string memberName = InputSearch.Text;
            UpdateDataGridView(controller.SearchByName(memberName));
        }
    }
}
