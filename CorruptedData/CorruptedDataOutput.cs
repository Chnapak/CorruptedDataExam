namespace CorruptedData
{
    internal class CorruptedDataOutput
    {
        public void Run()
        {
            // This program was for an exam where each line contained data about id, name, country, city and amount.
            // Each of this data are in the same coloumn and sometimes are replaced with "?" for unknown.


            // Extract each transaction in the form of a line from the input.
            string importFrom = "./corrupted_data.txt";
            string[] input = File.ReadAllLines(importFrom);

            // Incializes an array of Transactions, where each of the Transaction can be declared with the input.
            var transactionDetails = new Transaction[input.Length];
            
            // We fill up the array.
            for (int i = 0; i < input.Length; i++) 
            { 
                string[] individualValues = input[i].Split(";");

                transactionDetails[i] = new Transaction(individualValues[2], individualValues[0], individualValues[8], individualValues[4], individualValues[7]); 
            }

            // Afterwards we print it out.
            foreach (Transaction transaction in transactionDetails) 
            {
                Console.WriteLine($"{transaction.Name} ({transaction.Id}):\n\t{transaction.City} ({transaction.State})\n\tVklad: {transaction.Amount} EUR\n");
            }
        }
    }
}
