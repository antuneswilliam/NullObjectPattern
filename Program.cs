// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var mobileRepository = new MobileRepository();
IMobile mobile = mobileRepository.GetMobileByName("xiaomi");
mobile.TurnOn();
mobile.TurnOff();