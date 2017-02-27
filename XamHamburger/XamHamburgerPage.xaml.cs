using Xamarin.Forms;
using System.Collections.Generic;

namespace XamHamburger
{
public partial class XamHamburgerPage : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public XamHamburgerPage()
		{
			InitializeComponent();

			Icon = "hamburger.png";

			var masterPageItems = new List<MasterPageItem>();
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Contacts",
				TargetType = typeof(ContactsPage)

			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "TodoList",
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Reminders",
			});

			listView.ItemsSource = masterPageItems;
		}
	}
}
