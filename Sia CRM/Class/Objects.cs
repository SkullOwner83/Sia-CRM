namespace SiaCRM
{
    public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }
    }

    public class Service
    {
        public int Folio { get; set; }
        public int Customer { get; set; }
        public string Name { get; set; }
        public string AdmissionDate { get; set; }
        public string? DeliveryDate { get; set; }
        public int Status { get; set; }
        public string? Diagnostic { get; set; }

        //Refresh data in listview with instances in service list
        public static void Load(ListView View, List<Service> List)
        {
            View.Items.Clear();
            int Counter = 1;

            foreach (var Object in List)
            {
                AddItems(View, Object, Counter);
                Counter++;
            }
        }
        
        //Refresh data in listview with user filters
        public static void Filter(ListView View, List<Service> List, string Word)
        {
            View.Items.Clear();
            List<string> WordList = new List<string>();
            string CurrentWord = "";
            int Counter = 1;

            //Split words of strign for better filtering
            for (var i = 0; i < Word.Length; i++)
            {
                if (Word[i] != ' ')
                {
                    CurrentWord += Word[i];
                }
                else
                {
                    WordList.Add(CurrentWord);
                    CurrentWord = "";
                }
            }

            foreach (var Object in List)
            {
                //Add items in listview if matches the name or folio filter
                if (Object.Name.Contains(Word, StringComparison.OrdinalIgnoreCase) || 
                    Convert.ToString(Object.Folio).Contains(Word) || Object.AdmissionDate.Contains(Word))
                    {
                        AddItems(View, Object, Counter);
                        Counter++;
                        /*
                        //Highlight the best result in listview
                        if (Object.Name.Equals(Word, StringComparison.OrdinalIgnoreCase) || 
                            Convert.ToString(Object.Folio).Equals(Word, StringComparison.OrdinalIgnoreCase))
                            {
                                Item.BackColor = Color.Yellow;
                            }
                        */
                    }
            }
        }

        private static void AddItems(ListView View, Service Object, int Counter)
        {
            ListViewItem Item = new ListViewItem();
            Item = View.Items.Add(string.Empty);
            Item.SubItems.Add(Convert.ToString(Object.Folio));
            Item.SubItems.Add(Convert.ToString(Object.Name));
            Item.SubItems.Add(Object.AdmissionDate);
            Item.ImageIndex = Object.Status;

            if (Counter % 2 == 0)
            {
                Item.BackColor = Color.AliceBlue;
            }
        }
    }

    public class Computer
    {
       public string Name { get; set; }
    }
}
