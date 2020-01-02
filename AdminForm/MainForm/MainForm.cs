using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MES_DB;

namespace AdminForm
{
    public partial class MainForm : Form
    {
        private Point _imageLocation = new Point(15, 5);
        private Point _imgHitArea = new Point(13, 2);
        int CheckBtnIndex = 100;
        bool open = false;
        List<MenuTreeVo> menuList;

        public MainForm()
        {
            InitializeComponent();
            this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;


            this.tabControl1.ItemSize = new Size(120, 20);
            this.tabControl1.SizeMode = TabSizeMode.Fixed;

            // Add the Handler to draw the Image on Tab Pages
            tabControl1.DrawItem += tabControl1_DrawItem;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            MenuTreeService service = new MenuTreeService();
            menuList = service.GetAllMenu();
            CreateMenuTree("시스템관리");
            trvMenu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trvMenu.Visible = true;
            // 누르는 버튼
            Button btn = (Button)sender;
            // 열려있는 트리뷰가 존재하고
            // 현재 열려있는 버튼과 누르는 버튼이 같을 경우(트리뷰를 닫는다)
            if (btn.TabIndex == CheckBtnIndex && open)
            {
                foreach (var item in pnlMenu.Controls)
                {
                    Button conBtn;
                    if (item is Button)
                    {
                        conBtn = (Button)item;
                        if (conBtn.TabIndex > CheckBtnIndex)
                        {
                            conBtn.Location = new Point(0, conBtn.Location.Y - trvMenu.Size.Height);
                        }
                    }
                }
                open = false;
                trvMenu.Visible = false;
                return;
            }


            // 열려있는 트리뷰가 존재
            // 현재 열려있는버튼과 누르는 버튼이 다를 경우 
            if (open)
            {
                foreach (var item in pnlMenu.Controls)
                {
                    Button conBtn;
                    if (item is Button)
                    {
                        conBtn = (Button)item;
                        //눌려있는 버튼의 Index가 누르는 버튼의 Index보다 적을경우
                        //그 사이에 있는 버튼들을 treeview의 크기만큼 밀어준다
                        if (btn.TabIndex <= CheckBtnIndex)
                        {
                            if (btn.TabIndex < conBtn.TabIndex && CheckBtnIndex >= conBtn.TabIndex)
                            {
                                conBtn.Location = new Point(0, conBtn.Location.Y + trvMenu.Size.Height);
                            }
                        }

                        // 열려있는 버튼과 현재 누른 사이의 버튼들의 위치 재조정
                        if (conBtn.TabIndex <= btn.TabIndex && conBtn.TabIndex > CheckBtnIndex)
                        {
                            conBtn.Location = new Point(0, conBtn.Location.Y - trvMenu.Size.Height);
                            //if (conBtn.TabIndex > CheckBtnIndex)
                            //{
                            //    conBtn.Location = new Point(0, conBtn.Location.Y - trvMenu.Size.Height);
                            //}
                        }
                    }
                }
            }
            // 열려있는 트리뷰가 존재하지 않고
            // 현재 열려있는버튼과 누르는 버튼이 다를 경우 
            else
            {
                foreach (var item in pnlMenu.Controls)
                {
                    Button conBtn;
                    if (item is Button)
                    {
                        conBtn = (Button)item;
                        if (conBtn.TabIndex > btn.TabIndex)
                        {
                            conBtn.Location = new Point(0, conBtn.Location.Y + trvMenu.Size.Height);
                        }
                    }
                }
            }

            CheckBtnIndex = btn.TabIndex;
            trvMenu.Location = new Point(0, btn.Location.Y + btn.Size.Height);
            CreateMenuTree(btn.Text.Trim());
            open = true;
        }

        private void CreateMenuTree(string ParentMenu)
        {
            trvMenu.Nodes.Clear();
            trvMenu.ItemHeight = 25;
            List<MenuTreeVo> childMenu = (from item in menuList
                                          where item.Parent_Screen_Code == ParentMenu
                                          orderby item.Sort_index
                                          select item).ToList();
            trvMenu.Nodes.Add(ParentMenu);
            foreach (MenuTreeVo item in childMenu)
            {
                trvMenu.Nodes[0].Nodes.Add(item.Screen_Code);
            }
            trvMenu.ExpandAll();
        }


        private void MainForm_Resize(object sender, EventArgs e)
        {
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {

        }

        private void trvMenu_DoubleClick(object sender, EventArgs e)
        {
            if (trvMenu.SelectedNode.Text == "사용자그룹관리")
            {
                LoadWorkReport frm = new LoadWorkReport();
                frm.MdiParent = this;
                frm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                CreateTabMenu("사용자그룹관리");
            }
        }

        private void CreateTabMenu(string str)
        {
            TabPage tpFirst = new TabPage();
            tpFirst.Text = str;
            tabControl1.Controls.Add(tpFirst);
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                // Close Image to draw
                Image img = new Bitmap(System.Windows.Forms.Application.StartupPath + @"\image\Remove_16x16.png");
                Rectangle r = e.Bounds;
                r = this.tabControl1.GetTabRect(e.Index);
                r.Offset(2, 2);

                Brush TitleBrush = new SolidBrush(Color.Black);
                Font f = this.Font;

                string title = this.tabControl1.TabPages[e.Index].Text;

                e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));
                e.Graphics.DrawImage(img, new Point(r.X + (this.tabControl1.GetTabRect(e.Index).Width - _imageLocation.X-2), _imageLocation.Y-3));
            }
            catch (Exception err) { System.Windows.Forms.MessageBox.Show(err.Message); }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tc = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.tabControl1.GetTabRect(tc.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.tabControl1.GetTabRect(tc.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 16;
            r.Height = 16;
            if (r.Contains(p))
            {
                TabPage TabP = (TabPage)tc.TabPages[tc.SelectedIndex];
                tc.TabPages.Remove(TabP);
            }
            Form tempChild = this.ActiveMdiChild;
            tempChild.Close();
        }
    }
}
