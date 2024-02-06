using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Migrations
{
    [Migration(202402062339)]
    public class _202402062339_AddTableUser : Migration
    {
        public override void Up()
        {
            Create.Table("Users")
                .WithColumn("Id").AsInt32().PrimaryKey()
                .WithColumn("Name").AsString(50).NotNullable()
                .WithColumn("Email").AsString(50).Nullable()
                .WithColumn("CreateAt").AsDateTime().NotNullable();
        }
        public override void Down()
        {
            Delete.Table("Users");
        }

    }
}
