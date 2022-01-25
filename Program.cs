var mobileRepository = new MobileRepository();
IMobile mobile = mobileRepository.GetMobileByName("xiaomi");
mobile.TurnOn();
mobile.TurnOff();