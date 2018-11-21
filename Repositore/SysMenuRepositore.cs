using System;
using System.Collections.Generic;
using System.Text;
using Entitys;
using IRepositore;

namespace Repositore
{
    public class SysMenuRepositore : ISysmenuRepositore
    {
        public SysMenu GetModel(string id)
        {
            return new SysMenu { MenuID="aaaaa", HasSub=true, MenuName="P00001"};
        }
    }
}
