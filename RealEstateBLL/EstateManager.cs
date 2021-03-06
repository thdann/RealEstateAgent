

namespace RealEstateAgent
{
   
    public class EstateManager : ListManager<Estate>
    {
        
        public EstateManager()
        {
            TestEstates();
        }
       

        public void TestEstates()
        {
            base.Add(new School(1, new Address("björkväg1", "12345", "Malmö", Countries.Algeria), LegalForm.Ownership, 1000, 23, 40));
            base.Add(new Shop(2, new Address("ekväg4", "12222", "Lund", Countries.Algeria), LegalForm.Ownership, 100033, 3, 4));
            base.Add(new Villa(3, new Address("plommonväg1", "11111", "Oskarshamn", Countries.Algeria), LegalForm.Ownership, 1400008, 200, 700));
        }

    }
}