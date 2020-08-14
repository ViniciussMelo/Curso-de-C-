using System;
using Workout01.Entities;

namespace Workout01.Services
{
    class AmountService
    {
        private IPaymentService _paymentService;

        public AmountService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(1);
                double updatedQuota = basicQuota + _paymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _paymentService.PaymentFee(updatedQuota);

                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
