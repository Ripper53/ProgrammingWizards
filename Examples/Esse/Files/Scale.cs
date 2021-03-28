namespace Esse {
    public class Scale {
        public static Scale Default => new Scale("N/A");
        public string Description { get; }

        public Scale(string description) {
            Description = description;
        }

    }
}
