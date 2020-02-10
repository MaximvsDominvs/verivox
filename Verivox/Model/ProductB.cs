namespace Model
{
    public sealed class ProductB : Product
    {
        private readonly double _costPerYear;
        private readonly double _consumptionLimit;
        private readonly double _consumptionCost;
        /// <summary>
        /// Product B constructor
        /// </summary>
        /// <param name="costPerYear">basic price for product per annum(EUR)</param>
        /// <param name="consumptionLimit">amount of energy included in basic price (kWh)</param>
        /// <param name="consumptionCost">price per each kWh above consumption limit (EUR/kWh)</param>
        public ProductB(double costPerYear, double consumptionLimit, double consumptionCost)
        {
            _costPerYear = costPerYear;
            _consumptionLimit = consumptionLimit;
            _consumptionCost = consumptionCost;
        }

        public override double AnnualExpenses(double consumption)
        {
            // TODO: test
            double extraConsumption = consumption - _consumptionLimit;
            return _costPerYear + Heaviside(extraConsumption) * _consumptionCost;
        }
        /// <summary>
        /// Heaviside function implementation
        /// see https://en.wikipedia.org/wiki/Heaviside_step_function for details
        /// </summary>
        /// <param name="a">value to analyze</param>
        /// <returns>0 if a less than 0, or vlaue of <see cref="a"/> otherways</returns>
        private double Heaviside(double a)
        {
            return a < 0 ? 0 : a;
        }
    }
}
