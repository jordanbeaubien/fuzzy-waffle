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
        tmp = f"insert into types values ('{car_type}', " \
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
    dob = f'{random.randint(1950, 2020)}/{random.randint(1,12)}/{random.randint(1,31)}'
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
    position = random.choice(['grunt', 'peon', 'overseer', 'dark wizard', 'supreme commander'])
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


def new_car(id, make):
    model_idx = random.randrange(0, len(data.car_models_by_make[make]))
    model = data.car_models_by_make[make][model_idx]
    year = random.randint(1998, 2023)
    colour = random.choice(colours)
    plate = new_plate()
    type = data.car_type_by_model[make][model_idx]
    branch = random.choice(branch_ids)

    return f"insert into cars values ('{str(id).zfill(8)}', '{make}', '{model}', {year}, " \
           f"'{colour}', '{plate}', '{type}', {branch});\n"


def main():
    file = open('generate_dummy_data.txt', 'w')
    car_id = 785123

    text = ''
    text += populate_types()
    text += '\n'

    for _ in range(150):
        make = random.choice(data.car_makes)
        text += new_car(car_id, make)
        car_id += 1

    text += '\n'

    customer_id = 1
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

    file.write(text)
    print('write complete')
    file.close()


if __name__ == '__main__':
    main()