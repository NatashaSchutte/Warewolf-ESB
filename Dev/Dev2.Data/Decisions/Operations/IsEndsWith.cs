
/*
*  Warewolf - The Easy Service Bus
*  Copyright 2014 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/


using System;

namespace Dev2.Data.Decisions.Operations
{
    public class IsEndsWith : IDecisionOperation
    {
        public Enum HandlesType()
        {
            return enDecisionType.IsEndsWith;
        }

        public bool Invoke(string[] cols)
        {
            return (cols[0].EndsWith(cols[1]));
        }
    }
}
