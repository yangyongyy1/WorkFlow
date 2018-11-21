using System;
using System.Collections.Generic;
using System.Text;
using Entitys;
using IDomain;
using IRepositore;
namespace Domain
{
    public class SysMenu : ISysMenuDomian
    {
        private ISysmenuRepositore  _SysmenuRepositore;
        public SysMenu(ISysmenuRepositore sysmenuRepositore)
        {
            _SysmenuRepositore = sysmenuRepositore;
        }
        public Entitys.SysMenu GetModal(string id)
        {
            return _SysmenuRepositore.GetModel(id);
        }
    }
}
