# How to Set a Null Value in WinForms DateTimePickerAdv
This sample demonstrates how to set and display a null date in the Syncfusion WinForms DateTimePickerAdv control using its built‑in null date support.

Unlike the standard WinForms DateTimePicker, DateTimePickerAdv provides native properties to handle null values directly.

## Overview
In many applications, date fields are optional. The Syncfusion **DateTimePickerAdv** control supports this requirement through the _EnableNullDate_ and _IsNullDate_ properties.

This sample shows how to initialize the control with a **null (empty) date** when the form loads.

## What This Sample Demonstrates
- Enabling null date support in DateTimePickerAdv
- Setting the control to a null state programmatically
- Displaying an empty DateTimePicker without custom formatting
- Using built‑in Syncfusion APIs instead of workarounds

## Key Properties Used
| Property Name     | Description                                              |
|-------------------|----------------------------------------------------------|
| `EnableNullDate`  | Enables null date support in the control.                |
| `IsNullDate`      | Sets or gets whether the current value is null.          |

##  Code Implementation
Setting a Null Date on Form Load.

```Csharp
private void Form1_Load(object sender, EventArgs e)
{
    this.dateTimePickerAdv1.EnableNullDate = true;
    this.dateTimePickerAdv1.IsNullDate = true;
}
```
