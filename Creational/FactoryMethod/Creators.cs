namespace FactoryMethod;

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