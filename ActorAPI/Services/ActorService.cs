using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ActorAPI.Models;
using ActorAPI.Services;
using ActorAPI.Context;
using ActorAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Diagnostics.Metrics;

namespace ActorAPI.Services
{
    public class ActorService : IActorService
    {

        private readonly IActorRepository _actorRepository;

        public ActorService(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }
        public IEnumerable<Actor> addActors(IEnumerable<Actor> actors)
        {
            try
            {
                foreach(Actor a in actors)
                {
                 if(a != null && a.id == null)
                    {
                        _actorRepository.addActors(actors);
                    }
                }
                return actors;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void deleteActor(int id)
        {
            if (_actorRepository.GetUserById(id) != null)
            {
                _actorRepository.deleteActor(id);
            }
        }
            
        
        
        public Actor getActorById(int id)
        {
            try
            {
                var obj = _actorRepository.GetUserById(id);

                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }           
        }

        public Actor getActorByName(String name)
        {
            try
            {
                var obj = _actorRepository.GetUserByName(name);

                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Actor> getActors()
        {
            try
            {
                IEnumerable<Actor> ac = _actorRepository.GetActors();

                if (ac != null)
                {
                    return ac;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void addActor(Actor act)
        {
           if(_actorRepository.GetUserById(act.id)== null)
            {
                 _actorRepository.addActor(act);

            }     
        }

        public void updateActor(Actor act)
        {
                _actorRepository.updateActor(act);           
        }
}
}
