namespace Pepro.DataAccess.Entities;

public class SalaryScale
{
    private int _salaryScaleId;
    private string _group = "";
    private string _name = "";

    public required int SalaryScaleId
    {
        get => _salaryScaleId;
        set => _salaryScaleId = value;
    }

    public required string Group
    {
        get => _group;
        set => _group = value;
    }

    public required string Name
    {
        get => _name;
        set => _name = value;
    }
}
