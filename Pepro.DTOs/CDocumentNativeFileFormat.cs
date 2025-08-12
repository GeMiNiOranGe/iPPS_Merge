namespace Pepro.DTOs {
    public class CDocumentNativeFileFormat {
        // Attributes of the class
        private string strId;
        private string strNativeFileFormat;

        // Getters and setters for the attributes using lambda expressions
        public string Id {
            get => strId;
            set => strId = value;
        }

        public string NativeFileFormat {
            get => strNativeFileFormat;
            set => strNativeFileFormat = value;
        }
    }
}
