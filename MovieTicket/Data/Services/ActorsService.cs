﻿using Microsoft.EntityFrameworkCore;
using MovieTicket.Models;

namespace MovieTicket.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
           await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var results = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
             _context.Actors.Remove(results);
            await _context.SaveChangesAsync();
        }
              
        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
