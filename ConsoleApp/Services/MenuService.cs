using Infrastructure.Dtos;
using Infrastructure.Entities;
using Infrastructure.Services;
using System.Diagnostics;

namespace ConsoleApp.Services;

public class MenuService
{
    private readonly OrderService _orderService;
    private readonly CustomerService _customerService;
    private readonly ProductService _productService;

    public MenuService(OrderService orderService, CustomerService customerService, ProductService productService)
    {
        _orderService = orderService;
        _customerService = customerService;
        _productService = productService;
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
            Console.WriteLine("1.  Register New Order");
            Console.WriteLine("2.  Order Register");
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
                    RegisterNewOrder();
                    break;

                case "2":
                    OrderRegisterMenu();
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
            Console.WriteLine("4.  Update Customer");
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

                case "4":
                    UpdateCustomerFromList();
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
    public void OrderRegisterMenu()
    {
        Console.Clear();
        string? menuChoice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Order Register Menu");
            Console.WriteLine("---------------------");
            Console.WriteLine("1.  Show All Orders");
            Console.WriteLine("2.  Delete Order");
            Console.WriteLine("3.  Register New Order");
            Console.WriteLine("9.  Go Back");
            Console.WriteLine("---------------------");
            Console.WriteLine();
            Console.Write("Enter menu choice: ");

            menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    ShowAllOrders();
                    break;

                case "2":
                    DeleteOrderFromList();
                    break;

                case "3":
                    RegisterNewOrder();
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
                    ShowAllDeliveryMethods();
                    break;

                case "2":
                    DeleteDeliveryMethodFromList();
                    break;

                case "3":
                    RegisterNewDeliveryMethod();
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
    public void PaymentMethodRegisterMenu()
    {
        Console.Clear();
        string? menuChoice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Payment Method Register Menu");
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
                    ShowAllPaymentMethods();
                    break;

                case "2":
                    DeletePaymentMethodFromList();
                    break;

                case "3":
                    RegisterNewPaymentMethod();
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


    public void ProductAdminMenu()
    {
        Console.Clear();
        string? menuChoice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Product Administration Menu");
            Console.WriteLine("---------------------");
            Console.WriteLine("1.  Register New Product");
            Console.WriteLine("2.  Product Register");
            Console.WriteLine("3.  Category Register");
            Console.WriteLine("4.  Brand Register");
            Console.WriteLine("9.  Go Back");
            Console.WriteLine("---------------------");
            Console.WriteLine();
            Console.Write("Enter menu choice: ");

            menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    RegisterNewProduct();
                    break;

                case "2":
                    ProductRegisterMenu();
                    break;

                case "3":
                    CategoryRegisterMenu();
                    break;

                case "4":
                    BrandRegisterMenu();
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
    public void ProductRegisterMenu()
    {
        Console.Clear();
        string? menuChoice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Product Register Menu");
            Console.WriteLine("---------------------");
            Console.WriteLine("1.  Show All Products");
            Console.WriteLine("2.  Delete Product");
            Console.WriteLine("3.  Register New Product");
            Console.WriteLine("9.  Go Back");
            Console.WriteLine("---------------------");
            Console.WriteLine();
            Console.Write("Enter menu choice: ");

            menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    ShowAllProducts();
                    break;

                case "2":
                    DeleteProductFromList();
                    break;

                case "3":
                    RegisterNewProduct();
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
    public void CategoryRegisterMenu()
    {
        Console.Clear();
        string? menuChoice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Category Register Menu");
            Console.WriteLine("---------------------");
            Console.WriteLine("1.  Show All Categories");
            Console.WriteLine("2.  Delete Category");
            Console.WriteLine("3.  Register New Category");
            Console.WriteLine("4.  Show All Sub Categories");
            Console.WriteLine("5.  Delete Sub Category");
            Console.WriteLine("6.  Register New Sub Category");
            Console.WriteLine("9.  Go Back");
            Console.WriteLine("---------------------");
            Console.WriteLine();
            Console.Write("Enter menu choice: ");

            menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    ShowAllCategories();
                    break;

                case "2":
                    DeleteCategory();
                    break;

                case "3":
                    RegisterNewCategory();
                    break;

                case "4":
                    ShowAllSubCategories();
                    break;

                case "5":
                    DeleteSubCategory();
                    break;

                case "6":
                    RegisterNewSubCategory();
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
    public void BrandRegisterMenu()
    {
        {
            Console.Clear();
            string? menuChoice;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Brand Register Menu");
                Console.WriteLine("---------------------");
                Console.WriteLine("1.  Show All Brands");
                Console.WriteLine("2.  Delete Brand");
                Console.WriteLine("3.  Register New Brand");
                Console.WriteLine("9.  Go Back");
                Console.WriteLine("---------------------");
                Console.WriteLine();
                Console.Write("Enter menu choice: ");

                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        //ShowAllBrands();
                        break;

                    case "2":
                        //DeleteBrand();
                        break;

                    case "3":
                        //RegisterNewBrand();
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
    }  // NOT IMPLEMENTED



    // ------------------- ORDERS --------------------- //
    public void ShowAllOrders()
    {
        //var orders = _orderService.GetAllOrders().ToList();
        var orders = _orderService.GetAllOrders();

        //var orders = _orderRepository.GetAll();
        Console.Clear();

        Console.WriteLine("---------------------");
        Console.WriteLine("ALL ORDERS");
        Console.WriteLine("---------------------");

        foreach (var order in orders)
        {
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine($"Order Number: {order.Id}");
            Console.WriteLine($"Customer: {order.Customer.FirstName} {order.Customer.LastName}, {order.Customer.Email}");
            Console.WriteLine($"Address: {order.Customer.Address.StreetName}, {order.Customer.Address.PostalCode}, {order.Customer.Address.City}");
            Console.WriteLine($"Delivery Method: {order.DeliveryMethod.DeliveryMethodName}");
            Console.WriteLine($"Payment Method: {order.PaymentMethod.PaymentMethodName}");
            Console.WriteLine("---------------------");
            Console.WriteLine("Ordered Products:");
            foreach (var orderRow in order.OrderRows)
            {
                var product = _productService.GetProduct(orderRow.ProductId);
                if(product != null)
                    Console.WriteLine($"{orderRow.Id}.   {orderRow.Quantity}pcs, {product.Title}, {orderRow.RowPrice:0.00} SEK");
            }
            Console.WriteLine("---------------------");
        }

        PressAnyKey();
    }
    public void DeleteOrderFromList()
    {
        var orders = _orderService.GetAllOrders();
        bool loop = true;
        int orderNumber = 0;

        Console.Clear();

        do
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("ALL ORDERS");
            Console.WriteLine("---------------------");
            Console.WriteLine();

            foreach (var order in orders)
            {
                int numberOfOrderRows = order.OrderRows.ToList().Count;
                Console.WriteLine($"Order Number: {order.Id}");
                Console.WriteLine($"Customer: {order.Customer.FirstName} {order.Customer.LastName}");
                Console.WriteLine($"Number of order rows: {numberOfOrderRows}");
                Console.WriteLine("---------------------");
            }

            try
            {
                Console.WriteLine();
                Console.Write("Enter order number of the order you wish to delete (enter 0 to go back): ");
                orderNumber = Convert.ToInt32(Console.ReadLine());

                if (orderNumber != 0)
                {
                    var orderToDelete = orders.FirstOrDefault(x => x.Id == orderNumber)!;
                    var result = _orderService.DeleteOrder(orderToDelete);
                    Console.Clear();

                    if (result)
                    {
                        Console.WriteLine("\nOrder was deleted successfully.");
                        loop = false;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter a valid number.");
                    }
                }
                else loop = false;
            }
            catch
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("You can only enter a number.");
                PressAnyKey();
            }
        } while (loop);



        PressAnyKey();
    }
    public void RegisterNewOrder()
    {
        OrderEntity order = new OrderEntity();

        string? menuChoice;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("---------------------");
        Console.WriteLine("Are you sure you want to add a new order?");
        Console.WriteLine("1.  Yes");
        Console.WriteLine();
        Console.Write("Enter menu choice: ");

        menuChoice = Console.ReadLine();

        if (menuChoice == "1")
        {
            // Get customer-dialogue
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("New or existing customer?");
            Console.WriteLine("1.  New Customer");
            Console.WriteLine("2.  Existing Customer");
            Console.WriteLine();
            Console.Write("Enter menu choice: ");
            menuChoice = Console.ReadLine();

            // Get customer-switch
            switch (menuChoice)
            {
                case "1":
                    try
                    {
                        order.CustomerId = RegisterNewCustomerFromOrderMenu();
                    }
                    catch { }
                    break;
 
                case "2":
                    order.CustomerId = SelectCustomerFromList().Id;
                    break;
            }

            // Get delivery method-dialogue
            List<DeliveryMethodEntity> deliveryMethods = _orderService.GetAllDeliveryMethods().ToList();
            Console.Clear();

            Console.WriteLine("---------------------");
            Console.WriteLine("Delivery Methods: ");
            for (int i = 0; i < deliveryMethods.Count(); i++)
            {
                Console.WriteLine($"{i+1}.  {deliveryMethods[i].DeliveryMethodName}");
            }
            Console.WriteLine();
            Console.Write("Enter menu choice: ");

            // Get delivery method-logic
            bool loop = true;
            do
            {
                try
                {
                    int menuChoiceInt = Convert.ToInt32(Console.ReadLine());
                    order.DeliveryMethodId = deliveryMethods[menuChoiceInt-1].Id;
                    loop = false;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    Console.WriteLine("You can only enter an integer that is represented in the list of delivery methods.");
                    PressAnyKey();
                }
            } while (loop);


            // Get payment method-dialogue
            List<PaymentMethodEntity> paymentMethods = _orderService.GetAllPaymentMethods().ToList();
            Console.Clear();

            Console.WriteLine("---------------------");
            Console.WriteLine("Payment Methods: ");
            for (int i = 0; i < paymentMethods.Count(); i++)
            {
                Console.WriteLine($"{i + 1}.  {paymentMethods[i].PaymentMethodName}");
            }
            Console.WriteLine();
            Console.Write("Enter menu choice: ");

            // Get payment method-logic
            loop = true;
            do
            {
                try
                {
                    int menuChoiceInt = Convert.ToInt32(Console.ReadLine());
                    order.PaymentMethodId = paymentMethods[menuChoiceInt - 1].Id;
                    loop = false;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    Console.WriteLine("You can only enter an integer that is represented in the list of payment methods.");
                    PressAnyKey();
                }
            } while (loop);
            var createdOrder = _orderService.CreateOrder(order);

            AddOrderRows(createdOrder);

            PressAnyKey();
        }
        Console.Clear();
    }



    // ------------------ CUSTOMERS ------------------- //
    public void ShowAllCustomers()
    {
        var customers = _customerService.GetAllCustomers();
        Console.Clear();

        Console.WriteLine("---------------------");
        Console.WriteLine("ALL CUSTOMERS");
        Console.WriteLine("---------------------");

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
    public void UpdateCustomerFromList()
    {
        var oldCustomerDetails = SelectCustomerFromList();

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Update Customer");
        Console.WriteLine("---------------------");
        Console.WriteLine($"OLD First Name: {oldCustomerDetails.FirstName}");
        Console.Write("NEW First Name: ");
        string? firstName = Console.ReadLine();
        Console.WriteLine("---------------------");
        Console.WriteLine($"OLD Last Name: {oldCustomerDetails.LastName}");
        Console.Write("NEW  Last Name: ");
        string? lastName = Console.ReadLine();
        Console.WriteLine("---------------------");
        Console.WriteLine($"OLD Email: {oldCustomerDetails.Email}");
        Console.Write("NEW Email: ");
        string? email = Console.ReadLine();
        Console.WriteLine("---------------------");
        Console.WriteLine($"OLD Street Name: {oldCustomerDetails.Address.StreetName}");
        Console.Write("NEW Street Name: ");
        string? streetName = Console.ReadLine();
        Console.WriteLine("---------------------");
        Console.WriteLine($"OLD First Name: {oldCustomerDetails.Address.PostalCode}");
        Console.Write("NEW Postal Code: ");
        string? postalCode = Console.ReadLine();
        Console.WriteLine("---------------------");
        Console.WriteLine($"OLD First Name: {oldCustomerDetails.Address.City}");
        Console.Write("NEW City: ");
        string? city = Console.ReadLine();

        CustomerDto newCustomerDetails = new()
        {
            Id = oldCustomerDetails.Id,
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            StreetName = streetName,
            City = city,
            PostalCode = postalCode,
        };

        var result = _customerService.UpdateCustomer(newCustomerDetails);

        Console.WriteLine(result);
        Console.WriteLine();

        PressAnyKey();
    }
    public CustomerEntity SelectCustomerFromList()
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
                Console.Write("Enter customer number of the customer you wish to select: ");
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
            var customerToSelect = customers.FirstOrDefault(x => x.Id == customerNumber)!;
            Console.Clear();
            return customerToSelect;
        }
        else return null!;

        PressAnyKey();
    }
    public CustomerEntity RegisterNewCustomer()
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
            Console.WriteLine();
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
            Console.Clear();
            return customerToAdd;
        }
        else
        {
            Console.Clear();
            return null!; 
        }
    }
    public int RegisterNewCustomerFromOrderMenu()
    {
        Console.Clear();
        Console.WriteLine();
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

        var customers = _customerService.GetAllCustomers().ToList();

        int customerId = customers.FirstOrDefault(x => x.Email == customerToAdd.Email).Id;

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine(result);
        PressAnyKey();
        Console.Clear();
        return customerId;
    }



    // -------------- DELIVERY METHODS ---------------- //
    public void ShowAllDeliveryMethods()
    {
        var deliveryMethods = _orderService.GetAllDeliveryMethods();
        Console.Clear();

        Console.WriteLine("---------------------");
        Console.WriteLine("ALL DELIVERY METHODS");
        Console.WriteLine("---------------------");
        Console.WriteLine();

        foreach (var deliveryMethod in deliveryMethods)
        {
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine($"Delivery Method ID: {deliveryMethod.Id}");
            Console.WriteLine($"Delivery Method: {deliveryMethod.DeliveryMethodName}");
            Console.WriteLine("---------------------");
        }
        PressAnyKey();
    }
    public void DeleteDeliveryMethodFromList()
    {
        var deliveryMethods = _orderService.GetAllDeliveryMethods();
        bool loop = true;
        int deliveryMethodId = 0;

        Console.Clear();

        do
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("ALL DELIVERY METHODS");
            Console.WriteLine("---------------------");
            Console.WriteLine();

            foreach (var deliveryMethod in deliveryMethods)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------");
                Console.WriteLine($"Delivery Method ID: {deliveryMethod.Id}");
                Console.WriteLine($"Delivery Method: {deliveryMethod.DeliveryMethodName}");
                Console.WriteLine("---------------------");
            }

            try
            {
                Console.WriteLine();
                Console.Write("Enter delivery method ID of the delivery method you wish to delete: ");
                deliveryMethodId = Convert.ToInt32(Console.ReadLine());

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

        if (deliveryMethodId != 0)
        {
            var deliveryMethodToDelete = deliveryMethods.FirstOrDefault(x => x.Id == deliveryMethodId)!;
            var result = _orderService.DeleteDeliveryMethod(deliveryMethodToDelete);
            Console.Clear();

            Console.WriteLine();
            if (result)
                Console.WriteLine("Delivery method was deleted.");
            else Console.WriteLine("Something went wrong, delivery method was not deleted.");
        }

        PressAnyKey();
    }
    public void RegisterNewDeliveryMethod()
    {
        string? menuChoice;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("---------------------");
        Console.WriteLine("Are you sure you want to add a new delivery method?");
        Console.WriteLine("1.  Yes");
        Console.WriteLine();
        Console.Write("Enter menu choice: ");

        menuChoice = Console.ReadLine();

        if (menuChoice == "1")
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("New Delivery Method");
            Console.WriteLine("---------------------");
            Console.Write("Delivery Method Name: ");
            string? deliveryMethodName = Console.ReadLine();

            DeliveryMethodEntity deliveryMethodToAdd = new DeliveryMethodEntity
            {
                DeliveryMethodName = deliveryMethodName!,
            };

            var result = _orderService.CreateDeliveryMethod(deliveryMethodToAdd);
            Console.Clear();

            Console.WriteLine();
            if (result)
                Console.WriteLine("Delivery method was added.");
            else Console.WriteLine("Something went wrong, delivery method was not added.");

            PressAnyKey();
        }
        Console.Clear();
    }



    // -------------- PAYMENT METHODS ----------------- //
    public void ShowAllPaymentMethods()
    {
        var paymentMethods = _orderService.GetAllPaymentMethods();
        Console.Clear();

        Console.WriteLine("---------------------");
        Console.WriteLine("ALL PAYMENT METHODS");
        Console.WriteLine("---------------------");
        Console.WriteLine();

        foreach (var paymentMethod in paymentMethods)
        {
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine($"Payment Method ID: {paymentMethod.Id}");
            Console.WriteLine($"Payment Method: {paymentMethod.PaymentMethodName}");
            Console.WriteLine("---------------------");
        }
        PressAnyKey();
    }
    public void DeletePaymentMethodFromList()
    {
        var paymentMethods = _orderService.GetAllPaymentMethods();
        bool loop = true;
        int paymentMethodId = 0;

        Console.Clear();

        do
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("ALL PAYMENT METHODS");
            Console.WriteLine("---------------------");
            Console.WriteLine();

            foreach (var paymentMethod in paymentMethods)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------");
                Console.WriteLine($"Payment Method ID: {paymentMethod.Id}");
                Console.WriteLine($"Payment Method: {paymentMethod.PaymentMethodName}");
                Console.WriteLine("---------------------");
            }

            try
            {
                Console.WriteLine();
                Console.Write("Enter payment method ID of the payment method you wish to delete: ");
                paymentMethodId = Convert.ToInt32(Console.ReadLine());

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

        if (paymentMethodId != 0)
        {
            var paymentMethodToDelete = paymentMethods.FirstOrDefault(x => x.Id == paymentMethodId)!;
            var result = _orderService.DeletePaymentMethod(paymentMethodToDelete);
            Console.Clear();

            Console.WriteLine();
            if (result)
                Console.WriteLine("Payment method was deleted.");
            else Console.WriteLine("Something went wrong, payment method was not deleted.");
        }

        PressAnyKey();
    }
    public void RegisterNewPaymentMethod()
    {
        string? menuChoice;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("---------------------");
        Console.WriteLine("Are you sure you want to add a new payment method?");
        Console.WriteLine("1.  Yes");
        Console.WriteLine();
        Console.Write("Enter menu choice: ");

        menuChoice = Console.ReadLine();

        if (menuChoice == "1")
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("New Payment Method");
            Console.WriteLine("---------------------");
            Console.Write("Payment Method Name: ");
            string? paymentMethodName = Console.ReadLine();

            PaymentMethodEntity paymentMethodToAdd = new PaymentMethodEntity
            {
                PaymentMethodName = paymentMethodName!,
            };

            var result = _orderService.CreatePaymentMethod(paymentMethodToAdd);
            Console.Clear();

            Console.WriteLine();
            if (result)
                Console.WriteLine("Payment method was added.");
            else Console.WriteLine("Something went wrong, payment method was not added.");

            PressAnyKey();
        }
        Console.Clear();
    }



