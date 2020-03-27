using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class Smartphone : ICallable, IBrowsable
{
    public Smartphone(string[] numbersToCall, string[] sitesToBrowse)
    {
        this.NumbersToCall = numbersToCall;
        this.SitesToBrowse = sitesToBrowse;
    }

    public string[] NumbersToCall { get; set; }
    public string[] SitesToBrowse { get; set; }

    public string CallNumbers()
    {
        string result = String.Empty;

        foreach (var number in NumbersToCall)
        {
            result += $"{Call(number)}\r\n";
        }

        return result;
    }

    public string BrowseSites()
    {
        string result = String.Empty;

        if (SitesToBrowse.Length > 0)
        {
            foreach (var site in SitesToBrowse)
            {
                result += $"{Browse(site)}\r\n";
            }
        }
        else
        {
            return "Browsing: !";
        }

        return result;
    }
    public string Call(string phoneNumber)
    {
        if (Regex.IsMatch(phoneNumber, @"^[0-9]+$"))
        {
            return $"Calling... {phoneNumber}";
        }

        return "Invalid number!";
    }

    public string Browse(string siteURL)
    {
        if (Regex.IsMatch(siteURL, @"^[^0-9]+$"))
        {
            return $"Browsing: {siteURL}!";
        }

        return "Invalid URL!";
    }

    public override string ToString()
    {
        return this.CallNumbers() + this.BrowseSites();
    }
}

