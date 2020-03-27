using System;
namespace TRPO_Lab_5
{
    class Program
    {
        /// <summary>
        /// в main создаются объекты, производится работа со списком клиентов и оказанием конкретных услуг
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Person first = new Person("Buss Evgeny", "111222", "8712551465");
            Person second = new Person("Ivanov Petr", "222333", "1111111111");
            Person third = new Person("Petrov Vasily", "333444", "2222222222");
            Person fourth = new Person("Vanya Ivanov", "111111", "22222222");
            Company poly = new Company("Rudskoy A", "0000", "1111", "Polytech");
            Company itmo = new Company("Vasilev B", "1111", "2222", "ITMO");
            Company bonch = new Company("Nikolaev S", "2222", "3333", "Bonch");
            Bank myBank = new Bank();
            myBank.Add(first);
            myBank.Add(second);
            myBank.Add(third);
            myBank.Add(poly);
            myBank.Add(itmo);
            myBank.Add(bonch);
            MetallInvest metall = new MetallInvest();
            myBank.Accept(metall);
        }
    }
}
