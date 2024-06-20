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
    public partial class DependentView : UserControl
    {
        private readonly DependentController controller;
        private BindingList<Dependent>? bindingDependents;
        private string selectedDependentId;

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
                new { dependent.Id, dependent.Name, dependent.kinship }
            ).ToList();
            Table.Refresh();
        }

        //metodos de handle de eventos
        private void SaveButton_Click(Object sender, EventArgs e)
        {
            controller.AddDependent(IName, CPF, Kinship, MemberID);
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
            DependentController controllerx = new DependentController(new DependentRepository());

            MessageBox.Show("xx5");
            foreach (var item in controllerx.GetAllDependents())
            {
                MessageBox.Show(item.Name + item.Id);
            }
            Dependent dependent = controller.GetDependentByID(selectedDependentId);

            controller.UpdateDependent(selectedDependentId, IName, CPF, Kinship, dependent.memberId);
            UpdateDataGridView(controller.GetAllDependents());
            Clear();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Dependent dependent = controller.GetDependentByID(selectedDependentId);
            controller.DeleteDependent(selectedDependentId);
            UpdateDataGridView(controller.GetAllDependents());
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string dependentName = InputSearch.Text;
            UpdateDataGridView(controller.SearchByName(dependentName));
        }

        //metodos adicionais/dependentes
        private void Clear()
        {
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

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
