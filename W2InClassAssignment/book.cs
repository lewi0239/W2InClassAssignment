
namespace W2InClassAssignment
{
    class Book
    {
        public string title { get; set; }
        public string author{ get; set; }
        public string yearPublished { get; set; }

        public Book(string title, string author, string yearPublished)
        {
            this.title = title;
            this.author = author;
            this.yearPublished = yearPublished;
        }
        
        public void DisplayInfo()
        {
            Console.WriteLine($"""
                               {title}
                               {author}
                               {yearPublished}
                               """
                );

        }
     
    }
}