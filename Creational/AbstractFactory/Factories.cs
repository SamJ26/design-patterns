namespace AbstractFactory;

public interface IGuiFactory
{
    public IButton CreateButton();
    public ICheckbox CreateCheckbox();
}

public sealed class DesktopFactory : IGuiFactory
{
    public IButton CreateButton() => new DesktopButton();

    public ICheckbox CreateCheckbox() => new DesktopCheckbox();
}

public sealed class WebFactory : IGuiFactory
{
    public IButton CreateButton() => new WebButton();

    public ICheckbox CreateCheckbox() => new WebCheckbox();
}
