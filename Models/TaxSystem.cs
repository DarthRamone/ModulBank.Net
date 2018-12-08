namespace ModulBank.Models
{
    /// <summary>
    /// Система налогообложения
    /// </summary>
    public enum TaxSystem
    {
        /// <summary>
        /// Общая СН
        /// </summary>
        OSN,
        
        /// <summary>
        /// Упрощенная СН (доходы)
        /// </summary>
        USN_INCOME,
        
        /// <summary>
        /// Упрощенная СН (доходы минус расходы)
        /// </summary>
        USN_INCOME_OUTCOME,
        
        /// <summary>
        /// Единый налог на вмененный доход
        /// </summary>
        ENVD,
        
        /// <summary>
        /// Единый сельскохозяйственный налог
        /// </summary>
        ESN,
        
        /// <summary>
        /// Патентная СН
        /// </summary>
        PATENT
    }
}