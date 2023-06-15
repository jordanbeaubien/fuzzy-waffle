'''
CMPT 291 - Fuzzy Waffle Car Rental Enterprise
Generate SQL dummy data insert statements
Andrew Dool.
May 30th, 2023
'''
import random
import string
import fw_population as data


colours = ['red', 'blue', 'grey', 'black']
branch_ids = [1, 2, 3, 4, 5]

# car_prices_by_type = {type : [daily, weekly, monthly, diff_branch]}
car_prices_by_type = {'Compact' :   [10, 60, 200, 50],
                      'Luxury'  :   [50, 300, 1000, 150],
                      'Truck'   :   [20, 120, 400, 75],
                      'Van'     :   [15, 90, 300, 75]}


def populate_types():
    text = ''
    for car_type in data.car_types:
        tmp = f"insert CarType values ('{car_type}', " \
               f"{car_prices_by_type[car_type][0]}, {car_prices_by_type[car_type][1]}, {car_prices_by_type[car_type][2]}, {car_prices_by_type[car_type][3]}, " \
               f"'{data.car_features_by_type[car_type][0]}', {data.car_features_by_type[car_type][1]}, '{data.car_features_by_type[car_type][2]}');\n"
        text += tmp

    return text



def new_customer(id):
    id = str(id).zfill(8)
    first_name = random.choice(data.first_names)
    last_name = random.choice(data.last_names)
    house_number = random.randint(0, 5555)
    street = f'{random.randint(1, 150)} {random.choice(["Street", "Ave", "Blvd"])}'
    province = random.choice(data.provinces)
    city = random.choice(data.cities_by_province[province])
    dob = f'{random.randint(1950, 2020)}{str(random.randint(1,12)).zfill(2)}{str(random.randint(1,28)).zfill(2)}'
    licens_no = random.randint(10000000, 99999999)

    text = f"insert into customer values ('{id}', '{first_name}', '{last_name}', " \
           f"{house_number}, '{street}', '{city}', '{province}', '{dob}', '{licens_no}');\n"
    return text


def new_employee(id):
    id = str(id).zfill(8)
    first_name = random.choice(data.first_names)
    last_name = random.choice(data.last_names)
    house_number = random.randint(0, 5555)
    street = f'{random.randint(1, 150)} {random.choice(["Street", "Ave", "Blvd"])}'
    province = random.choice(data.provinces)
    city = random.choice(data.cities_by_province[province])
    position = random.choice(['grunt', 'peon', 'overseer', 'wizard', 'archmage', 'gladiator'])
    salary = random.randint(10, 2000000)
    branch_id = random.choice(branch_ids)

    text = f"insert into employee values ('{id}', '{first_name}', '{last_name}', " \
           f"{house_number}, '{street}', '{city}', '{province}', '{position}', '{salary}', '{branch_id}');\n"
    return text


def new_plate():
    plate = ''.join(random.choice(string.ascii_uppercase + string.digits) for _ in range(3))
    plate += '-'
    plate += ''.join(random.choice(string.ascii_uppercase + string.digits) for _ in range(3))
    return plate


def new_car(id, make, reservation_id):
    model_idx = random.randrange(0, len(data.car_models_by_make[make]))
    model = data.car_models_by_make[make][model_idx]
    year = random.randint(1998, 2023)
    colour = random.choice(colours)
    plate = new_plate()
    type = data.car_type_by_model[make][model_idx]
    branch = random.choice(branch_ids)

    return f"insert into car values ('{str(id).zfill(8)}', '{make}', '{model}', {year}, " \
           f"'{colour}', '{plate}', '{type}');\n"\
           f"insert into rental values('{reservation_id}', '20230601', '20230601', 1, '{str(id).zfill(8)}', {branch}, {branch});\n"


