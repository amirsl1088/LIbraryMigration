using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Migrations
{
    [Migration(202402062113)]
    public class _202402062113_AddTableBook : Migration
    {
        public override void Up()
        {
            Create.Table("Books")
                .WithColumn("Id").AsInt32().PrimaryKey()
                .WithColumn("Name").AsString(50).NotNullable()
                .WithColumn("Stock").AsInt32().WithDefaultValue(0)
                .WithColumn("GenreId").AsInt32().ForeignKey("FK_Books_Genres", "Genres","Id")
                .WithColumn("WriterId").AsInt32().ForeignKey("FK_Books_Writers", "Writers", "Id");

        }
        public override void Down()
        {
            throw new NotImplementedException();
        }

    }
}
