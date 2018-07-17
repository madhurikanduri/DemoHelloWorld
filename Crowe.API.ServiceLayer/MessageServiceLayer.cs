using System;
using Crowe.API.ServiceLayer.Interfaces;
using Crowe.API.ServiceLayer.Models;
using Crowe.API.DataLayer;
using Crowe.API.Common;
using System.Web;
using System.IO;

namespace Crowe.API.ServiceLayer
{
    public class MessageServiceLayer : IMessageServiceLayer
    {
        public MessageServiceLayer()
        {
        }

        public MessageServiceModel GetMessage()
        {
            MessageServiceModel msgModel = new MessageServiceModel();

            //if (string.IsNullOrEmpty(DbContext.Dbcon))
              //  return null;

            //string flatfilepath = DbContext.Dbcon;

            string flatfilepath = "filedb/message.txt";

            string path = System.IO.Path.Combine(System.Environment.CurrentDirectory, flatfilepath);
            string messageinformation = "";

            try
            {
                using (var filereader = new StreamReader(path))
                {
                    messageinformation = filereader.ReadToEnd();
                }
            }
            catch(Exception ex)
            {
                throw new IOException("test",ex);
            }

            msgModel.message = messageinformation;

            return msgModel;

        }
    }
}
