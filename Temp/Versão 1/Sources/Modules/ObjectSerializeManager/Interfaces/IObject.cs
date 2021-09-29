namespace LiveShowStudio.Modules.ObjectSerializeManager {

    public interface IObject {

        string Name { get; set; }
        bool IsSaved { get; set; }
        byte[] Icon { get; set; }
        string Directory { get; set; }
        string Type { get; }
    }
}