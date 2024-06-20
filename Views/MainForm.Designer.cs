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
            tabControl1 = new TabControl();
            Members = new TabPage();
            Dependents = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Members);
            tabControl1.Controls.Add(Dependents);
            tabControl1.Location = new Point(-1, 1);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(997, 523);
            tabControl1.TabIndex = 6;
            tabControl1.Click += Dependents_Click;
            // 
            // Members
            // 
            Members.BackColor = Color.Gainsboro;
            Members.Location = new Point(4, 24);
            Members.Margin = new Padding(3, 2, 3, 2);
            Members.Name = "Members";
            Members.Padding = new Padding(3, 2, 3, 2);
            Members.Size = new Size(989, 495);
            Members.TabIndex = 0;
            Members.Text = "Sócios";
            Members.Click += Members_Click;
            // 
            // Dependents
            // 
            Dependents.BackColor = Color.Gainsboro;
            Dependents.Location = new Point(4, 24);
            Dependents.Margin = new Padding(3, 2, 3, 2);
            Dependents.Name = "Dependents";
            Dependents.Padding = new Padding(3, 2, 3, 2);
            Dependents.Size = new Size(989, 495);
            Dependents.TabIndex = 1;
            Dependents.Text = "Dependentes";
            Dependents.Click += Dependents_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 523);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Nome";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage Members;
        private TabPage Dependents;
    }
}
