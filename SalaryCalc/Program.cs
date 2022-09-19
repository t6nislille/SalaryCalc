using System;

namespace SalaryCalc
{

    //*Maksuvaba tulu arvestamine: aastatuluga kuni 14 400 eurot on maksuvaba tulu 6000 eurot aastas,
    //*aastatulu kasvades 14 400 eurolt 25 200 euroni väheneb maksuvaba tulu vastavalt
    //valemile 6000 – 6000 ÷ 10 800 × (tulu summa – 14 400),
    //* aastatuluga üle 25 200 euro on maksuvaba tulu 0.


    //Eesti riigi palgakalkulaator:
    //Palga kalkulaator Test
    //1. Sina sisestad brutotasu ja valem arvutab välja netotasu.
    //2. Kokku peab olema kolm erinevat meetodit. Enne kui meetod algab, siis peab olema kontroll,
    //et millist meetodi hakatakse kasutama ja sisestatud palgasumma peab minema edasi järgmisse meetodi.
    //3. Netotasu peab arvutama selliselt välja, et sina ei peaks tuludeklaratsiooni ajal
    //juurde maksma ega saa pärast riigilt raha juurde kuna oled rohkem maksnud.
    //4. Kood peab olema inglisekeelne.

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Insert your Gross salary(before tax)");
            int GrossSalary = Convert.ToInt32(Console.ReadLine());

            if (GrossSalary <= 1200 && GrossSalary >= 500)
            {

                Calculator1(GrossSalary);
            }
            if (GrossSalary <= 2099 && GrossSalary >= 1201)
            {

                Calculator2(GrossSalary);
            }
            if (GrossSalary >= 2101)
            {
                Calculator3(GrossSalary);
            }
        }
        static void Calculator1(double GrossSalary)
        {
            double pensionFund = GrossSalary * 0.02;
            double insurance = GrossSalary * 0.016;
            double tax = (GrossSalary - 500 - pensionFund - insurance) * 0.2;
            double Calculator1 = GrossSalary - pensionFund - insurance - tax;
            Console.WriteLine("Your salary after tax deduction is: " + Calculator1);
        }

        static void Calculator2(double GrossSalary)
        {
            double pensionFund = GrossSalary * 0.02;
            double insurance = GrossSalary * 0.016;
            double taxFreeIncome = 500 - 0.55556 * (GrossSalary - 1200);
            double tax = (GrossSalary - pensionFund - insurance - taxFreeIncome) * 0.2;
            double Calculator2 = GrossSalary - pensionFund - insurance - tax;
            Console.WriteLine("Your salary after tax deduction is: " + Calculator2);

        }
        static void Calculator3(double GrossSalary)
        {
            double pensionFund = GrossSalary * 0.02;
            double insurance = GrossSalary * 0.016;
            double tax = GrossSalary * 0.2;
            double Calculator3 = GrossSalary - pensionFund - insurance - tax;
            Console.WriteLine("Your salary after tax deduction is: " + Calculator3);
        }
    }
}
