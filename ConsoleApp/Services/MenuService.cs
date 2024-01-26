using Infrastructure.Dtos;
using Infrastructure.Entities;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.Identity.Client;

namespace ConsoleApp.Services;

public class MenuService
{
    private readonly OrderService _orderService;
    private readonly AddressRepository _addressRepository;
    private readonly CustomerService _customerService;

    public MenuService(OrderService orderService, AddressRepository addressRepository, CustomerService customerService)
    {
        _orderService = orderService;
        _addressRepository = addressRepository;
        _customerService = customerService;
    }

    public void Run() 
    {

        CustomerDto customer = new CustomerDto 
        { 
            Firstname = "hampus",
            Lastname = "Holmberg",
            Email = "email.se",
            StreetName = "testvägen 1",
            City = "testköping",
            PostalCode = "12345",

        };

        _customerService.CreateCustomer(customer);

    }

    public void DefaultMenu()
    {
        Console.Clear();
        string? menuChoice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("1.  Order Administration");
            Console.WriteLine("2.  Product Administration");
            Console.WriteLine("9.  Exit");
            Console.WriteLine("---------------------");
            Console.WriteLine();
            Console.Write("Enter menu choice: ");

            menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    OrderAdminMenu();
                    break;

                case "2":
                    ProductAdminMenu();
                    break;

                default:
                    Console.Clear();
                    break;

                case "9":
                    Console.Clear();
                    return;
            }
        } while (menuChoice != null!);
    }

    // ---------------------------------- //
    public void OrderAdminMenu()
    {
        Console.Clear();
        string? menuChoice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("1.  Register New Order");
            Console.WriteLine("2.  Order Register");
            Console.WriteLine("3.  Customer Register");
            Console.WriteLine("4.  ?????");
            Console.WriteLine("5.  ?????");
            Console.WriteLine("6.  ?????");
            Console.WriteLine("9.  Go Back");
            Console.WriteLine("---------------------");
            Console.WriteLine();
            Console.Write("Enter menu choice: ");

            menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    AddOrderMenu();
                    break;

                case "2":
                    
                    break;
                    
                case "3":
                    CustomerRegisterMenu();
                    break;

                default:
                    Console.Clear();
                    break;

                case "9":
                    Console.Clear();
                    return;
            }
        } while (menuChoice != null!);
    }

    public void AddOrderMenu() {}

    public void OrderRegisterMenu() { }


    public void CustomerRegisterMenu() 
    {
    }

    // ---------------------------------- //





    // ---------------------------------- //
    public void ProductAdminMenu()
    {

    }
    // ---------------------------------- //
}