class Program { 
    delegate void OnChangeHandler(object sender, EventArgs e); 
    class TextBox
    {
        public event OnChangeHandler ChangeEvent;
        public string Value;
        public void OnChange()
        {
            if(ChangeEvent != null)
            {
                ChangeEvent(this, EventArgs.Empty);
            }
        }
        
    }

    static void Main(string[] args)
    {
        string current = string.Empty;
        TextBox txt = new TextBox();
        txt.ChangeEvent += txt_OnChangeEvent;

        while (current != "q") { 
            Console.Write("TextBox : ");
            string str = Console.ReadLine();
            if(str != current) 
            {
                txt.Value = str;
                txt.OnChange();
            }
            else
            {
                Console.WriteLine("String not change !!");
            }
            current = str;
        }
        Console.WriteLine("End Loop");
    }

    private static void txt_OnChangeEvent(object sender, EventArgs e)
    {
        Console.WriteLine("Value is change to: {0}", ((TextBox)sender).Value);
    }
}
