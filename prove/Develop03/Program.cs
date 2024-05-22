
using System;

class Program
{
    static void Main(string[] args)
    {

        Scripture _scripture = new Scripture(2, "Thessalonians", 1, 10, 12, "10. Who died for us, that, whether we wake or sleep, we should alive together with him.\n11. Wherefore acomfort yourselves together, and bedify one another, even as also ye do.\n12. And we beseech you, brethren, to know them which alabour among you, and are over you in the Lord, and admonish you;");
        Console.Clear();
        _scripture.RenderedDisplay();
        Console.WriteLine("\n\nPlease press 'enter' key to continue or type 'quit' to finish:");
        while (true)
        {
            string user_input = Console.ReadLine();
            if (user_input.ToLower() == "quit")
            {
                break;
            }
            if (!_scripture.HideWords())
            {
                break;
            }


            Console.Clear();
            _scripture.RenderedDisplay();
            Console.WriteLine("\n\nPlease press 'enter' key to continue or type 'quit' to finish:");
        }
    }

}

// The program exceeds the core requirements by displaying a scripture with first epistle and second epistle and gave it a member variable position;