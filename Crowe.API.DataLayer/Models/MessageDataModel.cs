using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crowe.API.DataLayer.Models
{
    [Table("Message")]
    public class MessageDataModel
    {
        public string message { get; set; }
    }
}
