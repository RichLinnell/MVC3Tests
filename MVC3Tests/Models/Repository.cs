using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC3Tests.Models
{
    public class Repository
    {
        private static IList<Fund> _funds = new List<Fund>
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

        private static IList<Strategy> _strategies = new List<Strategy>
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

        private static IList<Manager> _managers = new List<Manager> {
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

        public IList<Fund> Funds
        {
            get { return _funds; }
        }

        public IList<Strategy> Strategies
        {
            get { return _strategies; }
        }

        public IEnumerable<Manager> Managers
        {
            get { return _managers; }
        }
    }
}