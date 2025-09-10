using Pepro.Presentation.Controls;

namespace Pepro.Presentation.Extensions;

public static class PeproControlExtensions
{
    public static void SetSidebarButtonImages(
        this PeproIconButton button,
        string iconName
    )
    {
        button.ApplyFlatStyleNoBackColor();
        button.ApplyIcon(iconName, color: ThemeColors.Text);

        try
        {
            button.PressedImage = IconProvider.GetIcon(
                iconName,
                "Bold",
                color: ThemeColors.Text
            );
        }
        catch (Exception)
        {
            button.PressedImage = null;
        }
    }

    public static void BindTextToValue(
        this PeproInputField source,
        PeproComboBoxField target
    )
    {
        source.DataBindings.Add(
            nameof(PeproInputField.Text),
            target,
            nameof(PeproComboBoxField.SelectedValue)
        );
    }
}
