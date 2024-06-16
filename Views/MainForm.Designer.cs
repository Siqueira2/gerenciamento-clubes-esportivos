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
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1139, 697);
            tabControl1.TabIndex = 6;
            // 
            // Members
            // 
            Members.BackColor = Color.Gainsboro;
            Members.Location = new Point(4, 29);
            Members.Name = "Members";
            Members.Padding = new Padding(3);
            Members.Size = new Size(1131, 664);
            Members.TabIndex = 0;
            Members.Text = "Sócios";
            Members.Click += Members_Click;
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
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage Members;
        private TabPage Dependents;
    }
}
