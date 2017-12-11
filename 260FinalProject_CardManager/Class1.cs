using System;
using _260FinalProject_CardManager;

namespace _260FinalProject_CardManager
{
    //correct class file
    //this file contains classes built by Landon Frederes for the use of the card manager application
    public class Payment
    {
        private DateTime datetime;
        private float totalAmmount;

        public void SetPayment(float tA, DateTime dt)
        {
            datetime = dt;
            totalAmmount = tA;
        }
    }

    public class ReccuringPayments
    {
        private DateTime recDate;
        private float totalPlusInterest;
        private float monthPayment;
        private int numPayments;
        private float interest;
        private Payment recPayment = new Payment();


        internal int SetRecPayments(float totalPlusInterest, float interestVal, float monthPayment)
        {
            int months;
            float dectotal = totalPlusInterest;
            for (months = 1; dectotal - monthPayment > 0; ++months)
            {
                dectotal = dectotal - monthPayment;
                dectotal = dectotal + (dectotal * (interestVal / 100));
                if(months == 90)
                {
                    return -1;
                }
            }
            return months;
        }

    }
}