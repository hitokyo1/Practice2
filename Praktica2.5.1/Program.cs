﻿namespace GarageConsoleApp;
/// <summary>
/// 
/// Класс Program
/// здесь описываем логику приложения
/// вызываем нужные методы, пишем обработчики и т.д.
/// </summary>
public class Program 
{
    public static void Main(string[] args)
    {  
        Console.WriteLine($"Панель выбора \n1 - Просмотр типов машин \n2 - Добавление типов машин \n3 - Просмотр водителей \n4 - Просмотр прав у водителей \n5 - Добавление водителей \n6 - Добавление прав у водителей \n7 - Просмотр категорий прав \n8 - Добавление категорий прав \n9 - Просмотр машин \n10 - добавление машин \n11 - Просмотр маршрутов \n12 - Добавление маршрутов \n13 - Просмотр рейсов \n14 - Добавление рейсов \nQ - Выход ");
        string bang = Console.ReadLine();
        // работать пока не введем "P"
        while (bang != "P")  
        {
            int idDriver;
            switch (bang)   
            {
                case "1":
                    // кейс тип машин
                    DatabaseRequests.GetTypeCarQuery();   
                    break;
                case "2":
                    // добавляем тип машин
                    Console.Write("Введите название нового типа транспорта: ");
                    string name = Console.ReadLine();
                    
                    DatabaseRequests.AddTypeCarQuery(name);
                    
                    Console.WriteLine("Тип транспорта добавлен в базу данных.");
                    break;
                case "3":
                    // список водителей
                    DatabaseRequests.GetDriverQuery();  
                    Console.WriteLine();  
                    break;
                case "4":
                    // права по ключу(ID)
                    Console.Write("Введите id водителя, чтобы посмотреть его права: ");
                    int id = int.Parse(Console.ReadLine());  
                    DatabaseRequests.GetDriverRightsCategoryQuery(id);   
                    Console.WriteLine();   
                    break;
                case "5":
                    // добавляем водителя
                    Console.Write("Введите имя нового водителя: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Введите фамилию нового водителя: ");
                    string lastName = Console.ReadLine();

                    Console.Write("Введите дату рождения нового водителя: ");
                    DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
                    
                    DatabaseRequests.AddDriverQuery(firstName, lastName, birthDate);
                    
                    Console.WriteLine("Водитель внесем в базу данных.");
                    break;
                case "6":
                    // добавляем вод. права
                    Console.Write("Введите id водителя, которому хотите присвоить права: ");
                    idDriver = Int32.Parse(Console.ReadLine());
                    
                    Console.Write("Введите id прав, которые хотите присвоить водителю: ");
                    int idRightsCategory = Int32.Parse(Console.ReadLine());
                    
                    DatabaseRequests.AddDriverRightsCategoryQuery(idDriver, idRightsCategory );
                    
                    Console.WriteLine("Наличие прав у водителя внесено в базу данных.");
                    break;
                case "7":
                    // кейс категорий прав
                    DatabaseRequests.GetRightsCategoryQuery();
                    break;
                case "8":
                    // добавляем категории прав
                    Console.Write("Введите название новой категории прав: ");
                    string nameRightsCategory = Console.ReadLine();
                    
                    DatabaseRequests.AddRightsCategoryQuery(nameRightsCategory);

                    Console.WriteLine("Категория прав внесена в базу данных.");
                    break;
                case "9" :
                    // кейс машин
                    DatabaseRequests.GetCarQuery();
                    break;
                case "10":
                    // добавляем машину
                    Console.Write("Введите id типа машины, которую хотите добавить: ");
                    int idTypeCar = Int32.Parse(Console.ReadLine());

                    Console.Write("Введите модель машины: ");
                    string nameCar = Console.ReadLine();

                    Console.Write("Введите гос. номер машины: ");
                    string stateNumber = Console.ReadLine();

                    Console.Write("Введите количество посадочных мест: ");
                    int numberPassengers = Int32.Parse(Console.ReadLine());
                    
                    DatabaseRequests.AddCarQuery(idTypeCar, nameCar, stateNumber, numberPassengers);
                    
                    Console.WriteLine("Автомобиль внесен в базу данных.");
                    break; 
                case "11" :
                    // кейс маршруты
                    DatabaseRequests.GetItineraryQuery();    
                    break; 
                case "12":
                    // добавляем маршрут
                    Console.Write("Введите новый маршрут: ");
                    string nameItinerary = Console.ReadLine();
                    
                    DatabaseRequests.AddItineraryQuery(nameItinerary);
                    
                    Console.WriteLine("Маршрут добавлен в базу данных.");
                    break; 
                case "13" :
                    // кейс рейс
                    DatabaseRequests.GetRouteQuery();
                    break; 
                case "14":
                    // добавляем рейс
                    Console.Write("Введите id водителя: ");
                    idDriver = Int32.Parse(Console.ReadLine());
                    
                    Console.Write("Введите id машины: ");
                    int idCar = Int32.Parse(Console.ReadLine());

                    Console.Write("Введите id маршрута: ");
                    int idItinenrary = int.Parse(Console.ReadLine());

                    Console.Write("Введите id посадочных мест: ");
                    int idNubmerPassengers = Int32.Parse(Console.ReadLine());
                    
                    DatabaseRequests.AddRouteQuery(idDriver, idCar, idItinenrary, idNubmerPassengers);
                    
                    Console.WriteLine("Рейс добавлен в базу данных.");
                    break;
                default:
                    Console.WriteLine($"Введена неверная команда");  
                    break; 
            }   
            bang = Console.ReadLine();
        }  
    } 
}