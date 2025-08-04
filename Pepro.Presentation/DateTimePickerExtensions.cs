namespace Pepro.Presentation;

public static class DateTimePickerExtensions {
    public static void SetValue(this DateTimePicker dateTimePicker, DateTime actual) {
        dateTimePicker.Value = actual < dateTimePicker.MinDate ? DateTime.Now : actual;
    }
}
