using GerenciamentoClubesEsportivos.Controllers;
using GerenciamentoClubesEsportivos.Models.Entities;
using GerenciamentoClubesEsportivos.Models.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GerenciamentoClubesEsportivos.Views
{
    public partial class DependentView : UserControl, INotifyPropertyChanged
    {
        private readonly DependentController controller;
        private BindingList<Dependent>? bindingDependents;
        private string? selectedDependentId;

        private string? name;
        private string? cpf;
        private string? kinship;
        private string? memberId;

        public string IName
        {
            get { return name!; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
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
        public string Kinship
        {
            get { return kinship!; }
            set
            {
                kinship = value;
                OnPropertyChanged("Kinship");
            }
        }
        public string MemberID
        {
            get { return memberId!; }
            set
            {
                memberId = value;
                OnPropertyChanged("MemberID");
            }
        }
        public DependentView(DependentController controller)
        {
            this.controller = controller;

            InitializeComponent();
            BindProperties();
            UpdateDataGridView(this.controller.GetAllDependents());
        }

        private void BindProperties()
        {
            InputName.DataBindings.Add("Text", this, "IName");
            InputCPF.DataBindings.Add("Text", this, "CPF");
            InputKinship.DataBindings.Add("Text", this, "Kinship");
            InputMemberID.DataBindings.Add("Text", this, "MemberID");
        }

        private void UpdateDataGridView(List<Dependent> dependents)
        {
            bindingDependents = new BindingList<Dependent>(dependents);
            Table.DataSource = bindingDependents.Select(dependent =>
                new { dependent.Id, dependent.Name, dependent.CPF, dependent.Kinship, dependent.MemberId }
            ).ToList();
            Table.Refresh();
        }
        private void DependentView_Load(object sender, EventArgs e)
        {
            UpdateDataGridView(controller.GetAllDependents());
            Table.RowHeadersVisible = false;
            Table.Columns["Id"].HeaderText = "ID";
            Table.Columns["Name"].HeaderText = "Nome";
            Table.Columns["CPF"].HeaderText = "CPF";
            Table.Columns["Kinship"].HeaderText = "Parentesco";
            Table.Columns["MemberID"].HeaderText = "ID do Membro";
        }

        //metodos de handle de eventos
        private void SaveButton_Click(Object sender, EventArgs e)
        {
            try
            {
                controller.AddDependent(IName, CPF, Kinship, MemberID);
                
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }

            UpdateDataGridView(controller.GetAllDependents());
            Clear();
        }
        private void DismissButton_Click(object sender, EventArgs e)
        {
            Clear();
            Table.ClearSelection();
            DisableUpdateOrDelete();
        }
        private void EditButton_Click(Object sender, EventArgs e)
        {
            try
            {
                Dependent dependent = controller.GetDependentByID(selectedDependentId!);
                controller.UpdateDependent(selectedDependentId!, IName, CPF, Kinship, dependent.MemberId);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
            
            UpdateDataGridView(controller.GetAllDependents());
            Clear();
            Table.ClearSelection();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Dependent dependent = controller.GetDependentByID(selectedDependentId!);
                controller.DeleteDependent(selectedDependentId!);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
            
            UpdateDataGridView(controller.GetAllDependents());
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string dependentName = InputSearch.Text;
            UpdateDataGridView(controller.SearchByName(dependentName));
        }
        private void HandleCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = Table.Rows[e.RowIndex];


            selectedDependentId = (row.Cells[0].Value.ToString()!).ToString();
            IName = row.Cells[1].Value?.ToString() ?? string.Empty;
            CPF = row.Cells[2].Value?.ToString() ?? string.Empty;
            Kinship = row.Cells[3].Value?.ToString() ?? string.Empty;
            MemberID = row.Cells[4].Value?.ToString() ?? string.Empty;

            EnableUpdateOrDelete();
        }

        //metodos adicionais/dependentes
        private void Clear()
        {
            selectedDependentId = IName = CPF = Kinship = MemberID = "";

            InputName.Text =
            InputKinship.Text =
            InputMemberID.Text =
            InputCPF.Text = "";
        }
        private void EnableUpdateOrDelete()
        {
            SaveButton.Enabled = false;
            DeleteButton.Visible = true;
            DeleteButton.Enabled = true;
            InputMemberID.Enabled = false;
            EditButton.Visible = true;
            EditButton.Enabled = true;
        }
        private void DisableUpdateOrDelete()
        {
            SaveButton.Enabled = true;
            DeleteButton.Visible = false;
            DeleteButton.Enabled = false;
            EditButton.Visible = false;
            InputMemberID.Enabled = true;
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
