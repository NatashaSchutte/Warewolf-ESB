using System;
using System.Activities;
using System.Collections.Concurrent;
using Dev2;

namespace Warewolf.ResourceManagement
{
    public  class ResourceActivityCache : IResourceActivityCache
    {
        readonly IActivityParser _activityParser;
        readonly ConcurrentDictionary<Guid,IDev2Activity> _cache;

        public ResourceActivityCache(IActivityParser activityParser, ConcurrentDictionary<Guid, IDev2Activity> cache)
        {
            _activityParser = activityParser;
            _cache = cache;
        }        

        public IDev2Activity Parse(DynamicActivity activity,Guid resourceIdGuid)
        {
            if(HasActivityInCache(resourceIdGuid))
            {
                return GetActivity(resourceIdGuid);
            }
            var dynamicActivity = activity;
            if (dynamicActivity != null)
            {
                IDev2Activity act = _activityParser.Parse(dynamicActivity);
                if (_cache.TryAdd(resourceIdGuid, act))
                {
                    return act;
                }
            }
            return null;
        }

        public IDev2Activity GetActivity(Guid resourceIdGuid)
        {
            return _cache[resourceIdGuid];
        }

        public bool HasActivityInCache(Guid resourceIdGuid)
        {
            return _cache.ContainsKey(resourceIdGuid);
        }

        public void RemoveFromCache(Guid resourceID)
        {
            IDev2Activity act;
            _cache.TryRemove(resourceID, out act);
        }

        public void ClearCache()
        {
            _cache.Clear();
        }

    }
}