using System;
using System.Collections.Generic;

namespace jobBoard.Objects
{
  public class Contact
  {
    private string _name;
    private string _email;
    private string _phone;

    public Contact(string name, string email, string phone)
    {
      _name = name;
      _email = email;
      _phone = phone;
    }
    public string GetName()
    {
      return _name;
    }
    public string GetEmail()
    {
      return _email;
    }
    public string GetPhone()
    {
      return _phone;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public void SetEmail(string newEmail)
    {
      _email = newEmail;
    }
    public void SetPhone(string newPhone)
    {
      _phone = newPhone;
    }
  }
  public class Job
  {
    private string _title;
    private string _description;
    private Contact _contactInfo;
    private int _id;
    private static List<Job> _currentJobs = new List<Job> {};

    public Job(string title, string description, Contact contactInfo)
    {
      _title = title;
      _description = description;
      _contactInfo = contactInfo;

      _currentJobs.Add(this);

      _id = _currentJobs.Count;
    }
    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public Contact GetContactInfo()
    {
      return _contactInfo;
    }
    public void SetContactInfo(Contact newContactInfo)
    {
      _contactInfo = newContactInfo;
    }
    public static List<Job> GetJobs()
    {
      return _currentJobs;
    }
    public void ClearJobs()
    {
      _currentJobs.Clear();
    }
    public int GetID()
    {
      return _id;
    }
    public static Job SearchID(int SearchID)
    {
      return _currentJobs[SearchID-1];
    }
  }
}
