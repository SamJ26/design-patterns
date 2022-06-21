namespace FactoryMethod;

#region Products

// General product
public interface IButton
{
    public void Render();
    public void Click();
}

// Concrete product
public class DesktopButton : IButton
{
    public void Render() => Console.WriteLine("Rendering Desktop button");
    public void Click() => Console.WriteLine("Click on Desktop button");
}

// Concrete product
public class WebButton : IButton
{
    public void Render() => Console.WriteLine("Rendering web button");
    public void Click() => Console.WriteLine("Click on web button");
}

#endregion

#region Creators

// The creator class with factory method
public abstract class DialogComponent
{
    public abstract IButton CreateButton();

    public void Render()
    {
        // This call invokes overridden method in derived class
        IButton button = CreateButton();
        button.Render();
    }
}

// Concrete creators override the factory method
public sealed class DesktopDialogComponent : DialogComponent
{
    public override IButton CreateButton() => new DesktopButton();
}

// Concrete creators override the factory method
public sealed class WebDialogComponent : DialogComponent
{
    public override IButton CreateButton() => new WebButton();
}

#endregion

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
