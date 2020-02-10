namespace Model
{
    public sealed class ProductA: Product
    {
        private readonly double _costPerMonth;
        private readonly double _consumptionCost;
        /// <summary>
        /// Product A constructor
        /// </summary>
        /// <param name="costPerMonth">regular payment for product per month (EUR)</param>
        /// <param name="consumptionCost">price for energy consumed (EUR/kWh)</param>
        public ProductA(double costPerMonth, double consumptionCost)
        {
            _costPerMonth = costPerMonth;
            _consumptionCost = consumptionCost;
        }

        public override double AnnualExpenses(double consumption)
        {
            // TODO: test
            return _costPerMonth * 12 + _consumptionCost * consumption;
        }
    }
}
