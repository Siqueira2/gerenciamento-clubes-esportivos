namespace GerenciamentoClubesEsportivos.Views
{
    partial class MemberView
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            EditButton = new Button();
            InputName = new TextBox();
            Table = new DataGridView();
            InputSearch = new TextBox();
            LabelName = new Label();
            SearchButton = new Button();
            InputCPF = new TextBox();
            DismissButton = new Button();
            InputEmail = new TextBox();
            DeleteButton = new Button();
            InputCEP = new TextBox();
            SaveButton = new Button();
            InputPhone = new TextBox();
            label2 = new Label();
            LabelEmail = new Label();
            label3 = new Label();
            label4 = new Label();
            ImportButton = new Button();
            ExportButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Table).BeginInit();
            SuspendLayout();
            // 
            // EditButton
            // 
            EditButton.Enabled = false;
            EditButton.Location = new Point(83, 340);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 23);
            EditButton.TabIndex = 7;
            EditButton.Text = "Editar";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Visible = false;
            EditButton.Click += EditButton_Click;
            // 
            // InputName
            // 
            InputName.Location = new Point(83, 54);
            InputName.Name = "InputName";
            InputName.PlaceholderText = "Emma Lazarus";
            InputName.Size = new Size(240, 23);
            InputName.TabIndex = 0;
            // 
            // Table
            // 
            Table.AllowUserToAddRows = false;
            Table.AllowUserToDeleteRows = false;
            Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Table.Location = new Point(358, 54);
            Table.MultiSelect = false;
            Table.Name = "Table";
            Table.ReadOnly = true;
            Table.RowHeadersWidth = 51;
            Table.Size = new Size(616, 428);
            Table.TabIndex = 16;
            Table.CellClick += HandleCellClick;
            // 
            // InputSearch
            // 
            InputSearch.Location = new Point(358, 16);
            InputSearch.Name = "InputSearch";
            InputSearch.PlaceholderText = "John Doe";
            InputSearch.Size = new Size(273, 23);
            InputSearch.TabIndex = 9;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(27, 58);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(40, 15);
            LabelName.TabIndex = 10;
            LabelName.Text = "Nome";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(635, 16);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 10;
            SearchButton.Text = "Buscar";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // InputCPF
            // 
            InputCPF.Location = new Point(83, 187);
            InputCPF.Name = "InputCPF";
            InputCPF.PlaceholderText = "000.000.000-00";
            InputCPF.Size = new Size(240, 23);
            InputCPF.TabIndex = 3;
            // 
            // DismissButton
            // 
            DismissButton.Location = new Point(248, 294);
            DismissButton.Name = "DismissButton";
            DismissButton.Size = new Size(75, 23);
            DismissButton.TabIndex = 6;
            DismissButton.Text = "Cancelar";
            DismissButton.UseVisualStyleBackColor = true;
            DismissButton.Click += DismissButton_Click;
            // 
            // InputEmail
            // 
            InputEmail.Location = new Point(83, 99);
            InputEmail.Name = "InputEmail";
            InputEmail.PlaceholderText = "emma@mail.com";
            InputEmail.Size = new Size(240, 23);
            InputEmail.TabIndex = 1;
            // 
            // DeleteButton
            // 
            DeleteButton.Enabled = false;
            DeleteButton.Location = new Point(248, 340);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 8;
            DeleteButton.Text = "Deletar";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Visible = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // InputCEP
            // 
            InputCEP.Location = new Point(83, 234);
            InputCEP.Name = "InputCEP";
            InputCEP.PlaceholderText = "11.222-333";
            InputCEP.Size = new Size(240, 23);
            InputCEP.TabIndex = 4;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(83, 294);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 5;
            SaveButton.Text = "Adicionar";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // InputPhone
            // 
            InputPhone.Location = new Point(83, 142);
            InputPhone.Name = "InputPhone";
            InputPhone.PlaceholderText = "(00) 12345-6789";
            InputPhone.Size = new Size(240, 23);
            InputPhone.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 146);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Telefone";
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(31, 103);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(36, 15);
            LabelEmail.TabIndex = 8;
            LabelEmail.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 190);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 11;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 238);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 7;
            label4.Text = "CEP";
            // 
            // ImportButton
            // 
            ImportButton.Location = new Point(899, 16);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(75, 23);
            ImportButton.TabIndex = 15;
            ImportButton.Text = "Importar";
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += ImportButton_Click;
            // 
            // ExportButton
            // 
            ExportButton.Location = new Point(818, 16);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(75, 23);
            ExportButton.TabIndex = 16;
            ExportButton.Text = "Exportar";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // MemberView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EditButton);
            Controls.Add(InputName);
            Controls.Add(Table);
            Controls.Add(InputSearch);
            Controls.Add(LabelName);
            Controls.Add(SearchButton);
            Controls.Add(InputCPF);
            Controls.Add(DismissButton);
            Controls.Add(InputEmail);
            Controls.Add(DeleteButton);
            Controls.Add(InputCEP);
            Controls.Add(ExportButton);
            Controls.Add(ImportButton);
            Controls.Add(SaveButton);
            Controls.Add(InputPhone);
            Controls.Add(label2);
            Controls.Add(LabelEmail);
            Controls.Add(label3);
            Controls.Add(label4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MemberView";
            Size = new Size(990, 498);
            Load += MemberView_Load;
            Click += DismissButton_Click;
            ((System.ComponentModel.ISupportInitialize)Table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditButton;
        private TextBox InputName;
        private DataGridView Table;
        private TextBox InputSearch;
        private Label LabelName;
        private Button SearchButton;
        private TextBox InputCPF;
        private Button DismissButton;
        private TextBox InputEmail;
        private Button DeleteButton;
        private TextBox InputCEP;
        private Button SaveButton;
        private TextBox InputPhone;
        private Label label2;
        private Label LabelEmail;
        private Label label3;
        private Label label4;
        private Button ImportButton;
        private Button ExportButton;
    }
}