    // ----------------- ORDER ROWS ------------------- //
    public void AddOrderRows(OrderEntity order)
    {

        int orderRowId = 0;
        bool loop = true;

        do
        {
            orderRowId++;

            OrderRowEntity orderRow = new OrderRowEntity
            {
                OrderId = order.Id,
                Id = orderRowId               
            };

            string? menuChoice = "";
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("Menu");
            Console.WriteLine("1.  Add Order Row");
            Console.WriteLine("2.  Finish Register Order");
            Console.WriteLine();
            Console.Write("Enter menu choice: ");

            menuChoice = Console.ReadLine();

            switch(menuChoice)
            {

                case "1":
                    orderRow.ProductId = SelectProductFromList();
                    orderRow.Quantity = SetQuantity();
                    orderRow.RowPrice = SetPrice(orderRow);
                    _orderService.CreateOrderRow(orderRow);
                    break;
                case "2":
                    loop = false;
                    break;

                default:
                    break;
            }

        }
        while (loop);
        
        Console.Clear();
    }



    // ------------------ PRODUCTS -------------------- //
    public void ShowAllProducts()
    {
        var products = _productService.GetAllProducts();
        Console.Clear();

        Console.WriteLine("---------------------");
        Console.WriteLine("ALL PRODUCTS");
        Console.WriteLine("---------------------");
        Console.WriteLine();

        foreach (var product in products)
        {
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine($"Article Number: {product.ArticleNumber}");
            Console.WriteLine($"Title: {product.Title} - {product.Brand.BrandName} - {product.Description}");
            Console.WriteLine($"Category: {product.Category.CategoryName} -> {product.SubCategory.SubCategoryName}");
            Console.WriteLine("---------------------");
        }
        PressAnyKey();
    }
    public void DeleteProductFromList()
    {
        var products = _productService.GetAllProducts();
        bool loop = true;
        int articleNumber = 0;

        Console.Clear();

        do
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("ALL PRODUCTS");
            Console.WriteLine("---------------------");
            Console.WriteLine();

            foreach (var product in products)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------");
                Console.WriteLine($"Article Number: {product.ArticleNumber}");
                Console.WriteLine($"Title: {product.Title} - {product.Brand.BrandName} - {product.Description}");
                Console.WriteLine($"Category: {product.Category.CategoryName} -> {product.SubCategory.SubCategoryName}");
                Console.WriteLine("---------------------");
            }

