﻿using BlueApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueApp.Data
{
    public class DummyData
    {
        public static List<CarModel> carsList = new List<CarModel>
        {
            new CarModel { CarCode = "0000", CarBrand = "Toyota", CarMod = "Corolla", CarYear = 2022, CarColor="Rojo" },
            new CarModel { CarCode = "0001", CarBrand = "Honda", CarMod = "Civic", CarYear = 2021, CarColor="Rojo" },
            new CarModel { CarCode = "0002", CarBrand = "Ford", CarMod = "Mustang", CarYear = 2023, CarColor="Rojo" },
            new CarModel { CarCode = "0003", CarBrand = "Chevrolet", CarMod = "Silverado", CarYear = 2022, CarColor="Amarillo" },
            new CarModel { CarCode = "0004", CarBrand = "Nissan", CarMod = "Altima", CarYear = 2023, CarColor="Amarillo" },
            new CarModel { CarCode = "0005", CarBrand = "BMW", CarMod = "X5", CarYear = 2022, CarColor="Amarillo" },
            new CarModel { CarCode = "0006", CarBrand = "Audi", CarMod = "A4", CarYear = 2021, CarColor="Amarillo" },
            new CarModel { CarCode = "0007", CarBrand = "Kia", CarMod = "Seltos", CarYear = 2023, CarColor="Amarillo" },
            new CarModel { CarCode = "0008", CarBrand = "Hyundai", CarMod = "Tucson", CarYear = 2022, CarColor="Amarillo" },
            new CarModel { CarCode = "0009", CarBrand = "Lexus", CarMod = "RX", CarYear = 2021, CarColor="Amarillo" },
            new CarModel { CarCode = "0010", CarBrand = "Mazda", CarMod = "CX-5", CarYear = 2023, CarColor="Amarillo" },
            new CarModel { CarCode = "0011", CarBrand = "Subaru", CarMod = "Outback", CarYear = 2022, CarColor="Amarillo" },
            new CarModel { CarCode = "0012", CarBrand = "Volkswagen", CarMod = "Jetta", CarYear = 2021, CarColor="Amarillo" },
            new CarModel { CarCode = "0013", CarBrand = "Mercedes-Benz", CarMod = "E-Class", CarYear = 2023, CarColor="Amarillo" },
            new CarModel { CarCode = "0014", CarBrand = "Acura", CarMod = "MDX", CarYear = 2022, CarColor="Blanco" },
            new CarModel { CarCode = "0015", CarBrand = "Jeep", CarMod = "Wrangler", CarYear = 2021, CarColor="Blanco" },
            new CarModel { CarCode = "0016", CarBrand = "GMC", CarMod = "Sierra", CarYear = 2023, CarColor="Blanco" },
            new CarModel { CarCode = "0017", CarBrand = "Cadillac", CarMod = "Escalade", CarYear = 2022, CarColor="Blanco" },
            new CarModel { CarCode = "0018", CarBrand = "Buick", CarMod = "Enclave", CarYear = 2021, CarColor="Blanco" },
            new CarModel { CarCode = "0019", CarBrand = "Lincoln", CarMod = "Navigator", CarYear = 2023, CarColor="Blanco" },
            new CarModel { CarCode = "0020", CarBrand = "Chrysler", CarMod = "300", CarYear = 2022, CarColor="Blanco" },
            new CarModel { CarCode = "0021", CarBrand = "Dodge", CarMod = "Charger", CarYear = 2021, CarColor="Blanco" },
            new CarModel { CarCode = "0022", CarBrand = "Ram", CarMod = "1500", CarYear = 2023, CarColor="Blanco" },
            new CarModel { CarCode = "0023", CarBrand = "Fiat", CarMod = "500", CarYear = 2022, CarColor="Verde" },
            new CarModel { CarCode = "0024", CarBrand = "Alfa Romeo", CarMod = "Giulia", CarYear = 2021, CarColor="Verde" },
            new CarModel { CarCode = "0025", CarBrand = "Volvo", CarMod = "XC60", CarYear = 2023, CarColor="Verde" },
            new CarModel { CarCode = "0026", CarBrand = "Jaguar", CarMod = "F-PACE", CarYear = 2022, CarColor="Verde" },
            new CarModel { CarCode = "0027", CarBrand = "Land Rover", CarMod = "Range Rover", CarYear = 2021, CarColor="Verde" },
            new CarModel { CarCode = "0028", CarBrand = "Mini", CarMod = "Cooper", CarYear = 2023, CarColor="Rosado" },
            new CarModel { CarCode = "0029", CarBrand = "Porsche", CarMod = "911", CarYear = 2022, CarColor="Rosado" },
            new CarModel { CarCode = "0030", CarBrand = "Ferrari", CarMod = "488", CarYear = 2021, CarColor="Rosado" },
            new CarModel { CarCode = "0031", CarBrand = "Lamborghini", CarMod = "Aventador", CarYear = 2023, CarColor="Rosado" },
            new CarModel { CarCode = "0032", CarBrand = "McLaren", CarMod = "720S", CarYear = 2022, CarColor="Rosado" },
            new CarModel { CarCode = "0033", CarBrand = "Bugatti", CarMod = "Chiron", CarYear = 2021, CarColor="Violeta" },
            new CarModel { CarCode = "0034", CarBrand = "Bentley", CarMod = "Continental", CarYear = 2023, CarColor="Violeta" },
            new CarModel { CarCode = "0035", CarBrand = "Rolls-Royce", CarMod = "Phantom", CarYear = 2022, CarColor="Violeta" },
            new CarModel { CarCode = "0036", CarBrand = "Aston Martin", CarMod = "DB11", CarYear = 2021, CarColor="Violeta" },
            new CarModel { CarCode = "0037", CarBrand = "Maserati", CarMod = "Levante", CarYear = 2023, CarColor="Violeta" },
            new CarModel { CarCode = "0038", CarBrand = "Koenigsegg", CarMod = "Jesko", CarYear = 2022, CarColor="Violeta" },
            new CarModel { CarCode = "0039", CarBrand = "Pagani", CarMod = "Huayra", CarYear = 2021, CarColor="Violeta" },
            new CarModel { CarCode = "0040", CarBrand = "Lexus", CarMod = "LX", CarYear = 2023, CarColor="Violeta" },
            new CarModel { CarCode = "0041", CarBrand = "Infiniti", CarMod = "QX60", CarYear = 2022, CarColor="Negro" },
            new CarModel { CarCode = "0042", CarBrand = "Genesis", CarMod = "G80", CarYear = 2021, CarColor="Negro" },
            new CarModel { CarCode = "0043", CarBrand = "Kia", CarMod = "Forte", CarYear = 2023, CarColor="Negro" },
            new CarModel { CarCode = "0044", CarBrand = "Hyundai", CarMod = "Sonata", CarYear = 2022, CarColor="Negro" },
            new CarModel { CarCode = "0045", CarBrand = "Mazda", CarMod = "Mazda3", CarYear = 2021, CarColor="Negro" },
            new CarModel { CarCode = "0046", CarBrand = "Subaru", CarMod = "Impreza", CarYear = 2023, CarColor="Negro" },
            new CarModel { CarCode = "0047", CarBrand = "Volkswagen", CarMod = "Tiguan", CarYear = 2022, CarColor="Negro" },
            new CarModel { CarCode = "0048", CarBrand = "Audi", CarMod = "Q5", CarYear = 2021, CarColor="Negro" },
            new CarModel { CarCode = "0049", CarBrand = "BMW", CarMod = "3 Series", CarYear = 2023, CarColor="Verde" },
            new CarModel { CarCode = "0050", CarBrand = "Mercedes-Benz", CarMod = "C-Class", CarYear = 2022, CarColor="Verde" },
            new CarModel { CarCode = "0051", CarBrand = "Acura", CarMod = "TLX", CarYear = 2021, CarColor="Verde" },
            new CarModel { CarCode = "0052", CarBrand = "Chevrolet", CarMod = "Malibu", CarYear = 2023, CarColor="Verde" },
            new CarModel { CarCode = "0053", CarBrand = "Ford", CarMod = "Fusion", CarYear = 2022, CarColor="Plateado" },
            new CarModel { CarCode = "0054", CarBrand = "Honda", CarMod = "Accord", CarYear = 2021, CarColor="Plateado" },
            new CarModel { CarCode = "0055", CarBrand = "Toyota", CarMod = "Camry", CarYear = 2023, CarColor="Plateado" },
            new CarModel { CarCode = "0056", CarBrand = "Nissan", CarMod = "Sentra", CarYear = 2022, CarColor="Plateado" },
            new CarModel { CarCode = "0057", CarBrand = "Mitsubishi", CarMod = "Lancer", CarYear = 2021, CarColor="Plateado" },
            new CarModel { CarCode = "0058", CarBrand = "Jeep", CarMod = "Grand Cherokee", CarYear = 2023, CarColor="Plateado" },
            new CarModel { CarCode = "0059", CarBrand = "GMC", CarMod = "Terrain", CarYear = 2022, CarColor="Plateado" },
            new CarModel { CarCode = "0060", CarBrand = "Cadillac", CarMod = "XT5", CarYear = 2021, CarColor="Plateado" },
            new CarModel { CarCode = "0061", CarBrand = "Buick", CarMod = "Encore", CarYear = 2023, CarColor="Plateado" },
            new CarModel { CarCode = "0062", CarBrand = "Lincoln", CarMod = "Aviator", CarYear = 2022, CarColor="Dorado" },
            new CarModel { CarCode = "0063", CarBrand = "Chrysler", CarMod = "Pacifica", CarYear = 2021, CarColor="Dorado" },
            new CarModel { CarCode = "0064", CarBrand = "Dodge", CarMod = "Durango", CarYear = 2023, CarColor="Dorado" },
            new CarModel { CarCode = "0065", CarBrand = "Ram", CarMod = "2500", CarYear = 2022, CarColor="Dorado" },
            new CarModel { CarCode = "0066", CarBrand = "Fiat", CarMod = "Spider", CarYear = 2021, CarColor="Dorado" },
            new CarModel { CarCode = "0067", CarBrand = "Alfa Romeo", CarMod = "Stelvio", CarYear = 2023, CarColor="Dorado" },
            new CarModel { CarCode = "0068", CarBrand = "Volvo", CarMod = "S60", CarYear = 2022, CarColor="Dorado" },
            new CarModel { CarCode = "0069", CarBrand = "Jaguar", CarMod = "XE", CarYear = 2021, CarColor="Dorado" },
            new CarModel { CarCode = "0070", CarBrand = "Land Rover", CarMod = "Discovery", CarYear = 2023, CarColor="Dorado" },
            new CarModel { CarCode = "0071", CarBrand = "Mini", CarMod = "Countryman", CarYear = 2022, CarColor="Azul Mate" },
            new CarModel { CarCode = "0072", CarBrand = "Porsche", CarMod = "Cayenne", CarYear = 2021, CarColor="Azul Mate" },
            new CarModel { CarCode = "0073", CarBrand = "Ferrari", CarMod = "812", CarYear = 2023, CarColor="Azul Mate" },
            new CarModel { CarCode = "0074", CarBrand = "Lamborghini", CarMod = "Urus", CarYear = 2022, CarColor="Azul Mate" },
            new CarModel { CarCode = "0075", CarBrand = "McLaren", CarMod = "570S", CarYear = 2021, CarColor="Azul Mate" },
            new CarModel { CarCode = "0076", CarBrand = "Bugatti", CarMod = "Veyron", CarYear = 2023, CarColor="Azul Mate" },
            new CarModel { CarCode = "0077", CarBrand = "Bentley", CarMod = "Bentayga", CarYear = 2022, CarColor="Azul Mate" },
            new CarModel { CarCode = "0078", CarBrand = "Rolls-Royce", CarMod = "Cullinan", CarYear = 2021, CarColor="Azul Mate" },
            new CarModel { CarCode = "0079", CarBrand = "Aston Martin", CarMod = "Vantage", CarYear = 2023, CarColor="Azul Mate" },
            new CarModel { CarCode = "0080", CarBrand = "Maserati", CarMod = "Quattroporte", CarYear = 2022, CarColor="Gris Mate" },
            new CarModel { CarCode = "0081", CarBrand = "Koenigsegg", CarMod = "Regera", CarYear = 2021, CarColor="Gris Mate" },
            new CarModel { CarCode = "0082", CarBrand = "Pagani", CarMod = "Zonda", CarYear = 2023, CarColor="Gris Mate" },
            new CarModel { CarCode = "0083", CarBrand = "Lexus", CarMod = "ES", CarYear = 2022, CarColor="Gris Mate" },
            new CarModel { CarCode = "0084", CarBrand = "Infiniti", CarMod = "Q50", CarYear = 2021, CarColor="Gris Mate" },
            new CarModel { CarCode = "0085", CarBrand = "Genesis", CarMod = "G70", CarYear = 2023, CarColor="Gris Mate" },
            new CarModel { CarCode = "0086", CarBrand = "Kia", CarMod = "Rio", CarYear = 2022, CarColor="Gris Mate" },
            new CarModel { CarCode = "0087", CarBrand = "Hyundai", CarMod = "Elantra", CarYear = 2021, CarColor="Gris Mate" },
            new CarModel { CarCode = "0088", CarBrand = "Mazda", CarMod = "MX-5", CarYear = 2023, CarColor="Gris Mate" },
            new CarModel { CarCode = "0089", CarBrand = "Subaru", CarMod = "Forester", CarYear = 2022, CarColor="Verde" },
            new CarModel { CarCode = "0090", CarBrand = "Volkswagen", CarMod = "Atlas", CarYear = 2021, CarColor="Verde" },
            new CarModel { CarCode = "0091", CarBrand = "Audi", CarMod = "A3", CarYear = 2023, CarColor="Verde" },
            new CarModel { CarCode = "0092", CarBrand = "BMW", CarMod = "X3", CarYear = 2022, CarColor="Verde" },
            new CarModel { CarCode = "0093", CarBrand = "Mercedes-Benz", CarMod = "GLC", CarYear = 2021, CarColor="Verde" },
            new CarModel { CarCode = "0094", CarBrand = "Acura", CarMod = "ILX", CarYear = 2023, CarColor="Verde" },
            new CarModel { CarCode = "0095", CarBrand = "Chevrolet", CarMod = "Spark", CarYear = 2022, CarColor="Verde" },
            new CarModel { CarCode = "0096", CarBrand = "Ford", CarMod = "Escape", CarYear = 2021, CarColor="Plateado" },
            new CarModel { CarCode = "0097", CarBrand = "Honda", CarMod = "Fit", CarYear = 2023, CarColor="Plateado" },
            new CarModel { CarCode = "0098", CarBrand = "Toyota", CarMod = "Yaris", CarYear = 2022, CarColor="Plateado" },
            new CarModel { CarCode = "0099", CarBrand = "Nissan", CarMod = "Versa", CarYear = 2021, CarColor="Verde" }
        };
    }
}
