namespace Pepro.Presentation;

public static class ControlExtensions {
    public static void SetLocationY(this Control control, int y) {
        control.Location = new Point(control.Location.X, y);
    }
}
