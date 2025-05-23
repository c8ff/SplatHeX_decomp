using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace SplatHex;
[CompilerGenerated]
internal static class AssemblyLoader {
    private static object nullCacheLock;
    private static Dictionary<string, bool> nullCache;
    private static Dictionary<string, string> assemblyNames;
    private static Dictionary<string, string> symbolNames;
    private static int isAttached;
    private static string CultureToString(CultureInfo cultureInfo_0) {
        if (cultureInfo_0 == null) {
            return "";
        }

        return cultureInfo_0.Name;
    }

    private static Assembly ReadExistingAssembly(AssemblyName assemblyName_0) {
        Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
        int num = 0;
        Assembly assembly;
        while (true) {
            if (num < assemblies.Length) {
                assembly = assemblies[num];
                AssemblyName name = assembly.GetName();
                if (string.Equals(name.Name, assemblyName_0.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(CultureToString(name.CultureInfo), CultureToString(assemblyName_0.CultureInfo), StringComparison.InvariantCultureIgnoreCase)) {
                    break;
                }

                num++;
                continue;
            }

            return null;
        }

        return assembly;
    }

    private static void CopyTo(Stream stream_0, Stream stream_1) {
        byte[] array = new byte[81920];
        int count;
        while ((count = stream_0.Read(array, 0, array.Length)) != 0) {
            stream_1.Write(array, 0, count);
        }
    }

    private static Stream LoadStream(string string_0) {
        Assembly executingAssembly = Assembly.GetExecutingAssembly();
        if (string_0.EndsWith(".compressed")) {
            using (Stream stream = executingAssembly.GetManifestResourceStream(string_0)) {
                using DeflateStream stream_ = new DeflateStream(stream, CompressionMode.Decompress);
                MemoryStream memoryStream = new MemoryStream();
                CopyTo(stream_, memoryStream);
                memoryStream.Position = 0L;
                return memoryStream;
            }
        }

        return executingAssembly.GetManifestResourceStream(string_0);
    }

    private static Stream LoadStream(Dictionary<string, string> dictionary_0, string string_0) {
        if (dictionary_0.TryGetValue(string_0, out var value)) {
            return LoadStream(value);
        }

        return null;
    }

    private static byte[] ReadStream(Stream stream_0) {
        byte[] array = new byte[stream_0.Length];
        stream_0.Read(array, 0, array.Length);
        return array;
    }

    private static Assembly ReadFromEmbeddedResources(Dictionary<string, string> dictionary_0, Dictionary<string, string> dictionary_1, AssemblyName assemblyName_0) {
        string text = assemblyName_0.Name.ToLowerInvariant();
        if (assemblyName_0.CultureInfo != null && !string.IsNullOrEmpty(assemblyName_0.CultureInfo.Name)) {
            text = assemblyName_0.CultureInfo.Name + "." + text;
        }

        byte[] rawAssembly;
        using (Stream stream = LoadStream(dictionary_0, text)) {
            if (stream == null) {
                return null;
            }

            rawAssembly = ReadStream(stream);
        }

        using (Stream stream2 = LoadStream(dictionary_1, text)) {
            if (stream2 != null) {
                byte[] rawSymbolStore = ReadStream(stream2);
                return Assembly.Load(rawAssembly, rawSymbolStore);
            }
        }

        return Assembly.Load(rawAssembly);
    }

    public static Assembly ResolveAssembly(object object_0, ResolveEventArgs resolveEventArgs_0) {
        lock (nullCacheLock) {
            if (nullCache.ContainsKey(resolveEventArgs_0.Name)) {
                return null;
            }
        }

        AssemblyName assemblyName = new AssemblyName(resolveEventArgs_0.Name);
        Assembly assembly = ReadExistingAssembly(assemblyName);
        if (assembly != null) {
            return assembly;
        }

        assembly = ReadFromEmbeddedResources(assemblyNames, symbolNames, assemblyName);
        if (assembly == null) {
            lock (nullCacheLock) {
                nullCache[resolveEventArgs_0.Name] = true;
            }

            if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None) {
                assembly = Assembly.Load(assemblyName);
            }
        }

        return assembly;
    }

    static AssemblyLoader() {
        nullCacheLock = new object();
        nullCache = new Dictionary<string, bool>();
        assemblyNames = new Dictionary<string, string>();
        symbolNames = new Dictionary<string, string>();
        assemblyNames.Add("costura", "costura.costura.dll.compressed");
        assemblyNames.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
        symbolNames.Add("newtonsoft.json", "costura.newtonsoft.json.pdb.compressed");
    }

    public static void Attach() {
        if (Interlocked.Exchange(ref isAttached, 1) == 1) {
            return;
        }

        AppDomain.CurrentDomain.AssemblyResolve += delegate (object object_0, ResolveEventArgs resolveEventArgs_0) {
            lock (nullCacheLock) {
                if (nullCache.ContainsKey(resolveEventArgs_0.Name)) {
                    return (Assembly)null;
                }
            }

            AssemblyName assemblyName = new AssemblyName(resolveEventArgs_0.Name);
            Assembly assembly = ReadExistingAssembly(assemblyName);
            if (assembly != null) {
                return assembly;
            }

            assembly = ReadFromEmbeddedResources(assemblyNames, symbolNames, assemblyName);
            if (assembly == null) {
                lock (nullCacheLock) {
                    nullCache[resolveEventArgs_0.Name] = true;
                }

                if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None) {
                    assembly = Assembly.Load(assemblyName);
                }
            }

            return assembly;
        };
    }
}