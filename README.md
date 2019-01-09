# Unity_AutoReference_test
A scene for testing wether or not "Auto reference plugin" shows up or not. (Unmanaged/managed plugins) 

/Assets/TestDLLManaged.dll Is a managed plugin example written in C#, compiled for .net 3.5 that contains a simple method named "Multiply" that takes in an integer and a float, and multiplies the two.
when inspecting the managed plugin in the unity editor it should show an option "Auto reference"

/Assets/Plugins/TestDLL.dll Is an unmanaged/native plugin example written in C++. This plugin also has a simple method, named "MultiplyNumbers" that takes an integer and float as parameters, and returns the result of multiplying the two.
Inspecting this plugin in the editor will NOT show an option for "Auto reference". 

Project also includes a small benchmark for the two plugins.
