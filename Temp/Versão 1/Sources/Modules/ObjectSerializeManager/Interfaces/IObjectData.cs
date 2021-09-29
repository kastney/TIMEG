using System.Collections.Generic;

namespace LiveShowStudio.Modules.ObjectSerializeManager {

    public interface IObjectData {

        List<IRecentObject> GetRecentObject();
        void Remove(IRecentObject recent);
        void ClearRecentObject();
        void RegisterObject(string directory, string name, byte[] icon, string type);
    }
}