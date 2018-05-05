using System;

namespace ImmunoApp
{
    /// <summary>
    /// Model class for representing the details for top menu items
    /// Author: Christian Bender
    /// </summary>
	public class MasterPageItem
	{
		public string Title { get; set; }

		public string IconSource { get; set; }

		public Type TargetType { get; set; }
	}
}
