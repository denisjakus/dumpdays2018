using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop.Model.Db
{
    public class Post
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Headline { get; set; }

        [MaxLength(250)]
        public string Text { get; set; }
    }
}
