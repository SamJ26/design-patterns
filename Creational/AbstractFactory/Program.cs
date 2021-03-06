namespace AbstractFactory;

public class Application
{
    public IButton Button { get; private set; } = default!;
    public ICheckbox Checkbox { get; private set; } = default!;

    private readonly IGuiFactory guiFactory;

    public Application(IGuiFactory guiFactory)
    {
        this.guiFactory = guiFactory;
    }

    public void CreateGui()
    {
        Button = guiFactory.CreateButton();
        Checkbox = guiFactory.CreateCheckbox();
    }

    public void Render()
    {
        Button.Render();
        Checkbox.Render();
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var guiFactory = GetFactory(args);
        var app = new Application(guiFactory);

        app.CreateGui();
        app.Render();

        app.Button.Click();
        app.Checkbox.SetValue(true);
    }

    static IGuiFactory GetFactory(string[] args)
    {
        return args[0] switch
        {
            "web" => new WebFactory(),
            "desktop" => new DesktopFactory(),
            _ => throw new Exception("Unknown environment")
        };
    }
}
