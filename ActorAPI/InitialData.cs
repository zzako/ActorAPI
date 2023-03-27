using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActorAPI.Context;


namespace ActorAPI
{
    using System.Linq;
    using ActorAPI.Context;
    using ActorAPI.Models;
    public static  class InitialData
    {
        public static void seed(this ActorContext dbContext)
        {
            if(!dbContext.actors.Any())
            {
                dbContext.actors.Add(new Actor
                    {
                        name = "Pedro",
                        lastname = "Pascal",
                        Age = 42,
                        standoutmovie = "Last of Us",
                        gender = "Male"

                });
                dbContext.actors.Add(new Actor
                {
                    name = "Margot",
                    lastname = "Robbie",
                    Age = 32,
                    standoutmovie = "Suicide Squad",
                    gender = "Female"

                });
                dbContext.SaveChanges();
            }
        }
    }
}
