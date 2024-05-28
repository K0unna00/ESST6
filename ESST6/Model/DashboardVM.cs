namespace ESST6.Model;

public class DashboardVM
{
    public int Id { get; set; }

    public string UserId { get; set; }

    public string StansiyaAd { get; set; }

    public double DeviceBatteryPercent { get; set; }

    public double SolarBatteryPercent { get; set; }

    public double CurrentTemp { get; set; }

    public AppUser User { get; set; }
}
