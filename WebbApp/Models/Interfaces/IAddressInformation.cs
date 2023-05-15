namespace WebbApp.Models.Interfaces;

public interface IAddressInformation
{
    public string StreetName { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string? Country { get; set; }
}