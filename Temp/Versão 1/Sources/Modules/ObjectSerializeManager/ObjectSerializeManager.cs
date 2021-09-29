using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace LiveShowStudio.Modules.ObjectSerializeManager {

    public delegate void IsSavedChanged();
    public delegate void LoadedChanged();
    public delegate void ClosedChanged();

    public class ObjectSerializeManager<TObject, TObjectData> where TObject : IObject where TObjectData : IObjectData {

        #region Fields
        public TObject Object { get; private set; }
        public string FilterObject { get; set; }
        public IsSavedChanged IsSavedChanged { get; set; }
        public LoadedChanged LoadedChanged { get; set; }
        public ClosedChanged ClosedChanged { get; set; }
        #endregion

        #region Object Manager
        public bool CheckSaved() {
            if (Object != null && !Object.IsSaved) {
                switch (MessageBox.Show("O arquivo atual não está salvo, você quer salvar esse arquivo?", "Atenção", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)) {
                    case DialogResult.Yes: {
                        if (!SaveObject())
                            return false;
                        break;
                    }
                    case DialogResult.Cancel: {
                        return false;
                    }
                }
            }
            return true;
        }
        public void NewObject(TObject obj) {
            Object = obj;
            IsSavedChanged?.Invoke();
            LoadedChanged?.Invoke();
        }
        public void OpenObject(string directory = null) {
            if (string.IsNullOrEmpty(directory)) {
                directory = GetOpenDirectory();
                if (string.IsNullOrEmpty(directory))
                    return;
            }

            FileStream stream = null;
            try {
                stream = new FileStream(directory, FileMode.Open);
                var formatter = new BinaryFormatter();

                Object = (TObject)formatter.Deserialize(stream);
                Object.Directory = directory;
                Object.IsSaved = true;

                IsSavedChanged?.Invoke();

                objectData.RegisterObject(directory, Object.Name, Object.Icon, Object.Type);
                if (RecentOpenItem != null) { UpdateRecentObjects(); }
                LoadedChanged?.Invoke();
            } catch {
                MessageBox.Show("Não foi possível abrir o arquivo " + directory, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                if (stream != null)
                    stream.Close();
            }
        }
        public void CloseObject() {
            Object = default;
            ClosedChanged?.Invoke();
            IsSavedChanged?.Invoke();
        }
        public bool SaveObject() {
            if (string.IsNullOrEmpty(Object.Directory)) {
                Object.Directory = GetSaveDirectory();
                if (string.IsNullOrEmpty(Object.Directory))
                    return false;
            }

            FileStream stream = null;
            try {
                stream = new FileStream(Object.Directory, FileMode.OpenOrCreate);
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, Object, null);

                Object.IsSaved = true;

                IsSavedChanged?.Invoke();

                objectData.RegisterObject(Object.Directory, Object.Name, Object.Icon, Object.Type);
                UpdateRecentObjects();

                return true;
            } catch {
                MessageBox.Show("Não foi possível salvar o arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } finally {
                if (stream != null)
                    stream.Close();
            }
        }
        public bool SaveAsObject() {
            var directory = GetSaveDirectory();
            if (string.IsNullOrEmpty(directory))
                return false;

            FileStream stream = null;
            try {
                stream = new FileStream(directory, FileMode.OpenOrCreate);
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, Object, null);
                Object.Directory = directory;
                Object.IsSaved = true;
                IsSavedChanged?.Invoke();

                objectData.RegisterObject(directory, Object.Name, Object.Icon, Object.Type);
                UpdateRecentObjects();

                return true;
            } catch {
                MessageBox.Show("Não foi possível salvar o arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } finally {
                if (stream != null)
                    stream.Close();
            }
        }
        public bool SaveCopyObject() {
            var directory = GetSaveDirectory();
            if (string.IsNullOrEmpty(directory))
                return false;

            FileStream stream = null;
            try {
                stream = new FileStream(directory, FileMode.OpenOrCreate);
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, Object, null);
                return true;
            } catch {
                MessageBox.Show("Não foi possível salvar o arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } finally {
                if (stream != null)
                    stream.Close();
            }
        }
        public void RegisterChanged() {
            //Comite
            Object.IsSaved = false;
            IsSavedChanged?.Invoke();
        }
        #endregion

        #region Get Directory
        private string GetSaveDirectory() {
            using (var file = new SaveFileDialog()) {
                file.Filter = FilterObject;
                file.FileName = Object.Name;
                if (file.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(file.FileName)) {
                    return file.FileName;
                } else {
                    return null;
                }
            }
        }
        private string GetOpenDirectory() {
            using (var file = new OpenFileDialog()) {
                file.Filter = FilterObject;
                if (file.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(file.FileName)) {
                    return file.FileName;
                } else {
                    return null;
                }
            }
        }
        #endregion

        #region Recent Open
        private readonly IObjectData objectData;
        private readonly ToolStripMenuItem clearRecentObjectsMenuItem;
        private ToolStripMenuItem recentOpenItem;

        public ToolStripMenuItem RecentOpenItem {
            get { return recentOpenItem; }
            set {
                recentOpenItem = value;
                UpdateRecentObjects();
            }
        }

        public ObjectSerializeManager() {
            objectData = Activator.CreateInstance<TObjectData>();

            clearRecentObjectsMenuItem = new ToolStripMenuItem("Limpar arquivos recentes");
            clearRecentObjectsMenuItem.Click += ClearRecentObjectsMenuItem_Click;
        }
        public System.Collections.Generic.List<IRecentObject> GetRecentObject() {
            return objectData.GetRecentObject();
        }

        private void UpdateRecentObjects() {
            if (RecentOpenItem.DropDownItems.Count != 0) {
                for (int i = 0; i < RecentOpenItem.DropDownItems.Count - 2; i++)
                    if (RecentOpenItem.DropDownItems[i] is ToolStripMenuItem)
                        RecentOpenItem.DropDownItems[i].Click -= SelectedRecentObjectMenuItem_Click;
                RecentOpenItem.DropDownItems.Clear();
            }

            var recentObjects = objectData.GetRecentObject();
            if (recentObjects.Count == 0) {
                RecentOpenItem.Enabled = false;
            } else {
                foreach (var recent in recentObjects) {
                    var item = new ToolStripMenuItem($"{recent.Name} ({recent.Directory})") { Tag = recent };
                    RecentOpenItem.DropDownItems.Add(item);
                    item.Click += SelectedRecentObjectMenuItem_Click;
                }
                RecentOpenItem.DropDownItems.Add(new ToolStripSeparator());
                RecentOpenItem.DropDownItems.Add(clearRecentObjectsMenuItem);

                RecentOpenItem.Enabled = true;
            }
        }
        private void SelectedRecentObjectMenuItem_Click(object sender, EventArgs e) {
            var recent = (IRecentObject)((ToolStripMenuItem)sender).Tag;
            if (Object != null && Object.Directory.Equals(recent.Directory))
                return;
            if (CheckSaved())
                OpenObject(recent.Directory);
        }
        public void RemoveRecent(IRecentObject recent) {
            objectData.Remove(recent);
            UpdateRecentObjects();
        }
        private void ClearRecentObjectsMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Tem certeza se quer apagar a lista de arquivos recentes?", "Apagar os arquivos recentes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                objectData.ClearRecentObject();
                UpdateRecentObjects();
            }
        }
        #endregion

        public void Dispose() {
            GC.SuppressFinalize(this);
        }
    }
}