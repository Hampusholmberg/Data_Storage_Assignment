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
        Console.Clear();
        MainMenu();
    }



    // ------------------ MAIN MENUS ------------------ //

    public void MainMenu()
    {
        Console.Clear();
        string? menuChoice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Main Menu");
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

    public void OrderAdminMenu()
    {
        Console.Clear();
        string? menuChoice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Order Administration Menu");
            Console.WriteLine("---------------------");
            Console.WriteLine("1.  Register New Order"); // not implemented
            Console.WriteLine("2.  Order Register"); // not implemented
            Console.WriteLine("3.  Register New Customer");
            Console.WriteLine("4.  Customer Register");
            Console.WriteLine("5.  Delivery Method Register");
            Console.WriteLine("6.  Payment Method Register");
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
                    RegisterNewCustomer();
                    break;

                case "4":
                    CustomerRegisterMenu();
                    break;

                case "5":
                    DeliveryMethodRegisterMenu();
                    break;

                case "6":
                    PaymentMethodRegisterMenu();
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

    public void OrderRegisterMenu() { }

    public void CustomerRegisterMenu()
    {
        Console.Clear();
        string? menuChoice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Customer Register Menu");
            Console.WriteLine("---------------------");
            Console.WriteLine("1.  Show All Customers");
            Console.WriteLine("2.  Delete Customer");
            Console.WriteLine("3.  Register New Customer");
            Console.WriteLine("9.  Go Back");
            Console.WriteLine("---------------------");
            Console.WriteLine();
            Console.Write("Enter menu choice: ");

            menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    ShowAllCustomers();
                    break;

                case "2":
                    DeleteCustomerFromList();
                    break;

                case "3":
                    RegisterNewCustomer();
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

    public void AddOrderMenu() { }

    //NOT DONE
    public void DeliveryMethodRegisterMenu()
    {
        Console.Clear();
        string? menuChoice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Delivery Method Register Menu");
            Console.WriteLine("---------------------");
            Console.WriteLine("1.  Show All Delivery Methods");
            Console.WriteLine("2.  Delete Delivery Methods");
            Console.WriteLine("3.  Register New Delivery Methods");
            Console.WriteLine("9.  Go Back");
            Console.WriteLine("---------------------");
            Console.WriteLine();
            Console.Write("Enter menu choice: ");

            menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    ShowAllCustomers();
                    break;

                case "2":
                    DeleteCustomerFromList();
                    break;

                case "3":
                    RegisterNewCustomer();
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

    //NOT DONE
    public void PaymentMethodRegisterMenu()
    {
        Console.Clear();
        string? menuChoice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Customer Register Menu");
            Console.WriteLine("---------------------");
            Console.WriteLine("1.  Show All Payment Methods");
            Console.WriteLine("2.  Delete Payment Method");
            Console.WriteLine("3.  Register New Payment Method");
            Console.WriteLine("9.  Go Back");
            Console.WriteLine("---------------------");
            Console.WriteLine();
            Console.Write("Enter menu choice: ");

            menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":

                    break;

                case "2":

                    break;

                case "3":

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

    // ------------------------------------------------ //




    // ------------------ CUSTOMERS ------------------- //

    public void ShowAllCustomers()
    {
        var customers = _customerService.GetAllCustomers();
        Console.Clear();

        Console.WriteLine("---------------------");
        Console.WriteLine("ALL CUSTOMERS");
        Console.WriteLine("---------------------");
        Console.WriteLine();

        foreach (var customer in customers)
        {
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine($"Customer Number: {customer.Id}");
            Console.WriteLine($"Customer: {customer.FirstName} {customer.LastName}, {customer.Email}");
            Console.WriteLine($"Address: {customer.Address.StreetName}, {customer.Address.PostalCode}, {customer.Address.City}");
            Console.WriteLine("---------------------");

        }
        PressAnyKey();
    }
    public void DeleteCustomerFromList()
    {
        var customers = _customerService.GetAllCustomers();
        bool loop = true;
        int customerNumber = 0;

        Console.Clear();

        do
        {

            Console.WriteLine("---------------------");
            Console.WriteLine("ALL CUSTOMERS");
            Console.WriteLine("---------------------");
            Console.WriteLine();

            foreach (var customer in customers)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------");
                Console.WriteLine($"Customer Number: {customer.Id}");
                Console.WriteLine($"Customer: {customer.FirstName} {customer.LastName}, {customer.Email}");
                Console.WriteLine($"Address: {customer.Address.StreetName}, {customer.Address.PostalCode}, {customer.Address.City}");
                Console.WriteLine("---------------------");
            }

            try
            {
                Console.WriteLine();
                Console.Write("Enter customer number of the customer you wish to delete: ");
                customerNumber = Convert.ToInt32(Console.ReadLine());

                loop = false;
            }
            catch
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("You can only enter a number.");
                PressAnyKey();
            }
        } while (loop);

        if (customerNumber != 0)
        {
            var customerToDelete = customers.FirstOrDefault(x => x.Id == customerNumber)!;
            var result = _customerService.DeleteCustomer(customerToDelete);
            Console.Clear();
            Console.WriteLine(result);
        }

        PressAnyKey();
    }
    public void RegisterNewCustomer()
    {
        string? menuChoice;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("---------------------");
        Console.WriteLine("Are you sure you want to add a new customer?");
        Console.WriteLine("1.  Yes");
        Console.WriteLine();
        Console.Write("Enter menu choice: ");

        menuChoice = Console.ReadLine();

        if (menuChoice == "1")
        {
            Console.Clear();
            Console.WriteLine("New Customer");
            Console.WriteLine("---------------------");
            Console.Write("First Name: ");
            string? firstName = Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.Write("Last Name: ");
            string? lastName = Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.Write("Email: ");
            string? email = Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.Write("Street Name: ");
            string? streetName = Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.Write("Postal Code: ");
            string? postalCode = Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.Write("City: ");
            string? city = Console.ReadLine();

            CustomerDto customerToAdd = new CustomerDto
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                StreetName = streetName,
                City = city,
                PostalCode = postalCode,
            };

            var result = _customerService.CreateCustomer(customerToAdd);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(result);
            PressAnyKey();
        }
        Console.Clear();
    }

    // UPDATE ALSO

    // ------------------------------------------------ //



    // NOT DONE
    // -------------- DELIVERY METHODS ---------------- //

    public void ShowAllDeliveryMethods()
    {
        var customers = _customerService.GetAllCustomers();
        Console.Clear();

        Console.WriteLine("---------------------");
        Console.WriteLine("ALL DELIVERY METHODS");
        Console.WriteLine("---------------------");
        Console.WriteLine();

        foreach (var customer in customers)
        {
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine($"Customer Number: {customer.Id}");
            Console.WriteLine($"Customer: {customer.FirstName} {customer.LastName}, {customer.Email}");
            Console.WriteLine($"Address: {customer.Address.StreetName}, {customer.Address.PostalCode}, {customer.Address.City}");
            Console.WriteLine("---------------------");

        }
        PressAnyKey();
    }
    public void DeleteDeliveryMethodFromList()
    {
        var customers = _customerService.GetAllCustomers();
        bool loop = true;
        int customerNumber = 0;

        Console.Clear();

        do
        {

            Console.WriteLine("---------------------");
            Console.WriteLine("ALL CUSTOMERS");
            Console.WriteLine("---------------------");
            Console.WriteLine();

            foreach (var customer in customers)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------");
                Console.WriteLine($"Customer Number: {customer.Id}");
                Console.WriteLine($"Customer: {customer.FirstName} {customer.LastName}, {customer.Email}");
                Console.WriteLine($"Address: {customer.Address.StreetName}, {customer.Address.PostalCode}, {customer.Address.City}");
                Console.WriteLine("---------------------");
            }

            try
            {
                Console.WriteLine();
                Console.Write("Enter customer number of the customer you wish to delete: ");
                customerNumber = Convert.ToInt32(Console.ReadLine());

                loop = false;
            }
            catch
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("You can only enter a number.");
                PressAnyKey();
            }
        } while (loop);

        if (customerNumber != 0)
        {
            var customerToDelete = customers.FirstOrDefault(x => x.Id == customerNumber)!;
            var result = _customerService.DeleteCustomer(customerToDelete);
            Console.Clear();
            Console.WriteLine(result);
        }

        PressAnyKey();
    }
    public void RegisterNewDeliveryMethod()
    {
        string? menuChoice;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("---------------------");
        Console.WriteLine("Are you sure you want to add a new customer?");
        Console.WriteLine("1.  Yes");
        Console.WriteLine();
        Console.Write("Enter menu choice: ");

        menuChoice = Console.ReadLine();

        if (menuChoice == "1")
        {
            Console.Clear();
            Console.WriteLine("New Customer");
            Console.WriteLine("---------------------");
            Console.Write("First Name: ");
            string? firstName = Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.Write("Last Name: ");
            string? lastName = Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.Write("Email: ");
            string? email = Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.Write("Street Name: ");
            string? streetName = Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.Write("Postal Code: ");
            string? postalCode = Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.Write("City: ");
            string? city = Console.ReadLine();

            CustomerDto customerToAdd = new CustomerDto
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                StreetName = streetName,
                City = city,
                PostalCode = postalCode,
            };

            var result = _customerService.CreateCustomer(customerToAdd);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(result);
            PressAnyKey();
        }
        Console.Clear();
    }

    // ------------------------------------------------ //



    // NOT DONE
    // -------------- DELIVERY METHODS ---------------- //

    public void ShowAllPaymentMethods()
    {
        var customers = _customerService.GetAllCustomers();
        Console.Clear();

        Console.WriteLine("---------------------");
        Console.WriteLine("ALL CUSTOMERS");
        Console.WriteLine("---------------------");
        Console.WriteLine();

        foreach (var customer in customers)
        {
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine($"Customer Number: {customer.Id}");
            Console.WriteLine($"Customer: {customer.FirstName} {customer.LastName}, {customer.Email}");
            Console.WriteLine($"Address: {customer.Address.StreetName}, {customer.Address.PostalCode}, {customer.Address.City}");
            Console.WriteLine("---------------------");

        }
        PressAnyKey();
    }
    public void DeletePaymentMethodFromList()
    {
        var customers = _customerService.GetAllCustomers();
        bool loop = true;
        int customerNumber = 0;

        Console.Clear();

        do
        {

            Console.WriteLine("---------------------");
            Console.WriteLine("ALL CUSTOMERS");
            Console.WriteLine("---------------------");
            Console.WriteLine();

            foreach (var customer in customers)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------");
                Console.WriteLine($"Customer Number: {customer.Id}");
                Console.WriteLine($"Customer: {customer.FirstName} {customer.LastName}, {customer.Email}");
                Console.WriteLine($"Address: {customer.Address.StreetName}, {customer.Address.PostalCode}, {customer.Address.City}");
                Console.WriteLine("---------------------");
            }

            try
            {
                Console.WriteLine();
                Console.Write("Enter customer number of the customer you wish to delete: ");
                customerNumber = Convert.ToInt32(Console.ReadLine());

                loop = false;
            }
            catch
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("You can only enter a number.");
                PressAnyKey();
            }
        } while (loop);

        if (customerNumber != 0)
        {
            var customerToDelete = customers.FirstOrDefault(x => x.Id == customerNumber)!;
            var result = _customerService.DeleteCustomer(customerToDelete);
            Console.Clear();
            Console.WriteLine(result);
        }

        PressAnyKey();
    }
    public void RegisterNewPaymentMethod()
    {
        string? menuChoice;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("---------------------");
        Console.WriteLine("Are you sure you want to add a new customer?");
        Console.WriteLine("1.  Yes");
        Console.WriteLine();
        Console.Write("Enter menu choice: ");

        menuChoice = Console.ReadLine();

        if (menuChoice == "1")
        {
            Console.Clear();
            Console.WriteLine("New Customer");
            Console.WriteLine("---------------------");
            Console.Write("First Name: ");
            string? firstName = Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.Write("Last Name: ");
            string? lastName = Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.Write("Email: ");
            string? email = Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.Write("Street Name: ");
            string? streetName = Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.Write("Postal Code: ");
            string? postalCode = Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.Write("City: ");
            string? city = Console.ReadLine();

            CustomerDto customerToAdd = new CustomerDto
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                StreetName = streetName,
                City = city,
                PostalCode = postalCode,
            };

            var result = _customerService.CreateCustomer(customerToAdd);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(result);
            PressAnyKey();
        }
        Console.Clear();
    }

    // ------------------------------------------------ //













    public void ProductAdminMenu()
    {

    }

    public void PressAnyKey() 
    {
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }

}