# WDDN
WDDN or Winform Designer DotNet is a tool based on [SWD4CS](https://github.com/hry2566/SWD4CS) which is intended to be a light weight form creator/editor to be used outside of VisualStudio. Eventually i intend to add Powershell WinForm ability to this tool

# Development environment
 * Windows10+
 * VisualStudio2022 C#
 * .net6.0
 
## Screenshots  
![WDDN](https://user-images.githubusercontent.com/86605611/152679486-e8f7bbed-69b4-4186-b402-35d7bd2fec8f.png)
![WDDN](https://user-images.githubusercontent.com/86605611/152784518-c135ec3a-e156-4163-8f8d-90cc023d8448.png)
Control Tree is display only
 
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
