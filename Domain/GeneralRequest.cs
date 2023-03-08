using System;

namespace Domain
{
    public class GeneralRequest<T>
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public T Result { get; set; }
    }
}
