using System;

namespace RestApiModeloDDD.Domain.Entitys
{
    public class Base
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public bool IsActive { get; set; }
    }
}
