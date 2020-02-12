namespace Model
{
    /// <summary>
    /// Basic class for product
    /// </summary>
    public abstract class Product
    {
        /// <summary>
        /// Tariff name
        /// </summary>
        public string Name;
        /// <summary>
        /// Calculate annual cost/expenses per tariff for consumption provided
        /// </summary>
        /// <param name="consumption">total energy consumption for year in kWh</param>
        /// <returns></returns>
        public abstract double AnnualExpenses(double consumption);
    }
}
