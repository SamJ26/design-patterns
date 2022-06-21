namespace FactoryMethod;

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