namespace Ryujinx.Graphics.Shader.IntermediateRepresentation
{
    enum StorageKind
    {
        None,
        Input,
        InputPerPatch,
        Output,
        OutputPerPatch,
        ConstantBuffer,
        StorageBuffer,
        LocalMemory,
        SharedMemory,
        GlobalMemory
    }

    static class StorageKindExtensions
    {
        public static bool IsInputOrOutput(this StorageKind storageKind)
        {
            return storageKind == StorageKind.Input ||
                   storageKind == StorageKind.InputPerPatch ||
                   storageKind == StorageKind.Output ||
                   storageKind == StorageKind.OutputPerPatch;
        }

        public static bool IsOutput(this StorageKind storageKind)
        {
            return storageKind == StorageKind.Output ||
                   storageKind == StorageKind.OutputPerPatch;
        }

        public static bool IsPerPatch(this StorageKind storageKind)
        {
            return storageKind == StorageKind.InputPerPatch ||
                   storageKind == StorageKind.OutputPerPatch;
        }
    }
}