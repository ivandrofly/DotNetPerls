//Program that uses operator keyword: C#

using System;

internal class Widget
{
    public int _value;
    // new most be static
    public static Widget operator +(Widget a, Widget b)
    {
        // Add two Widgets together.
        // ... Add the two int values and return a new Widget.
        Widget widget = new Widget();
        widget._value = a._value + b._value;
        return widget;
    }

    public static Widget operator ++(Widget w)
    {
        // Increment this widget.
        w._value++;
        return w;
    }
}

internal class Program
{
    private static void Main()
    {
        // Increment widget twice.
        Widget w = new Widget();
        w++;
        Console.WriteLine(w._value);
        w++;
        Console.WriteLine(w._value);

        // Create another widget.
        Widget g = new Widget();
        g++;
        Console.WriteLine(g._value);

        // Add two widgets.
        Widget t = w + g;
        Console.WriteLine(t._value);
    }
}

//Output

//1
//2
//1
//3

//Unary operators you can overload

//+
//-
//!
//~
//++
//--
//true
//false

//Binary operators you can overload

//+
//-
//*
///
//%
//&
//|
//^
//<<
//>>
//==
//!=
//>
//<
//>=
//<=