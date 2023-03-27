using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActorAPI.Models;

namespace ActorAPI.Services
{
    public interface IActorService
    {
        public IEnumerable<Actor> getActors();
        public void  deleteActor(int id);

        public void updateActor(Actor act);

        public IEnumerable<Actor> addActors(IEnumerable<Actor> actors);

        public void addActor(Actor a);

        Actor getActorById(int id);

        Actor getActorByName(String name);


    }
}
