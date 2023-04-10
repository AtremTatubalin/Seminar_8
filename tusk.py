def writing_person():
    name = input("Введите имя: ")
    lastname = input("Введите фамилию: ")
    surname = input("Введите отчество: ")
    phone = input("Введите номер телефона: ")
    data = open("phonebook.txt", "a", encoding = "utf-8")
    data.writelines(f"Фамилия: {lastname} Имя: {name} Отчество: {surname} Телефон: {phone}\n")
    data.close()

def search():
    desired = input("Введите информацию для поиска: ")
    with open("phonebook.txt", "r", encoding = "utf-8") as data:
        for line in data:
            if desired in data:
                print(line)

def print_phonebook():
    with open("phonebook.txt", "r", encoding = "utf-8") as data:
        for line in data:
            print(line)

def load():
    new_phonebook = input("Введите ссылку на файл: ")
    with open(new_phonebook, "r", encoding = "utf-8") as data:
        with open("phonebook.txt", "a", encoding = "utf-8") as data_1:
            for line in data:
                if line not in data_1:
                    data_1.write(line)
            data_1.write("\n")

def change():
    desired = input("Введите информацию для поиска: ")
    with open("phonebook.txt", "a", encoding = "utf-8") as data:
        for line in data:
            if desired in line:
                print(line)
                name = input("Введите новое имя: ")
                lastname = input("Введите новую фамилию: ")
                surname = input("Введите новое отчество: ")
                phone = input("Введите новый номер телефона: ")
                data.write(f"Фамилия: {lastname} Имя: {name} Отчество: {surname} Телефон: {phone}\n")

def delete():
    desired = input("Введите информацию для поиска: ")
    with open("phonebook.txt", "a", encoding = "utf-8") as data:
        for line in data:
            if desired in line:
                print(line)
                name = ""
                lastname = ""
                surname = ""
                phone = ""
                data.write(f"Фамилия: {lastname} Имя: {name} Отчество: {surname} Телефон: {phone}\n")

reques = int(input("""1 - добавить новый контакт; 
2 - поиск; 
3 - вывести на экран всю книгу; 
4 - импорт в файл;
5 - изменить запись;
6 - удалить запись
"""))

if reques == 1:
    writing_person()
if reques == 2:
    search()
if reques == 3:
    print_phonebook()
if reques == 4:
    load()
if reques == 5:
    change()
if reques == 6:
    delete()
else:
    print("Такой команды не существует.")