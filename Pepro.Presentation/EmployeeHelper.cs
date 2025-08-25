namespace Pepro.Presentation;

public static class EmployeeHelper
{
    public static RadioButton SelectGenderRadio(
        string? gender,
        RadioButton maleRadioButton,
        RadioButton femaleRadioButton,
        RadioButton otherRadioButton
    )
    {
        if (gender != null)
        {
            return gender == Business.Utilities.EmployeeHelper.Male
                ? maleRadioButton
                : femaleRadioButton;
        }
        return otherRadioButton;
    }

    public static string? GetSelectedGender(
        RadioButton maleRadioButton,
        RadioButton femaleRadioButton
    )
    {
        string? gender = null;
        if (maleRadioButton.Checked)
        {
            gender = Business.Utilities.EmployeeHelper.Male;
        }

        if (femaleRadioButton.Checked)
        {
            gender = Business.Utilities.EmployeeHelper.Female;
        }

        return gender;
    }
}
