using System.Collections.Generic;
using Xamarin.Forms;
using System.Diagnostics;

namespace XamHamburger
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public MasterPage()
		{
			InitializeComponent();

			var masterPageItems = new List<MasterPageItem>();
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Contacts",
				TargetType = typeof(ContactsPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "TodoList",
				TargetType = typeof(ContactsPage)

			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Reminders",
				TargetType = typeof(ContactsPage)

			});

			listView.ItemsSource = masterPageItems;
		}
	}
}
