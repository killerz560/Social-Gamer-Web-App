using System;
using System.Collections.Generic;
using System.IO;

namespace GamersForums.Models
{
    class ForumArticleRepository : List<ForumArticle>
    {
        private string rootPath;
        private string forumFile;

        public ForumArticleRepository(string rootPath, string forumFile)
        {
            this.rootPath = rootPath;
            this.forumFile = forumFile;
            GetAllForumArticles(false);
        }

        public void GetAllForumArticles(bool? forceReload)
        {
            if (this.Count == 0 || (forceReload == true))
            {
                this.Clear();
                LoadForumArticlesFromDataStore();
            }
        }

        private void LoadForumArticlesFromDataStore()
        {
            string[] allLines = File.ReadAllLines(Path.Combine(rootPath, forumFile));
            foreach (string line in allLines)
            {
                try
                {
                    string[] allItems = line.Split('|');

                    ForumArticle ba = new ForumArticle();
                    ba.Id = Convert.ToInt32(allItems[0]); //id 1; newest first (top of file)
                    ba.Title = allItems[1]; // "Looking for new clan!";
                    ba.Category = allItems[2]; //"Battlefield 4";
                    ba.RelativeFilePath = allItems[3];// "GamerForum1.htm";
                    ba.Created = DateTime.Parse(allItems[4]); // 2019-02-4
                    this.Add(ba);
                }
                finally
                {
                    // if any fail, just move to the next one
                    // do not stop the app for any reason!
                }
            }
        }

    }
}