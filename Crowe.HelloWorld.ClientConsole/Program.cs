using System;

namespace Crowe.HelloWorld.ClientConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ConsumeWebAPI callAPI = new ConsumeWebAPI();
            callAPI.GetMessageData();
        }
    }
}
