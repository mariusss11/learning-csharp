using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Gat.Controls;
using Microsoft.Extensions.DependencyInjection;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;
using PersonalNotepad.Services;

namespace PersonalNotepad.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    
    [ObservableProperty] private string? _textBoxContent;

    [RelayCommand]
    private async Task Exit()
    {
        
        var message = MessageBoxManager.GetMessageBoxStandard("Exit Modal", "Are you sure you want to close the editor?", ButtonEnum.YesNo, Icon.Question);

        var result = await message.ShowAsync();

        if (result == ButtonResult.Yes)
        {
            Console.WriteLine("Exiting...");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Not closing the editor...");
        }
    }
    
    [RelayCommand]
    private async Task OpenFile(CancellationToken token)
    {
        Console.WriteLine("Opening file...");
        ErrorMessages?.Clear();
        try
        {
            var filesService = App.Current?.Services?.GetService<IFilesService>();
            if (filesService is null) throw new NullReferenceException("Missing File Service instance.");

            var file = await filesService.OpenFileAsync();
            if (file is null) return;

            // Limit the text file to 1MB
            if ((await file.GetBasicPropertiesAsync()).Size <= 1024 * 1024 * 1)
            {
                await using var readStream = await file.OpenReadAsync();
                using var reader = new StreamReader(readStream);
                TextBoxContent = await reader.ReadToEndAsync(token);
            }
            else
            {
                throw new Exception("File exceeded 1MB limit.");
            }
        }
        catch (Exception e)
        {
            ErrorMessages?.Add(e.Message);
        }
    }
    
    [RelayCommand]
    private async Task SaveFile()
    {
        ErrorMessages?.Clear();
        try
        {
            var filesService = App.Current?.Services?.GetService<IFilesService>();
            if (filesService is null) throw new NullReferenceException("Missing File Service instance.");

            var file = await filesService.SaveFileAsync();
            if (file is null) return;


            // Limit the text file to 1MB
            if (TextBoxContent?.Length <= 1024 * 1024 * 1)
            {
                var stream = new MemoryStream(Encoding.Default.GetBytes((string)TextBoxContent));
                await using var writeStream = await file.OpenWriteAsync();
                await stream.CopyToAsync(writeStream);
            }
            else
            {
                throw new Exception("File exceeded 1MB limit.");
            }
        }
        catch (Exception e)
        {
            ErrorMessages?.Add(e.Message);
        }
    }

    
}