using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingForm.Models
{
    public static class Repository
    {

        private static List<Create> _create;

        static Repository()
        {
            _create = new List<Create>()
            {

            };

        }

        public static List<Create> creates
        {
            get { return _create; }
        }

        public static void AddCreate(Create entity)
        {
            _create.Add(entity);
        }
    }
}
