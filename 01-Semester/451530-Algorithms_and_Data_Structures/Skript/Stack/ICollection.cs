/* * * * * * *
 * Title:   Stack
 * Class:   ICollection.cs
 * Author:  Christian B.
 * Date:    02.01.2019
 * 
*/

#region Bibliothek von Alexandria
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace myStack
{
    interface ICollection
    {
        void Clear();
        int Count { get; }
    }
}
