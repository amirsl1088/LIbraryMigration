using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Migrations
{
    [Migration(202402062108)]
    public class _202402062108_AddTableWriter : Migration
    {
        public override void Up()
        {
            Create.Table("Writers")
                .WithColumn("Id").AsInt32().PrimaryKey()
                .WithColumn("Name").AsString(50).NotNullable();
        }
        public override void Down()
        {
            Delete.Table("Writers");
        }

    }
}
