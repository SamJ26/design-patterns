namespace FactoryMethod;

public interface IButton
{
    public void Click();
}

public class DesktopButton : IButton
{
    public void Click() => Console.WriteLine("Click on Desktop button");
}

public class WebButton : IButton
{
    public void Click() => Console.WriteLine("Click on Web button");
}