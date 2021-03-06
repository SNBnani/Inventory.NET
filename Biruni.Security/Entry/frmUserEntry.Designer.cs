namespace Biruni.Security.Entry
{
    partial class frmUserEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserEntry));
            this.c1Combo1 = new C1.Win.C1List.C1Combo();
            this.dsSecurity1 = new Biruni.Shared.Data.dsSecurity();
            this.label5 = new System.Windows.Forms.Label();
            this.c1TextBox3 = new C1.Win.C1Input.C1TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.c1TextBox2 = new C1.Win.C1Input.C1TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.c1TextBox1 = new C1.Win.C1Input.C1TextBox();
            this.daUsers = new Biruni.Shared.Data.dsSecurityTableAdapters.UsersTableAdapter();
            this.daRoles = new Biruni.Shared.Data.dsSecurityTableAdapters.RolesTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.c1TextBox4 = new C1.Win.C1Input.C1TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.c1TextBox5 = new C1.Win.C1Input.C1TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.c1TextBox6 = new C1.Win.C1Input.C1TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSecurity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(366, 39);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // c1Combo1
            // 
            this.c1Combo1.AddItemSeparator = ';';
            this.c1Combo1.AlternatingRows = true;
            this.c1Combo1.Caption = "";
            this.c1Combo1.CaptionHeight = 17;
            this.c1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1Combo1.ColumnCaptionHeight = 17;
            this.c1Combo1.ColumnFooterHeight = 17;
            this.c1Combo1.ColumnHeaders = false;
            this.c1Combo1.ColumnWidth = 100;
            this.c1Combo1.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.c1Combo1.ContentHeight = 16;
            this.c1Combo1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSecurity1, "Users.RoleID", true));
            this.c1Combo1.DataMember = "Roles";
            this.c1Combo1.DataSource = this.dsSecurity1;
            this.c1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1Combo1.DisplayMember = "Roles.Name";
            this.c1Combo1.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown;
            this.c1Combo1.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1Combo1.EditorFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1Combo1.EditorHeight = 16;
            this.c1Combo1.ExtendRightColumn = true;
            this.c1Combo1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo1.Images"))));
            this.c1Combo1.ItemHeight = 15;
            this.c1Combo1.Location = new System.Drawing.Point(112, 168);
            this.c1Combo1.MatchEntryTimeout = ((long)(2000));
            this.c1Combo1.MaxDropDownItems = ((short)(15));
            this.c1Combo1.MaxLength = 32767;
            this.c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo1.Name = "c1Combo1";
            this.c1Combo1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo1.Size = new System.Drawing.Size(234, 22);
            this.c1Combo1.TabIndex = 21;
            this.c1Combo1.ValueMember = "Roles.ID";
            this.c1Combo1.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            this.c1Combo1.PropBag = resources.GetString("c1Combo1.PropBag");
            // 
            // dsSecurity1
            // 
            this.dsSecurity1.DataSetName = "dsSecurity";
            this.dsSecurity1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Password length minimal 4 character";
            // 
            // c1TextBox3
            // 
            this.c1TextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.c1TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1TextBox3.Location = new System.Drawing.Point(112, 128);
            this.c1TextBox3.Name = "c1TextBox3";
            this.c1TextBox3.PasswordChar = '●';
            this.c1TextBox3.Size = new System.Drawing.Size(234, 19);
            this.c1TextBox3.TabIndex = 19;
            this.c1TextBox3.Tag = null;
            this.c1TextBox3.TextDetached = true;
            this.c1TextBox3.UseSystemPasswordChar = true;
            this.c1TextBox3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "User Function";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password";
            // 
            // c1TextBox2
            // 
            this.c1TextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.c1TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsSecurity1, "Users.Password", true));
            this.c1TextBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1TextBox2.Location = new System.Drawing.Point(112, 104);
            this.c1TextBox2.Name = "c1TextBox2";
            this.c1TextBox2.PasswordChar = '●';
            this.c1TextBox2.Size = new System.Drawing.Size(234, 19);
            this.c1TextBox2.TabIndex = 17;
            this.c1TextBox2.Tag = null;
            this.c1TextBox2.TextDetached = true;
            this.c1TextBox2.UseSystemPasswordChar = true;
            this.c1TextBox2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username";
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.c1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.c1TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsSecurity1, "Users.UserName", true));
            this.c1TextBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1TextBox1.Location = new System.Drawing.Point(112, 56);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Size = new System.Drawing.Size(168, 19);
            this.c1TextBox1.TabIndex = 11;
            this.c1TextBox1.Tag = null;
            this.c1TextBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // daUsers
            // 
            this.daUsers.ClearBeforeFill = true;
            // 
            // daRoles
            // 
            this.daRoles.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Full Name";
            // 
            // c1TextBox4
            // 
            this.c1TextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.c1TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsSecurity1, "Users.FullName", true));
            this.c1TextBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1TextBox4.Location = new System.Drawing.Point(112, 80);
            this.c1TextBox4.Name = "c1TextBox4";
            this.c1TextBox4.Size = new System.Drawing.Size(234, 19);
            this.c1TextBox4.TabIndex = 15;
            this.c1TextBox4.Tag = null;
            this.c1TextBox4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Title";
            // 
            // c1TextBox5
            // 
            this.c1TextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.c1TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsSecurity1, "Users.Title", true));
            this.c1TextBox5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1TextBox5.Location = new System.Drawing.Point(112, 208);
            this.c1TextBox5.Name = "c1TextBox5";
            this.c1TextBox5.Size = new System.Drawing.Size(234, 19);
            this.c1TextBox5.TabIndex = 24;
            this.c1TextBox5.Tag = null;
            this.c1TextBox5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Department";
            // 
            // c1TextBox6
            // 
            this.c1TextBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.c1TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsSecurity1, "Users.Department", true));
            this.c1TextBox6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1TextBox6.Location = new System.Drawing.Point(112, 232);
            this.c1TextBox6.Name = "c1TextBox6";
            this.c1TextBox6.Size = new System.Drawing.Size(234, 19);
            this.c1TextBox6.TabIndex = 26;
            this.c1TextBox6.Tag = null;
            this.c1TextBox6.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsSecurity1, "Users.Active", true));
            this.checkBox1.Location = new System.Drawing.Point(284, 57);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Active";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmUserEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(366, 270);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.c1TextBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.c1TextBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.c1TextBox4);
            this.Controls.Add(this.c1Combo1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.c1TextBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.c1TextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c1TextBox1);
            this.Name = "frmUserEntry";
            this.Text = "User Account Entry";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.c1TextBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.c1TextBox2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.c1TextBox3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.c1Combo1, 0);
            this.Controls.SetChildIndex(this.c1TextBox4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.c1TextBox5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.c1TextBox6, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSecurity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1List.C1Combo c1Combo1;
        private System.Windows.Forms.Label label5;
        private C1.Win.C1Input.C1TextBox c1TextBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1Input.C1TextBox c1TextBox2;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Input.C1TextBox c1TextBox1;
        private Biruni.Shared.Data.dsSecurity dsSecurity1;
        private Biruni.Shared.Data.dsSecurityTableAdapters.UsersTableAdapter daUsers;
        private Biruni.Shared.Data.dsSecurityTableAdapters.RolesTableAdapter daRoles;
        private System.Windows.Forms.Label label6;
        private C1.Win.C1Input.C1TextBox c1TextBox4;
        private System.Windows.Forms.Label label7;
        private C1.Win.C1Input.C1TextBox c1TextBox5;
        private System.Windows.Forms.Label label8;
        private C1.Win.C1Input.C1TextBox c1TextBox6;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
