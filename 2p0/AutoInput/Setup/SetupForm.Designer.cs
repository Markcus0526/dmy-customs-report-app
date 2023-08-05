namespace Setup
{
    partial class SetupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupForm));
            this.btnInst = new System.Windows.Forms.Button();
            this.btnUninst = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.chkAgree = new System.Windows.Forms.CheckBox();
            this.lstAttend = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInst
            // 
            this.btnInst.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInst.ForeColor = System.Drawing.Color.Navy;
            this.btnInst.Location = new System.Drawing.Point(98, 222);
            this.btnInst.Name = "btnInst";
            this.btnInst.Size = new System.Drawing.Size(64, 24);
            this.btnInst.TabIndex = 1;
            this.btnInst.Text = "安 装";
            this.btnInst.UseVisualStyleBackColor = true;
            this.btnInst.Click += new System.EventHandler(this.btnInst_Click);
            // 
            // btnUninst
            // 
            this.btnUninst.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUninst.ForeColor = System.Drawing.Color.Navy;
            this.btnUninst.Location = new System.Drawing.Point(220, 223);
            this.btnUninst.Name = "btnUninst";
            this.btnUninst.Size = new System.Drawing.Size(64, 23);
            this.btnUninst.TabIndex = 2;
            this.btnUninst.Text = "删 除";
            this.btnUninst.UseVisualStyleBackColor = true;
            this.btnUninst.Click += new System.EventHandler(this.btnUninst_Click);
            // 
            // lblNote
            // 
            this.lblNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.Gray;
            this.lblNote.Location = new System.Drawing.Point(121, 255);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(0, 13);
            this.lblNote.TabIndex = 2;
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkAgree
            // 
            this.chkAgree.AutoSize = true;
            this.chkAgree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAgree.Location = new System.Drawing.Point(35, 198);
            this.chkAgree.Name = "chkAgree";
            this.chkAgree.Size = new System.Drawing.Size(177, 20);
            this.chkAgree.TabIndex = 0;
            this.chkAgree.Text = "同意上面的要求事项。";
            this.chkAgree.UseVisualStyleBackColor = true;
            this.chkAgree.CheckedChanged += new System.EventHandler(this.chkAgree_CheckedChanged);
            // 
            // lstAttend
            // 
            this.lstAttend.BackColor = System.Drawing.Color.White;
            this.lstAttend.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAttend.FormattingEnabled = true;
            this.lstAttend.HorizontalScrollbar = true;
            this.lstAttend.ItemHeight = 15;
            this.lstAttend.Items.AddRange(new object[] {
            "用户使用",
            "1、自动输入海关报关单之前，请开动海关程序。",
            "2、设置程序以后，如用鼠标2次按一下CDT文件，就自动输入海关程序内容。",
            "",
            "没有开发商的同意下不允许把这个程序非法复印或变更。"});
            this.lstAttend.Location = new System.Drawing.Point(35, 68);
            this.lstAttend.Name = "lstAttend";
            this.lstAttend.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstAttend.Size = new System.Drawing.Size(319, 124);
            this.lstAttend.TabIndex = 4;
            this.lstAttend.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(52, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "这个是可以自动输入海关报关单的程序。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "请阅读下面的要求事项。";
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 282);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAttend);
            this.Controls.Add(this.chkAgree);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnUninst);
            this.Controls.Add(this.btnInst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "海关报关单-自动输入软件";
            this.Load += new System.EventHandler(this.SetupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInst;        
        private System.Windows.Forms.Button btnUninst;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.CheckBox chkAgree;
        private System.Windows.Forms.ListBox lstAttend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

