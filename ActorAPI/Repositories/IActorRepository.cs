using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActorAPI.Context;
using ActorAPI.Models;

namespace ActorAPI.Repositories
{
    public interface IActorRepository
    {
        IEnumerable<Actor> GetActors();
        Actor GetUserById(int id);
        Actor GetUserByName(String name);

        void addActor(Actor act);
        void addActors(IEnumerable<Actor> actors);
     

        void updateActor(Actor act);

        void deleteActor(int id);
    }
}
