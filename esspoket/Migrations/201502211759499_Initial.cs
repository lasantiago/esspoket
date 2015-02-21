namespace esspocketORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountAddresses",
                c => new
                    {
                        AccountAddressId = c.Guid(nullable: false),
                        AccountId = c.Guid(nullable: false),
                        AddressLine1 = c.String(nullable: false),
                        AddressLine2 = c.String(),
                        Building = c.String(),
                        PremiseNumber = c.String(),
                        LocalityId = c.Guid(nullable: false),
                        Postcode = c.String(),
                        IsAddressActive = c.Boolean(nullable: false),
                        IsAddressAproved = c.Boolean(nullable: false),
                        IsPrimaryAccountAddress = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AccountAddressId)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .ForeignKey("dbo.Localities", t => t.LocalityId, cascadeDelete: true)
                .Index(t => t.AccountId)
                .Index(t => t.LocalityId);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountId = c.Guid(nullable: false),
                        AccountTypeId = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Password = c.String(),
                        PersonalDocumentId = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        GenderId = c.Guid(nullable: false),
                        Photo = c.Binary(),
                        Pin = c.String(),
                        TransactionSigningPin = c.String(),
                        AccountCreationDate = c.DateTime(nullable: false),
                        BusinessName = c.String(),
                        BusinessAccountId = c.Guid(nullable: false),
                        TaxId = c.String(),
                        LanguageId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.AccountId)
                .ForeignKey("dbo.AccountTypes", t => t.AccountTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Genders", t => t.GenderId, cascadeDelete: true)
                .ForeignKey("dbo.Languages", t => t.LanguageId, cascadeDelete: true)
                .Index(t => t.AccountTypeId)
                .Index(t => t.GenderId)
                .Index(t => t.LanguageId);
            
            CreateTable(
                "dbo.AccountEmails",
                c => new
                    {
                        AccountEmailId = c.Guid(nullable: false),
                        AccountId = c.Guid(nullable: false),
                        Email = c.String(nullable: false),
                        IsAccountEmailActive = c.Boolean(nullable: false),
                        IsAccountEmailValidated = c.Boolean(nullable: false),
                        IsPrimaryAccountEmail = c.Boolean(nullable: false),
                        EmailType_EmailTypeID = c.Int(),
                    })
                .PrimaryKey(t => t.AccountEmailId)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .ForeignKey("dbo.EmailTypes", t => t.EmailType_EmailTypeID)
                .Index(t => t.AccountId)
                .Index(t => t.EmailType_EmailTypeID);
            
            CreateTable(
                "dbo.EmailTypes",
                c => new
                    {
                        EmailTypeID = c.Int(nullable: false, identity: true),
                        EmailTypeName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EmailTypeID);
            
            CreateTable(
                "dbo.AccountPhones",
                c => new
                    {
                        AccountPhoneId = c.Guid(nullable: false),
                        AccountId = c.Guid(nullable: false),
                        AccountPhoneNumber = c.String(nullable: false),
                        IsAccountPhoneNumberActive = c.Boolean(nullable: false),
                        IsAccountPhoneNumberValidated = c.Boolean(nullable: false),
                        IsAccountPrimaryPhoneNumber = c.Boolean(nullable: false),
                        PhoneType_PhoneTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AccountPhoneId)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .ForeignKey("dbo.PhoneTypes", t => t.PhoneType_PhoneTypeId, cascadeDelete: true)
                .Index(t => t.AccountId)
                .Index(t => t.PhoneType_PhoneTypeId);
            
            CreateTable(
                "dbo.PhoneTypes",
                c => new
                    {
                        PhoneTypeId = c.Int(nullable: false, identity: true),
                        PhoneTypeName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PhoneTypeId);
            
            CreateTable(
                "dbo.AccountTypes",
                c => new
                    {
                        AccountTypeId = c.Guid(nullable: false),
                        AccountTypeName = c.String(nullable: false, maxLength: 10),
                        DateEntered = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        CreatedByUserId = c.Guid(nullable: false),
                        ModifiedByUserId = c.Guid(nullable: false),
                        AssignedToUserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.AccountTypeId);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        GenderId = c.Guid(nullable: false),
                        GenderName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.GenderId);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        LanguageId = c.Guid(nullable: false),
                        ISO6391 = c.String(nullable: false),
                        LanguageName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.LanguageId);
            
            CreateTable(
                "dbo.Localities",
                c => new
                    {
                        LocalityId = c.Guid(nullable: false),
                        LocalityName = c.String(nullable: false, maxLength: 50),
                        RegionId = c.Guid(nullable: false),
                        DateEntered = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        CreatedByUserId = c.Guid(nullable: false),
                        ModifiedByUserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.LocalityId)
                .ForeignKey("dbo.Regions", t => t.RegionId, cascadeDelete: true)
                .Index(t => t.RegionId);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        RegionId = c.Guid(nullable: false),
                        RegionName = c.String(nullable: false, maxLength: 50),
                        CountryId = c.Guid(nullable: false),
                        DateEntered = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        CreatedByUserId = c.Guid(nullable: false),
                        ModifiedByUserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.RegionId)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Guid(nullable: false),
                        CountryName = c.String(nullable: false, maxLength: 50),
                        DateEntered = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        CreatedByUserId = c.Guid(nullable: false),
                        ModifiedByUserId = c.Guid(nullable: false),
                        AssignedToUserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.Banks",
                c => new
                    {
                        BankId = c.Int(nullable: false, identity: true),
                        BankName = c.String(nullable: false),
                        Locality_LocalityId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.BankId)
                .ForeignKey("dbo.Localities", t => t.Locality_LocalityId, cascadeDelete: true)
                .Index(t => t.Locality_LocalityId);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionId = c.Guid(nullable: false),
                        RelatedTransactionId = c.Guid(nullable: false),
                        TransactionDate = c.DateTime(nullable: false),
                        AccountId = c.Guid(nullable: false),
                        Details = c.String(nullable: false),
                        OriginalAmount = c.Double(nullable: false),
                        Fee = c.Double(nullable: false),
                        NetAmount = c.Double(nullable: false),
                        CurrentBalance = c.Double(nullable: false),
                        IsCurrentBalance = c.Boolean(nullable: false),
                        TransactionStatus_TransactionStatusId = c.Int(nullable: false),
                        TransactionType_TransactionTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionId)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .ForeignKey("dbo.TransactionStatus", t => t.TransactionStatus_TransactionStatusId, cascadeDelete: true)
                .ForeignKey("dbo.TransactionTypes", t => t.TransactionType_TransactionTypeId, cascadeDelete: true)
                .Index(t => t.AccountId)
                .Index(t => t.TransactionStatus_TransactionStatusId)
                .Index(t => t.TransactionType_TransactionTypeId);
            
            CreateTable(
                "dbo.TransactionStatus",
                c => new
                    {
                        TransactionStatusId = c.Int(nullable: false, identity: true),
                        TransactionStatusName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionStatusId);
            
            CreateTable(
                "dbo.TransactionTypes",
                c => new
                    {
                        TransactionTypeId = c.Int(nullable: false, identity: true),
                        TransactionTypeName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionTypeId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "TransactionType_TransactionTypeId", "dbo.TransactionTypes");
            DropForeignKey("dbo.Transactions", "TransactionStatus_TransactionStatusId", "dbo.TransactionStatus");
            DropForeignKey("dbo.Transactions", "AccountId", "dbo.Accounts");
            DropForeignKey("dbo.Banks", "Locality_LocalityId", "dbo.Localities");
            DropForeignKey("dbo.AccountAddresses", "LocalityId", "dbo.Localities");
            DropForeignKey("dbo.Localities", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.Regions", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.AccountAddresses", "AccountId", "dbo.Accounts");
            DropForeignKey("dbo.Accounts", "LanguageId", "dbo.Languages");
            DropForeignKey("dbo.Accounts", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.Accounts", "AccountTypeId", "dbo.AccountTypes");
            DropForeignKey("dbo.AccountPhones", "PhoneType_PhoneTypeId", "dbo.PhoneTypes");
            DropForeignKey("dbo.AccountPhones", "AccountId", "dbo.Accounts");
            DropForeignKey("dbo.AccountEmails", "EmailType_EmailTypeID", "dbo.EmailTypes");
            DropForeignKey("dbo.AccountEmails", "AccountId", "dbo.Accounts");
            DropIndex("dbo.Transactions", new[] { "TransactionType_TransactionTypeId" });
            DropIndex("dbo.Transactions", new[] { "TransactionStatus_TransactionStatusId" });
            DropIndex("dbo.Transactions", new[] { "AccountId" });
            DropIndex("dbo.Banks", new[] { "Locality_LocalityId" });
            DropIndex("dbo.Regions", new[] { "CountryId" });
            DropIndex("dbo.Localities", new[] { "RegionId" });
            DropIndex("dbo.AccountPhones", new[] { "PhoneType_PhoneTypeId" });
            DropIndex("dbo.AccountPhones", new[] { "AccountId" });
            DropIndex("dbo.AccountEmails", new[] { "EmailType_EmailTypeID" });
            DropIndex("dbo.AccountEmails", new[] { "AccountId" });
            DropIndex("dbo.Accounts", new[] { "LanguageId" });
            DropIndex("dbo.Accounts", new[] { "GenderId" });
            DropIndex("dbo.Accounts", new[] { "AccountTypeId" });
            DropIndex("dbo.AccountAddresses", new[] { "LocalityId" });
            DropIndex("dbo.AccountAddresses", new[] { "AccountId" });
            DropTable("dbo.Users");
            DropTable("dbo.TransactionTypes");
            DropTable("dbo.TransactionStatus");
            DropTable("dbo.Transactions");
            DropTable("dbo.Banks");
            DropTable("dbo.Countries");
            DropTable("dbo.Regions");
            DropTable("dbo.Localities");
            DropTable("dbo.Languages");
            DropTable("dbo.Genders");
            DropTable("dbo.AccountTypes");
            DropTable("dbo.PhoneTypes");
            DropTable("dbo.AccountPhones");
            DropTable("dbo.EmailTypes");
            DropTable("dbo.AccountEmails");
            DropTable("dbo.Accounts");
            DropTable("dbo.AccountAddresses");
        }
    }
}
