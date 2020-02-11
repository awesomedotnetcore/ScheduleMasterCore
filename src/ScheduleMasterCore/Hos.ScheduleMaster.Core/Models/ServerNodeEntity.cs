﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hos.ScheduleMaster.Core.Models
{
    [Table("servernodes")]
    public class ServerNodeEntity : IEntity
    {
        /// <summary>
        /// 节点标识
        /// </summary>
        [Key]
        [Column("nodename")]
        public string NodeName { get; set; }

        /// <summary>
        /// 节点类型 master/worker
        /// </summary>
        [Required]
        [Column("nodetype")]
        public string NodeType { get; set; }

        /// <summary>
        /// 所在机器
        /// </summary>
        [Column("machinename")]
        public string MachineName { get; set; }

        /// <summary>
        /// 访问协议，http/https
        /// </summary>
        [Required]
        [Column("accessprotocol")]
        public string AccessProtocol { get; set; }

        /// <summary>
        /// 节点主机(IP+端口)
        /// </summary>
        [Required]
        [Column("host")]
        public string Host { get; set; }

        /// <summary>
        /// 访问秘钥，每次节点激活时会更新，用来验证访问权限
        /// </summary>
        [Column("accesssecret")]
        public string AccessSecret { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        [Column("lastupdatetime")]
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// 节点状态，0-下线，1-停机，2-运行
        /// </summary>
        [Column("status")]
        public int Status { get; set; }

        /// <summary>
        /// 权重
        /// </summary>
        [Column("priority")]
        public int Priority { get; set; }
    }
}
