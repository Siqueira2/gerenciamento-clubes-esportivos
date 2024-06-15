namespace GerenciamentoClubesEsportivos
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(47, 87);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(40, 15);
            LabelName.TabIndex = 0;
            LabelName.Text = "Nome";
            // 
            // DismissButton
            // 
            DismissButton.Location = new Point(268, 323);
            DismissButton.Name = "DismissButton";
            DismissButton.Size = new Size(75, 23);
            DismissButton.TabIndex = 1;
            DismissButton.Text = "Cancelar";
            DismissButton.UseVisualStyleBackColor = true;
            DismissButton.Click += DismissButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(369, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(616, 428);
            dataGridView1.TabIndex = 2;
            // 
            // InputName
            // 
            InputName.Location = new Point(103, 83);
            InputName.Name = "InputName";
            InputName.Size = new Size(240, 23);
            InputName.TabIndex = 3;
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(51, 132);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(36, 15);
            LabelEmail.TabIndex = 0;
            LabelEmail.Text = "Email";
            // 
            // InputEmail
            // 
            InputEmail.Location = new Point(103, 128);
            InputEmail.Name = "InputEmail";
            InputEmail.Size = new Size(240, 23);
            InputEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 175);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 220);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 0;
            label3.Text = "CPF";
            // 
            // InputPhone
            // 
            InputPhone.Location = new Point(103, 171);
            InputPhone.Name = "InputPhone";
            InputPhone.Size = new Size(240, 23);
            InputPhone.TabIndex = 3;
            // 
            // InputCPF
            // 
            InputCPF.Location = new Point(103, 216);
            InputCPF.Name = "InputCPF";
            InputCPF.Size = new Size(240, 23);
            InputCPF.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 267);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 0;
            label4.Text = "CEP";
            // 
            // InputCEP
            // 
            InputCEP.Location = new Point(103, 263);
            InputCEP.Name = "InputCEP";
            InputCEP.Size = new Size(240, 23);
            InputCEP.TabIndex = 3;
            // 
            // InputSearch
            // 
            InputSearch.Location = new Point(369, 37);
            InputSearch.Name = "InputSearch";
            InputSearch.Size = new Size(273, 23);
            InputSearch.TabIndex = 5;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(648, 37);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Buscar";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Enabled = false;
            DeleteButton.Location = new Point(186, 323);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 1;
            DeleteButton.Text = "Deletar";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DismissButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(103, 323);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Adicionar";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 523);
            Controls.Add(InputSearch);
            Controls.Add(InputCPF);
            Controls.Add(InputEmail);
            Controls.Add(InputCEP);
            Controls.Add(InputPhone);
            Controls.Add(InputName);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(LabelEmail);
            Controls.Add(label2);
            Controls.Add(SearchButton);
            Controls.Add(SaveButton);
            Controls.Add(DeleteButton);
            Controls.Add(DismissButton);
            Controls.Add(LabelName);
            Name = "Form1";
            Text = "Nome";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
