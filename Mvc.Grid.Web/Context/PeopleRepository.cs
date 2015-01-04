using NonFactors.Mvc.Grid.Web.Models;
using System;
using System.Collections.Generic;

namespace NonFactors.Mvc.Grid.Web.Context
{
    public static class PeopleRepository
    {
        public static IEnumerable<PersonModel> GetPeople()
        {
            return new List<PersonModel>
            {
                new PersonModel
                {
                    Name = "Joe",
                    Surname = "Crosswave",

                    Age = (Int32)(DateTime.Now - new DateTime(1988, 01, 05)).TotalDays / 365,
                    Birthday = new DateTime(1988, 01, 05),
                    IsWorking = false
                },
                new PersonModel
                {
                    Name = "Merry",
                    Surname = "Lisel",

                    Age = (Int32)(DateTime.Now - new DateTime(1978, 05, 06)).TotalDays / 365,
                    Birthday = new DateTime(1978, 05, 06)
                },
                new PersonModel
                {
                    Name = "Henry",
                    Surname = "Crux",

                    Age = (Int32)(DateTime.Now - new DateTime(1990, 11, 19)).TotalDays / 365,
                    Birthday = new DateTime(1990, 11, 19),
                    IsWorking = true
                },
                new PersonModel
                {
                    Name = "Cody",
                    Surname = "Jurut",

                    Age = (Int32)(DateTime.Now - new DateTime(1970, 08, 11)).TotalDays / 365,
                    Birthday = new DateTime(1970, 08, 11),
                    IsWorking = false
                },
                new PersonModel
                {
                    Name = "Simon",
                    Surname = "Scranton",

                    Age = (Int32)(DateTime.Now - new DateTime(1985, 10, 10)).TotalDays / 365,
                    Birthday = new DateTime(1985, 10, 10)
                },
                new PersonModel
                {
                    Name = "Leena",
                    Surname = "Laurent",

                    Age = (Int32)(DateTime.Now - new DateTime(2000, 07, 01)).TotalDays / 365,
                    Birthday = new DateTime(2000, 07, 01),
                    IsWorking = false
                },
                new PersonModel
                {
                    Name = "Ode",
                    Surname = "Cosmides",

                    Age = (Int32)(DateTime.Now - new DateTime(1966, 04, 17)).TotalDays / 365,
                    Birthday = new DateTime(1966, 04, 17),
                    IsWorking = true
                },
                new PersonModel
                {
                    Name = "Diandra",
                    Surname = "Mizner",

                    Age = (Int32)(DateTime.Now - new DateTime(1999, 08, 20)).TotalDays / 365,
                    Birthday = new DateTime(1999, 08, 20),
                    IsWorking = false
                },
                new PersonModel
                {
                    Name = "Pete",
                    Surname = "Cassel",

                    Age = (Int32)(DateTime.Now - new DateTime(1997, 03, 13)).TotalDays / 365,
                    Birthday = new DateTime(1997, 03, 13),
                    IsWorking = false
                },
                new PersonModel
                {
                    Name = "Nicky",
                    Surname = "Tremblay",

                    Age = (Int32)(DateTime.Now - new DateTime(1988, 01, 05)).TotalDays / 365,
                    Birthday = new DateTime(1988, 01, 05),
                    IsWorking = true
                },
                new PersonModel
                {
                    Name = "Rikki",
                    Surname = "Mattison",

                    Age = (Int32)(DateTime.Now - new DateTime(2000, 10, 12)).TotalDays / 365,
                    Birthday = new DateTime(2000, 10, 12)
                }
            };
        }
    }
}
