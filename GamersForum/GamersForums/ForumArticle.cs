using System;

namespace GamersForums.Models
{
    public class ForumArticle
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string relativeFilePath;

        public string RelativeFilePath
        {
            get { return relativeFilePath; }
            set { relativeFilePath = value; }
        }
        private DateTime created;

        public DateTime Created
        {
            get { return created; }
            set { created = value; }
        }
    }
}