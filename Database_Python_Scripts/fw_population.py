'''
CMPT 291 - Fuzzy Waffle Car Rental Enterprise
Non-randomized information for database population.
Jordan Beaubien for Andrew Doole.
May 30th, 2023
'''

provinces = ["Alberta", "British Columbia", "Manitoba", "New Brunswick", "Newfoundland", 
             "Nova Scotia", "Ontario", "Prince Edward Island", "Quebec","Saskatchewan"]

# cities_by_province = { city : [ five most populated cities in province ] }
cities_by_province = { "Alberta"              : ["Calgary", "Edmonton", "Red Deer", "Lethbridge", "Airdrie"],
                       "British Columbia"     : ["Vancouver", "Victoria", "Kelowna", "Abbotsford", "White Rock"],
                       "Manitoba"             : ["Winnipeg", "Brandon", "Steinbach", "Springfield", "Winkler"],
                       "New Brunswick"        : ["Moncton", "Saint John", "Fredericton", "Dieppe", "Riverview"],
                       "Newfoundland"         : ["St. John's", "Conception Bay South", "Paradise", "Mount Pearl", "Corner Brook"],
                       "Nova Scotia"          : ["Halifax", "Cape Breton", "Lunenburg", "East Hants", "West Hants"],
                       "Ontario"              : ["Toronto", "Ottawa", "Mississauga", "Brampton", "Hamilton"],
                       "Prince Edward Island" : ["Charlottetown", "Summerside", "Cornwall", "Montague", "Kensington"],
                       "Quebec"               : ["Montréal", "Québec City", "Laval", "Gatineau", "Longueuil"],
                       "Saskatchewan"         : ["Saskatoon", "Regina", "Prince Albert", "Moose Jaw", "Lloydminster"] }

first_names = ["Joey", "Aurelio", "Evan", "Donny", "Foster", "Dwayne", "Grady", "Quinton", "Darin", "Mickey",
               "Hank", "Kim", "Peter", "Jeremy", "Jess", "Jimmie", "Vern", "Pasquale", "Romeo", "Chris", "Dale",
               "Beau", "Cliff", "Timothy", "Raphael", "Brain", "Mauro", "Luke", "Myron", "Omar", "Reynaldo", 
               "Major", "Clinton", "Nolan", "Raymond", "Lucien", "Carey", "Winfred", "Dan", "Abel", "Elliott",
               "Brent", "Chuck", "Dirk", "Tod", "Emerson", "Dewey", "Scot", "Enrique", "Al", "Beatrice", "Brandy",
               "Kathy", "Jane", "Marcy", "Shelly", "Lucy", "Cathy", "Joanna", "Doris", "Lindsay", "Staci", "Shelia",
               "Rosanne", "Rebecca", "Luz", "Flora", "Rosalie", "Karla", "Phoebe", "Meagan", "Virginia", "Amanda",
               "Katy", "Karla", "Deanne", "Pearl", "Christi", "Victoria", "Ola", "Alexandra", "Marina", "Lorraine",
               "Sybil", "Adeline", "Taylor", "Anita", "Aurora", "Neva", "Alisha", "Maria", "Erna", "Gwendolyn", 
               "Brenda", "Bethany", "Sybil", "Earline", "June", "Brandy", "Sue"]

last_names = ["Mejia", "Robles", "Kennedy", "Case", "Bryan", "Leach", "Mccall", "Reed", "Torres", "Mayo", "Acevedo",
              "Hardy", "Arroyo", "Tran", "Haley", "Stark", "Schmidt", "Kelley", "Johnston", "Owens", "French", "Banks",
              "Flynn", "Buck", "Munoz", "Bauer", "Hunt", "Fisher", "Salinas", "Roth", "Sanders", "Brown", "Powers", 
              "Cowan", "Cochran", "Weeks", "Rodgers", "Krause", "Salas", "Jacobson", "Bush", "Waters", "Stevenson", 
              "Mccann", "Glenn", "Santos", "Everett", "Chavez", "Petty", "Pennington", "Abbott", "Maldonado", "Simon", 
              "Mendoza", "Love", "Nichols", "Anderson", "Clay", "Lyons", "Chandler", "Ford", "Shepard", "Vargas", "Blake", 
              "Singh", "Green", "Jefferson", "Serrano", "Vang", "Case", "Pennington", "Hawkins", "Shepard", "Carlson", 
              "Waters", "Walters", "Greer", "Ware", "Rojas", "Frank", "Welch", "Haas", "Pittman", "Love", "Cooper", "Shepard", 
              "Hoffman", "Hernandez", "Dudley", "Bright", "Dillon", "Moran", "Mcdaniel", "Potts", "Lopez", "Hill", "Dodson", 
              "Leach", "Michael", "Walls"]

car_types = ["Compact", "Luxury", "Truck", "Van"]

# car_features_by_type = { type : [ features, passengers, baggage_space ] }
car_features_by_type = { "Compact" : ["Fuel Efficient", 5, "Two Standard Suitcases"],
                         "Luxury"  : ["AC", 5, "Two Standard Suitcases"],
                         "Truck"   : ["Towing", 3, "200lbs Truckbox"],
                         "Van"     : ["Family Trips", 7, "Three Suitcases and Two medium dogs"] }

car_makes = ["BMW", "Ford", "General Motors", "Honda", "Hyundai", "Nissan", "Toyota"]

# car_models <=> car_type
car_models_by_make = { "BMW"            : ["4 Series", "2 Series"], 
                       "Ford"           : ["F-150", "Transit"], 
                       "General Motors" : ["1500", "Savana"], 
                       "Honda"          : ["Civic", "CR-V"], 
                       "Hyundai"        : ["Kona", "Tucson"], 
                       "Nissan"         : ["Altima", "Rogue"], 
                       "Toyota"         : ["Corolla", "Camry"] }

car_type_by_model = { "BMW"            : ["Luxury", "Luxury"], 
                      "Ford"           : ["Truck", "Van"], 
                      "General Motors" : ["Truck", "Van"], 
                      "Honda"          : ["Compact", "Compact"], 
                      "Hyundai"        : ["Compact", "Compact"], 
                      "Nissan"         : ["Compact", "Compact"], 
                      "Toyota"         : ["Compact", "Compact"] }

