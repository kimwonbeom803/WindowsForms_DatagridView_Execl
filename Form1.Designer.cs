
namespace WindowsForms_DatagridView_Execl
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_Input = new System.Windows.Forms.GroupBox();
            this.richTextBox_Note = new System.Windows.Forms.RichTextBox();
            this.comboBox_Sector = new System.Windows.Forms.ComboBox();
            this.comboBox_Region = new System.Windows.Forms.ComboBox();
            this.comboBox_Country = new System.Windows.Forms.ComboBox();
            this.label_note = new System.Windows.Forms.Label();
            this.label_Sector = new System.Windows.Forms.Label();
            this.label_Region = new System.Windows.Forms.Label();
            this.label_Country = new System.Windows.Forms.Label();
            this.label_Factory_header = new System.Windows.Forms.Label();
            this.label_Factory_Nmae = new System.Windows.Forms.Label();
            this.label_Factory_Code = new System.Windows.Forms.Label();
            this.textBox_Factory_Header = new System.Windows.Forms.TextBox();
            this.textBox_Factory_Name = new System.Windows.Forms.TextBox();
            this.textBox_Factory_Code = new System.Windows.Forms.TextBox();
            this.group_factory_list = new System.Windows.Forms.GroupBox();
            this.dgv_Factory_list = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_Download = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Empty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_Input.SuspendLayout();
            this.group_factory_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Factory_list)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_Input);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.group_factory_list);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1298, 596);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox_Input
            // 
            this.groupBox_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Input.AutoSize = true;
            this.groupBox_Input.Controls.Add(this.richTextBox_Note);
            this.groupBox_Input.Controls.Add(this.comboBox_Sector);
            this.groupBox_Input.Controls.Add(this.comboBox_Region);
            this.groupBox_Input.Controls.Add(this.comboBox_Country);
            this.groupBox_Input.Controls.Add(this.label_note);
            this.groupBox_Input.Controls.Add(this.label_Sector);
            this.groupBox_Input.Controls.Add(this.label_Region);
            this.groupBox_Input.Controls.Add(this.label_Country);
            this.groupBox_Input.Controls.Add(this.label_Factory_header);
            this.groupBox_Input.Controls.Add(this.label_Factory_Nmae);
            this.groupBox_Input.Controls.Add(this.label_Factory_Code);
            this.groupBox_Input.Controls.Add(this.textBox_Factory_Header);
            this.groupBox_Input.Controls.Add(this.textBox_Factory_Name);
            this.groupBox_Input.Controls.Add(this.textBox_Factory_Code);
            this.groupBox_Input.Location = new System.Drawing.Point(0, 65);
            this.groupBox_Input.Name = "groupBox_Input";
            this.groupBox_Input.Size = new System.Drawing.Size(1298, 225);
            this.groupBox_Input.TabIndex = 0;
            this.groupBox_Input.TabStop = false;
            this.groupBox_Input.Text = "입력영역";
            this.groupBox_Input.Enter += new System.EventHandler(this.groupBox_Input_Enter);
            // 
            // richTextBox_Note
            // 
            this.richTextBox_Note.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.richTextBox_Note.Location = new System.Drawing.Point(98, 142);
            this.richTextBox_Note.Name = "richTextBox_Note";
            this.richTextBox_Note.Size = new System.Drawing.Size(687, 59);
            this.richTextBox_Note.TabIndex = 13;
            this.richTextBox_Note.Text = "";
            // 
            // comboBox_Sector
            // 
            this.comboBox_Sector.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.comboBox_Sector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Sector.FormattingEnabled = true;
            this.comboBox_Sector.Location = new System.Drawing.Point(649, 108);
            this.comboBox_Sector.Name = "comboBox_Sector";
            this.comboBox_Sector.Size = new System.Drawing.Size(136, 23);
            this.comboBox_Sector.TabIndex = 12;
            // 
            // comboBox_Region
            // 
            this.comboBox_Region.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.comboBox_Region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Region.FormattingEnabled = true;
            this.comboBox_Region.Location = new System.Drawing.Point(377, 108);
            this.comboBox_Region.Name = "comboBox_Region";
            this.comboBox_Region.Size = new System.Drawing.Size(136, 23);
            this.comboBox_Region.TabIndex = 11;
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.comboBox_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Country.FormattingEnabled = true;
            this.comboBox_Country.Location = new System.Drawing.Point(98, 108);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.Size = new System.Drawing.Size(136, 23);
            this.comboBox_Country.TabIndex = 10;
            this.comboBox_Country.SelectedIndexChanged += new System.EventHandler(this.comboBox_Country_SelectedIndexChanged);
            // 
            // label_note
            // 
            this.label_note.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label_note.AutoSize = true;
            this.label_note.Location = new System.Drawing.Point(25, 142);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(37, 15);
            this.label_note.TabIndex = 9;
            this.label_note.Text = "비고";
            // 
            // label_Sector
            // 
            this.label_Sector.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label_Sector.AutoSize = true;
            this.label_Sector.Location = new System.Drawing.Point(588, 111);
            this.label_Sector.Name = "label_Sector";
            this.label_Sector.Size = new System.Drawing.Size(37, 15);
            this.label_Sector.TabIndex = 8;
            this.label_Sector.Text = "업종";
            // 
            // label_Region
            // 
            this.label_Region.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label_Region.AutoSize = true;
            this.label_Region.Location = new System.Drawing.Point(319, 111);
            this.label_Region.Name = "label_Region";
            this.label_Region.Size = new System.Drawing.Size(37, 15);
            this.label_Region.TabIndex = 7;
            this.label_Region.Text = "지역";
            // 
            // label_Country
            // 
            this.label_Country.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label_Country.AutoSize = true;
            this.label_Country.Location = new System.Drawing.Point(25, 108);
            this.label_Country.Name = "label_Country";
            this.label_Country.Size = new System.Drawing.Size(37, 15);
            this.label_Country.TabIndex = 6;
            this.label_Country.Text = "국가";
            // 
            // label_Factory_header
            // 
            this.label_Factory_header.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label_Factory_header.AutoSize = true;
            this.label_Factory_header.Location = new System.Drawing.Point(588, 72);
            this.label_Factory_header.Name = "label_Factory_header";
            this.label_Factory_header.Size = new System.Drawing.Size(52, 15);
            this.label_Factory_header.TabIndex = 5;
            this.label_Factory_header.Text = "공장장";
            // 
            // label_Factory_Nmae
            // 
            this.label_Factory_Nmae.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label_Factory_Nmae.AutoSize = true;
            this.label_Factory_Nmae.Location = new System.Drawing.Point(319, 71);
            this.label_Factory_Nmae.Name = "label_Factory_Nmae";
            this.label_Factory_Nmae.Size = new System.Drawing.Size(52, 15);
            this.label_Factory_Nmae.TabIndex = 4;
            this.label_Factory_Nmae.Text = "공장명";
            // 
            // label_Factory_Code
            // 
            this.label_Factory_Code.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label_Factory_Code.AutoSize = true;
            this.label_Factory_Code.Location = new System.Drawing.Point(25, 71);
            this.label_Factory_Code.Name = "label_Factory_Code";
            this.label_Factory_Code.Size = new System.Drawing.Size(67, 15);
            this.label_Factory_Code.TabIndex = 3;
            this.label_Factory_Code.Text = "공장코드";
            // 
            // textBox_Factory_Header
            // 
            this.textBox_Factory_Header.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.textBox_Factory_Header.Location = new System.Drawing.Point(649, 68);
            this.textBox_Factory_Header.Multiline = true;
            this.textBox_Factory_Header.Name = "textBox_Factory_Header";
            this.textBox_Factory_Header.Size = new System.Drawing.Size(136, 25);
            this.textBox_Factory_Header.TabIndex = 2;
            // 
            // textBox_Factory_Name
            // 
            this.textBox_Factory_Name.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.textBox_Factory_Name.Location = new System.Drawing.Point(377, 67);
            this.textBox_Factory_Name.Name = "textBox_Factory_Name";
            this.textBox_Factory_Name.Size = new System.Drawing.Size(136, 25);
            this.textBox_Factory_Name.TabIndex = 1;
            this.textBox_Factory_Name.TextChanged += new System.EventHandler(this.textBox_Factory_Name_TextChanged);
            // 
            // textBox_Factory_Code
            // 
            this.textBox_Factory_Code.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.textBox_Factory_Code.Location = new System.Drawing.Point(98, 67);
            this.textBox_Factory_Code.Name = "textBox_Factory_Code";
            this.textBox_Factory_Code.Size = new System.Drawing.Size(136, 25);
            this.textBox_Factory_Code.TabIndex = 0;
            this.textBox_Factory_Code.TextChanged += new System.EventHandler(this.textBox_Factory_Code_TextChanged);
            // 
            // group_factory_list
            // 
            this.group_factory_list.Controls.Add(this.dgv_Factory_list);
            this.group_factory_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_factory_list.Location = new System.Drawing.Point(0, 0);
            this.group_factory_list.Name = "group_factory_list";
            this.group_factory_list.Size = new System.Drawing.Size(1298, 307);
            this.group_factory_list.TabIndex = 1;
            this.group_factory_list.TabStop = false;
            this.group_factory_list.Text = "공장 목록";
            this.group_factory_list.Enter += new System.EventHandler(this.group_factory_list_Enter);
            // 
            // dgv_Factory_list
            // 
            this.dgv_Factory_list.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dgv_Factory_list.AllowUserToAddRows = false;
            this.dgv_Factory_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Factory_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Factory_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Factory_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Factory_list.Location = new System.Drawing.Point(3, 21);
            this.dgv_Factory_list.Name = "dgv_Factory_list";
            this.dgv_Factory_list.RowHeadersWidth = 51;
            this.dgv_Factory_list.RowTemplate.Height = 27;
            this.dgv_Factory_list.Size = new System.Drawing.Size(1292, 283);
            this.dgv_Factory_list.TabIndex = 0;
            this.dgv_Factory_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.button_Create);
            this.panel1.Controls.Add(this.button_Download);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_Empty);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 55);
            this.panel1.TabIndex = 0;
            // 
            // button_Create
            // 
            this.button_Create.AutoSize = true;
            this.button_Create.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Create.Location = new System.Drawing.Point(1073, 0);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(75, 55);
            this.button_Create.TabIndex = 0;
            this.button_Create.Text = "신규";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // button_Download
            // 
            this.button_Download.AutoSize = true;
            this.button_Download.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Download.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Download.Location = new System.Drawing.Point(1148, 0);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(75, 55);
            this.button_Download.TabIndex = 1;
            this.button_Download.Text = "저장";
            this.button_Download.UseVisualStyleBackColor = true;
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.AutoSize = true;
            this.button_Delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Delete.Location = new System.Drawing.Point(1223, 0);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 55);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "삭제";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Empty
            // 
            this.button_Empty.AutoSize = true;
            this.button_Empty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Empty.Enabled = false;
            this.button_Empty.Location = new System.Drawing.Point(0, 0);
            this.button_Empty.Name = "button_Empty";
            this.button_Empty.Size = new System.Drawing.Size(1298, 55);
            this.button_Empty.TabIndex = 3;
            this.button_Empty.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "공장코드 관리";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_Input.ResumeLayout(false);
            this.groupBox_Input.PerformLayout();
            this.group_factory_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Factory_list)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgv_Factory_list;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox_Input;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Download;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.RichTextBox richTextBox_Note;
        private System.Windows.Forms.ComboBox comboBox_Sector;
        private System.Windows.Forms.ComboBox comboBox_Region;
        private System.Windows.Forms.ComboBox comboBox_Country;
        private System.Windows.Forms.Label label_note;
        private System.Windows.Forms.Label label_Sector;
        private System.Windows.Forms.Label label_Region;
        private System.Windows.Forms.Label label_Country;
        private System.Windows.Forms.Label label_Factory_header;
        private System.Windows.Forms.Label label_Factory_Nmae;
        private System.Windows.Forms.Label label_Factory_Code;
        private System.Windows.Forms.TextBox textBox_Factory_Header;
        private System.Windows.Forms.TextBox textBox_Factory_Name;
        private System.Windows.Forms.TextBox textBox_Factory_Code;
        private System.Windows.Forms.GroupBox group_factory_list;
        private System.Windows.Forms.Button button_Empty;
    }
}

