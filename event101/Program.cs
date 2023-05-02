class Program { 
    delegate void OnChangeHandler(object sender, TextBoxArguments e); 
    class TextBox
    {
        public event OnChangeHandler ChangeEvent;
        public string Value;
        public void OnChange(TextBoxArguments e)
        {
            if(ChangeEvent != null)
            {
                ChangeEvent(this, e);
            }
        }
    }

    public class TextBoxArguments : EventArgs
    {
        public int Length;
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
                TextBoxArguments arg = new TextBoxArguments();
                arg.Length = txt.Value.Length;
                txt.OnChange(arg);
            }
            else
            {
                Console.WriteLine("String not change !!");
            }
            current = str;
        }
        Console.WriteLine("End Loop");
    }

    private static void txt_OnChangeEvent(object sender, TextBoxArguments e)
    {
        Console.WriteLine("Value is change to: {0} and Length {1}", ((TextBox)sender).Value, e.Length);
    }
}
