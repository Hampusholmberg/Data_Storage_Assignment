using Infrastructure.Dtos;
using Infrastructure.Repositories;
using Infrastructure.Services;

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

        CustomerDto customerToAdd = new CustomerDto
        {
            FirstName = "Johan",
            LastName = "Larsson",
            Email = "Johnny@email.se",
            StreetName = "testvägen 87c",
            City = "Testarp",
            PostalCode = "12345",

        };

        var result = _customerService.CreateCustomer(customerToAdd);

        var customers = _customerService.GetAllCustomers();
        Console.Clear();

        foreach (var customer in customers)
        {
            Console.WriteLine(  $"{customer.FirstName} {customer.LastName}, " +
                                $"{customer.Email}, " +
                                $"{customer.Address.StreetName}, " +
                                $"{customer.Address.PostalCode}, " +
                                $"{customer.Address.City} ");
        }

        Console.ReadKey();
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