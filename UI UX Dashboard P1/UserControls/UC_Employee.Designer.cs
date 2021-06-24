
namespace UI_UX_Dashboard_P1.UserControls
{
    partial class UC_Employee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnShowLocked = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(3, 124);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(1140, 567);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.Click += new System.EventHandler(this.dgvEmployee_Click);
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.Color.LightCoral;
            this.btnLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLock.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLock.Location = new System.Drawing.Point(177, 42);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(81, 33);
            this.btnLock.TabIndex = 10;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.Location = new System.Drawing.Point(3, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 33);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEdit.Location = new System.Drawing.Point(90, 42);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 33);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnShowLocked
            // 
            this.btnShowLocked.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnShowLocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLocked.ForeColor = System.Drawing.Color.DarkRed;
            this.btnShowLocked.Location = new System.Drawing.Point(351, 42);
            this.btnShowLocked.Name = "btnShowLocked";
            this.btnShowLocked.Size = new System.Drawing.Size(134, 33);
            this.btnShowLocked.TabIndex = 10;
            this.btnShowLocked.Text = "Show Locked";
            this.btnShowLocked.UseVisualStyleBackColor = false;
            this.btnShowLocked.Click += new System.EventHandler(this.btnShowLocked_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(491, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Show Actived";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnShowActived_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.Thistle;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnShowAll.Location = new System.Drawing.Point(631, 42);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(92, 33);
            this.btnShowAll.TabIndex = 10;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnActive
            // 
            this.btnActive.BackColor = System.Drawing.Color.YellowGreen;
            this.btnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnActive.Location = new System.Drawing.Point(264, 42);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(81, 33);
            this.btnActive.TabIndex = 10;
            this.btnActive.Text = "Active";
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // UC_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowLocked);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "UC_Employee";
            this.Size = new System.Drawing.Size(1146, 694);
            this.Load += new System.EventHandler(this.UC_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnShowLocked;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnActive;
    }
}
