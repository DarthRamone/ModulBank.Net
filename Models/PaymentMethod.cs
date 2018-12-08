namespace ModulBank.Models
{
    /// <summary>
    /// Метод платежа
    /// </summary>
    public enum PaymentMethod
    {
        /// <summary>
        /// Предоплата 100%
        /// </summary>
        FULL_PREPAYMENT,
        
        /// <summary>
        /// Предоплата
        /// </summary>
        PREPAYMENT,
        
        /// <summary>
        /// Составной предмет расчета
        /// </summary>
        ADVANCE,
        
        /// <summary>
        /// Аванс
        /// </summary>
        FULL_PAYMENT,
        
        /// <summary>
        /// Полный расчет
        /// </summary>
        PARTIAL_PAYMENT,
        
        /// <summary>
        /// Частичный расчет и кредит
        /// </summary>
        CREDIT,
        
        /// <summary>
        /// Передача в кредит
        /// </summary>
        CREDIT_PAYMENT
    }
}