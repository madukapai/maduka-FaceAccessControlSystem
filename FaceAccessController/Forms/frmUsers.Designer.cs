namespace FaceAccessController.Forms
{
    partial class frmUsers
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
            this.gbxPersonGroup = new System.Windows.Forms.GroupBox();
            this.btnPersonGroupTrain = new System.Windows.Forms.Button();
            this.btnDeletePersonGroup = new System.Windows.Forms.Button();
            this.btnAddPersonGroup = new System.Windows.Forms.Button();
            this.txtPersonGroup = new System.Windows.Forms.TextBox();
            this.lbxPersonGroup = new System.Windows.Forms.ListBox();
            this.gbxPerson = new System.Windows.Forms.GroupBox();
            this.btnPersonEditFace = new System.Windows.Forms.Button();
            this.btnDeletePerson = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.lbxPerson = new System.Windows.Forms.ListBox();
            this.gbxPersonGroup.SuspendLayout();
            this.gbxPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPersonGroup
            // 
            this.gbxPersonGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxPersonGroup.Controls.Add(this.btnPersonGroupTrain);
            this.gbxPersonGroup.Controls.Add(this.btnDeletePersonGroup);
            this.gbxPersonGroup.Controls.Add(this.btnAddPersonGroup);
            this.gbxPersonGroup.Controls.Add(this.txtPersonGroup);
            this.gbxPersonGroup.Controls.Add(this.lbxPersonGroup);
            this.gbxPersonGroup.Location = new System.Drawing.Point(12, 12);
            this.gbxPersonGroup.Name = "gbxPersonGroup";
            this.gbxPersonGroup.Size = new System.Drawing.Size(562, 160);
            this.gbxPersonGroup.TabIndex = 2;
            this.gbxPersonGroup.TabStop = false;
            this.gbxPersonGroup.Text = "Person Group";
            // 
            // btnPersonGroupTrain
            // 
            this.btnPersonGroupTrain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersonGroupTrain.Enabled = false;
            this.btnPersonGroupTrain.Location = new System.Drawing.Point(481, 126);
            this.btnPersonGroupTrain.Name = "btnPersonGroupTrain";
            this.btnPersonGroupTrain.Size = new System.Drawing.Size(75, 23);
            this.btnPersonGroupTrain.TabIndex = 1;
            this.btnPersonGroupTrain.Text = "Train";
            this.btnPersonGroupTrain.UseVisualStyleBackColor = true;
            this.btnPersonGroupTrain.Click += new System.EventHandler(this.btnPersonGroupTrain_Click);
            // 
            // btnDeletePersonGroup
            // 
            this.btnDeletePersonGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePersonGroup.Enabled = false;
            this.btnDeletePersonGroup.Location = new System.Drawing.Point(481, 97);
            this.btnDeletePersonGroup.Name = "btnDeletePersonGroup";
            this.btnDeletePersonGroup.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePersonGroup.TabIndex = 3;
            this.btnDeletePersonGroup.Text = "Delete";
            this.btnDeletePersonGroup.UseVisualStyleBackColor = true;
            this.btnDeletePersonGroup.Click += new System.EventHandler(this.btnDeletePersonGroup_Click);
            // 
            // btnAddPersonGroup
            // 
            this.btnAddPersonGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPersonGroup.Location = new System.Drawing.Point(481, 21);
            this.btnAddPersonGroup.Name = "btnAddPersonGroup";
            this.btnAddPersonGroup.Size = new System.Drawing.Size(75, 23);
            this.btnAddPersonGroup.TabIndex = 2;
            this.btnAddPersonGroup.Text = "Add";
            this.btnAddPersonGroup.UseVisualStyleBackColor = true;
            this.btnAddPersonGroup.Click += new System.EventHandler(this.btnAddPersonGroup_Click);
            // 
            // txtPersonGroup
            // 
            this.txtPersonGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonGroup.Location = new System.Drawing.Point(6, 21);
            this.txtPersonGroup.Name = "txtPersonGroup";
            this.txtPersonGroup.Size = new System.Drawing.Size(469, 22);
            this.txtPersonGroup.TabIndex = 1;
            // 
            // lbxPersonGroup
            // 
            this.lbxPersonGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxPersonGroup.FormattingEnabled = true;
            this.lbxPersonGroup.ItemHeight = 12;
            this.lbxPersonGroup.Location = new System.Drawing.Point(6, 49);
            this.lbxPersonGroup.Name = "lbxPersonGroup";
            this.lbxPersonGroup.Size = new System.Drawing.Size(469, 100);
            this.lbxPersonGroup.TabIndex = 0;
            this.lbxPersonGroup.SelectedIndexChanged += new System.EventHandler(this.lbxPersonGroup_SelectedIndexChanged);
            // 
            // gbxPerson
            // 
            this.gbxPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxPerson.Controls.Add(this.btnPersonEditFace);
            this.gbxPerson.Controls.Add(this.btnDeletePerson);
            this.gbxPerson.Controls.Add(this.btnAddPerson);
            this.gbxPerson.Controls.Add(this.txtPerson);
            this.gbxPerson.Controls.Add(this.lbxPerson);
            this.gbxPerson.Location = new System.Drawing.Point(12, 178);
            this.gbxPerson.Name = "gbxPerson";
            this.gbxPerson.Size = new System.Drawing.Size(562, 243);
            this.gbxPerson.TabIndex = 3;
            this.gbxPerson.TabStop = false;
            this.gbxPerson.Text = "Person";
            // 
            // btnPersonEditFace
            // 
            this.btnPersonEditFace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersonEditFace.Enabled = false;
            this.btnPersonEditFace.Location = new System.Drawing.Point(481, 210);
            this.btnPersonEditFace.Name = "btnPersonEditFace";
            this.btnPersonEditFace.Size = new System.Drawing.Size(75, 23);
            this.btnPersonEditFace.TabIndex = 4;
            this.btnPersonEditFace.Text = "Faces";
            this.btnPersonEditFace.UseVisualStyleBackColor = true;
            this.btnPersonEditFace.Click += new System.EventHandler(this.btnPersonEditFace_Click);
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePerson.Enabled = false;
            this.btnDeletePerson.Location = new System.Drawing.Point(481, 181);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePerson.TabIndex = 3;
            this.btnDeletePerson.Text = "Delete";
            this.btnDeletePerson.UseVisualStyleBackColor = true;
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPerson.Enabled = false;
            this.btnAddPerson.Location = new System.Drawing.Point(481, 21);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerson.TabIndex = 2;
            this.btnAddPerson.Text = "Add";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // txtPerson
            // 
            this.txtPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPerson.Location = new System.Drawing.Point(6, 21);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Size = new System.Drawing.Size(469, 22);
            this.txtPerson.TabIndex = 1;
            // 
            // lbxPerson
            // 
            this.lbxPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxPerson.FormattingEnabled = true;
            this.lbxPerson.ItemHeight = 12;
            this.lbxPerson.Location = new System.Drawing.Point(6, 49);
            this.lbxPerson.Name = "lbxPerson";
            this.lbxPerson.Size = new System.Drawing.Size(469, 184);
            this.lbxPerson.TabIndex = 0;
            this.lbxPerson.SelectedIndexChanged += new System.EventHandler(this.lbxPerson_SelectedIndexChanged);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 433);
            this.Controls.Add(this.gbxPerson);
            this.Controls.Add(this.gbxPersonGroup);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.gbxPersonGroup.ResumeLayout(false);
            this.gbxPersonGroup.PerformLayout();
            this.gbxPerson.ResumeLayout(false);
            this.gbxPerson.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPersonGroup;
        private System.Windows.Forms.Button btnPersonGroupTrain;
        private System.Windows.Forms.Button btnDeletePersonGroup;
        private System.Windows.Forms.Button btnAddPersonGroup;
        private System.Windows.Forms.TextBox txtPersonGroup;
        private System.Windows.Forms.ListBox lbxPersonGroup;
        private System.Windows.Forms.GroupBox gbxPerson;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.TextBox txtPerson;
        private System.Windows.Forms.ListBox lbxPerson;
        private System.Windows.Forms.Button btnDeletePerson;
        private System.Windows.Forms.Button btnPersonEditFace;
    }
}