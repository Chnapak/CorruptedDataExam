namespace CorruptedData
{
    internal class Transaction
    {
        // A class containing all we can know from an trasanction from input. With their respective get methods.

        private string name;

        public string Name
        {
            get { return name; }
        }

        private string id;

        public string Id
        {
            get { return id; }
        }

        private string city;

        public string City
        {
            get { return city; }
        }

        private string state;

        public string State
        {
            get { return state; }
        }

        private string amount;

        public string Amount
        {
            get { return amount; }
        }
        public Transaction(string name, string id, string city, string state, string amount)
        {
            this.name = CheckForUnknown(name);
            this.id = CheckForUnknown(id);
            this.city = CheckForUnknown(city);
            this.state = CheckForUnknown(state);
            this.amount = CheckForUnknown(amount);
        }

        public string CheckForUnknown(string s)
        {
            if (s == "?")
            {
                return "unknown";
            }

            return s;
        }
    }
}
