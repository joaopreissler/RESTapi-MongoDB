using System;
namespace Catalog.Dtos
{
     public record ItemDto{

        public Guid Id {get; init;}
        public string Name {get; init;}
        public string CPF {get; init;}
    }
}