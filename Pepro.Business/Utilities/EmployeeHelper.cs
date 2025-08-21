namespace Pepro.Business.Utilities;

public static class EmployeeHelper
{
    private static readonly string _male = "Nam";
    private static readonly string _female = "Nữ";

    public static string Male => _male;

    public static string Female => _female;

    public static string? FormatGender(bool? gender)
    {
        if (gender != null)
        {
            return (bool)gender ? _male : _female;
        }
        return null;
    }

    public static bool? ParseGender(string? gender)
    {
        if (gender != null)
        {
            return gender == _male;
        }
        return null;
    }

    public static RadioButton SelectGenderRadio(
        string? gender,
        RadioButton maleRadioButton,
        RadioButton femaleRadioButton,
        RadioButton otherRadioButton
    )
    {
        if (gender != null)
        {
            return gender == _male ? maleRadioButton : femaleRadioButton;
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
            gender = _male;
        }

        if (femaleRadioButton.Checked)
        {
            gender = _female;
        }

        return gender;
    }
}
