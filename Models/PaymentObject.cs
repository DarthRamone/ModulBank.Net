namespace ModulBank.Models
{
    /// <summary>
    /// Предмет расчета
    /// </summary>
    public enum PaymentObject
    {
        /// <summary>
        /// Товар
        /// </summary>
        COMMODITY,
        
        /// <summary>
        /// Подакцизный товар
        /// </summary>
        EXCISE,
        
        /// <summary>
        /// Работа
        /// </summary>
        JOB,
        
        /// <summary>
        /// Услуга
        /// </summary>
        SERVICE,
        
        /// <summary>
        /// Ставка азартной игры
        /// </summary>
        GAMBLING_BET,
        
        /// <summary>
        /// Лотерейный билет
        /// </summary>
        LOTTERY,
        
        /// <summary>
        /// Выигрыш лотереи
        /// </summary>
        LOTTERY_PRIZE,
        
        /// <summary>
        /// Предоставление результатов интеллектуальной деятельности
        /// </summary>
        INTELLECTUAL_ACTIVITY,
        
        /// <summary>
        /// Платеж
        /// </summary>
        PAYMENT,
        
        /// <summary>
        /// Агентское вознаграждение
        /// </summary>
        AGENT_COMISSION,
        
        /// <summary>
        /// Составной предмет расчета
        /// </summary>
        COMPOSITE,
        
        /// <summary>
        /// Другое
        /// </summary>
        ANOTHER
    }
}