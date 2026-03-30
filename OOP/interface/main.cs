using System;

interface IControl
{
    void Paint();
}

public class Binder
{
    public string Source { get; }
    public Binder(string source) { Source = source; }
}

interface IDataBound
{
    void Bind(Binder b);
}


// Paint method from the IControl interface and the Bind method from the IDataBound interface are implemented using public members.
// public class EditBox: IControl, IDataBound
// {
//     public void Paint() {
//         Console.WriteLine("EditBox is being painted");
//     }
//     public void Bind(Binder b) {
//         Console.WriteLine($"EditBox is being bound to {b.Source}");
//     }
// }

// Paint method from the IControl interface and the Bind method from the IDataBound interface are implemented using explicit interface members.
public class EditBox: IControl, IDataBound
{
    /* explicit interface members */
    void IControl.Paint() {
        Console.WriteLine("EditBox is being painted");
    }

    void IDataBound.Bind(Binder b) {
        Console.WriteLine($"EditBox is being bound to {b.Source}");
    }
}


class Program
{
    static void Main()
    {
        EditBox editBox = new EditBox();
        // editBox.Paint(); // Error, no such method if use explicit interface members

        /* Explicit interface members can only be accessed via the interface type. */
        IControl control = editBox;
        control.Paint(); // OK
    }
}