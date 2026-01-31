using System.Collections.Generic;
using System.Threading.Tasks;
using crud_application.Data;
using crud_application.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_application.Services;

public class CustomerService : ICustomerService
{
    private readonly ApplicationDbContext _context;

    public CustomerService(ApplicationDbContext context)
    {   
        _context = context;
    }

    public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
    {
        return await _context.Customers.ToListAsync();
    }

    public async Task<Customer> GetCustomerByIdAsync(int id)
    {
        return await _context.Customers.FindAsync(id);
    }

    public async Task<int> AddCustomerAsync(Customer customer)
    {
        var c =  _context.Customers.Add(customer);
        await _context.SaveChangesAsync();
        return c.Entity.Id;
    }
    
    public async Task UpdateCustomerAsync(Customer updated)
    {
        var customer = await _context.Customers
            .FirstOrDefaultAsync(c => c.Id == updated.Id);

        if (customer == null)
            return;

        customer.FirstName = updated.FirstName;
        customer.LastName = updated.LastName;
        customer.Email = updated.Email;
        customer.PhoneNumber = updated.PhoneNumber;
        customer.Address = updated.Address;
        customer.City = updated.City;

        await _context.SaveChangesAsync();
    }

    public async Task DeleteCustomerAsync(Customer customer)
    {
        _context.Customers.Remove(customer);
        await _context.SaveChangesAsync();
    }
}