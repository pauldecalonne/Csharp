using System;
namespace pdcCsharpeV2
{


    /**
    class Book
    {
        public string title;
        public string author;
        private string pages;
        public static int songCount = 0;
        //private: only code inside the class can change pages
        public Book(string aTitle, string aAuthor, string aPages)
        {
            title = aTitle;
            author = aAuthor;
            Pages = aPages;
            songCount++;
        }

        public int getSongCount()
        {
            return songCount;
        }

        public string Pages
        {
            get { return pages; }
            set {
                if (value == "G" || value == "PG")
                {
                    pages = value;
                }
                else
                {
                    pages = "NR";
                }
            }
        }

        /**
        public bool HasHonors()
        {
            if(pages> 500)
            {
                return true;
            }
            return false;
        }
        



}
    */
    static class UsefulTools
    {
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello" + name);
        }
    }
}
