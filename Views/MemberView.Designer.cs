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
            ((System.ComponentModel.ISupportInitialize)Table).BeginInit();
            SuspendLayout();
            // 
            // EditButton
            // 
            EditButton.Enabled = false;
            EditButton.Location = new Point(95, 454);
            EditButton.Margin = new Padding(3, 4, 3, 4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(86, 31);
            EditButton.TabIndex = 23;
            EditButton.Text = "Editar";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Visible = false;
            EditButton.Click += EditButton_Click;
            // 
            // InputName
            // 
            InputName.Location = new Point(95, 72);
            InputName.Margin = new Padding(3, 4, 3, 4);
            InputName.Name = "InputName";
            InputName.PlaceholderText = "Emma Lazarus";
            InputName.Size = new Size(274, 27);
            InputName.TabIndex = 20;
            // 
            // Table
            // 
            Table.AllowUserToAddRows = false;
            Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Table.Location = new Point(409, 72);
            Table.Margin = new Padding(3, 4, 3, 4);
            Table.Name = "Table";
            Table.RowHeadersWidth = 51;
            Table.Size = new Size(704, 571);
            Table.TabIndex = 16;
            Table.CellClick += HandleCellClick;
            Table.CellContentClick += HandleCellClick;
            // 
            // InputSearch
            // 
            InputSearch.Location = new Point(409, 21);
            InputSearch.Margin = new Padding(3, 4, 3, 4);
            InputSearch.Name = "InputSearch";
            InputSearch.PlaceholderText = "John Doe";
            InputSearch.Size = new Size(311, 27);
            InputSearch.TabIndex = 22;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(31, 77);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(50, 20);
            LabelName.TabIndex = 10;
            LabelName.Text = "Nome";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(726, 21);
            SearchButton.Margin = new Padding(3, 4, 3, 4);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(86, 31);
            SearchButton.TabIndex = 12;
            SearchButton.Text = "Buscar";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // InputCPF
            // 
            InputCPF.Location = new Point(95, 249);
            InputCPF.Margin = new Padding(3, 4, 3, 4);
            InputCPF.Name = "InputCPF";
            InputCPF.PlaceholderText = "000.000.000-00";
            InputCPF.Size = new Size(274, 27);
            InputCPF.TabIndex = 19;
            // 
            // DismissButton
            // 
            DismissButton.Location = new Point(283, 392);
            DismissButton.Margin = new Padding(3, 4, 3, 4);
            DismissButton.Name = "DismissButton";
            DismissButton.Size = new Size(86, 31);
            DismissButton.TabIndex = 13;
            DismissButton.Text = "Cancelar";
            DismissButton.UseVisualStyleBackColor = true;
            DismissButton.Click += DismissButton_Click;
            // 
            // InputEmail
            // 
            InputEmail.Location = new Point(95, 132);
            InputEmail.Margin = new Padding(3, 4, 3, 4);
            InputEmail.Name = "InputEmail";
            InputEmail.PlaceholderText = "emma@mail.com";
            InputEmail.Size = new Size(274, 27);
            InputEmail.TabIndex = 18;
            // 
            // DeleteButton
            // 
            DeleteButton.Enabled = false;
            DeleteButton.Location = new Point(283, 454);
            DeleteButton.Margin = new Padding(3, 4, 3, 4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(86, 31);
            DeleteButton.TabIndex = 14;
            DeleteButton.Text = "Deletar";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Visible = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // InputCEP
            // 
            InputCEP.Location = new Point(95, 312);
            InputCEP.Margin = new Padding(3, 4, 3, 4);
            InputCEP.Name = "InputCEP";
            InputCEP.PlaceholderText = "11.222-333";
            InputCEP.Size = new Size(274, 27);
            InputCEP.TabIndex = 21;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(95, 392);
            SaveButton.Margin = new Padding(3, 4, 3, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(86, 31);
            SaveButton.TabIndex = 15;
            SaveButton.Text = "Adicionar";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // InputPhone
            // 
            InputPhone.Location = new Point(95, 189);
            InputPhone.Margin = new Padding(3, 4, 3, 4);
            InputPhone.Name = "InputPhone";
            InputPhone.PlaceholderText = "(00) 12345-6789";
            InputPhone.Size = new Size(274, 27);
            InputPhone.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 194);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 9;
            label2.Text = "Telefone";
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(35, 137);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(46, 20);
            LabelEmail.TabIndex = 8;
            LabelEmail.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 254);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 11;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 317);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 7;
            label4.Text = "CEP";
            // 
            // MemberView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Controls.Add(SaveButton);
            Controls.Add(InputPhone);
            Controls.Add(label2);
            Controls.Add(LabelEmail);
            Controls.Add(label3);
            Controls.Add(label4);
            Size = new Size(1131, 664);
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
    }
}
