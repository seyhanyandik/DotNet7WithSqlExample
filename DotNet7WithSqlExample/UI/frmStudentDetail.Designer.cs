namespace DotNet7WithSqlExample.UI
{
    partial class frmStudentDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            idLabel = new Label();
            updateButton = new Button();
            addressTextBox = new TextBox();
            fatherNameTextBox = new TextBox();
            nameTextBox = new TextBox();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(idLabel);
            groupBox1.Controls.Add(updateButton);
            groupBox1.Controls.Add(addressTextBox);
            groupBox1.Controls.Add(fatherNameTextBox);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(Label3);
            groupBox1.Controls.Add(Label2);
            groupBox1.Controls.Add(Label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 280);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Information";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(342, 25);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(0, 21);
            idLabel.TabIndex = 9;
            idLabel.Visible = false;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(355, 180);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 34);
            updateButton.TabIndex = 8;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(118, 145);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(312, 29);
            addressTextBox.TabIndex = 5;
            // 
            // fatherNameTextBox
            // 
            fatherNameTextBox.Location = new Point(118, 105);
            fatherNameTextBox.Name = "fatherNameTextBox";
            fatherNameTextBox.Size = new Size(312, 29);
            fatherNameTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(118, 66);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(312, 29);
            nameTextBox.TabIndex = 7;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(6, 145);
            Label3.Name = "Label3";
            Label3.Size = new Size(66, 21);
            Label3.TabIndex = 2;
            Label3.Text = "Address";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(6, 105);
            Label2.Name = "Label2";
            Label2.Size = new Size(99, 21);
            Label2.TabIndex = 3;
            Label2.Text = "Father Name";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(6, 69);
            Label1.Name = "Label1";
            Label1.Size = new Size(52, 21);
            Label1.TabIndex = 4;
            Label1.Text = "Name";
            // 
            // frmStudentDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 291);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmStudentDetail";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmStudentDetail";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label Label3;
        private Label Label2;
        private Label Label1;
        private Button updateButton;
        public TextBox addressTextBox;
        public TextBox fatherNameTextBox;
        public TextBox nameTextBox;
        public Label idLabel;
    }
}