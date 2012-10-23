using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC3Tests.Models
{
    public class Repository
    {
        public IEnumerable<Fund> Funds
        {
            get
            {
                return new List<Fund>
                           {
                               new Fund()
                                   {
                                       Code = "DKD",
                                       ID = 1,
                                       Name = "DK Distressed",
                                       ManagerID = 1,
                                       StrategyID = 1,
                                   },
                               new Fund()
                                   {
                                       Code = "LakeW",
                                       ID = 2,
                                       ManagerID = 2,
                                       Name = "Lakewood",
                                       StrategyID = 2,
                                   }
                           };
            }
        }

        public IEnumerable<Strategy> Strategies
        {
            get
            {
                return new Strategy[]
                           {
                               new Strategy
                                   {
                                       ID = 1,
                                       Name = "Long Shorts in the winter",
                                   },
                               new Strategy
                                   {
                                       ID = 2,
                                       Name = "Distressed Denim Credit"
                                   }
                           };
            }
        }

        public IEnumerable<Manager> Managers
        {
            get
            {
                return new Manager[]
                           {
                               new Manager
                                   {
                                       ID = 1,
                                       Name = "DK Manager",
                                   },
                               new Manager
                                   {
                                       ID = 2,
                                       Name = "Lakewoods Manager",
                                   },

                           };
            }
        }
    }
}