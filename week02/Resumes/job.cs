



public class Job 
{
    public string _jobTitle;
    public string _companyName;

    public string _year;

    //Method perfoming the action of displaying the job details
    public void DisplayJobDetails ()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_year}");
    }
}