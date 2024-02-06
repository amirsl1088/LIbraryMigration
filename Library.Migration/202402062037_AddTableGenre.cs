using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Migrations
{
    [Migration(202402062037)]
    public class _202402062037_AddTableGenre : Migration
    {
        public override void Up()
        {
            Create.Table("Genres")
                .WithColumn("Id").AsInt32().PrimaryKey()
                .WithColumn("Name").AsString(50).NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Genres");
        }

    }
}

