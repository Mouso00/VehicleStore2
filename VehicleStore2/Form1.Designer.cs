namespace VehicleStore2
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
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbox_model = new System.Windows.Forms.TextBox();
            this.txtbox_maker = new System.Windows.Forms.TextBox();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_maker = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_store = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(205, 500);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(188, 58);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbox_model);
            this.groupBox1.Controls.Add(this.txtbox_maker);
            this.groupBox1.Controls.Add(this.lbl_model);
            this.groupBox1.Controls.Add(this.lbl_maker);
            this.groupBox1.Location = new System.Drawing.Point(62, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 362);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtbox_model
            // 
            this.txtbox_model.Location = new System.Drawing.Point(143, 106);
            this.txtbox_model.Name = "txtbox_model";
            this.txtbox_model.Size = new System.Drawing.Size(250, 47);
            this.txtbox_model.TabIndex = 3;
            // 
            // txtbox_maker
            // 
            this.txtbox_maker.Location = new System.Drawing.Point(143, 52);
            this.txtbox_maker.Name = "txtbox_maker";
            this.txtbox_maker.Size = new System.Drawing.Size(250, 47);
            this.txtbox_maker.TabIndex = 2;
            this.txtbox_maker.TextChanged += new System.EventHandler(this.txtbox_maker_TextChanged);
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Location = new System.Drawing.Point(23, 106);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(104, 41);
            this.lbl_model.TabIndex = 1;
            this.lbl_model.Text = "Model";
            // 
            // lbl_maker
            // 
            this.lbl_maker.AutoSize = true;
            this.lbl_maker.Location = new System.Drawing.Point(19, 52);
            this.lbl_maker.Name = "lbl_maker";
            this.lbl_maker.Size = new System.Drawing.Size(101, 41);
            this.lbl_maker.TabIndex = 0;
            this.lbl_maker.Text = "Maker";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_store);
            this.groupBox2.Location = new System.Drawing.Point(766, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 510);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lst_store
            // 
            this.lst_store.Location = new System.Drawing.Point(6, 46);
            this.lst_store.Name = "lst_store";
            this.lst_store.Size = new System.Drawing.Size(528, 435);
            this.lst_store.TabIndex = 0;
            this.lst_store.UseCompatibleStateImageBehavior = false;
            this.lst_store.SelectedIndexChanged += new System.EventHandler(this.lst_store_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 698);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_save;
        private GroupBox groupBox1;
        private TextBox txtbox_model;
        private TextBox txtbox_maker;
        private Label lbl_model;
        private Label lbl_maker;
        private GroupBox groupBox2;
        private ListView lst_store;
    }
}