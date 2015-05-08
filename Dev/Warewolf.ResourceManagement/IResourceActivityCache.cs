using System;
using System.Activities;
using Dev2;

namespace Warewolf.ResourceManagement
{
    public interface IResourceActivityCache
    {
        IDev2Activity Parse(DynamicActivity activity, Guid resourceIdGuid);

        void RemoveFromCache(Guid resourceID);

        void ClearCache();

        bool HasActivityInCache(Guid resourceIdGuid);

        IDev2Activity GetActivity(Guid resourceIdGuid);
    }
}