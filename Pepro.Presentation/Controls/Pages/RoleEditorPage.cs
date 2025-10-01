using Pepro.DTOs;
using Pepro.Presentation.Controls.Templates;
using Pepro.Presentation.Enums;
using Pepro.Presentation.Interfaces;
using System.ComponentModel;

namespace Pepro.Presentation.Controls.Pages;

public partial class RoleEditorPage : EditorTemplate, IEditorUserControl<RoleDto>
{
    private RoleDto _item = null!;
    private EditorMode _mode;

    public RoleEditorPage()
    {
        InitializeComponent();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public RoleDto Item
    {
        get => _item;
        set
        {
            _item = value ?? throw new ArgumentNullException(nameof(Item));
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public EditorMode Mode
    {
        get => _mode;
        set
        {
            _mode = value;
            HeaderText = _mode switch
            {
                EditorMode.Create => "Create a new role",
                EditorMode.Edit => "Edit role",
                _ => throw new InvalidEnumArgumentException(nameof(Mode), (int)_mode, typeof(EditorMode)),
            };
        }
    }
}
