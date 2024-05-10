namespace DotNet7WithSqlExample
{
    partial class frmStudent
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            studentDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            FatherName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            saveButton = new Button();
            addressTextBox = new TextBox();
            fatherNameTextBox = new TextBox();
            nameTextBox = new TextBox();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(studentDataGridView);
            groupBox1.Controls.Add(saveButton);
            groupBox1.Controls.Add(addressTextBox);
            groupBox1.Controls.Add(fatherNameTextBox);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(Label3);
            groupBox1.Controls.Add(Label2);
            groupBox1.Controls.Add(Label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(606, 361);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Information";
            // 
            // studentDataGridView
            // 
            studentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Name, FatherName, Address });
            studentDataGridView.ContextMenuStrip = contextMenuStrip1;
            studentDataGridView.Location = new Point(17, 208);
            studentDataGridView.Name = "studentDataGridView";
            studentDataGridView.RowTemplate.Height = 25;
            studentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentDataGridView.Size = new Size(572, 148);
            studentDataGridView.TabIndex = 3;
            studentDataGridView.RowHeaderMouseDoubleClick += studentDataGridView_RowHeaderMouseDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // FatherName
            // 
            FatherName.HeaderText = "Father Name";
            FatherName.Name = "FatherName";
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.Name = "Address";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 48);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(481, 174);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 28);
            saveButton.TabIndex = 2;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(218, 129);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(338, 29);
            addressTextBox.TabIndex = 1;
            // 
            // fatherNameTextBox
            // 
            fatherNameTextBox.Location = new Point(218, 83);
            fatherNameTextBox.Name = "fatherNameTextBox";
            fatherNameTextBox.Size = new Size(338, 29);
            fatherNameTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(218, 40);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(338, 29);
            nameTextBox.TabIndex = 1;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(117, 132);
            Label3.Name = "Label3";
            Label3.Size = new Size(66, 21);
            Label3.TabIndex = 0;
            Label3.Text = "Address";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(117, 91);
            Label2.Name = "Label2";
            Label2.Size = new Size(99, 21);
            Label2.TabIndex = 0;
            Label2.Text = "Father Name";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(117, 43);
            Label1.Name = "Label1";
            Label1.Size = new Size(52, 21);
            Label1.TabIndex = 0;
            Label1.Text = "Name";
            // 
            // frmStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 366);
            Controls.Add(groupBox1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Entry";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox nameTextBox;
        private Label Label1;
        private TextBox fatherNameTextBox;
        private Label Label3;
        private Label Label2;
        private TextBox addressTextBox;
        private Button saveButton;
        private DataGridView studentDataGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn FatherName;
        private DataGridViewTextBoxColumn Address;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
