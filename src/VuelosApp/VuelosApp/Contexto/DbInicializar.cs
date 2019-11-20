using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VuelosApp.Contexto
{
    namespace DAL.Migrations
    {
        public class DbInicializar
        {
            public static void Initialize(Contexto context)
            {
                try
                {
                    context.Database.EnsureCreated();

                }
                catch (Exception e)
                {

                    throw e;
                }

            }

        }
    }
}
