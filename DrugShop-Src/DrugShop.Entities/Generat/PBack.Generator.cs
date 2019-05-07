﻿#region AgileEAS.NET-generated
//------------------------------------------------------------------------------
//     AgileEAS.NET应用开发平台，是基于敏捷并行开发思想以及.NET构件技术而开发的一个应用系统快速开发平台，用于帮助中小软件企业
//建立一条适合快速变化的开发团队，以达到节省开发成本、缩短开发时间，快速适应市场变化的目的。
//     AgileEAS.NET应用开发平台包含基础类库、资源管理平台、运行容器、开发辅助工具等四大部分，资源管理平台为敏捷并行开发提供了
//设计、实现、测试等开发过程的并行，应用系统的各个业务功能子系统，在系统体系结构设计的过程中被设计成各个原子功能模块，各个子
//功能模块按照业务功能组织成单独的程序集文件，各子系统开发完成后，由AgileEAS.NET资源管理平台进行统一的集成部署。
//
//     AgileEAS.NET SOA 中间件平台是一套免费的快速开发工具，可以不受限制的用于各种非商业开发之中，商业应用请向作者获取商业授权，
//商业授权也是免费的，但是对于非授权的商业应用视为侵权，开发人员可以参考官方网站和博客园等专业网站获取公开的技术资料，也可以向
//AgileEAS.NET官方团队请求技术支持。
//
// 官方网站：http://www.smarteas.net
// 团队网站：http://www.agilelab.cn
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由AgileEAS.NET数据模型设计工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
#endregion

using System;
using System.Linq;
using System.ComponentModel;
using System.Data;
using EAS.Data;
using EAS.Data.Access;
using EAS.Data.ORM;
using EAS.Data.Linq;
using System.Runtime.Serialization;

namespace DrugShop.Entities
{
   /// <summary>
   /// 实体对象 PBack(供应商退货)。
   /// </summary>
   [Serializable()]
   [Table("DS_RPBACK","供应商退货")]
   partial class PBack: DataEntity<PBack>, IDataEntity<PBack>
   {
       public PBack()
       {
       }
       
       protected PBack(SerializationInfo info, StreamingContext context)
           : base(info, context)
       {
       }
       
       #region O/R映射成员

       /// <summary>
       /// 记录ID,大于0的32位整数 。
       /// </summary>
       [Column("ID","记录ID,大于0的32位整数"),DataSize(10),PrimaryKey]
       [DisplayName("记录ID,大于0的32位整数")]
       public int Id
       {
           get;
           set;
       }

       /// <summary>
       /// Code 。
       /// </summary>
       [Column("CODE","Code"),DataSize(16)]
       [DisplayName("Code")]
       public string Code
       {
           get;
           set;
       }

       /// <summary>
       /// 药品ID 。
       /// </summary>
       [Column("DrugID","药品ID"),DataSize(32)]
       [DisplayName("药品ID")]
       public string DrugID
       {
           get;
           set;
       }

       /// <summary>
       /// 中文名称 。
       /// </summary>
       [Column("CName","中文名称"),DataSize(64)]
       [DisplayName("中文名称")]
       public string ChinseName
       {
           get;
           set;
       }

       /// <summary>
       /// 药品规格 。
       /// </summary>
       [Column("SPEC","药品规格"),DataSize(32)]
       [DisplayName("药品规格")]
       public string Spec
       {
           get;
           set;
       }

       /// <summary>
       /// 大包装 。
       /// </summary>
       [Column("UNIT","大包装"),DataSize(16)]
       [DisplayName("大包装")]
       public string Unit
       {
           get;
           set;
       }

       /// <summary>
       /// 药品分装规则 。
       /// </summary>
       [Column("PACKRULE","药品分装规则"),DataSize(10)]
       [DisplayName("药品分装规则")]
       public int Packrule
       {
           get;
           set;
       }

       /// <summary>
       /// 药品批发价格 。
       /// </summary>
       [Column("JobPrice","药品批发价格"),DataSize(18,4)]
       [DisplayName("药品批发价格")]
       public decimal JobPrice
       {
           get;
           set;
       }

       /// <summary>
       /// 药品销售价格 。
       /// </summary>
       [Column("SalePrice","药品销售价格"),DataSize(18,4)]
       [DisplayName("药品销售价格")]
       public decimal SalePrice
       {
           get;
           set;
       }

       /// <summary>
       /// 退货数量 。
       /// </summary>
       [Column("NUMBER","退货数量"),DataSize(10)]
       [DisplayName("退货数量")]
       public int Number
       {
           get;
           set;
       }

       /// <summary>
       /// 药品类型 。
       /// </summary>
       [Column("TYPE","药品类型"),DataSize(10)]
       [DisplayName("药品类型")]
       public int Type
       {
           get;
           set;
       }

       /// <summary>
       /// 药品批号 。
       /// </summary>
       [Column("BatchID","药品批号"),DataSize(64)]
       [DisplayName("药品批号")]
       public string BatchID
       {
           get;
           set;
       }

       /// <summary>
       /// 药品效期 。
       /// </summary>
       [Column("TimeLimit","药品效期"),DataSize(23,3)]
       [DisplayName("药品效期")]
       public DateTime TimeLimit
       {
           get;
           set;
       }

       /// <summary>
       /// 退药日期 。
       /// </summary>
       [Column("EventTime","退药日期"),DataSize(23,3)]
       [DisplayName("退药日期")]
       public DateTime EventTime
       {
           get;
           set;
       }

       /// <summary>
       /// 供应商 。
       /// </summary>
       [Column("PROVIDER","供应商"),DataSize(50)]
       [DisplayName("供应商")]
       public string Provider
       {
           get;
           set;
       }

       /// <summary>
       /// 输入码1 。
       /// </summary>
       [Column("InputCode1","输入码1"),DataSize(64)]
       [DisplayName("输入码1")]
       public string InputCode1
       {
           get;
           set;
       }
       
       #endregion
   }
}
