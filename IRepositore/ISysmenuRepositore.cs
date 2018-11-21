using System;
using System.Collections.Generic;
using System.Text;
using Entitys;

namespace IRepositore
{
   public interface ISysmenuRepositore
    {
        SysMenu GetModel(string id);
    }
}
