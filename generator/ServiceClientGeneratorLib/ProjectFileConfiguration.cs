﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Json.LitJson;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Represents the metadata needed to generate a platform-specific project file
    /// for a service (eg compile constants, build configuration and platform etc).
    /// </summary>
    public class ProjectFileConfiguration
    {
        /// <summary>
        /// The name of the platform configuration; this forms part of the project
        /// filename.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The set of solution build configuration and platforms (eg Debug|Any CPU)
        /// supported by the project kind.
        /// </summary>
        public IEnumerable<string> Configurations { get; set; }

        /// <summary>
        /// The .Net Framework versions, in format vX.Y, that the project will compile 
        /// against.
        /// </summary>
        public IEnumerable<string> TargetFrameworkVersions { get; set; }

        /// <summary>
        /// The #define constants to be set at compile time. These are used for all
        /// compilation types (debug, release etc).
        /// </summary>
        public IEnumerable<string> CompilationConstants { get; set; }

        /// <summary>
        /// The name of the subfolder that the compile outputs should be placed into.
        /// By convention this is the same as the Name property, but lowercase.
        /// </summary>
        public string BinSubFolder { get; set; }

        /// <summary>
        /// The name of the T4 generator file used to emit the project file. The
        /// type name should be relative to the code generator's Generators 
        /// namespace.
        /// </summary>
        public string Template { get; set; }

        /// <summary>
        /// The set of subfolder names used to hold custom code for a platform
        /// </summary>
        public IEnumerable<string> PlatformCodeFolders { get; set; }

        public IEnumerable<string> PlatformExcludeFolders { get; set; }

        /// <summary>
        /// The platform name used by NuGet (e.g. wpa81)
        /// </summary>
        public string NuGetTargetPlatform { get; set; }

        /// <summary>
        /// The set of projects that should be included in the solution test folder.
        /// </summary>
        public IEnumerable<string> ExtraTestProjects { get; set; }

        /// <summary>
        /// Returns true if the last component of the specified folder 
        /// path begins with '_' character, our convention for representing
        /// platform-specific code.
        /// </summary>
        public bool IsPlatformCodeFolder(string sourceFolder)
        {
            return GetPlatformFolderName(sourceFolder) != null;
        }

        public IEnumerable<ProjectFileCreator.ProjectReference> ProjectReferences { get; set; }
        
        public IEnumerable<string> EmbeddedResources { get; set; }

        public IEnumerable<string> VisualStudioServices { get; set; }

        public string NoWarn { get; set; }

        public string OutputPathOverride { get; set; }

        public List<ProjectFileCreator.PackageReference> PackageReferences { get; set; }

        /// <summary>
        /// Specify where the framework binaries are.  For net35 in vs2017 project, this is needed
        /// to work around https://github.com/Microsoft/msbuild/issues/1333
        /// </summary>
        public string FrameworkPathOverride { get; set; }

        public IEnumerable<Dependency> DllReferences { get; set; }

        /// <summary>
        /// Returns true if the specified folder ends with one of the custom code
        /// platform folder names declared for this configuration.
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <returns></returns>

        private string GetPlatformFolderName(string folder)
        {
            var tokens = folder.Split('\\');
            string platformFolder = null;
            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                if (tokens[i].StartsWith("_"))
                {
                    platformFolder = tokens[i];
                    break;
                }
            }

            return platformFolder;
        }

        /// <summary>
        /// Returns true if the specified path folder names conforms with the 
        /// platform folder names declared for this configuration.
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <returns></returns>
        public bool IsValidPlatformPathForProject(string sourceFolder)
        {
            var tokens = sourceFolder.Split(new[] { Path.AltDirectorySeparatorChar });

            if (PlatformCodeFolders.Any())
            {
                foreach(var folder in tokens)
                {
                    if (folder.StartsWith("_"))
                    {
                        bool isValid = false;
                        foreach (var pcf in PlatformCodeFolders)
                        {
                            if (folder.Equals(pcf, StringComparison.OrdinalIgnoreCase))
                            {
                                isValid = true;
                                break;
                            }
                        }
                        if (!isValid)
                        {
                            return false;
                        }
                    }
                    
                }
                
            }

            return true;
        }
    }
}
