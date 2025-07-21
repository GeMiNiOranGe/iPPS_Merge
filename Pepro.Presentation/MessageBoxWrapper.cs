namespace Pepro.Presentation;

public static class MessageBoxWrapper
{
    // TODO: Use `*.en.resx` instead
    private static string GetMessage(string key)
    {
        return key switch
        {
            "SelectDocument" => "Vui lòng chọn tài liệu để xoá",
            "DeleteDocumentSuccess" => "Xóa {0} tài liệu thành công",
            "ConfirmDelete" => "Bạn có chắc muốn xóa không?",
            _ => "Không có thông điệp nào phụ hợp với 'key'"
        };
    }

    public static DialogResult ShowInformation(string key, params object[] args)
    {
        string raw = GetMessage(key);

        return MessageBox.Show(
            string.Format(raw, args),
            "Thông báo",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }

    public static DialogResult ConfirmDelete()
    {
        return MessageBox.Show(
            GetMessage("ConfirmDelete"),
            "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );
    }
}
