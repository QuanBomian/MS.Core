using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AspNetCore.Entity.Context;
using AspNetCore.Entity.Core;

namespace AspNetCore.Domain.Respository
{
    public class VillagerRespository : IVillagerRespository
    {
        private readonly MsContext _db;

        public VillagerRespository(MsContext db)
        {
            _db = db;
        }

        public Task<List<Villager>> Get()
        {
            return _db.Villagers.ToListAsync();
        }
        public Villager GetVillagerById(int id)
        {
            return _db.Villagers.Find(id);
        }

        public Villager AddVillager(Villager villager)
        {
            _db.Villagers.Add(villager);
            _db.SaveChanges();
            return GetVillagerById(villager.VillagerID);
        }

        public Villager UpdateVillager(Villager villager)
        {
            _db.Villagers.Update(villager);
            _db.SaveChanges();
            return GetVillagerById(villager.VillagerID);
        }

        public void DeleteVillageById(int id)
        {
            Villager villager =  GetVillagerById(id);
            _db.Villagers.Remove(villager);
            _db.SaveChanges();
        }
    }
}