            try
            {
                Console.WriteLine();
                Console.Write("Enter article number of the product you wish to delete: ");
                articleNumber = Convert.ToInt32(Console.ReadLine());

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

        if (articleNumber != 0)
        {
            var productToDelete = products.FirstOrDefault(x => x.ArticleNumber == articleNumber)!;
            var result = _productService.DeleteProduct(productToDelete);
            Console.Clear();

            if (result)
                Console.WriteLine("Product was deleted.");
            else Console.WriteLine("Something went wrong, product was not deleted.");
        }

        PressAnyKey();
    }
    public void RegisterNewProduct()
    {
        Product productToAdd = new Product();

        string? menuChoice;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("---------------------");
        Console.WriteLine("Are you sure you want to add a new product?");
        Console.WriteLine("1.  Yes");
        Console.WriteLine();
        Console.Write("Enter menu choice: ");

        menuChoice = Console.ReadLine();

        if (menuChoice == "1")
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("New Product");
            Console.WriteLine("---------------------");
            Console.Write("Product Title: ");

            // should not be nullable, FIX
            productToAdd.Title = Console.ReadLine();

            // should not be nullable, FIX
            Console.Write("Description: ");
            productToAdd.Description = Console.ReadLine();

            // TRY CATCH HERE
            Console.Write("Price: ");
            productToAdd.Price = Convert.ToDecimal(Console.ReadLine());

            productToAdd.CategoryId = SelectCategoryFromList();
            productToAdd.SubCategoryId = SelectSubCategoryFromList(productToAdd.CategoryId);
            productToAdd.BrandId = SelectBrandFromList();

            var result = _productService.CreateProduct(productToAdd);
            Console.Clear();

            Console.WriteLine();
            if (result)
                Console.WriteLine("Product was added.");
            else Console.WriteLine("Something went wrong, product was not added.");

            PressAnyKey();
        }
        Console.Clear();
    }
    public int SelectProductFromList()
    {
        var products = _productService.GetAllProducts().ToList();
        bool loop = true;

        do
        {
            Console.Clear();

            Console.WriteLine("---------------------");
            Console.WriteLine("Product: ");
            for (int i = 0; i < products.Count(); i++)
            {
                Console.WriteLine($"{i + 1}.  {products[i].Title}");
            }
            Console.WriteLine();
            Console.Write("Enter menu choice: ");

            try
            {
                int menuChoiceInt = Convert.ToInt32(Console.ReadLine());
                var result = products[menuChoiceInt - 1].ArticleNumber;
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("You can only enter an integer that is represented in the list of products.");
                PressAnyKey();
            }
        } while (loop);

        return 0;
    }



    // ----------------- CATEGORIES ------------------- //
    public int SelectCategoryFromList()
    {
        var categories = _productService.GetAllCategories().ToList();
        bool loop = true;

        do
        {
            Console.Clear();

            Console.WriteLine("---------------------");
            Console.WriteLine("Category: ");
            for (int i = 0; i < categories.Count(); i++)
            {
                Console.WriteLine($"{i + 1}.  {categories[i].CategoryName}");
            }
            Console.WriteLine();
            Console.Write("Enter menu choice: ");

            try
            {
                int menuChoiceInt = Convert.ToInt32(Console.ReadLine());
                var result = categories[menuChoiceInt - 1].Id;
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("You can only enter an integer that is represented in the list of categories.");
                PressAnyKey();
            }
        } while (loop);

        return 0;
    }
    public void ShowAllCategories()
    {
        var categories = _productService.GetAllCategories();
        Console.Clear();

        Console.WriteLine("---------------------");
        Console.WriteLine("ALL CATEGORIES");
        Console.WriteLine("---------------------");
        Console.WriteLine();

        foreach (var category in categories)
        {
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine($"Category ID: {category.Id}");
            Console.WriteLine($"Category: {category.CategoryName}");
            Console.WriteLine("---------------------");
        }
        PressAnyKey();
    }
    public void DeleteCategory()
    {
        var categories = _productService.GetAllCategories();
        bool loop = true;
        int categorydId = 0;

        Console.Clear();

        do
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("ALL CATEGORIES");
            Console.WriteLine("---------------------");
            Console.WriteLine();

            foreach (var category in categories)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------");
                Console.WriteLine($"Category ID: {category.Id}");
                Console.WriteLine($"Category: {category.CategoryName}");
                Console.WriteLine("---------------------");
            }

            try
            {
                Console.WriteLine();
                Console.WriteLine("WARNING - DELETING A CATEGORY WILL DELETE ALL PRODUCTS, SUB CATEGORIES AND ORDERS ASSOCIATED WITH IT.");
                Console.WriteLine();
                Console.Write("Enter category ID of the category you wish to delete (enter 0 to go back): ");
                categorydId = Convert.ToInt32(Console.ReadLine());

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

        if (categorydId != 0)
        {
            var categoryToDelete = categories.FirstOrDefault(x => x.Id == categorydId)!;
            var result = _productService.DeleteCategory(categoryToDelete);
            Console.Clear();

            Console.WriteLine();
            if (result)
                Console.WriteLine("Category was deleted.");
            else Console.WriteLine("Something went wrong, category was not deleted.");
        }

        PressAnyKey();
    }
    public void RegisterNewCategory()
    {
        string? menuChoice;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("---------------------");
        Console.WriteLine("Are you sure you want to add a new category?");
        Console.WriteLine("1.  Yes");
        Console.WriteLine();
        Console.Write("Enter menu choice: ");

        menuChoice = Console.ReadLine();

        if (menuChoice == "1")
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("New Category");
            Console.WriteLine("---------------------");
            Console.Write("Category Name: ");
            string? categoryName = Console.ReadLine();

            Category categoryToAdd = new Category
            {
                CategoryName = categoryName!,
            };

            var result = _productService.CreateCategory(categoryToAdd);
            Console.Clear();

            Console.WriteLine();
            if (result)
                Console.WriteLine("Category was added.");
            else Console.WriteLine("Something went wrong, category was not added.");

            PressAnyKey();
        }
        Console.Clear();
    }



    // --------------- SUB CATEGORIES  ---------------- //
    public int SelectSubCategoryFromList(int id)
    {
        var subCategories = _productService.GetAllSubCategories(id).ToList();
        bool loop = true;

        do
        {
            Console.Clear();

            Console.WriteLine("---------------------");
            Console.WriteLine("Sub Categories: ");
            for (int i = 0; i < subCategories.Count(); i++)
            {
                Console.WriteLine($"{i + 1}.  {subCategories[i].SubCategoryName}");
            }
            Console.WriteLine();
            Console.Write("Enter menu choice: ");

            try
            {
                int menuChoiceInt = Convert.ToInt32(Console.ReadLine());
                var result = subCategories[menuChoiceInt - 1].Id;
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("You can only enter an integer that is represented in the list of sub categories.");
                PressAnyKey();
            }
        } while (loop);

        return 0;
    }
    public void ShowAllSubCategories()
    {
        var categories = _productService.GetAllCategories();
        Console.Clear();

        Console.WriteLine("---------------------");
        Console.WriteLine("ALL SUB CATEGORIES");
        Console.WriteLine("---------------------");
        Console.WriteLine();

        foreach (var category in categories)
        {
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine($"Category: {category.CategoryName}");
            Console.WriteLine();
            int count = 1;

            foreach (var subCategory in category.SubCategories)
            {
                Console.WriteLine($"{count}. {subCategory.SubCategoryName}");
                count++;
            }
        }
        PressAnyKey();
    }
    public void DeleteSubCategory()
    {
        var categories = _productService.GetAllCategories();
        var subCategories = _productService.GetAllSubCategories().ToList();
        bool loop = true;
        int subCategorydId = 0;

        Console.Clear();

        do
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("ALL SUB CATEGORIES");
            Console.WriteLine("---------------------");
            Console.WriteLine();
            int count = 1;

            foreach (var category in categories)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------");
                Console.WriteLine($"Category: {category.CategoryName}");
                Console.WriteLine();

                foreach (var subCategory in category.SubCategories)
                {
                    Console.WriteLine($"{count}. {subCategory.SubCategoryName}");
                    count++;
                }
            }

            try
            {
                Console.WriteLine();
                Console.WriteLine("WARNING - DELETING A SUB CATEGORY WILL DELETE ALL PRODUCTS AND ORDERS ASSOCIATED WITH IT.");
                Console.WriteLine();
                Console.Write("Enter sub category ID of the sub category you wish to delete (enter 0 to go back): ");
                subCategorydId = Convert.ToInt32(Console.ReadLine());

                if (subCategorydId == 0)
                    break;

                var subCategoryToDelete = subCategories[subCategorydId-1];
                var result = _productService.DeleteSubCategory(subCategoryToDelete);
                Console.Clear();
                Console.WriteLine();


                if (result)
                {
                    Console.WriteLine("Category was successfully deleted.");
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Something went wrong, category was not deleted.");
                    loop = false;
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("You can only enter a number represented in the list of sub categories.");
                PressAnyKey();
            }
        } while (loop);


        PressAnyKey();
    }
    public void RegisterNewSubCategory()
    {
        string? menuChoice;
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("---------------------");
        Console.WriteLine("Are you sure you want to add a new sub category?");
        Console.WriteLine("1.  Yes");
        Console.WriteLine("2.  No");
        Console.WriteLine();
        Console.Write("Enter menu choice: ");

        menuChoice = Console.ReadLine();

        if (menuChoice == "1")
        {
            int categoryId = SelectCategoryFromList();

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("New Sub Category");
            Console.WriteLine("---------------------");
            Console.Write("Sub Category Name: ");
            string? subCategoryName = Console.ReadLine();

            SubCategory subCategoryToAdd = new SubCategory
            {
                SubCategoryName = subCategoryName!,
                CategoryId = categoryId
            };

            var result = _productService.CreateSubCategory(subCategoryToAdd);
            Console.Clear();

            Console.WriteLine();
            if (result)
                Console.WriteLine("Sub category was added.");
            else Console.WriteLine("Something went wrong, sub category was not added.");

            PressAnyKey();
        }
        Console.Clear();
    }



    // ------------------- BRANDS --------------------- //
    public int SelectBrandFromList()
    {
        var brands = _productService.GetAllBrands().ToList();
        bool loop = true;

        do
        {
            Console.Clear();

            Console.WriteLine("---------------------");
            Console.WriteLine("Brand: ");
            for (int i = 0; i < brands.Count(); i++)
            {
                Console.WriteLine($"{i + 1}.  {brands[i].BrandName}");
            }
            Console.WriteLine();
            Console.Write("Enter menu choice: ");

            try
            {
                int menuChoiceInt = Convert.ToInt32(Console.ReadLine());
                var result = brands[menuChoiceInt - 1].Id;
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("You can only enter an integer that is represented in the list of brands.");
                PressAnyKey();
            }
        } while (loop);

        return 0;
    }



    // -------------------- MISC ---------------------- //
    public void PressAnyKey() 
    {
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
    public int SetQuantity()
    {
        bool loop = true;
        do
        {
            try
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("---------------------");
                Console.Write("Enter quantity: ");

                int quantity = Convert.ToInt32(Console.ReadLine());
                return quantity;
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("You can only enter an integer.");
                Console.WriteLine();
            }
        } while (loop);
        return 0;
    }
    public decimal SetPrice(OrderRowEntity orderRow)
    {
        var result = _productService.GetProduct(orderRow.ProductId);
        decimal price = result.Price * orderRow.Quantity;
        return price;
    }
}