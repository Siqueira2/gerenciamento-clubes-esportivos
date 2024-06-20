namespace GerenciamentoClubesEsportivos.Views
{
    partial class DependentView
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            EditButton = new Button();
            InputName = new TextBox();
            Table = new DataGridView();
            InputSearch = new TextBox();
            LabelName = new Label();
            SearchButton = new Button();
            DismissButton = new Button();
            InputCPF = new TextBox();
            DeleteButton = new Button();
            SaveButton = new Button();
            LabelEmail = new Label();
            InputKinship = new TextBox();
            label2 = new Label();
            InputMemberID = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)Table).BeginInit();
            SuspendLayout();
            // 
            // EditButton
            // 
            EditButton.Enabled = false;
            EditButton.Location = new Point(83, 340);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 23);
            EditButton.TabIndex = 40;
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
            InputName.TabIndex = 37;
            // 
            // Table
            // 
            Table.AllowUserToAddRows = false;
            Table.AllowUserToDeleteRows = false;
            Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Table.Location = new Point(358, 54);
            Table.Name = "Table";
            Table.ReadOnly = true;
            Table.RowHeadersWidth = 51;
            Table.Size = new Size(616, 428);
            Table.TabIndex = 33;
            Table.CellClick += HandleCellClick;
            // 
            // InputSearch
            // 
            InputSearch.Location = new Point(358, 16);
            InputSearch.Name = "InputSearch";
            InputSearch.PlaceholderText = "John Doe";
            InputSearch.Size = new Size(273, 23);
            InputSearch.TabIndex = 39;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(27, 58);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(40, 15);
            LabelName.TabIndex = 27;
            LabelName.Text = "Nome";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(635, 16);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 29;
            SearchButton.Text = "Buscar";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // DismissButton
            // 
            DismissButton.Location = new Point(248, 294);
            DismissButton.Name = "DismissButton";
            DismissButton.Size = new Size(75, 23);
            DismissButton.TabIndex = 30;
            DismissButton.Text = "Cancelar";
            DismissButton.UseVisualStyleBackColor = true;
            DismissButton.Click += DismissButton_Click;
            // 
            // InputCPF
            // 
            InputCPF.Location = new Point(83, 99);
            InputCPF.Name = "InputCPF";
            InputCPF.PlaceholderText = "000.000.000-00";
            InputCPF.Size = new Size(240, 23);
            InputCPF.TabIndex = 35;
            // 
            // DeleteButton
            // 
            DeleteButton.Enabled = false;
            DeleteButton.Location = new Point(248, 340);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 31;
            DeleteButton.Text = "Deletar";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Visible = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(83, 294);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 32;
            SaveButton.Text = "Adicionar";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(31, 103);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(28, 15);
            LabelEmail.TabIndex = 25;
            LabelEmail.Text = "CPF";
            // 
            // InputKinship
            // 
            InputKinship.Location = new Point(83, 187);
            InputKinship.Name = "InputKinship";
            InputKinship.PlaceholderText = "Pai";
            InputKinship.Size = new Size(240, 23);
            InputKinship.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 191);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 41;
            label2.Text = "Parentesco";
            // 
            // InputMemberID
            // 
            InputMemberID.Location = new Point(83, 142);
            InputMemberID.Name = "InputMemberID";
            InputMemberID.PlaceholderText = "0000";
            InputMemberID.Size = new Size(240, 23);
            InputMemberID.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 146);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 43;
            label3.Text = "ID Membro";
            // 
            // DependentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(InputMemberID);
            Controls.Add(label3);
            Controls.Add(InputKinship);
            Controls.Add(label2);
            Controls.Add(EditButton);
            Controls.Add(InputName);
            Controls.Add(Table);
            Controls.Add(InputSearch);
            Controls.Add(LabelName);
            Controls.Add(SearchButton);
            Controls.Add(DismissButton);
            Controls.Add(InputCPF);
            Controls.Add(DeleteButton);
            Controls.Add(SaveButton);
            Controls.Add(LabelEmail);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DependentView";
            Size = new Size(990, 498);
            Load += DependentView_Load;
            VisibleChanged += DependentView_Load;
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
        private Button DismissButton;
        private TextBox InputCPF;
        private Button DeleteButton;
        private Button SaveButton;
        private Label LabelEmail;
        private TextBox InputKinship;
        private Label label2;
        private TextBox InputMemberID;
        private Label label3;
    }
}
