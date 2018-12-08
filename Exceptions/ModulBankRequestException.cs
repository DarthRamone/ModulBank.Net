using System;

namespace ModulBank.Exceptions
{
    public class ModulBankRequestException : Exception
    {
        public ModulBankRequestException(string message) : base(message)
        {
        }
    }
}