# For COP4870 Class: Example for styling Radio Button in Maui

This is intended for at least one student of the FSU COP4870 course as of the Spring 2023 semester and is meant to serve as an example of how to style the RadioButton control in .NET MAUI and as a starting point for doing so. **Please keep in mind that I am a student of this course and have no involvement with its instruction. This is not official course content.**

The relevant files are:
- MAUI.RadioStyleButtonExample/App.xaml
- MAUI.RadioStyleButtonExample/MainPage.xaml
- MAUI.RadioStyleButtonExample/Resources/ControlTemplates/


## Some Explanations

### In App.xaml
```xaml
...
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="Resources/Styles/Colors.xaml" />
                <ResourceDictionary Source="Resources/Styles/Styles.xaml" />
                <ResourceDictionary Source="Resources/ControlTemplates/RadioButtonFillControlTemplate.xaml"/>
                <ResourceDictionary Source="Resources/ControlTemplates/RadioButtonHollowControlTemplate.xaml"/>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
...
```
Defines the resources at the Application level.


### In MainPage.xaml
```xaml
<ContentPage ...>   
    <ContentPage.Resources>               
        <Style TargetType="RadioButton">
            <Setter Property="ControlTemplate"
                    Value="{StaticResource RadioButtonFillTemplate}"/>
        </Style>
    </ContentPage.Resources>
...
</ContentPage>
```
Defines the style for RadioButton on this ContentPage and consumes the RadioButtonFillTemplate resource. **Include this general part in the xaml for each ContentPage you wish to use it with.**

### In Resources/ControlTemplates/
There are two different ControlTemplates here in this example: one with a 'fill' style (i.e. a space between a border and a fill for the button) and one with a 'hollow' style (i.e. changes the size of the border or stroke of the button instead of filling).

There are a few comments in there that provide a bit of labelling which should hopefully be overall sufficient for understanding. 

---
```xaml
Stroke="{AppThemeBinding Light={StaticResource Primary}, Dark=#0787F0}"
```
What this is doing is setting the color based on which theme is set (Light or Dark). You could also just doing something like `Stroke=Blue` if you want. For the latter, refer to these resources:
- https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.graphics.colors?view=net-maui-7.0
- https://learn.microsoft.com/en-us/dotnet/maui/user-interface/brushes/solidcolor?view=net-maui-7.0#solid-color-brushes-1

```xaml
... Light={StaticResource Primary}, ...
```
`Primary` is defined in Resources/Styles/Colors.xaml. This file is included with the standard MAUI template and has been left unmodified in this example.

---

## References / Acknowledgements
The code used for the content templates in this example is heavily based on the examples provided by Microsoft.
https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/radiobutton?view=net-maui-7.0#redefine-radiobutton-appearance
