using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Net;  
using System.Text; 

namespace Crowe.HelloWorld.ClientConsole
{
    public class ConsumeWebAPI
    {
        public void GetMessageData() //Get All Events Records  
            {  
                using(var client = new WebClient()) //WebClient  
                    {  
                        client.Headers.Add("Content-Type:application/json"); //Content-Type  
                        client.Headers.Add("Accept:application/json");  
                        var result = client.DownloadString("https://localhost:5001/api/HelloWorld/Message"); //URI  
                        Console.WriteLine(Environment.NewLine + result);  
                    }  
            }  
    }
}
