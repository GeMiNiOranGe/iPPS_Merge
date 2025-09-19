using Pepro.Business;
using Pepro.DTOs;
using Pepro.Presentation.Controls.Templates;
using Pepro.Presentation.Enums;
using Pepro.Presentation.Extensions;

namespace Pepro.Presentation.Controls.Pages;

public partial class AccountPage : CrudTemplate
{
    public AccountPage()
    {
        InitializeComponent();
        accountDataGridView.SetupCellStyle();
        employeeColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

        searchButton.ApplyFlatStyleWithIcon("Search", ThemeColors.Text);
        reloadButton.ApplyFlatStyleWithIcon("Refresh", ThemeColors.Text);
        insertButton.ApplyFlatStyleWithIcon("Plus", ThemeColors.Text);
        deleteButton.ApplyFlatStyleWithIcon("Trash", ThemeColors.Text);
        updateButton.ApplyFlatStyleWithIcon("EditPencil", ThemeColors.Text);
    }

    private void LoadAccounts()
    {
        accountDataGridView.DataSource = AccountBusiness
            .Instance.GetAccountViews()
            .ToList();
    }

    private void AccountPage_Load(object sender, EventArgs e)
    {
        LoadAccounts();
    }

    private void AccountDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        BindDataGridViewCellClick<AccountDto>((DataGridView)sender, e);
    }

    private void SearchButton_Click(object sender, EventArgs e)
    {
        /*
        BindSearchButtonClick(
            searchTextBox.Text,
            accountDataGridView,
            AccountBusiness.Instance.SearchAccountViews
        );
        */
    }

    private void ReloadButton_Click(object sender, EventArgs e)
    {
        LoadAccounts();
    }

    private void InsertButton_Click(object sender, EventArgs e)
    {
        /*
        BindInsertButtonClick<AccountDto>(
            new(),
            ControlUiEvent.PushAccountEditorPage,
            LoadAccounts
        );
        */
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        /*
        BindUpdateButtonClick<AccountDto>(
            accountDataGridView,
            ControlUiEvent.PushAccountEditorPage,
            LoadAccounts
        );
        */
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        /*
        BindDeleteButtonClick<AccountDto>(
            accountDataGridView,
            (item) => AccountBusiness.Instance.DeleteAccount(item.AccountId),
            LoadAccounts
        );
        */
    }
}
