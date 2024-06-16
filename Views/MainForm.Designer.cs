namespace GerenciamentoClubesEsportivos
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelName = new Label();
            DismissButton = new Button();
            dataGridView1 = new DataGridView();
            InputName = new TextBox();
            LabelEmail = new Label();
            InputEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            InputPhone = new TextBox();
            InputCPF = new TextBox();
            label4 = new Label();
            InputCEP = new TextBox();
            InputSearch = new TextBox();
            SearchButton = new Button();
            DeleteButton = new Button();
            SaveButton = new Button();
            tabControl1 = new TabControl();
            Members = new TabPage();
            EditButton = new Button();
            Dependents = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            Members.SuspendLayout();
            SuspendLayout();
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(24, 88);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(50, 20);
            LabelName.TabIndex = 0;
            LabelName.Text = "Nome";
            // 
            // DismissButton
            // 
            DismissButton.Location = new Point(276, 403);
            DismissButton.Margin = new Padding(3, 4, 3, 4);
            DismissButton.Name = "DismissButton";
            DismissButton.Size = new Size(86, 31);
            DismissButton.TabIndex = 1;
            DismissButton.Text = "Cancelar";
            DismissButton.UseVisualStyleBackColor = true;
            DismissButton.Click += DismissButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(402, 83);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(704, 571);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // InputName
            // 
            InputName.Location = new Point(88, 83);
            InputName.Margin = new Padding(3, 4, 3, 4);
            InputName.Name = "InputName";
            InputName.PlaceholderText = "Emma Lazarus";
            InputName.Size = new Size(274, 27);
            InputName.TabIndex = 3;
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(28, 148);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(46, 20);
            LabelEmail.TabIndex = 0;
            LabelEmail.Text = "Email";
            // 
            // InputEmail
            // 
            InputEmail.Location = new Point(88, 143);
            InputEmail.Margin = new Padding(3, 4, 3, 4);
            InputEmail.Name = "InputEmail";
            InputEmail.PlaceholderText = "emma@mail.com";
            InputEmail.Size = new Size(274, 27);
            InputEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 205);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 0;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 265);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 0;
            label3.Text = "CPF";
            // 
            // InputPhone
            // 
            InputPhone.Location = new Point(88, 200);
            InputPhone.Margin = new Padding(3, 4, 3, 4);
            InputPhone.Name = "InputPhone";
            InputPhone.PlaceholderText = "(00) 12345-6789";
            InputPhone.Size = new Size(274, 27);
            InputPhone.TabIndex = 3;
            // 
            // InputCPF
            // 
            InputCPF.Location = new Point(88, 260);
            InputCPF.Margin = new Padding(3, 4, 3, 4);
            InputCPF.Name = "InputCPF";
            InputCPF.PlaceholderText = "000.000.000-00";
            InputCPF.Size = new Size(274, 27);
            InputCPF.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 328);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 0;
            label4.Text = "CEP";
            // 
            // InputCEP
            // 
            InputCEP.Location = new Point(88, 323);
            InputCEP.Margin = new Padding(3, 4, 3, 4);
            InputCEP.Name = "InputCEP";
            InputCEP.PlaceholderText = "11.222-333";
            InputCEP.Size = new Size(274, 27);
            InputCEP.TabIndex = 3;
            // 
            // InputSearch
            // 
            InputSearch.Location = new Point(402, 32);
            InputSearch.Margin = new Padding(3, 4, 3, 4);
            InputSearch.Name = "InputSearch";
            InputSearch.PlaceholderText = "John Doe";
            InputSearch.Size = new Size(311, 27);
            InputSearch.TabIndex = 5;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(721, 32);
            SearchButton.Margin = new Padding(3, 4, 3, 4);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(86, 31);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Buscar";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Enabled = false;
            DeleteButton.Location = new Point(276, 465);
            DeleteButton.Margin = new Padding(3, 4, 3, 4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(86, 31);
            DeleteButton.TabIndex = 1;
            DeleteButton.Text = "Deletar";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Visible = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(88, 403);
            SaveButton.Margin = new Padding(3, 4, 3, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(86, 31);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Adicionar";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Members);
            tabControl1.Controls.Add(Dependents);
            tabControl1.Location = new Point(-1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1139, 697);
            tabControl1.TabIndex = 6;
            // 
            // Members
            // 
            Members.BackColor = Color.Gainsboro;
            Members.Controls.Add(EditButton);
            Members.Controls.Add(InputName);
            Members.Controls.Add(dataGridView1);
            Members.Controls.Add(InputSearch);
            Members.Controls.Add(LabelName);
            Members.Controls.Add(SearchButton);
            Members.Controls.Add(InputCPF);
            Members.Controls.Add(DismissButton);
            Members.Controls.Add(InputEmail);
            Members.Controls.Add(DeleteButton);
            Members.Controls.Add(InputCEP);
            Members.Controls.Add(SaveButton);
            Members.Controls.Add(InputPhone);
            Members.Controls.Add(label2);
            Members.Controls.Add(LabelEmail);
            Members.Controls.Add(label3);
            Members.Controls.Add(label4);
            Members.Location = new Point(4, 29);
            Members.Name = "Members";
            Members.Padding = new Padding(3);
            Members.Size = new Size(1131, 664);
            Members.TabIndex = 0;
            Members.Text = "Sócios";
            Members.Click += DismissButton_Click;
            // 
            // EditButton
            // 
            EditButton.Enabled = false;
            EditButton.Location = new Point(88, 465);
            EditButton.Margin = new Padding(3, 4, 3, 4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(86, 31);
            EditButton.TabIndex = 6;
            EditButton.Text = "Editar";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Visible = false;
            EditButton.Click += EditButton_Click;
            // 
            // Dependents
            // 
            Dependents.Location = new Point(4, 29);
            Dependents.Name = "Dependents";
            Dependents.Padding = new Padding(3);
            Dependents.Size = new Size(1131, 664);
            Dependents.TabIndex = 1;
            Dependents.Text = "Dependentes";
            Dependents.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 697);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Nome";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            Members.ResumeLayout(false);
            Members.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LabelName;
        private Button DismissButton;
        private DataGridView dataGridView1;
        private TextBox InputName;
        private Label LabelEmail;
        private TextBox InputEmail;
        private Label label2;
        private Label label3;
        private TextBox InputPhone;
        private TextBox InputCPF;
        private Label label4;
        private TextBox InputCEP;
        private TextBox InputSearch;
        private Button SearchButton;
        private Button DeleteButton;
        private Button SaveButton;
        private TabControl tabControl1;
        private TabPage Members;
        private TabPage Dependents;
        private Button EditButton;
    }
}
