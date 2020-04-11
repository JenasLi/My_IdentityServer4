﻿using System;

namespace LJ.Ids4.Core.Domain.Clients
{
    /// <summary>
    /// 客户秘钥
    /// </summary>
    public class ClientSecret : BaseEntity
    {
        public string Description { get; set; }
        public string Value { get; set; }
        public DateTime? Expiration { get; set; }
        public string Type { get; set; } = "SharedSecret";
        public DateTime Created { get; set; } = DateTime.UtcNow;

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}