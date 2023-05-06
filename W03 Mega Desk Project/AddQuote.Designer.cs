namespace W03_Mega_Desk_Project
{
    partial class AddQuote
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
            this.Back = new System.Windows.Forms.Button();
            this.DisplayQuote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DeskMaterials = new System.Windows.Forms.ComboBox();
            this.RushOrder = new System.Windows.Forms.ComboBox();
            this.numOfDrawers = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.TextBox();
            this.depth = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(493, 331);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DisplayQuote
            // 
            this.DisplayQuote.Location = new System.Drawing.Point(12, 331);
            this.DisplayQuote.Name = "DisplayQuote";
            this.DisplayQuote.Size = new System.Drawing.Size(75, 23);
            this.DisplayQuote.TabIndex = 6;
            this.DisplayQuote.Text = "Add Quote";
            this.DisplayQuote.UseVisualStyleBackColor = true;
            this.DisplayQuote.Click += new System.EventHandler(this.DisplayQuote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desk Width:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desk Depth:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of Drawers:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Materials:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rush Order:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DeskMaterials
            // 
            this.DeskMaterials.FormattingEnabled = true;
            this.DeskMaterials.Location = new System.Drawing.Point(166, 175);
            this.DeskMaterials.Name = "DeskMaterials";
            this.DeskMaterials.Size = new System.Drawing.Size(161, 23);
            this.DeskMaterials.TabIndex = 4;
            this.DeskMaterials.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RushOrder
            // 
            this.RushOrder.FormattingEnabled = true;
            this.RushOrder.Location = new System.Drawing.Point(166, 217);
            this.RushOrder.Name = "RushOrder";
            this.RushOrder.Size = new System.Drawing.Size(161, 23);
            this.RushOrder.TabIndex = 5;
            this.RushOrder.SelectedIndexChanged += new System.EventHandler(this.RushOrder_SelectedIndexChanged);
            // 
            // numOfDrawers
            // 
            this.numOfDrawers.Location = new System.Drawing.Point(166, 135);
            this.numOfDrawers.Name = "numOfDrawers";
            this.numOfDrawers.Size = new System.Drawing.Size(161, 23);
            this.numOfDrawers.TabIndex = 3;
            this.numOfDrawers.TextChanged += new System.EventHandler(this.numOfDrawers_TextChanged);
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(166, 91);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(161, 23);
            this.width.TabIndex = 2;
            this.width.Validating += new System.ComponentModel.CancelEventHandler(this.Width_Validating);
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(166, 51);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(161, 23);
            this.depth.TabIndex = 1;
            this.depth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Depth_KeyPress);
            // 
            // customerName
            // 
            this.customerName.AcceptsTab = true;
            this.customerName.Location = new System.Drawing.Point(166, 7);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(161, 23);
            this.customerName.TabIndex = 0;
            this.customerName.TextChanged += new System.EventHandler(this.customerName_TextChanged);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 366);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.numOfDrawers);
            this.Controls.Add(this.RushOrder);
            this.Controls.Add(this.DeskMaterials);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayQuote);
            this.Controls.Add(this.Back);
            this.MaximizeBox = false;
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Back;
        private Button DisplayQuote;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox DeskMaterials;
        private ComboBox RushOrder;
        private TextBox numOfDrawers;
        private TextBox width;
        private TextBox depth;
        private TextBox customerName;
    }
}