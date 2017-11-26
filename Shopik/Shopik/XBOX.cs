namespace Shops
{
    public class XBOXGames:Product
    {
        public bool AvailabilityOfWebcam { get; private set; }

        public XBOXGames(string name, int price, string publisher, string genre, bool availabilityOfWebcam)
        {
            Name = name;
            Publisher = publisher;
            Price = price;
            Genre = genre;
            AvailabilityOfWebcam = availabilityOfWebcam;
        }
    }
}