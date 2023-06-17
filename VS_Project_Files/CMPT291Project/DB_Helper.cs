using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace CMPT291Project
{
    public class DB_Helper
    {
        string[] provinces = new string[] { "AB", "BC", "MN", "NB", "NF", "NS", "ON", "PE", "QC", "SK" };

        Dictionary<string, string[]> cities_by_province = new Dictionary<string, string[]>
        {
            { "AB", new string[] {"Calgary", "Edmonton", "Red Deer", "Lethbridge", "Airdrie" } },
            { "BC", new string[] {"Vancouver", "Victoria", "Kelowna", "Abbotsford", "White Rock" } },
            { "MN", new string[] {"Winnipeg", "Brandon", "Steinbach", "Springfield", "Winkler" } },
            { "NB", new string[] {"Moncton", "Saint John", "Fredericton", "Dieppe", "Riverview"} },
            { "NF", new string[] {"St. John''s", "Conception Bay South", "Paradise", "Mount Pearl", "Corner Brook"} },
            { "NS", new string[] { "Halifax", "Cape Breton", "Lunenburg", "East Hants", "West Hants"} },
            { "ON", new string[] { "Toronto", "Ottawa", "Mississauga", "Brampton", "Hamilton"} },
            { "PE", new string[] { "Charlottetown", "Summerside", "Cornwall", "Montague", "Kensington"} },
            { "QC", new string[] { "Montréal", "Québec City", "Laval", "Gatineau", "Longueuil"} },
            { "SK", new string[] { "Saskatoon", "Regina", "Prince Albert", "Moose Jaw", "Lloydminster"} }
        };

        string[] first_names = {"Joey", "Aurelio", "Evan", "Donny", "Foster", "Dwayne", "Grady", "Quinton", "Darin", "Mickey",
            "Hank", "Kim", "Peter", "Jeremy", "Jess", "Jimmie", "Vern", "Pasquale", "Romeo", "Chris", "Dale",
            "Beau", "Cliff", "Timothy", "Raphael", "Brain", "Mauro", "Luke", "Myron", "Omar", "Reynaldo",
            "Major", "Clinton", "Nolan", "Raymond", "Lucien", "Carey", "Winfred", "Dan", "Abel", "Elliott",
            "Brent", "Chuck", "Dirk", "Tod", "Emerson", "Dewey", "Scot", "Enrique", "Al", "Beatrice", "Brandy",
            "Kathy", "Jane", "Marcy", "Shelly", "Lucy", "Cathy", "Joanna", "Doris", "Lindsay", "Staci", "Shelia",
            "Rosanne", "Rebecca", "Luz", "Flora", "Rosalie", "Karla", "Phoebe", "Meagan", "Virginia", "Amanda",
            "Katy", "Karla", "Deanne", "Pearl", "Christi", "Victoria", "Ola", "Alexandra", "Marina", "Lorraine",
            "Sybil", "Adeline", "Taylor", "Anita", "Aurora", "Neva", "Alisha", "Maria", "Erna", "Gwendolyn",
            "Brenda", "Bethany", "Sybil", "Earline", "June", "Brandy", "Sue" };

        string[] last_names = {"Mejia", "Robles", "Kennedy", "Case", "Bryan", "Leach", "Mccall", "Reed", "Torres", "Mayo", "Acevedo",
            "Hardy", "Arroyo", "Tran", "Haley", "Stark", "Schmidt", "Kelley", "Johnston", "Owens", "French", "Banks",
            "Flynn", "Buck", "Munoz", "Bauer", "Hunt", "Fisher", "Salinas", "Roth", "Sanders", "Brown", "Powers",
            "Cowan", "Cochran", "Weeks", "Rodgers", "Krause", "Salas", "Jacobson", "Bush", "Waters", "Stevenson",
            "Mccann", "Glenn", "Santos", "Everett", "Chavez", "Petty", "Pennington", "Abbott", "Maldonado", "Simon",
            "Mendoza", "Love", "Nichols", "Anderson", "Clay", "Lyons", "Chandler", "Ford", "Shepard", "Vargas", "Blake",
            "Singh", "Green", "Jefferson", "Serrano", "Vang", "Case", "Pennington", "Hawkins", "Shepard", "Carlson",
            "Waters", "Walters", "Greer", "Ware", "Rojas", "Frank", "Welch", "Haas", "Pittman", "Love", "Cooper", "Shepard",
            "Hoffman", "Hernandez", "Dudley", "Bright", "Dillon", "Moran", "Mcdaniel", "Potts", "Lopez", "Hill", "Dodson",
            "Leach", "Michael", "Walls" };

        string[] car_makes = { "BMW", "Ford", "General Motors", "Honda", "Hyundai", "Nissan", "Toyota" };

        Dictionary<string, string[]> car_models_by_make = new Dictionary<string, string[]>
        {
            { "BMW"            , new string[] {"4 Series", "2 Series" } },
            { "Ford"           , new string[] {"F-150", "Transit" } },
            { "General Motors" , new string[] {"1500", "Savana" } },
            { "Honda"          , new string[] {"Civic", "CR-V" } },
            { "Hyundai"        , new string[] {"Kona", "Tucson" } },
            { "Nissan"         , new string[] {"Altima", "Rogue" } },
            { "Toyota"         , new string[] {"Corolla", "Camry" } }
        };

        Dictionary<string, string[]> car_type_by_model = new Dictionary<string, string[]>
        {
            { "BMW"            , new string[] { "Luxury", "Luxury" } },
            { "Ford"           , new string[] { "Truck", "Van" } },
            { "General Motors" , new string[] { "Truck", "Van" } },
            { "Honda"          , new string[] { "Compact", "Compact" } },
            { "Hyundai"        , new string[] { "Compact", "Compact" } },
            { "Nissan"         , new string[] { "Compact", "Compact" } },
            { "Toyota"         , new string[] { "Compact", "Compact" } }
        };

        public string[] colours = new string[] { "red", "blue", "grey", "black" };

        Dictionary<string, int[]> car_prices_by_type = new Dictionary<string, int[]>
        {
            {"Compact" ,   new int[] { 10, 60, 200, 50 } },
            {"Luxury" ,   new int[] { 50, 300, 1000, 150 } },
            {"Truck" ,   new int[] { 20, 120, 400, 75 } },
            {"Van" ,   new int[] { 15, 90, 300, 75 } }
        };


        public string new_customer()
        {
            // Randomly generate a sql insertion string for a new customer
            Random rnd = new Random();
            string first_name = $"'{first_names[rnd.Next(0, first_names.Length)]}'";
            string last_name = $"'{last_names[rnd.Next(0, last_names.Length)]}'";
            int house_number = rnd.Next(1, 5555);
            string street = $"'{rnd.Next(1, 150)} Street'";
            string province = $"{provinces[rnd.Next(0, provinces.Length)]}";
            string city = $"'{cities_by_province[province][rnd.Next(0, cities_by_province[province].Length)]}'";
            province = $"'{province}'";     // province needed to be used for dictionary indexing without quotes first
            string dob = $"'{rnd.Next(1950, 2005)}{rnd.Next(1, 12).ToString().PadLeft(2, '0')}{rnd.Next(1, 28).ToString().PadLeft(2, '0')}'";
            string license_no = $"'{rnd.Next(10000000, 99999999)}'";

            string text = $"INSERT INTO customer VALUES ((SELECT MAX(customer_id) + 1 FROM customer), " +
                          $"{first_name}, {last_name}, {house_number}, {street}, {city}, {province}, {dob}, {license_no})";
            return text;
        }

        public string new_employee()
        {
            // Randomly generate a sql insertion string for a new employee
            Random rnd = new Random();
            string[] positions = new string[] { "grunt", "peon", "overseer", "wizard", "archmage", "gladiator" };

            string first_name = $"'{first_names[rnd.Next(0, first_names.Length)]}'";
            string last_name = $"'{last_names[rnd.Next(0, last_names.Length)]}'";
            int house_number = rnd.Next(1, 5555);
            string street = $"'{rnd.Next(1, 150)} Street'";
            string province = $"{provinces[rnd.Next(0, provinces.Length)]}";
            string city = $"'{cities_by_province[province][rnd.Next(0, cities_by_province[province].Length)]}'";
            province = $"'{province}'";     // province needed to be used for dictionary indexing without quotes first
            string position = $"'{positions[rnd.Next(0, positions.Length)]}'";
            int salary = rnd.Next(3, 15) * 10000;
            string branch_id = "(SELECT TOP 1 branch_id FROM branch ORDER BY NEWID())";


            string text = $"INSERT INTO employee VALUES ((SELECT MAX(employee_id) + 1 FROM employee), " +
                          $"{first_name}, {last_name}, {house_number}, {street}, {city}, {province}, {position}, {salary}, {branch_id});";
            return text;
        }


        public string new_car(string vin)
        {
            Random rnd = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] plateChars = new char[7];

            for (int i = 0; i < plateChars.Length; i++)
            {
                if (i == 3)
                {
                    plateChars[i] = '-';
                }
                else
                {
                    plateChars[i] = chars[rnd.Next(chars.Length)];
                }
            }
            string plate = $"'{new string(plateChars)}'";
            string make = car_makes[rnd.Next(0, car_makes.Length)];
            int model_idx = rnd.Next(0, car_models_by_make[make].Length);
            string type = $"'{car_type_by_model[make][rnd.Next(0, car_type_by_model[make].Length)]}'";
            string model = $"'{car_models_by_make[make][rnd.Next(0, car_models_by_make[make].Length)]}'";
            make = $"'{make}'";
            int year = rnd.Next(1998, 2023);
            string colour = $"'{colours[rnd.Next(0, colours.Length)]}'";
            string branch_id = "(SELECT TOP 1 branch_id FROM branch ORDER BY NEWID())";

            string text = $"INSERT INTO car VALUES ('{vin}', {make}, {model}, {year}, {colour}, {plate}, {type});\n" +
                          $"INSERT INTO rental VALUES ((SELECT MAX(reservation_id) + 1 FROM rental), '20200101', '20200101', 1, " +
                          $"'{vin}', 1, {branch_id});";

            return text;
        }


        public string[] clear_tables()
        {
            string[] tables = { "customerLogin", "employeeLogin", "rental", "car", "carType", "employee", "branch", "customer" };
            string[] output = new string[tables.Length];

            for (int i = 0; i < tables.Length; i++)
            {
                output[i] = $"DELETE FROM {tables[i]};";
            }

            return output;
        }

        public string[] populate_car_types = new string[]
        {
            "insert CarType values ('Compact', 10, 60, 200, 50, 'Fuel Efficient', 5, 2);",
            "insert CarType values('Luxury', 50, 300, 1000, 150, 'AC', 5, 2);",
            "insert CarType values('Truck', 20, 120, 400, 75, 'Towing', 3, 5);",
            "insert CarType values('Van', 15, 90, 300, 75, 'Family Trips', 7, 3);"
        };


        public string[] populate_branches = new string[]
        {
            "insert into branch values (1, 50, '1st street', 'Edmonton', 'AB', '7805556789', 'branch1@kevauto.ca');",
            "insert into branch values(2, 987, '22nd street', 'Calgary', 'AB', '7805559876', 'branch2@kevauto.ca');",
            "insert into branch values(3, 10101, '99th avenue', 'Vancouver', 'BC', '7805554321', 'branch3@kevauto.ca');",
            "insert into branch values(4, 10, '11th street', 'Toronto', 'ON', '7805551234', 'branch4@kevauto.ca');",
            "insert into branch values(5, 4, 'Whyte Avenue', 'Edmonton', 'AB', '7805555555', 'branch5@kevauto.ca');"
        };


        public string[] starter_values = new string[]
        {
            "insert into customer values ('1', 'RELOCATION', 'RELOCATION', 1, '1', 'R', 'RR', '20200101', '55555555');",
            "insert into car values ('test', 'test', 'test', 2016, 'grey', '1A1-A1A', 'Compact');",
            "insert into rental values('1', '20200101', '20200101', 1, 'test', 1, 1);",
            "insert into employee values ('1', 'test', 'test', 4300, '87 Street', 'test', 'AB', 'test', '1472551', '1');",
            "insert into CustomerLogin values(1, 'test', 'pwd');",
            "insert into EmployeeLogin values(1, 'test', 'pwd');"
        };


        public List<string> populate_data(int num_cars, int num_employees, int num_customers)
        {
            List<string> data = new List<string>();

            int start_vin = 2;
            string[] cars = new string[num_cars];
            for (int i = 0; i < num_cars; i++)
            {
                cars[i] = new_car($"{start_vin++}".PadLeft(8, '0'));
            }



            string[][] blocks = new string[][]
            {
                clear_tables(),
                populate_car_types,
                populate_branches,
                starter_values,
                cars,
            };

            return data;
        }

        public void test()
        {
            string[] t = clear_tables();
            for (int i = 0; i < t.Length; i++)
            {
                MessageBox.Show(t[i]);
            }
        }
    }
}


