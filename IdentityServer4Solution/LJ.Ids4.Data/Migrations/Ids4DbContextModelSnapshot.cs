﻿// <auto-generated />
using System;
using LJ.Ids4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LJ.Ids4.Data.Migrations
{
    [DbContext(typeof(Ids4DbContext))]
    partial class Ids4DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Clients.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

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

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("clients");
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Clients.ClientClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("clientclaims");
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Clients.ClientCorsOrigin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("clientcorsorigins");
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Clients.ClientGrantType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<string>("GrantType")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("clientgranttypes");
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Clients.ClientIdPRestriction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("clientidprestrictions");
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Clients.ClientPostLogoutRedirectUri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<string>("PostLogoutRedirectUri")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("clientpostlogoutredirecturis");
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Clients.ClientProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("clientpropertys");
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Clients.ClientRedirectUri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<string>("RedirectUri")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("clientredirecturis");
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Clients.ClientScope", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<string>("Scope")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("clientscopes");
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Clients.ClientSecret", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

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

                    b.ToTable("clientsecrets");
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Resources.ApiResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

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

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("apiresources");
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Resources.ApiResourceClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApiResourceId");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ApiResourceId");

                    b.ToTable("apiresourceclaims");
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Resources.ApiResourceProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApiResourceId");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("ApiResourceId");

                    b.ToTable("apiresourcepropertys");
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Resources.ApiScope", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

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

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("apiscopes");
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Resources.ApiScopeClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApiScopeId");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ApiScopeId");

                    b.ToTable("apiscopeclaims");
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Resources.ApiSecret", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

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

                    b.ToTable("apisecrets");
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Resources.IdentityClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdentityResourceId");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("IdentityResourceId");

                    b.ToTable("identityclaims");
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Resources.IdentityResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

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

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("identityresources");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2020, 4, 14, 5, 57, 6, 226, DateTimeKind.Utc).AddTicks(4135),
                            DisplayName = "OpenId",
                            Emphasize = false,
                            Enabled = true,
                            Name = "openid",
                            NonEditable = false,
                            Required = false,
                            ShowInDiscoveryDocument = true
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2020, 4, 14, 5, 57, 6, 226, DateTimeKind.Utc).AddTicks(6826),
                            DisplayName = "Profile",
                            Emphasize = false,
                            Enabled = true,
                            Name = "profile",
                            NonEditable = false,
                            Required = false,
                            ShowInDiscoveryDocument = true
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2020, 4, 14, 5, 57, 6, 226, DateTimeKind.Utc).AddTicks(6849),
                            DisplayName = "Email",
                            Emphasize = false,
                            Enabled = true,
                            Name = "email",
                            NonEditable = false,
                            Required = false,
                            ShowInDiscoveryDocument = true
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2020, 4, 14, 5, 57, 6, 226, DateTimeKind.Utc).AddTicks(6849),
                            DisplayName = "Address",
                            Emphasize = false,
                            Enabled = true,
                            Name = "address",
                            NonEditable = false,
                            Required = false,
                            ShowInDiscoveryDocument = true
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2020, 4, 14, 5, 57, 6, 226, DateTimeKind.Utc).AddTicks(6855),
                            DisplayName = "Phone",
                            Emphasize = false,
                            Enabled = true,
                            Name = "phone",
                            NonEditable = false,
                            Required = false,
                            ShowInDiscoveryDocument = true
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(2020, 4, 14, 5, 57, 6, 226, DateTimeKind.Utc).AddTicks(6855),
                            DisplayName = "OfflineAccess",
                            Emphasize = false,
                            Enabled = true,
                            Name = "offline_access",
                            NonEditable = false,
                            Required = false,
                            ShowInDiscoveryDocument = true
                        });
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Resources.IdentityResourceProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdentityResourceId");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("IdentityResourceId");

                    b.ToTable("identityresourcepropertys");
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Clients.ClientClaim", b =>
                {
                    b.HasOne("LJ.Ids4.Core.Domain.Clients.Client", "Client")
                        .WithMany("ClientClaims")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Clients.ClientCorsOrigin", b =>
                {
                    b.HasOne("LJ.Ids4.Core.Domain.Clients.Client", "Client")
                        .WithMany("ClientCorsOrigins")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Clients.ClientGrantType", b =>
                {
                    b.HasOne("LJ.Ids4.Core.Domain.Clients.Client", "Client")
                        .WithMany("ClientGrantTypes")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Clients.ClientIdPRestriction", b =>
                {
                    b.HasOne("LJ.Ids4.Core.Domain.Clients.Client", "Client")
                        .WithMany("ClientIdPRestrictions")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Clients.ClientPostLogoutRedirectUri", b =>
                {
                    b.HasOne("LJ.Ids4.Core.Domain.Clients.Client", "Client")
                        .WithMany("ClientPostLogoutRedirectUris")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Clients.ClientProperty", b =>
                {
                    b.HasOne("LJ.Ids4.Core.Domain.Clients.Client", "Client")
                        .WithMany("ClientProperties")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Clients.ClientRedirectUri", b =>
                {
                    b.HasOne("LJ.Ids4.Core.Domain.Clients.Client", "Client")
                        .WithMany("ClientRedirectUris")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Clients.ClientScope", b =>
                {
                    b.HasOne("LJ.Ids4.Core.Domain.Clients.Client", "Client")
                        .WithMany("ClientScopes")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Clients.ClientSecret", b =>
                {
                    b.HasOne("LJ.Ids4.Core.Domain.Clients.Client", "Client")
                        .WithMany("ClientSecrets")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Resources.ApiResourceClaim", b =>
                {
                    b.HasOne("LJ.Ids4.Core.Domain.Resources.ApiResource", "ApiResource")
                        .WithMany("ApiResourceClaims")
                        .HasForeignKey("ApiResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Resources.ApiResourceProperty", b =>
                {
                    b.HasOne("LJ.Ids4.Core.Domain.Resources.ApiResource", "ApiResource")
                        .WithMany("ApiResourceProperties")
                        .HasForeignKey("ApiResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Resources.ApiScope", b =>
                {
                    b.HasOne("LJ.Ids4.Core.Domain.Resources.ApiResource", "ApiResource")
                        .WithMany("ApiScopes")
                        .HasForeignKey("ApiResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Resources.ApiScopeClaim", b =>
                {
                    b.HasOne("LJ.Ids4.Core.Domain.Resources.ApiScope", "ApiScope")
                        .WithMany("ApiScopeClaims")
                        .HasForeignKey("ApiScopeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Resources.ApiSecret", b =>
                {
                    b.HasOne("LJ.Ids4.Core.Domain.Resources.ApiResource", "ApiResource")
                        .WithMany("ApiSecrets")
                        .HasForeignKey("ApiResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Resources.IdentityClaim", b =>
                {
                    b.HasOne("LJ.Ids4.Core.Domain.Resources.IdentityResource", "IdentityResource")
                        .WithMany("IdentityClaims")
                        .HasForeignKey("IdentityResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LJ.Ids4.Core.Domain.Resources.IdentityResourceProperty", b =>
                {
                    b.HasOne("LJ.Ids4.Core.Domain.Resources.IdentityResource", "IdentityResource")
                        .WithMany("IdentityResourceProperties")
                        .HasForeignKey("IdentityResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
