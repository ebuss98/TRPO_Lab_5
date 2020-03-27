using System;
using System.Collections.Generic;
namespace TRPO_Lab_5
{
    /// <summary>
    /// класс для работы со списком клиентов, реализованы метод Add и Remove для добавления и удаления клиента из списка соответственно
    /// </summary>
    class Bank
    {
        readonly List<IAccount> accounts = new List<IAccount>();
        public void Add(IAccount acc)
        {
            accounts.Add(acc);
        }
        public void Remove(IAccount acc)
        {
            accounts.Remove(acc);
        }
        public void Accept(IVisitor visitor)
        {
            foreach (IAccount acc in accounts)
                acc.Accept(visitor);
        }
    }
    /// <summary>
    /// Интерфейс-акцептор, содержит метод для "приема" посетителя
    /// </summary>
    interface IAccount
    {
        void Accept(IVisitor visitor);
    }
    /// <summary>
    /// Класс физического лица, содержит поля с данными клиента, конструктор и переопределенный метод-акцептор
    /// </summary>
    class Person : IAccount
    {
        public string name;
        public string accNumber;
        public string passport;
        /// <summary>
        /// конструктор, принимает на вход имя, номер счета и номер паспорта клиента
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="AccNumber"></param>
        /// <param name="Passport"></param>
        public Person(string Name, string AccNumber, string Passport)
        {
            name = Name;
            accNumber = AccNumber;
            passport = Passport;
        }
        /// <summary>
        /// метод-акцептор, содержит ссылку на себя, чтобы посетитель мог получить доступ к состоянию элемента
        /// </summary>
        /// <param name="visitor"></param>
        public void Accept(IVisitor visitor)
        {
            visitor.VisitPersonAcc(this);
        }
    }
    /// <summary>
    /// Класс юридического лица, содержит поля с данными клиента, конструктор и переопределенный метод-акцептор
    /// </summary>
    class Company : IAccount
    {
        public string name;
        public string regDoc;
        public string number;
        public string companyName;
        /// <summary>
        /// конструктор, принимает на вход имя,номер регистрационного документа, номер счета и название компании
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="AccNumber"></param>
        /// <param name="Passport"></param>
        public Company(string Name, string RegDoc, string Number, string CompanyName)
        {
            name = Name;
            regDoc = RegDoc;
            number = Number;
            companyName = CompanyName;
        }
        /// <summary>
        /// метод-акцептор, содержит ссылку на себя, чтобы посетитель мог получить доступ к состоянию элемента
        /// </summary>
        /// <param name="visitor"></param>
        public void Accept(IVisitor visitor)
        {
            visitor.VisitCompanyAcc(this);
        }
    }
}
