# How to load custom view cell in Xamarin.Forms ListView?
This example demonstrate how to load custom view cell in Xamarin.Forms ListView.

## Sample

```xaml
<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="adKey">
            <local:AdView/>
        </DataTemplate>
        <DataTemplate x:Key="booksKey">
            <code>
            . . .
            . . .
            <code>
        </DataTemplate>
        <local:BookTemplateSelector x:Key="dataSelector" BookTemplate="{StaticResource booksKey}" AdTemplate="{StaticResource adKey}" />
    </ResourceDictionary>
</ContentPage.Resources>
<syncfusion:SfListView x:Name="myListView" SelectionMode="None" AutoFitMode="Height" ItemTemplate="{StaticResource dataSelector}" ItemsSource="{Binding BookInfo}" ItemSize="50"/>
```

## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

