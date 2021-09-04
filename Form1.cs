using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace WindowsForms_DatagridView_Execl
{
    public partial class Form1 : Form
    {

        DataTable table = new DataTable();
        int count = 0; //테이블 no값
        const string Code_Placeholder = "(필수 입력)";

        //콤보박스 바인딩 리스트 선언
        private BindingList<object> binglist_contry = new BindingList<object>();
        private BindingList<object> binglist_region = new BindingList<object>();
        private BindingList<object> binglist_sector = new BindingList<object>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("No", typeof(string));
            table.Columns.Add("공장코드", typeof(string));
            table.Columns.Add("공장명", typeof(string));
            table.Columns.Add("국가", typeof(string));
            table.Columns.Add("지역", typeof(string));
            table.Columns.Add("업종", typeof(string));
            table.Columns.Add("공장장", typeof(string));
            table.Columns.Add("비고", typeof(string));

            dgv_Factory_list.DataSource = table; 

            initContorl(); //콤보박스 바인딩
            initPlaceholder(); //텍스트 박스 필수입력란 호출
            Deletebutton_Enable_check(); //삭제 버튼 비활성화 여부 판단

            //그리드 뷰 셀 헤더 설정
            dgv_Factory_list.EnableHeadersVisualStyles = false;
            dgv_Factory_list.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;

            //그리드 뷰 디폴트 로우헤더 비활성화
            dgv_Factory_list.RowHeadersVisible = false;
        }

        private void initPlaceholder()
        {
            //처음 공백 Placeholder 지정
            textBox_Factory_Code.ForeColor = Color.DarkGray;
            textBox_Factory_Code.Text = Code_Placeholder;

            textBox_Factory_Name.ForeColor = Color.DarkGray;
            textBox_Factory_Name.Text = Code_Placeholder;

            //텍스트박스 커서 Focus 여부에 따라 이벤트 지정
            textBox_Factory_Code.GotFocus += RemovePlaceholder;
            textBox_Factory_Code.LostFocus += SetPlaceholder;

            textBox_Factory_Name.GotFocus += RemovePlaceholder;
            textBox_Factory_Name.LostFocus += SetPlaceholder;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            txt.ForeColor = Color.Black; //사용자 입력 진한 글씨
            txt.Text = string.Empty;

        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                //사용자 입력값이 하나도 없는 경우에 포커스 잃으면 Placeholder 적용해주기
                txt.ForeColor = Color.DarkGray; //Placeholder 흐린 글씨
                txt.Text = Code_Placeholder;

            }
        }

        private void Deletebutton_Enable_check()
        {
            //저장 버튼 동작
            if (string.IsNullOrEmpty(textBox_Factory_Code.Text) == true || string.IsNullOrEmpty(textBox_Factory_Name.Text) == true || textBox_Factory_Code.Text == Code_Placeholder || textBox_Factory_Name.Text == Code_Placeholder)
            {
                button_Download.Enabled = false; //빈값인 경우 비활성화
            }
            else
            {
                button_Download.Enabled = true; //값이 들어있으면 활성화
            }
        }
        //상단 패널
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //하단 패널
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void groupBox_Input_Enter(object sender, EventArgs e)
        {

        }

        private void group_factory_list_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_Factory_Code_TextChanged(object sender, EventArgs e)
        {

            Deletebutton_Enable_check();

        }
        private void textBox_Factory_Name_TextChanged(object sender, EventArgs e)
        {
            Deletebutton_Enable_check();
        }

        /* //콤보박스 데이터 연결 sql 연결시?
        public class ComboBoxItem
        {
            #region Fields

            private int code;
            private string name;
            #endregion

            #region Properties
            public int Code
            {
                get { return code; }
                set { code = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            #endregion

            public override string ToString()
            {
                return this.name;
            }

 
        }

        private void initContorl()
        {
            ComboBoxItem item1 = new ComboBoxItem();
            item1.Code =  1;
            item1.Name = "대한민국";
            comboBox_Country.Items.Add(item1);
        }*/
        private void initContorl()
        {

            binglist_contry.Add(new { Text = "대한민국", Value = "KR" });
            binglist_contry.Add(new { Text = "미국", Value = "US" });
            binglist_contry.Add(new { Text = "중국", Value = "CN" });
            binglist_contry.Add(new { Text = "일본", Value = "JP" });
            binglist_contry.Add(new { Text = "러시아", Value = "RS" });
            binglist_contry.Add(new { Text = "인도", Value = "IN" });
            comboBox_Country.DataSource = binglist_contry;
            comboBox_Country.DisplayMember = "Text";
            comboBox_Country.ValueMember = "Value";

            binglist_region.Add(new { Text = "서율", Value = "02" });
            binglist_region.Add(new { Text = "경기", Value = "031" });
            binglist_region.Add(new { Text = "인천", Value = "032" });
            binglist_region.Add(new { Text = "부산", Value = "051" });
            binglist_region.Add(new { Text = "대구", Value = "053" });
            binglist_region.Add(new { Text = "울산", Value = "052" });
            comboBox_Region.DataSource = binglist_region;
            comboBox_Region.DisplayMember = "Text";
            comboBox_Region.ValueMember = "Value";

            binglist_sector.Add(new { Text = "화학제조업", Value = 1000 });
            binglist_sector.Add(new { Text = "섬유", Value = 1001 });
            binglist_sector.Add(new { Text = "부품조립", Value = 1002 });
            binglist_sector.Add(new { Text = "자동차", Value = 1003 });
            binglist_sector.Add(new { Text = "반도체", Value = 1004 });
            binglist_sector.Add(new { Text = "설비생산", Value = 1005 });
            comboBox_Sector.DataSource = binglist_sector;
            comboBox_Sector.DisplayMember = "Text";
            comboBox_Sector.ValueMember = "Value";

    
        }

        private void comboBox_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        
        private void button_Create_Click(object sender, EventArgs e)
        {
            //초기화
            textBox_Factory_Code.Text = "";
            textBox_Factory_Name.Text = "";
            textBox_Factory_Header.Text = "";
            comboBox_Country.SelectedIndex = 0;
            comboBox_Region.SelectedIndex = 0;
            comboBox_Sector.SelectedIndex = 0;
            richTextBox_Note.Text = "";

            initPlaceholder();
        }

        private void button_Download_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dialogResult = MessageBox.Show("저장 하시겠습니까?", "저장", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("저장 되었습니다.", "저장 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    table.Rows.Add(count, textBox_Factory_Code.Text, textBox_Factory_Name.Text, comboBox_Country.SelectedValue.ToString(), comboBox_Region.SelectedValue.ToString(), comboBox_Sector.SelectedValue.ToString(), textBox_Factory_Header.Text, richTextBox_Note.Text);

                    dgv_Factory_list.DataSource = table;
                    count++;
                }
                /*
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("아니요", "저장 취소", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }*/

            }
            catch (Exception ex)
            {
                MessageBox.Show("입력 에러 관리자에게 문의하세요." + "\r\n" + ex);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("삭제 하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(dialogResult == DialogResult.Yes)
                {
                    int selectedIndex = dgv_Factory_list.CurrentCell.RowIndex;

                    if (selectedIndex > -1)
                    {

                        int j = 0;
                        int count = 0;

                        for (j = 0; j < 8; j++)
                        {
                            if (dgv_Factory_list.Rows[selectedIndex].Cells[j].Value.ToString() != "")
                            {
                                dgv_Factory_list.Rows.RemoveAt(selectedIndex);
                                dgv_Factory_list.Refresh();
                            }

                            j++;
                        }
                        //dgv_Factory_list.Rows.RemoveAt(selectedIndex);
                    }
                    else
                    {
                        MessageBox.Show("마지막 셀 입니다.");
                    }
                }
            }
        
            catch (Exception ex)
            {
                MessageBox.Show("삭제할 수 있는 셀이 없습니다.");
            }
        }
    }
}
