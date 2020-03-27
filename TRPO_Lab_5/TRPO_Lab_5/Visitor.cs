using System;
namespace TRPO_Lab_5
{
    /// <summary>
    /// Интерфейс-посетитель, содержит прототипы методов VisitPersonAcc и VisitCompanyAcc для работы с физическими и юридическими лицами соответственно
    /// </summary>
    interface IVisitor
    {
        void VisitPersonAcc(Person acc);
        void VisitCompanyAcc(Company acc);
    }
    /// <summary>
    /// Класс наследует интерфейс IVisitor, отвечает за методы для работы с мобильным банком, содержит методы для физ и юр лиц
    /// </summary>
    class MobileBank : IVisitor
    {
        /// <summary>
        /// Принимает объект типа Person, выводит уведомление о подключении услуги мобильного банка и физического лица
        /// </summary>
        /// <param name="acc"></param>
        public void VisitPersonAcc(Person acc)
        {
            Console.WriteLine("Успешно подключена услуга \"Мобильный банк для физических лиц\" " + acc.name);
        }
        /// <summary>
        /// Принимает объект типа Person, выводит уведомление о подключении услуги мобильного банка и название компании
        /// </summary>
        /// <param name="acc"></param>
        public void VisitCompanyAcc(Company acc)
        {
            Console.WriteLine("Успешно подключена услуга \"Мобильный банк для юридических лиц\" " + acc.companyName);
        }
    }
    /// <summary>
    /// Класс наследует интерфейс IVisitor, отвечает за методы для работы с вкладом в драгоценных металлах, содержит методы для физ и юр лиц
    /// </summary>
    class MetallInvest : IVisitor
    {
        /// <summary>
        /// Принимает объект типа Person, выводит уведомление об открытии вклада и имя клиента
        /// </summary>
        /// <param name="acc"></param>
        public void VisitPersonAcc(Person acc)
        {
            Console.WriteLine("Открыт вклад в драгоценных металлах для физического лица " + acc.name);
        }
        /// <summary>
        /// Принимает объект типа Person, выводит уведомление об открытии вклада и название компании
        /// </summary>
        /// <param name="acc"></param>
        public void VisitCompanyAcc(Company acc)
        {
            Console.WriteLine("Открыт вклад в драгоценных металлах для юридического лица " + acc.companyName);
        }
    }
    /// <summary>
    /// Класс наследует интерфейс IVisitor, отвечает за методы для работы с валютными вкладами, содержит методы для физ и юр лиц
    /// </summary>
    class CurrencyInvest : IVisitor
    {
        /// <summary>
        /// Принимает объект типа Person, выводит уведомление об открытии вклада и имя клиента
        /// </summary>
        /// <param name="acc"></param>
        public void VisitPersonAcc(Person acc)
        {
            Console.WriteLine("Открыт валютный вклад для физического лица " + acc.name);
        }
        /// <summary>
        /// Принимает объект типа Person, выводит уведомление об открытии вклада и название компании
        /// </summary>
        /// <param name="acc"></param>
        public void VisitCompanyAcc(Company acc)
        {
            Console.WriteLine("Открыт вклад в драгоценных металлах для юридического лица " + acc.companyName);
        }
    }
}
