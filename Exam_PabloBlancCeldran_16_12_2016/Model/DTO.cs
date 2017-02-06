using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /**
     * This interface ensures the casting from a given entity source.
     */
    public interface DTO<T>
    {

        /**
         * Forces a lookup on the given entity table to get an equivalent entity.
         */ 
        T castFrom(IEnumerable<T> src);

    }
}
