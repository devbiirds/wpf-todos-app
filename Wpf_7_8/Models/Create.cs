using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_7_8.Models
{
	class Create
	{
		class ToDoMod : INotifyPropertyChanged
		{
			public DateTime CreationDate { get; set; } = DateTime.Now;

			private bool _Status;

			public bool Status
			{
				get { return _Status; }
				set
				{
					if (_Status == value)
						return;
					else _Status = value;
					OnPropertyChanged("Status");
				}
			}

			private string _EndDate;

			public string EndDate
			{
				get { return _EndDate; }
				set
				{
					if (_EndDate == value)
						return;
					_EndDate = value;
					OnPropertyChanged("EndDate");
				}
			}

			private string _Name;

			public string Name
			{
				get { return _Name; }
				set
				{
					if (_Name == value)
						return;
					_Name = value;
					OnPropertyChanged("Name");
				}

			}


			private string _Category;

			public string Category
			{
				get { return _Category; }
				set
				{
					if (_Category == value)
						return;
					_Category = value;
					OnPropertyChanged("Category");
				}
			}


			private string _Description;

			public string Description
			{
				get { return _Description; }
				set
				{
					if (_Description == value)
						return;
					_Description = value;
					OnPropertyChanged("Description");
				}
			}



			private string _Priority;



			public string Priority
			{
				get { return _Priority; }
				set
				{
					if (_Priority == value)
						return;
					_Priority = value;
					OnPropertyChanged("Priority");
				}
			}

			public event PropertyChangedEventHandler PropertyChanged;

			protected virtual void OnPropertyChanged(string propertyName = "")
			{
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

			}

		}
	}
}
