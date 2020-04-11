﻿using LJ.Ids4.Core.Domain.Clients;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LJ.Ids4.Data.Mapping.Clients
{
    public class ClientPostLogoutRedirectUriMap : IEntityTypeConfiguration<ClientPostLogoutRedirectUri>
    {
        public void Configure(EntityTypeBuilder<ClientPostLogoutRedirectUri> builder)
        {
            builder.ToTable("clientpostlogoutredirecturis");
            builder.HasKey(k => k.Id);
            builder.Property(p => p.PostLogoutRedirectUri).HasMaxLength(2000).IsRequired();
        }
    }
}