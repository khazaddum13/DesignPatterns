using System;
using DesignPatterns.BusinessServices;
using DesignPatterns.BusinessServices.StrategyDesignPattern.Permit;
using DesignPatterns.BusinessServices.StrategyDesignPattern.Salary;
using DesignPatterns.Model;
using DesignPatterns.BusinessServices.ABL;
using System.Collections.Generic;

namespace DesignPatterns.Console.Management
{
    internal static class Program
    {
        #region Property

        private static ProductBS m_ProductBS = new ProductBS();

        #endregion
        private static void Main(string[] args)
        {
            #region Prototype Desing Pattern

            Car proptotype = new Car()
            {
                m_Name = "Mercedes",
                m_Velocity = 260,
                m_Acceleration = 10
            };

            Car copy1 = (Car)proptotype.Clone();
            copy1.m_Name = "Audi";
            copy1.m_Velocity = 240;
            copy1.m_Acceleration = 20;

            Car copy2 = (Car)proptotype.Clone();
            copy2.m_Name = "Opel";
            copy2.m_Velocity = 260;
            copy2.m_Acceleration = 5;


            CarToRace racingCars = new CarToRace() { proptotype, copy1, copy2 };

            List<Car> result = racingCars.Race();

            #endregion Prototype Desing Pattern

            #region BuilderDesignPattern

            MessageCreator creator = new MessageCreator();
            Message birthdayMessage = creator.Create(new BirthdayMessageBuilder());

            #endregion

            #region Singleton Desing Pattern

            DBHelper test_1 = DBHelper.CreateDBHelper("test");

            DBHelper test_2 = DBHelper.CreateDBHelper("test_2");

            #endregion

            #region FactoryDesignPattern

            

            #endregion

            #region CommandDesignPattern

            //Person Kisi = new Person { PersonID = 1, Name = "Ahmet" };

            //ReceiverPerson rk1 = new ReceiverPerson(Kisi);

            //CommadPerson ckAdd = new ConcreteCommandAddPerson(rk1);
            //CommadPerson ckSil = new ConcreteCommandDelete(rk1);
            //CommadPerson ckCreate = new ConcreteCommandCreate(rk1);
            //CommadPerson ckUpdate = new ConcreteCommandUpdate(rk1);


            //InvokerPerson ik = new InvokerPerson();

            //ik.CommandList.Add(ckAdd);
            //ik.CommandList.Add(ckSil);
            //ik.CommandList.Add(ckCreate);
            //ik.CommandList.Add(ckUpdate);


            //ik.ExecuteAll();

            //System.Console.ReadKey();

            #endregion

            #region StrategyDesignPattern

            Personnel personnel = new Personnel(new CalculateEngineerSalary(), new CalculateDeptBPermit());

            int engineerSalary = personnel.m_PersonnelSalary.CalculateSalary();
            int engineerPermit = personnel.m_PersonnelPermit.CalculatePermit();

            personnel = new Personnel(new CalculateManagerSalary(), new CalculateDeptAPermit());
            int managerSalary = personnel.m_PersonnelSalary.CalculateSalary();
            int managerPermit = personnel.m_PersonnelPermit.CalculatePermit();

            #endregion

            #region ObserverDesignPattern
            //test

            #endregion

            #region BridgeDesignPattern

            Rapor rapor = new SalesReport(new DesktopFormat());

            string resultBridge = rapor.Display();

            rapor = new PerformanceReport(new MobileFormat());
            resultBridge = rapor.Display();

            #endregion
        }
    }
}
