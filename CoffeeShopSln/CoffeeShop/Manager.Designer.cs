namespace CoffeeShop
{
    partial class Manager
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelJoinDate = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelDept = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelWC = new System.Windows.Forms.Label();
            this.labelAsdress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.panelMouseC = new System.Windows.Forms.Panel();
            this.buttonChangePass = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonTransaction = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonUpItem = new System.Windows.Forms.Button();
            this.buttonItemAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Red;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(980, 633);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(185, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(792, 627);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelJoinDate);
            this.panel1.Controls.Add(this.labelSalary);
            this.panel1.Controls.Add(this.labelDept);
            this.panel1.Controls.Add(this.labelDOB);
            this.panel1.Controls.Add(this.labelWC);
            this.panel1.Controls.Add(this.labelAsdress);
            this.panel1.Controls.Add(this.labelPhone);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 568);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelJoinDate
            // 
            this.labelJoinDate.AutoSize = true;
            this.labelJoinDate.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.labelJoinDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJoinDate.ForeColor = System.Drawing.Color.Gray;
            this.labelJoinDate.Location = new System.Drawing.Point(30, 247);
            this.labelJoinDate.Name = "labelJoinDate";
            this.labelJoinDate.Size = new System.Drawing.Size(0, 19);
            this.labelJoinDate.TabIndex = 25;
            this.labelJoinDate.UseWaitCursor = true;
            this.labelJoinDate.Visible = false;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.labelSalary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.ForeColor = System.Drawing.Color.Gray;
            this.labelSalary.Location = new System.Drawing.Point(30, 219);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(0, 19);
            this.labelSalary.TabIndex = 24;
            this.labelSalary.UseWaitCursor = true;
            this.labelSalary.Visible = false;
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.labelDept.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDept.ForeColor = System.Drawing.Color.Gray;
            this.labelDept.Location = new System.Drawing.Point(30, 189);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(0, 19);
            this.labelDept.TabIndex = 23;
            this.labelDept.UseWaitCursor = true;
            this.labelDept.Visible = false;
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.labelDOB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.ForeColor = System.Drawing.Color.Gray;
            this.labelDOB.Location = new System.Drawing.Point(30, 156);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(0, 19);
            this.labelDOB.TabIndex = 22;
            this.labelDOB.UseWaitCursor = true;
            this.labelDOB.Visible = false;
            // 
            // labelWC
            // 
            this.labelWC.AutoSize = true;
            this.labelWC.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.labelWC.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWC.ForeColor = System.Drawing.Color.Red;
            this.labelWC.Location = new System.Drawing.Point(26, 15);
            this.labelWC.Name = "labelWC";
            this.labelWC.Size = new System.Drawing.Size(0, 33);
            this.labelWC.TabIndex = 21;
            this.labelWC.UseWaitCursor = true;
            this.labelWC.Visible = false;
            // 
            // labelAsdress
            // 
            this.labelAsdress.AutoSize = true;
            this.labelAsdress.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.labelAsdress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsdress.ForeColor = System.Drawing.Color.Gray;
            this.labelAsdress.Location = new System.Drawing.Point(30, 305);
            this.labelAsdress.Name = "labelAsdress";
            this.labelAsdress.Size = new System.Drawing.Size(0, 19);
            this.labelAsdress.TabIndex = 20;
            this.labelAsdress.UseWaitCursor = true;
            this.labelAsdress.Visible = false;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.labelPhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.ForeColor = System.Drawing.Color.Gray;
            this.labelPhone.Location = new System.Drawing.Point(30, 275);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(0, 19);
            this.labelPhone.TabIndex = 19;
            this.labelPhone.UseWaitCursor = true;
            this.labelPhone.Visible = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.labelEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.Gray;
            this.labelEmail.Location = new System.Drawing.Point(28, 130);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(0, 19);
            this.labelEmail.TabIndex = 18;
            this.labelEmail.UseWaitCursor = true;
            this.labelEmail.Visible = false;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.labelID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.Gray;
            this.labelID.Location = new System.Drawing.Point(28, 100);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 19);
            this.labelID.TabIndex = 17;
            this.labelID.UseWaitCursor = true;
            this.labelID.Visible = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.labelName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Gray;
            this.labelName.Location = new System.Drawing.Point(28, 67);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 19);
            this.labelName.TabIndex = 16;
            this.labelName.UseWaitCursor = true;
            this.labelName.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBoxSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 47);
            this.panel3.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(745, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coffee Palace";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(401, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.White;
            this.textBoxSearch.Location = new System.Drawing.Point(167, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(240, 31);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCustomers);
            this.panel2.Controls.Add(this.panelMouseC);
            this.panel2.Controls.Add(this.buttonChangePass);
            this.panel2.Controls.Add(this.btnEmployees);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.buttonLogOut);
            this.panel2.Controls.Add(this.buttonTransaction);
            this.panel2.Controls.Add(this.buttonAddEmployee);
            this.panel2.Controls.Add(this.buttonUpItem);
            this.panel2.Controls.Add(this.buttonItemAdd);
            this.panel2.Controls.Add(this.buttonUpdate);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 627);
            this.panel2.TabIndex = 1;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(9, 368);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(164, 46);
            this.btnCustomers.TabIndex = 12;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // panelMouseC
            // 
            this.panelMouseC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.panelMouseC.Location = new System.Drawing.Point(3, 56);
            this.panelMouseC.Name = "panelMouseC";
            this.panelMouseC.Size = new System.Drawing.Size(10, 46);
            this.panelMouseC.TabIndex = 10;
            // 
            // buttonChangePass
            // 
            this.buttonChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.buttonChangePass.FlatAppearance.BorderSize = 0;
            this.buttonChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePass.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePass.ForeColor = System.Drawing.Color.White;
            this.buttonChangePass.Location = new System.Drawing.Point(9, 472);
            this.buttonChangePass.Name = "buttonChangePass";
            this.buttonChangePass.Size = new System.Drawing.Size(164, 46);
            this.buttonChangePass.TabIndex = 9;
            this.buttonChangePass.Text = "Change Password";
            this.buttonChangePass.UseVisualStyleBackColor = false;
            this.buttonChangePass.Click += new System.EventHandler(this.buttonChangePass_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.Location = new System.Drawing.Point(9, 316);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(164, 46);
            this.btnEmployees.TabIndex = 11;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(9, 524);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(164, 46);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Deactivate";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.White;
            this.buttonLogOut.Location = new System.Drawing.Point(9, 576);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(164, 46);
            this.buttonLogOut.TabIndex = 7;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonTransaction
            // 
            this.buttonTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.buttonTransaction.FlatAppearance.BorderSize = 0;
            this.buttonTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransaction.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransaction.ForeColor = System.Drawing.Color.White;
            this.buttonTransaction.Location = new System.Drawing.Point(9, 420);
            this.buttonTransaction.Name = "buttonTransaction";
            this.buttonTransaction.Size = new System.Drawing.Size(164, 46);
            this.buttonTransaction.TabIndex = 6;
            this.buttonTransaction.Text = "Transactions";
            this.buttonTransaction.UseVisualStyleBackColor = false;
            this.buttonTransaction.Click += new System.EventHandler(this.buttonTransaction_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.buttonAddEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddEmployee.FlatAppearance.BorderSize = 0;
            this.buttonAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEmployee.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEmployee.ForeColor = System.Drawing.Color.White;
            this.buttonAddEmployee.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAddEmployee.Location = new System.Drawing.Point(9, 108);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(164, 46);
            this.buttonAddEmployee.TabIndex = 5;
            this.buttonAddEmployee.Text = "Add Employee";
            this.buttonAddEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddEmployee.UseVisualStyleBackColor = false;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonUpItem
            // 
            this.buttonUpItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.buttonUpItem.FlatAppearance.BorderSize = 0;
            this.buttonUpItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpItem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpItem.ForeColor = System.Drawing.Color.White;
            this.buttonUpItem.Location = new System.Drawing.Point(9, 264);
            this.buttonUpItem.Name = "buttonUpItem";
            this.buttonUpItem.Size = new System.Drawing.Size(164, 46);
            this.buttonUpItem.TabIndex = 4;
            this.buttonUpItem.Text = "Update Item";
            this.buttonUpItem.UseVisualStyleBackColor = false;
            this.buttonUpItem.Click += new System.EventHandler(this.buttonUpItem_Click);
            // 
            // buttonItemAdd
            // 
            this.buttonItemAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.buttonItemAdd.FlatAppearance.BorderSize = 0;
            this.buttonItemAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonItemAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemAdd.ForeColor = System.Drawing.Color.White;
            this.buttonItemAdd.Location = new System.Drawing.Point(9, 212);
            this.buttonItemAdd.Name = "buttonItemAdd";
            this.buttonItemAdd.Size = new System.Drawing.Size(164, 46);
            this.buttonItemAdd.TabIndex = 3;
            this.buttonItemAdd.Text = "Add Item";
            this.buttonItemAdd.UseVisualStyleBackColor = false;
            this.buttonItemAdd.Click += new System.EventHandler(this.buttonItemAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(9, 160);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(164, 46);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Update AC";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHome.Location = new System.Drawing.Point(9, 56);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(164, 46);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 633);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonUpItem;
        private System.Windows.Forms.Button buttonItemAdd;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonTransaction;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChangePass;
        private System.Windows.Forms.Panel panelMouseC;
        private System.Windows.Forms.Label labelJoinDate;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelWC;
        private System.Windows.Forms.Label labelAsdress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button button2;
    }
}