namespace FactoryMethod;

public class DialogWindow
{
    public IButton Button { get; }
    
    public DialogWindow(string[] args)
    {
        Button = args[0] switch
        {
            "web" => new WebButtonFactory().CreateButton(),
            "desktop" => new DesktopButtonFactory().CreateButton(),
            _ => throw new Exception("Unknown environment")
        };
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        new DialogWindow(args).Button.Click();
    }
}
