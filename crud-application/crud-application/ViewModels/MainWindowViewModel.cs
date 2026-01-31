using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using crud_application.Models;
using crud_application.Services;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;

namespace crud_application.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly ICustomerService _customerService;
    [ObservableProperty] private ObservableCollection<Customer> _customers;

    [ObservableProperty] private Customer? _selectedCustomer;
    
    [ObservableProperty] private string _firstName;
    [ObservableProperty] private string _lastName;
    [ObservableProperty] private string _address;
    [ObservableProperty] private string _city;
    [ObservableProperty] private string _phoneNumber;
    [ObservableProperty] private string _email;

    [ObservableProperty] private string _saveBtnState = "Save";
    
    [ObservableProperty] private bool _isLoading;

    public MainWindowViewModel(ICustomerService customerService)
    {
        _customerService = customerService;
        _customers = new ObservableCollection<Customer>();
        LoadCustomerData();
    }

    public MainWindowViewModel() : this(null) { }

    private async Task LoadCustomerData()
    {
        try
        {
            IsLoading = true;
            
            await Task.Delay(2000);
            
            Customers.Clear();
            var allCustomersAsync = await _customerService.GetAllCustomersAsync();
            foreach (var customer in allCustomersAsync)
            {
                Customers.Add(customer);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        finally
        {
            IsLoading = false;
        }
        
    }

    [RelayCommand]
    private async Task SaveCustomer()
    {

        var box = MessageBoxManager
            .GetMessageBoxStandard("Customer Added", "Customer Added Successfully!");
        
        if (SelectedCustomer is not null)
        {
            SelectedCustomer.FirstName = FirstName;
            SelectedCustomer.LastName = LastName;
            SelectedCustomer.Email = Email;
            SelectedCustomer.PhoneNumber = PhoneNumber;
            SelectedCustomer.Address = Address;
            SelectedCustomer.City = City;

            await _customerService.UpdateCustomerAsync(SelectedCustomer);
            
            box = MessageBoxManager
                .GetMessageBoxStandard("Customer Updated", "Customer Updated Successfully!");

        }
        else
        {
            var customer = new Customer()
            {
                FirstName = FirstName,
                LastName = LastName,
                Address = Address,
                City = City,
                PhoneNumber = PhoneNumber,
                Email = Email
            };
            var customerId = await _customerService.AddCustomerAsync(customer);
            customer.Id = customerId;
            Customers.Add(customer);
        }
        
        await box.ShowAsync();
        
        ClearFieldsCommand.Execute(null);
    }

    [RelayCommand]
    private void ClearFields()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        Address = string.Empty;
        City = string.Empty;
        PhoneNumber = string.Empty;
        Email = string.Empty;
    }

    [RelayCommand]
    private async Task DeleteCustomer()
    {
        if (SelectedCustomer is not null)
        {
            _customerService.DeleteCustomerAsync(SelectedCustomer);
            Customers.Remove(SelectedCustomer);
            SelectedCustomer = null;
            
            var box = MessageBoxManager
                .GetMessageBoxStandard("Customer Deleted", "Customer Deleted Successfully!");

            await box.ShowAsync();
        } 
    }

    [RelayCommand]
    private async Task RefreshCustomers()
    {
        await LoadCustomerData();
    } 

    partial void OnSelectedCustomerChanged(Customer? value)
    {
        if (value is not null)
        {
            FirstName = value.FirstName;
            LastName = value.LastName;
            Email = value.Email;
            PhoneNumber = value.PhoneNumber;
            Address = value.Address;
            City = value.City;
            SaveBtnState = "Update";
        }
    }
    
    

}