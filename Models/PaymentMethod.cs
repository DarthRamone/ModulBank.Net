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
        /// Аванс
        /// </summary>
        ADVANCE,
        
        /// <summary>
        /// Полный расчёт
        /// </summary>
        FULL_PAYMENT,
        
        /// <summary>
        /// Частичный расчет и кредит
        /// </summary>
        PARTIAL_PAYMENT,
        
        /// <summary>
        /// Передача в кредит
        /// </summary>
        CREDIT,
        
        /// <summary>
        /// Оплата кредита
        /// </summary>
        CREDIT_PAYMENT
    }
}