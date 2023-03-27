using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActorAPI.Context;
using ActorAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ActorAPI.Repositories
{
    public class ActorRepository : IActorRepository
    {
        private readonly ActorContext _dbContext;


        public ActorRepository(ActorContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Actor> GetActors()
        {
            return _dbContext.actors;
        }
        public Actor GetUserById(int id)
        {
             return _dbContext.actors.Find(id);  
        }

        public void addActor(Actor act)
        {
            _dbContext.Add(act);
            _dbContext.SaveChanges();
        }


        public void updateActor(Actor act)
        {
            _dbContext.Update(act);
            _dbContext.SaveChanges();
        }

        public void deleteActor(int id)
        {

            Actor act = _dbContext.actors.Find(id);
            _dbContext.Remove(act);
            _dbContext.SaveChanges();

        }

        public Actor GetUserByName(String s)
        {          
            return _dbContext.actors.Find(s);                       
        }

        public void addActors(IEnumerable<Actor> actors)
        {
            foreach (Actor a in actors)
            {
               _dbContext.actors.Add(a);
                _dbContext.SaveChanges();
            }
  
        }
    }
}
