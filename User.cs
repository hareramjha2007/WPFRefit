using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ExpenseManager.Models
{
	public partial class User
	{
		[JsonProperty("userID")]
		public int UserID { get; set; }

		[JsonProperty("loginName")]
		public string LoginName { get; set; }

		[JsonProperty("password")]
		public string Password { get; set; }

		[JsonProperty("firstName")]
		public string FirstName { get; set; }

		[JsonProperty("lastName")]
		public string LastName { get; set; }

		[JsonProperty("dateSettingId")]
		public Nullable<int> DateSettingId { get; set; }

		[JsonProperty("currencyId")]
		public Nullable<int> CurrencyId { get; set; }

		[JsonProperty("currencyFormatId")]
		public Nullable<int> CurrencyFormatId { get; set; }

		[JsonProperty("email")]
		public string EMAIL { get; set; }

		[JsonProperty("userPicture")]
		public byte[] UserPicture { get; set; }

		[JsonProperty("adminId")]
		public Nullable<int> AdminId { get; set; }

		[JsonProperty("dateSetting")]
		public virtual string DateSetting { get; set; }

		[JsonProperty("currency")]
		public virtual string Currency { get; set; }
	}


}
