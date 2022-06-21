namespace FactoryMethod;

public class Application
{
    public DialogComponent Dialog { get; }
    
    public Application(string[] args)
    {
        Dialog = args[0] switch
        {
            "Web" => new WebDialogComponent(),
            "Desktop" => new DesktopDialogComponent(),
            _ => throw new Exception("Unknown environment")
        };
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var app = new Application(args);
        app.Dialog.Render();
    }
}
