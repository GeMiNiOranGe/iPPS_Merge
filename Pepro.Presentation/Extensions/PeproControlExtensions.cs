using Pepro.Presentation.Controls.Atoms;
using Pepro.Presentation.Controls.Molecules;
using Pepro.Presentation.Utilities;

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
        this TextBoxField source,
        ComboBoxField target
    )
    {
        source.DataBindings.Add(
            nameof(TextBoxField.Text),
            target,
            nameof(ComboBoxField.SelectedValue)
        );
    }
}
