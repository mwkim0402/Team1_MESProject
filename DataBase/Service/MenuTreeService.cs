﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class MenuTreeService
    {
        public List<MenuTreeVo> GetAllMenu()
        {
            MenuTreeDac dac = new MenuTreeDac();
            return dac.GetAllMenu();
        }
    }
}
