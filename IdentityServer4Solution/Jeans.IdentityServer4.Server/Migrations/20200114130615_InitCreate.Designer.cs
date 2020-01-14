﻿// <auto-generated />
using System;
using Jeans.IdentityServer4.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Jeans.IdentityServer4.Server.Migrations
{
    [DbContext(typeof(IdentityServerDbContext))]
    [Migration("20200114130615_InitCreate")]
    partial class InitCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ApiResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AllowedAccessTokenSigningAlgorithms")
                        .HasMaxLength(100);

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<string>("DisplayName")
                        .HasMaxLength(200);

                    b.Property<bool>("Enabled");

                    b.Property<DateTime?>("LastAccessed");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("NonEditable");

                    b.Property<DateTime?>("Updated");

                    b.HasKey("Id");

                    b.ToTable("ApiResources");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ApiResourceClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApiResourceId");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ApiResourceId");

                    b.ToTable("ApiResourceClaims");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ApiResourceProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApiResourceId");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("ApiResourceId");

                    b.ToTable("ApiResourceProperties");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ApiScope", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApiResourceId");

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<string>("DisplayName")
                        .HasMaxLength(200);

                    b.Property<bool>("Emphasize");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("Required");

                    b.Property<bool>("ShowInDiscoveryDocument");

                    b.HasKey("Id");

                    b.HasIndex("ApiResourceId");

                    b.ToTable("ApiScopes");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ApiScopeClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApiScopeId");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ApiScopeId");

                    b.ToTable("ApiScopeClaims");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ApiSecret", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApiResourceId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<DateTime?>("Expiration");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(4000);

                    b.HasKey("Id");

                    b.HasIndex("ApiResourceId");

                    b.ToTable("ApiSecrets");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AbsoluteRefreshTokenLifetime");

                    b.Property<int>("AccessTokenLifetime");

                    b.Property<int>("AccessTokenType");

                    b.Property<bool>("AllowAccessTokensViaBrowser");

                    b.Property<bool>("AllowOfflineAccess");

                    b.Property<bool>("AllowPlainTextPkce");

                    b.Property<bool>("AllowRememberConsent");

                    b.Property<string>("AllowedIdentityTokenSigningAlgorithms")
                        .HasMaxLength(100);

                    b.Property<bool>("AlwaysIncludeUserClaimsInIdToken");

                    b.Property<bool>("AlwaysSendClientClaims");

                    b.Property<int>("AuthorizationCodeLifetime");

                    b.Property<bool>("BackChannelLogoutSessionRequired");

                    b.Property<string>("BackChannelLogoutUri")
                        .HasMaxLength(2000);

                    b.Property<string>("ClientClaimsPrefix")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ClientName")
                        .HasMaxLength(200);

                    b.Property<string>("ClientUri")
                        .HasMaxLength(2000);

                    b.Property<int?>("ConsentLifetime");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<int>("DeviceCodeLifetime");

                    b.Property<bool>("EnableLocalLogin");

                    b.Property<bool>("Enabled");

                    b.Property<bool>("FrontChannelLogoutSessionRequired");

                    b.Property<string>("FrontChannelLogoutUri")
                        .HasMaxLength(2000);

                    b.Property<int>("IdentityTokenLifetime");

                    b.Property<bool>("IncludeJwtId");

                    b.Property<DateTime?>("LastAccessed");

                    b.Property<string>("LogoUri")
                        .HasMaxLength(2000);

                    b.Property<bool>("NonEditable");

                    b.Property<string>("PairWiseSubjectSalt")
                        .HasMaxLength(200);

                    b.Property<string>("ProtocolType")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("RefreshTokenExpiration");

                    b.Property<int>("RefreshTokenUsage");

                    b.Property<bool>("RequireClientSecret");

                    b.Property<bool>("RequireConsent");

                    b.Property<bool>("RequirePkce");

                    b.Property<int>("SlidingRefreshTokenLifetime");

                    b.Property<bool>("UpdateAccessTokenClaimsOnRefresh");

                    b.Property<DateTime?>("Updated");

                    b.Property<string>("UserCodeType")
                        .HasMaxLength(100);

                    b.Property<int?>("UserSsoLifetime");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ClientClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientClaims");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ClientCorsOrigin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientCorsOrigins");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ClientGrantType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<string>("GrantType")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientGrantTypes");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ClientIdPRestriction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientIdPRestrictions");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ClientPostLogoutRedirectUri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<string>("PostLogoutRedirectUri")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientPostLogoutRedirectUris");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ClientProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientProperties");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ClientRedirectUri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<string>("RedirectUri")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientRedirectUris");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ClientScope", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<string>("Scope")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientScopes");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ClientSecret", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description")
                        .HasMaxLength(2000);

                    b.Property<DateTime?>("Expiration");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(4000);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientSecrets");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.DeviceFlowCode", b =>
                {
                    b.Property<string>("UserCode")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Data")
                        .IsRequired();

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime?>("Expiration");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200);

                    b.HasKey("UserCode");

                    b.ToTable("DeviceFlowCodes");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.IdentityClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdentityResourceId");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("IdentityResourceId");

                    b.ToTable("IdentityClaims");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.IdentityResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<string>("DisplayName")
                        .HasMaxLength(200);

                    b.Property<bool>("Emphasize");

                    b.Property<bool>("Enabled");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("NonEditable");

                    b.Property<bool>("Required");

                    b.Property<bool>("ShowInDiscoveryDocument");

                    b.Property<DateTime?>("Updated");

                    b.HasKey("Id");

                    b.ToTable("IdentityResources");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.IdentityResourceProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdentityResourceId");

                    b.Property<int>("Key")
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("IdentityResourceId");

                    b.ToTable("IdentityResourceProperties");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Data")
                        .IsRequired();

                    b.Property<DateTime?>("Expiration");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Key");

                    b.ToTable("PersistedGrants");
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ApiResourceClaim", b =>
                {
                    b.HasOne("Jeans.IdentityServer4.Server.Core.Entity.ApiResource", "ApiResource")
                        .WithMany("ApiResourceClaims")
                        .HasForeignKey("ApiResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ApiResourceProperty", b =>
                {
                    b.HasOne("Jeans.IdentityServer4.Server.Core.Entity.ApiResource", "ApiResource")
                        .WithMany("ApiResourceProperties")
                        .HasForeignKey("ApiResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ApiScope", b =>
                {
                    b.HasOne("Jeans.IdentityServer4.Server.Core.Entity.ApiResource", "ApiResource")
                        .WithMany("ApiScopes")
                        .HasForeignKey("ApiResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ApiScopeClaim", b =>
                {
                    b.HasOne("Jeans.IdentityServer4.Server.Core.Entity.ApiScope", "ApiScope")
                        .WithMany("ApiScopeClaims")
                        .HasForeignKey("ApiScopeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ApiSecret", b =>
                {
                    b.HasOne("Jeans.IdentityServer4.Server.Core.Entity.ApiResource", "ApiResource")
                        .WithMany("ApiSecrets")
                        .HasForeignKey("ApiResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ClientClaim", b =>
                {
                    b.HasOne("Jeans.IdentityServer4.Server.Core.Entity.Client", "Client")
                        .WithMany("ClientClaims")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ClientCorsOrigin", b =>
                {
                    b.HasOne("Jeans.IdentityServer4.Server.Core.Entity.Client", "Client")
                        .WithMany("ClientCorsOrigins")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ClientGrantType", b =>
                {
                    b.HasOne("Jeans.IdentityServer4.Server.Core.Entity.Client", "Client")
                        .WithMany("ClientGrantTypes")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ClientIdPRestriction", b =>
                {
                    b.HasOne("Jeans.IdentityServer4.Server.Core.Entity.Client", "Client")
                        .WithMany("ClientIdPRestrictions")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ClientPostLogoutRedirectUri", b =>
                {
                    b.HasOne("Jeans.IdentityServer4.Server.Core.Entity.Client", "Client")
                        .WithMany("ClientPostLogoutRedirectUris")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ClientProperty", b =>
                {
                    b.HasOne("Jeans.IdentityServer4.Server.Core.Entity.Client", "Client")
                        .WithMany("ClientProperties")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ClientRedirectUri", b =>
                {
                    b.HasOne("Jeans.IdentityServer4.Server.Core.Entity.Client", "Client")
                        .WithMany("ClientRedirectUris")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ClientScope", b =>
                {
                    b.HasOne("Jeans.IdentityServer4.Server.Core.Entity.Client", "Client")
                        .WithMany("ClientScopes")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.ClientSecret", b =>
                {
                    b.HasOne("Jeans.IdentityServer4.Server.Core.Entity.Client", "Client")
                        .WithMany("ClientSecrets")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.IdentityClaim", b =>
                {
                    b.HasOne("Jeans.IdentityServer4.Server.Core.Entity.IdentityResource", "IdentityResource")
                        .WithMany("IdentityClaims")
                        .HasForeignKey("IdentityResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Jeans.IdentityServer4.Server.Core.Entity.IdentityResourceProperty", b =>
                {
                    b.HasOne("Jeans.IdentityServer4.Server.Core.Entity.IdentityResource", "IdentityResource")
                        .WithMany("IdentityResourceProperties")
                        .HasForeignKey("IdentityResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
