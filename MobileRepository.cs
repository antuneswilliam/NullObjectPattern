public class MobileRepository
{  
    private readonly IDictionary<string, IMobile> mobiles;
    public MobileRepository()
    {
        mobiles = new Dictionary<string, IMobile>()
        {
            { "sony", new SonyXperia() },
            { "apple", new AppleIPhone() },
            { "samsung", new SamsungGalaxy() },
        };
    }
    public IMobile GetMobileByName(string mobileName) {

        if (!mobiles.Keys.Contains(mobileName))
            return NullMobile.Instance;

        return mobiles[mobileName];
    }
}  