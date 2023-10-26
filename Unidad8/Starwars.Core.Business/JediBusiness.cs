﻿using Starwars.Core.DataADONet;
using Starwars.Core.Entities;
using Starwars.Core.Entities.Filters;

namespace Starwars.Core.Business
{
    public class JediBusiness
    {
        private StarwarsConfig _starwarsConfig;
        private JediRepository _jediRepository;

        public JediBusiness(StarwarsConfig starwarsConfig,
                            JediRepository jediRepository)
        {
            _starwarsConfig = starwarsConfig;

            _jediRepository = jediRepository;
            //_jediRepository = new JediRepository(_starwarsConfig);
        }


        public List<Jedi> GetAll()
        {
            return _jediRepository.GetAll();
        }


        public List<Jedi> Search(JediFilter filter) {

            if (filter is null)
            {
                throw new ArgumentException("Filter is invalid");
            }

            return _jediRepository.Search(filter);
        }

        public List<Jedi> SearchWithStoreProcedure(JediFilter filter)
        {

            if (filter is null)
            {
                throw new ArgumentException("Filter is invalid");
            }

            return _jediRepository.SearchWithStoreProcedure(filter);
        }

        public Jedi Get(int jediId)
        {
            if (jediId <= 0)
            {
                throw new ArgumentException("JediId is invalid");
            }

            return _jediRepository.Get(jediId);
        }
        
    }
}
