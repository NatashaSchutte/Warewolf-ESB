
/*
*  Warewolf - The Easy Service Bus
*  Copyright 2015 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/


namespace Dev2.Activities
{
    public class DsfForEachItem
    {
        public static DsfForEachItem[] EmptyList = new DsfForEachItem[0];

        public string Name { get; set; }

        public string Value { get; set; }

        public int RowIndex { get; set; }

        public int GroupID { get; set; }
    }
}
