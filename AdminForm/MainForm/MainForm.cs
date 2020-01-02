using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MES_DB;

namespace AdminForm
{
    public partial class MainForm : Form
    {
        int CheckBtnIndex = 91;
        List<MenuTreeVo> menuList;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            MenuTreeService service = new MenuTreeService();
            menuList = service.GetAllMenu();

            CreateMenuTree("시스템관리");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 누르는 버튼
            Button btn = (Button)sender;
            foreach (var item in pnlMenu.Controls)
            {
                Button conBtn;
                if(item is Button)
                {
                    conBtn = (Button)item;
                    //눌려있는 버튼의 Index가 누르는 버튼의 Index보다 적을경우
                    //그 사이에 있는 버튼들을 treeview의 크기만큼 밀어준다
                    if (btn.TabIndex < CheckBtnIndex)
                    {
                        if(btn.TabIndex<conBtn.TabIndex && CheckBtnIndex >= conBtn.TabIndex)
                        {
                            conBtn.Location = new Point(0, conBtn.Location.Y + 404);
                        }
                    }

                    
                    if(conBtn.TabIndex <= btn.TabIndex)
                    {
                        if (conBtn.TabIndex >CheckBtnIndex)
                        {
                            conBtn.Location = new Point(0, conBtn.Location.Y - 404);
                        }                        
                    }             
                }
            }
            CheckBtnIndex = btn.TabIndex;
            trvMenu.Location = new Point(0, btn.Location.Y + 33);
            CreateMenuTree(btn.Text.Trim());
        }
        private void CreateMenuTree(string ParentMenu)
        {
            trvMenu.Nodes.Clear();
            List<MenuTreeVo> childMenu = (from item in menuList
                                          where item.Parent_Screen_Code == ParentMenu
                                          select item).ToList();
            trvMenu.Nodes.Add(ParentMenu);
            foreach (MenuTreeVo item in childMenu)
            {
                trvMenu.Nodes[0].Nodes.Add(item.Screen_Code);
            }
            trvMenu.ExpandAll();
        }       
    }
}
