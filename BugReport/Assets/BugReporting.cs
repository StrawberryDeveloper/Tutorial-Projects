using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using UnityEditor.PackageManager;


public static class BugReporting
{
    static string _formUrl = "https://docs.google.com/forms/d/e/1FAIpQLSdpcXaS6HFezj8qUIClIwGhlEpncemcMsaQMzuQeGcimocZLQ/formResponse";

    static string _entryId = "entry.1355802841";

    public static async void Send(string message)
    {
        var formData = new Dictionary<string, string>()
        {
            { _entryId, message }
        };

        try
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var content = new FormUrlEncodedContent(formData);

                HttpResponseMessage responseMessage = await httpClient.PostAsync(_formUrl, content);

                if (responseMessage.IsSuccessStatusCode)
                {
                    Debug.Log("Success");
                }
                else
                {
                    Debug.Log("Error");
                }
            }
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }
}
