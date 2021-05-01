## Blazor file management
In this repository you will find a complete guide to manage file in blazor

First, we have to create a new component and add the InputFile

```csharp
<InputFile OnChange="@OnInputFileChange"  class="btn btn-primary" />   
```

You can add a multiple file selection using "multiple" tag

```csharp
<InputFile OnChange="@OnInputFileChange"  class="btn btn-primary" multiple />   
```

You must implement the OnChange method to get all the information about the file selected
```csharp
IBrowserFile file;
public async Task OnInputFileChange(InputFileChangeEventArgs e)  
{  
    file = e.File;
}
```

You can read and show the properties from the IBrowserFile

```html
<div class="form-group">
    <p>@file?.Name</p>
    <p>@file?.ContentType</p>
    <p>@(file?.Size != null ? file?.Size/1024 + " KBs" : "")</p>
    <p>@file?.LastModified</p>
</div>
```

Using Regex we can validate the file extension

```csharp
IBrowserFile file;
public async Task OnInputFileChange(InputFileChangeEventArgs e)  
{  
   
    Regex regex = new Regex(".+\\.csv", RegexOptions.Compiled);  
    if (regex.IsMatch(e.File))  
    {  
        file = e.File;
    }
}
```



Using Regex we can validate the file extension

```csharp
IBrowserFile file;
public async Task OnInputFileChange(InputFileChangeEventArgs e)  
{   
    Regex regex = new Regex(".+\\.csv", RegexOptions.Compiled);  
    if (regex.IsMatch(e.File))  
    {  
         file = e.File;
        var stream = singleFile.OpenReadStream();  
        var csv = new List<string[]>();  
        MemoryStream ms = new MemoryStream();  
        await stream.CopyToAsync(ms);  
        stream.Close();  
        var outputFileString = System.Text.Encoding.UTF8.GetString(ms.ToArray());  
  
        foreach (var item in outputFileString.Split(Environment.NewLine))  
        {  
            csv.Add(SplitCSV(item.ToString()));  
        }  
    }
}


private string[] SplitCSV(string input)  
{  
    //Excludes commas within quotes  
    Regex csvSplit = new Regex("(?:^|,)(\"(?:[^\"]+|\"\")*\"|[^,]*)", RegexOptions.Compiled);  
    List<string> list = new List<string>();  
    string curr = null;  
    foreach (Match match in csvSplit.Matches(input))  
    {  
        curr = match.Value;  
        if (0 == curr.Length)  list.Add(""); 
        list.Add(curr.TrimStart(','));  
    }  
  
    return list.ToArray();  
}  
```
