using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations.Schema;

namespace crud_application.Models
{
    public class Customer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private int id;
        [Column("id")]
        public int Id
        {
            get => id;
            set { id = value; OnPropertyChanged(); }
        }

        private string firstName;
        [Column("first_name")]
        public string FirstName
        {
            get => firstName;
            set { firstName = value; OnPropertyChanged(); }
        }

        private string lastName;
        [Column("last_name")]
        public string LastName
        {
            get => lastName;
            set { lastName = value; OnPropertyChanged(); }
        }

        private string email;
        [Column("email")]
        public string Email
        {
            get => email;
            set { email = value; OnPropertyChanged(); }
        }

        private string phoneNumber;
        [Column("phone_number")]
        public string PhoneNumber
        {
            get => phoneNumber;
            set { phoneNumber = value; OnPropertyChanged(); }
        }

        private string city;
        [Column("city")]
        public string City
        {
            get => city;
            set { city = value; OnPropertyChanged(); }
        }

        private string address;
        [Column("address")]
        public string Address
        {
            get => address;
            set { address = value; OnPropertyChanged(); }
        }
    }
}