def main():
    file = open('generate_dummy_data.txt', 'w')
    car_id = 785123
    reservation_id = 1

    text = ''
    #text += populate_types()

    text += "delete from customerlogin;\ndelete from employeelogin;\ndelete from rental;\ndelete from car;\ndelete from CarType;\ndelete from employee;\ndelete from branch;\ndelete from customer;\n"

    text += "insert CarType values ('Compact', 10, 60, 200, 50, 'Fuel Efficient', 5, 2);\n\
insert CarType values ('Luxury', 50, 300, 1000, 150, 'AC', 5, 2);\n\
insert CarType values ('Truck', 20, 120, 400, 75, 'Towing', 3, 5);\n\
insert CarType values ('Van', 15, 90, 300, 75, 'Family Trips', 7, 3);\n\n\
insert into branch values (1, 50, 'somewhere street', 'Edmonton', 'AB', '7805556789', 'branch1@whatever.ca');\n\
insert into branch values (2, 987, 'somewhere street', 'Calgary', 'AB', '7805559876', 'branch2@whatever.ca');\n\
insert into branch values (3, 10101, 'somewhere street', 'Vancouver', 'BC', '7805554321', 'branch3@whatever.ca');\n\
insert into branch values (4, 10, 'somewhere street', 'Toronto', 'ON', '7805551234', 'branch4@whatever.ca');\n\
insert into branch values (5, 4, 'somewhere street', 'Edmonton', 'AB', '7805555555', 'branch5@whatever.ca');\n"
    text += '\n'

    text += "insert into customer values ('00000001', 'RELOCATION', 'RELOCATION', 1, '1', 'R', 'RR', '20200101', '55555555');\n"

    for _ in range(20):
        make = random.choice(data.car_makes)
        text += new_car(car_id, make, reservation_id)
        car_id += 1
        reservation_id += 1

    text += '\n'

    customer_id = 2
    for _ in range(200):
        customer = new_customer(customer_id)
        text += customer
        customer_id += 1

    text += '\n'
    employee_id = 1
    for _ in range(50):
        employee = new_employee(employee_id)
        text += employee
        employee_id += 1

    text += f"insert into rental values ({reservation_id}, '20230606', '20230608', 1, '00785123', 1, 1);\n" \
            f"insert into rental values ({reservation_id + 1}, '20230620', '20230625', 3, '00785123', 1, 2);\n" \
            f"insert into rental values ({reservation_id + 2}, '20230610', '20230620', 7, '00785137', 2, 2);\n" \
            f"insert into rental values ({reservation_id + 3}, '20230709', '20230713', 11, '00785137', 2, 4);\n" \
            f"insert into rental values ({reservation_id + 4}, '20230602', '20230620', 17, '00785142', 1, 4);\n" \
            f"insert into rental values ({reservation_id + 5}, '20230801', '20230808', 66, '00785142', 4, 1);\n"

    text += "\ninsert into CustomerLogin values(1, 'test', 'pwd');\ninsert into employeeLogin values(1, 'test', 'pwd');\n"

    text += "insert into branch values (6, 9, 'somewhere street', 'Calgary', 'AB', '7805555555', 'branch6@whatever.ca');"
    text += "insert into branch values (7, 201, 'somewhere street', 'Kelowna', 'BC', '7805555555', 'branch7@whatever.ca');"

    text += "insert into car values ('11111111', 'Test', 'Compact', 2020, 'red', 'A1A-1A1', 'Compact');\n"
    text += f"insert into rental values('{reservation_id + 6}', '20230601', '20230601', 1, '11111111', 6, 6);\n"
    text += "insert into car values ('2222222', 'Test', 'Truck', 2020, 'red', 'A1A-1A1', 'Truck');\n"
    text += f"insert into rental values('{reservation_id + 7}', '20230601', '20230601', 1, '2222222', 6, 6);\n"
    text += "insert into car values ('3333333', 'Test', 'Compact2', 2020, 'red', 'A1A-1A1', 'Compact');\n"
    text += f"insert into rental values('{reservation_id + 8}', '20230601', '20230601', 1, '3333333', 7, 7);\n"

    file.write(text)
    print('write complete')
    file.close()


if __name__ == '__main__':
    main()
