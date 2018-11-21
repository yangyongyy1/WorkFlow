using System;
using System.Collections.Generic;
using System.Text;
using Entitys;
namespace IDomain
{
    public interface ISysMenuDomian
    {
        SysMenu GetModal(string id);
        void UpdateModal(SysMenu entity);
    }
}
