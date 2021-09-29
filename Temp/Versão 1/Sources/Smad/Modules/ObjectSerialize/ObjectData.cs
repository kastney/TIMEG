using System.Linq;
using System.Collections.Generic;
using LiveShowStudio.Modules.ObjectSerializeManager;

namespace Smad.Modules.ObjectSerialize {

    public class ObjectData : IObjectData {

        public List<IRecentObject> GetRecentObject() {
            List<RecentObject> recentObjects = Properties.Settings.Default.OpenRecents;
            if (recentObjects == null) {
                recentObjects = new List<RecentObject>();
                Properties.Settings.Default.OpenRecents = recentObjects;
                Properties.Settings.Default.Save();
            }

            return recentObjects.ToList<IRecentObject>();
        }

        public void ClearRecentObject() {
            List<RecentObject> recentObjects = Properties.Settings.Default.OpenRecents;
            if (recentObjects != null) {
                recentObjects.Clear();
                Properties.Settings.Default.OpenRecents = recentObjects;
                Properties.Settings.Default.Save();
            }
        }

        public void RegisterObject(string directory, string name, byte[] icon, string type) {
            List<RecentObject> recentObjects = Properties.Settings.Default.OpenRecents;
            if (recentObjects != null) {
                if (recentObjects.FirstOrDefault(a => a.Directory.Equals(directory)) is RecentObject auxObject) {
                    recentObjects.Remove(auxObject);
                }
                recentObjects.Insert(0, new RecentObject {
                    Directory = directory,
                    Name = name,
                    LastAcess = System.DateTime.Now,
                    Icon = icon,
                    ProjectType = type
                });
                Properties.Settings.Default.OpenRecents = recentObjects;
                Properties.Settings.Default.Save();
            }
        }

        public void Remove(IRecentObject recentObject) {
            List<RecentObject> recentObjects = Properties.Settings.Default.OpenRecents;
            if (recentObjects != null) {
                if (recentObjects.FirstOrDefault(a => a.Directory.Equals(recentObject.Directory)) is RecentObject auxObject) {
                    recentObjects.Remove(auxObject);
                }
                Properties.Settings.Default.OpenRecents = recentObjects;
                Properties.Settings.Default.Save();
            }
        }
    }
}