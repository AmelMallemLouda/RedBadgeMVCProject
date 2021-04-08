﻿using RedBadgeMVC.Data;
using RedBadgeMVC.Models.HomeKitchenModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeMVC.Service
{
    public class HomeKitchenService
    {
        private readonly Guid _userId;
        public HomeKitchenService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateHomeKitchen(HomeKitchenCreate model)
        {
            var entity = new HomeKitchen()
            {
               HomeKitchenName=model.HomeKitchenName
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.HomeKitchens.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }


        public IEnumerable<HomeKitchenListItem> GetHomeKitchen()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.HomeKitchens.Select(
                            e =>
                                new HomeKitchenListItem
                                {
                                    HomeKitchenName = e.HomeKitchenName
                                }

                        );

                return query.ToArray();
            }
        }
  
    }
}
