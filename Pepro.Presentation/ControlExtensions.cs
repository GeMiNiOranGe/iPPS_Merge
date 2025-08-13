using System.Reflection;

namespace Pepro.Presentation;

public static class ControlExtensions {
    public static void SetLocationY(this Control control, int y) {
        control.Location = new Point(control.Location.X, y);
    }

    public static void ExecuteWithoutEvent<T>(
        this T control,
        string eventName,
        EventHandler handler,
        Action action
    ) {
        EventInfo eventInfo = typeof(T).GetEvent(eventName)
            ?? throw new ArgumentException($"Event '{eventName}' not found on {typeof(T).Name}");

        Type eventHandlerType = eventInfo.EventHandlerType
            ?? throw new ArgumentException($"Event '{eventName}' on {typeof(T).Name} does not have a delegate type.");

        Delegate eventHandler = Delegate.CreateDelegate(
            eventHandlerType,
            handler.Target,
            handler.Method
        );

        eventInfo.RemoveEventHandler(control, eventHandler);
        try {
            action();
        }
        finally {
            eventInfo.AddEventHandler(control, eventHandler);
        }
    }
}
