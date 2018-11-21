using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entitys
{
    //系统菜单
    [Serializable]
    [Table("SysMenu")]
    public  class SysMenu
    {
        [Key]
        /// <summary>
        /// 菜单编号
        /// </summary>		
        public string MenuID
        {
            get; set;
        }
        /// <summary>
        /// 递归编号
        /// </summary>
        public string SearchCode { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>		
        public string MenuName
        {
            get; set;
        }
        /// <summary>
        /// 上级菜单
        /// </summary>		
        public string ParentID
        {
            get; set;
        }
        /// <summary>
        /// 是否有子级
        /// </summary>		
        public bool? HasSub
        {
            get; set;
        }
        /// <summary>
        /// Area
        /// </summary>		
        public string Area
        {
            get; set;
        }
        /// <summary>
        /// Controller
        /// </summary>		
        public string Controller
        {
            get; set;
        }
        /// <summary>
        /// Action
        /// </summary>		
        public string Operation
        {
            get; set;
        }
        /// <summary>
        /// URL
        /// </summary>		
        public string Url
        {
            get; set;
        }
        /// <summary>
        /// 程序集
        /// </summary>		
        public string AssemblyPath
        {
            get; set;
        }
        /// <summary>
        /// 图标
        /// </summary>		
        public string ClsIcon
        {
            get; set;
        }
        /// <summary>
        /// 快捷键
        /// </summary>		
        public string ShortCut
        {
            get; set;
        }
        /// <summary>
        /// 排序号
        /// </summary>		
        public int? Orders
        {
            get; set;
        }
        /// <summary>
        /// 是否是客户端功能
        /// </summary>		
        public bool? IsCS
        {
            get; set;
        }
        /// <summary>
        /// 是否是Web端功能
        /// </summary>		
        public bool? IsWeb
        {
            get; set;
        }
        /// <summary>
        /// 是否允许锁定
        /// </summary>		
        public bool? IsAllowLock
        {
            get; set;
        }
        /// <summary>
        /// 创建时间
        /// </summary>		
        public DateTime? CreateDate
        {
            get; set;
        }
        /// <summary>
        /// 创建人
        /// </summary>		
        public string CreateBy
        {
            get; set;
        }
        /// <summary>
        /// 修改时间
        /// </summary>		
        public DateTime? UpdateDate
        {
            get; set;
        }
        /// <summary>
        /// 修改人
        /// </summary>		
        public string UpdateBy
        {
            get; set;
        }
        /// <summary>
        /// 状态
        /// </summary>		
        public int? Status
        {
            get; set;
        }
        /// <summary>
        /// 页面显示标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 菜单类型
        /// </summary>
        public string MenuCategory { get; set; }
    }
}
