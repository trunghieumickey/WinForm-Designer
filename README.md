# WDDN
WDDN or Winform Designer DotNet is a tool based on [SWD4CS](https://github.com/hry2566/SWD4CS) which is intended to be a light weight form creator/editor to be used outside of VisualStudio. This fork includes the ability create forms for powershell.

# Features
* C# Form Creation
* Powershell Form Creation
* Conversion of C# Forms to powershell


# Development environment
 * Windows 11
 * Visual Studio 2022.4
 * .Net 7.0

 
## Implementation
 ・Some property changes
 ・Button  
 ・CheckBox  
 ・CheckedListBox  
 ・ComboBox  
 ・DataGridView  
 ・DateTimePicker  
 ・DomainUpDown  
 ・GroupBox  
 ・HScrollBar  
 ・Label  
 ・LinkLabel  
 ・ListBox  
 ・ListView  
 ・MaskedTextBox  
 ・MonthCalender  
 ・Panel  
 ・PictureBox  
 ・ProgressBar  
 ・PropertyGrid  
 ・RadioButton  
 ・RichText  
 ・SplitContainer  
 ・StatusStrip  
 ・TabControl  
 ・TabPage  
 ・TextBox  
 ・TreeView  
 ・VScrollBar  
 ・Designer.cs Read / Write ~~ ( Other edits other than WDDN cannot be opened ) ~~
 ・Add other controllers as needed.

## Corresponding property（Type）
 ・System.Drawing.Point  
 ・System.Drawing.Size  
 ・System.String  
 ・System.Boolean  
 ・System.Int32  
 ・System.Windows.Forms.AnchorStyles  
 ・System.Windows.Forms.DockStyle  
 ・System.Drawing.ContentAlignment  
 ・System.Windows.Forms.ScrollBars  
 ・System.Windows.Forms.HorizontalAlignment  
 ・System.Drawing.Color  
 ・System.Windows.Forms.FormStartPosition  
 ・System.Windows.Forms.FormWindowState  
 ・System.Windows.Forms.FixedPanel  
 ・System.Windows.Forms.PictureBoxSizeMode  
 ・System.Windows.Forms.View  
 ・System.Windows.Forms.Orientation  
 ・System.Windows.Forms.FormBorderStyle  
 ・System.Windows.Forms.AutoScaleMode  
 ・System.Drawing.Font  

## How to add a control
* Added to "// Edit the following when adding a control".
・cls_form.cs  
・cls_control.cs  
