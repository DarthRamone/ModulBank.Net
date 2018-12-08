namespace ModulBank.Models
{
    /// <summary>
    /// Ставка НДС
    /// </summary>
    public enum VAT
    {
        /// <summary>
        /// Без НДС
        /// </summary>
        NONE,
        
        /// <summary>
        /// НДС по ставке 0%
        /// </summary>
        VAT0,
        
        /// <summary>
        /// НДС чека по ставке 10%
        /// </summary>
        VAT10,
        
        /// <summary>
        /// НДС чека по ставке 18%
        /// </summary>
        VAT18,
        
        /// <summary>
        /// НДС чека по расчетной ставке 10%
        /// </summary>
        VAT110,
        
        /// <summary>
        /// НДС чека по расчетной ставке 18%
        /// </summary>
        VAT118
    }
}