using System.Collections.Generic;

namespace Web.Model.TestData
{
    public class TypeOfPets
    {
        public TypeOfPets(string petTypeId, string petType)
        {
            PetTypeId   = petTypeId;
            PetType     = petType;
        }

        public string PetTypeId { get;}
        public string PetType   { get;}
    }
    public static class TestSearchData
    {
            public static IEnumerable<TypeOfPets> DogList()
            {
                List<TypeOfPets> typesOfPet = new List<TypeOfPets>
                {
                    new TypeOfPets("dog", "German Shepherd"),
                    new TypeOfPets("dog", "Husky"),
                    new TypeOfPets("cat", "Russian Blue"),
                    new TypeOfPets("fish", "Goldfish")
                };
                return typesOfPet;
            }
    }
}
