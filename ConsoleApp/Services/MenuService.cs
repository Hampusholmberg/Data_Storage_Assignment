using Infrastructure.Dtos;
using Infrastructure.Entities;
using Infrastructure.Services;
using System.Diagnostics;

namespace ConsoleApp.Services;

public class MenuService
{
    private readonly OrderService _orderService;
    private readonly CustomerService _customerService;

    public MenuService(OrderService orderService, CustomerService customerService)
    {
        _orderService = orderService;
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

    public void OrderRegisterMenu()
    {
        Console.Clear();
        string? menuChoice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Customer Register Menu");
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

    // ------------------------------------------------ //




    // ------------------- ORDERS --------------------- //

    public void ShowAllOrders()
    {
        var orders = _orderService.GetAllOrders();
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
                // IMPLEMENTERA NÅGON TYP AV LISTA MED NAMN PÅ PRODUKTER
                Console.WriteLine($"{orderRow.Id}, {orderRow.ProductId}, {orderRow.Quantity}st, {orderRow.RowPrice}");
            }
            Console.WriteLine("---------------------");
        }
        Console.WriteLine();
        //Console.Write("Enter order number to see details (leave blank to continue): ");

        //// Crashes on faulty input. IMPLENENT TRY CATCH
        //int orderToExpand = Convert.ToInt32(Console.ReadLine());

        //_orderService.GetOrder(orderToExpand);

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
                Console.WriteLine($"Order Number: {order.Id}");
                Console.WriteLine($"Customer: {order.Customer.FirstName} {order.Customer.LastName}");
                Console.WriteLine($"Number of order rows: Logic not implemented yet :)");
                Console.WriteLine("---------------------");
            }

            try
            {
                Console.WriteLine();
                Console.Write("Enter order number of the orderyou wish to delete: ");
                orderNumber = Convert.ToInt32(Console.ReadLine());

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

        if (orderNumber != 0)
        {
            var orderToDelete = orders.FirstOrDefault(x => x.Id == orderNumber)!;
            var result = _orderService.DeleteOrder(orderToDelete);
            Console.Clear();
            Console.WriteLine(result);
        }

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
                    order.CustomerId = RegisterNewCustomer().Id;
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

            // ADD LOGIC TO CREATE ORDER ROWS HERE (MUST SET UP PRODUCT CATALOG DB)


            PressAnyKey();
        }
        Console.Clear();
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

    // ------------------------------------------------ //




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

    // ------------------------------------------------ //




    // -------------- DELIVERY METHODS ---------------- //

    public void ShowAllPaymentMethods()
    {
        var paymentMethods = _orderService.GetAllPaymentMethods();
        Console.Clear();

        Console.WriteLine("---------------------");
        Console.WriteLine("ALL DELIVERY METHODS");
        Console.WriteLine("---------------------");
        Console.WriteLine();

        foreach (var paymentMethod in paymentMethods)
        {
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine($"Delivery Method ID: {paymentMethod.Id}");
            Console.WriteLine($"Delivery Method: {paymentMethod.PaymentMethodName}");
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
            Console.WriteLine("ALL DELIVERY METHODS");
            Console.WriteLine("---------------------");
            Console.WriteLine();

            foreach (var paymentMethod in paymentMethods)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------");
                Console.WriteLine($"Delivery Method ID: {paymentMethod.Id}");
                Console.WriteLine($"Delivery Method: {paymentMethod.PaymentMethodName}");
                Console.WriteLine("---------------------");
            }

            try
            {
                Console.WriteLine();
                Console.Write("Enter delivery method ID of the delivery method you wish to delete: ");
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
                Console.WriteLine("Delivery method was deleted.");
            else Console.WriteLine("Something went wrong, delivery method was not deleted.");
        }

        PressAnyKey();
    }
    public void RegisterNewPaymentMethod()
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
            string? paymentMethodName = Console.ReadLine();

            PaymentMethodEntity paymentMethodToAdd = new PaymentMethodEntity
            {
                PaymentMethodName = paymentMethodName!,
            };

            var result = _orderService.CreatePaymentMethod(paymentMethodToAdd);
            Console.Clear();

            Console.WriteLine();
            if (result)
                Console.WriteLine("Delivery method was added.");
            else Console.WriteLine("Something went wrong, delivery method was not added.");

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