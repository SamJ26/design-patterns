namespace FactoryMethod;

public interface IButtonFactory
{
    public IButton CreateButton();
}

public class DesktopButtonFactory : IButtonFactory
{
    public IButton CreateButton()
    {
        return new DesktopButton();
    }
}

public class WebButtonFactory : IButtonFactory
{
    public IButton CreateButton()
    {
        return new WebButton();
    }
}