namespace AbstractFactory;

public interface IUiElement
{
    public void Render();
}

#region Button

public interface IButton : IUiElement
{
    public void Click();
}

public sealed class DesktopButton : IButton
{
    public void Click() => Console.WriteLine($"Click on DESKTOP button");

    public void Render() => Console.WriteLine("Render DESKTOP button");
}

public sealed class WebButton : IButton
{
    public void Click() => Console.WriteLine("Click on WEB button");

    public void Render() => Console.WriteLine("Render WEB button");
}

#endregion

#region Checkbox

public interface ICheckbox : IUiElement
{
    public void SetValue(bool value);
}

public sealed class DesktopCheckbox : ICheckbox
{
    public void SetValue(bool value) => Console.WriteLine($"Set DESKTOP checkbox to {value}");

    public void Render() => Console.WriteLine("Render DESKTOP checkbox");
}

public sealed class WebCheckbox : ICheckbox
{
    public void SetValue(bool value) => Console.WriteLine($"Set WEB checkbox to {value}");

    public void Render() => Console.WriteLine("Render WEB checkbox");
}

#endregion