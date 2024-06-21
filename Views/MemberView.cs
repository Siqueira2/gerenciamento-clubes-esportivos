using GerenciamentoClubesEsportivos.Controllers;
using GerenciamentoClubesEsportivos.Models.Entities;
using GerenciamentoClubesEsportivos.Models.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoClubesEsportivos.Views
{
    public partial class MemberView : UserControl, INotifyPropertyChanged
    {
        private readonly MemberController controller;
        private BindingList<Member>? bindingMembers;
        private string? selectedMemberId;

        private string? name;
        private string? email;
        private string? cpf;
        private string? cep;
        private string? phoneNumber;

        public string IName
        {
            get { return name!; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Email
        {
            get { return email!; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }
        public string CPF
        {
            get { return cpf!; }
            set
            {
                cpf = value;
                OnPropertyChanged("CPF");
            }
        }
        public string CEP
        {
            get { return cep!; }
            set
            {
                cep = value;
                OnPropertyChanged("CEP");
            }
        }
        public string PhoneNumber
        {
            get { return phoneNumber!; }
            set
            {
                phoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }

        public MemberView(MemberController controller)
        {
            this.controller = controller;

            InitializeComponent();
            BindProperties();
            UpdateDataGridView(this.controller.GetAllMembers());
        }
        private void BindProperties()
        {
            InputName.DataBindings.Add("Text", this, "IName");
            InputEmail.DataBindings.Add("Text", this, "Email");
            InputCPF.DataBindings.Add("Text", this, "CPF");
            InputCEP.DataBindings.Add("Text", this, "CEP");
            InputPhone.DataBindings.Add("Text", this, "PhoneNumber");
        }
        private void UpdateDataGridView(List<Member> members)
        {
            bindingMembers = new BindingList<Member>(members);
            Table.DataSource = bindingMembers.Select(member =>
                new { member.Id, member.Name, member.Email, member.CPF, member.CEP, member.PhoneNumber, member.MembershipDate }
            ).ToList();
            Table.Refresh();
        }
        private void MemberView_Load(object sender, EventArgs e)
        {
            Table.RowHeadersVisible = false;
            Table.Columns["Id"].HeaderText = "ID";
            Table.Columns["Name"].HeaderText = "Nome";
            Table.Columns["Email"].HeaderText = "E-mail";
            Table.Columns["CPF"].HeaderText = "CPF";
            Table.Columns["CEP"].HeaderText = "CEP";
            Table.Columns["PhoneNumber"].HeaderText = "Telefone";
            Table.Columns["MembershipDate"].HeaderText = "Data de Associação";
        }

        //metodos de handle de eventos
        private void SaveButton_Click(Object sender, EventArgs e)
        {
            try
            {
                controller.AddMember(IName, CPF, Email, PhoneNumber, CEP, DateTime.Now);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }

            UpdateDataGridView(controller.GetAllMembers());
            Clear();
        }
        private void EditButton_Click(Object sender, EventArgs e)
        {
            try
            {
                Member member = controller.GetMemberByID(selectedMemberId!);
                controller.UpdateMember(selectedMemberId!, IName, CPF, Email, PhoneNumber, CEP, member.MembershipDate);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }

            UpdateDataGridView(controller.GetAllMembers());
            Clear();
            Table.ClearSelection();
        }
        private void DismissButton_Click(object sender, EventArgs e)
        {
            Clear();
            Table.ClearSelection();
            DisableUpdateOrDelete();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Member member = controller.GetMemberByID(selectedMemberId!);
                controller.DeleteMember(selectedMemberId!);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
            
            UpdateDataGridView(controller.GetAllMembers());
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string memberName = InputSearch.Text;
            UpdateDataGridView(controller.SearchByName(memberName));
        }
        private void HandleCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = Table.Rows[e.RowIndex];

            selectedMemberId = (row.Cells[0].Value.ToString()!).ToString();
            IName = row.Cells[1].Value?.ToString() ?? string.Empty;
            Email = row.Cells[2].Value?.ToString() ?? string.Empty;
            CPF = row.Cells[3].Value?.ToString() ?? string.Empty;
            CEP = row.Cells[4].Value?.ToString() ?? string.Empty;
            PhoneNumber = row.Cells[5].Value?.ToString() ?? string.Empty;

            Table.ClearSelection();

            EnableUpdateOrDelete();
        }
        private void ImportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Arquivos XML (*.xml)|*.xml|Todos os arquivos (*.*)|*.*";
            openFileDialog1.Title = "Selecionar Arquivo XML";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string caminhoArquivo = openFileDialog1.FileName;
                    controller.ImportFromXmlFile(caminhoArquivo);
                    UpdateDataGridView(controller.GetAllMembers());
                }
                catch (Exception ex)
                {
                    ShowErrorMessage($"Ocorreu um erro ao importar o XML: {ex.Message}");
                }
            }
        }
        private void ExportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Arquivos XML (*.xml)|*.xml|Todos os arquivos (*.*)|*.*";
            saveFileDialog1.Title = "Salvar como XML";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string FileName = saveFileDialog1.FileName;
                    controller.ExportAsXmlFile(FileName);
                }
                catch (Exception ex)
                {
                    ShowErrorMessage($"Ocorreu um erro ao exportar para XML: {ex.Message}");
                }
            }
        }

        //metodos adicionais/dependentes
        private void Clear()
        {
            selectedMemberId = 
            IName = CEP = CPF = 
            Email = PhoneNumber = "";

            InputName.Text =
            InputEmail.Text =
            InputCPF.Text =
            InputCEP.Text =
            InputPhone.Text = "";
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
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
