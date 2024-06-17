using System;
using System.Text;

namespace PracticeArrayLikeVariables
{
    public class UserFlightData
    {
        public string _id;
        public string _firstName;
        public string _lastName;
        public string _destination;
        public DateOnly _departureDate;
        public DateOnly _returnDate;

        public string Id {
            get { return _id; }
            set { _id = value; }
        }
        public string FirstName {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Destination {
            get { return _destination; }
            set { _destination = value; }
        }
        public DateOnly DepartureDate {
            get { return _departureDate; }
            set { _departureDate = value; }
        }
        public DateOnly ReturnDate;
        
        public UserFlightData(string firstName, string lastName, string destination, DateOnly departureDate, DateOnly returnDate) {
            Id = Guid.NewGuid().ToString();
            FirstName = firstName;
            LastName = lastName;
            Destination = destination;
            DepartureDate = departureDate;
            ReturnDate = returnDate;
        }
        
        public override string ToString() {
            return new StringBuilder()
                .Append("User Id: ").AppendLine(Id)
                .Append("User first name: ").AppendLine(FirstName)
                .Append("User last name: ").AppendLine(LastName)
                .Append("User destination: ").AppendLine(Destination)
                .Append("User departure date: ").AppendLine(DepartureDate.ToString("yyyy-MM-dd"))
                .Append("User return date: ").AppendLine(ReturnDate.ToString("yyyy-MM-dd"))
            .ToString();
        }
    }
}