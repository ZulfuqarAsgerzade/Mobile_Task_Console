namespace Net_News.Models
{
    public class Contact
    {
        private static int _id = 0;
        public int ID { get => _id; }
        public string FullName { get; set; }
        public string Number { get; set; }

        private Contact() 
        {
            _id++;
        }

        public Contact(string FullName, string Number) : this()
        {
            this.FullName = FullName;
            this.Number = Number;
        }
    }
}
