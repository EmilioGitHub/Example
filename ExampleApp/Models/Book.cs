namespace ExampleApp.Models
{
    public class Book : Product
    {
        public string Author { get; set; }
        public uint NumberOfPages { get; set; }
        public static uint NumberOfBooks{get;set;}
        public Book() : base()
        {
            this.Author = "";
            this.NumberOfPages = default(uint);
        }
        public Book(string name, string desc, uint price, string author, uint pages):base( name, desc, price)
        {
            this.Author = author;
            this.NumberOfPages = pages;
        }
        public override void Info()
        {
            throw new System.NotImplementedException();
        }
    }
}