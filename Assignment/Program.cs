using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Assignment.InterfaceQ1;
using Assignment.InterfaceQ2;
using Assignment.InterfaceQ3;

namespace Assignment
{
  

    internal class Program
    {
        #region Q1
        static void DisplayShapeInfo(IShape shape)
        {
            if(shape != null)
            {
                Console.WriteLine($"the area is equal {shape.DisplayShapeInfo()}");
            }
        }
        #endregion

        static void Main(string[] args)
        {

            // part 01
            // 1. b
            // 2. a
            // 3. b
            // 4. b
            // 5. d
            // 6. a
            // 7. b
            // 8. b
            // 9. b
            // 10. c
            // Part 02
            #region Q1
            //Circle circle = new Circle();
            //circle.Radius = 10;
            //DisplayShapeInfo(circle);
            //Rectangle rectangle = new Rectangle();
            //rectangle.Width = 5;
            //rectangle.Length = 5;
            //DisplayShapeInfo(rectangle);

            #endregion

            #region Q2
            //IAuthenticationService authService = new BasicAuthenticationService();
            //Console.WriteLine("Enter username: ");
            //string username = Console.ReadLine();

            //Console.WriteLine("Enter password: ");
            //string password = Console.ReadLine();
            //if (authService.AuthenticateUser(username, password))
            //{
            //    Console.WriteLine("Authentication Success");
            //    Console.WriteLine("Enter role: ");
            //    string role = Console.ReadLine();
            //    if(authService.AuthorizeUser(username, role))
            //    {
            //        Console.WriteLine("authorization Success");

            //    }
            //    else
            //    {
            //        Console.WriteLine($"{role} is not authorized");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{username} is not Authenticated");

            //}



            #endregion
            #region Q3
            EmailNotificationService emailAddress = new EmailNotificationService();
            SmsNotificationService smsNotification = new SmsNotificationService();
            PushNotificationService pushNotification = new PushNotificationService();
            smsNotification.SendNotification("mariam", "hello");

            #endregion
            #region
            #endregion
        }
    }
}
