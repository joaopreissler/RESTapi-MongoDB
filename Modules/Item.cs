using System;
namespace Catalog.Entities{
    public record Item{

        public Guid Id {get; init;}
        public string Name {get; init;}
        public string CPF {get; init;}
    }
}