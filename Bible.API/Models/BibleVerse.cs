namespace Bible.API.Models
{
    public class BibleVerse
    {
        string book;
        int chapter;
        int verse;
        string text;

        public string Book
        {
            get { return book; }
            set { book = value; }
        }
        public int Chapter
        {
            get { return chapter; }
            set { chapter = value; }
        }
        public int Verse
        {
            get { return verse; }
            set { verse = value; }
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

    }
}