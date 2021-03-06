﻿using System;

namespace MailJet.Client.Response.Data
{
	public class ContactListData : DataItem
	{
		public string Address { get; set; }
		public DateTime CreatedAt { get; set; }
		public bool IsDeleted { get; set; }
		public string Name { get; set; }
		public long SubscriberCount { get; set; }
	}
}
