public class Ampel
{
    public string Status { get; private set; }

    public Ampel()
    {
        Status = "Grün";
    }

    public void SetStatus(string status)
    {
        Status = status;
    }

    public string GetStatus()
    {
        return Status;
    }
}
