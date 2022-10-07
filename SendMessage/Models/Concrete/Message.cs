using System;
using System.ComponentModel.DataAnnotations;

namespace SendMessage.Models.Concrete
{
	public class Message
	{
		[Key]
		public int ID { get; set; }
		public string Name { get; set; }
		public string MessageContent { get; set; }
		public string Mail { get; set; }
		public string ImageURL { get; set; }
		public DateTime Date { get; set; }
	}
}
