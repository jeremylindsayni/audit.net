﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NugetAuditor.VSIX.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NugetAuditor.VSIX.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Auditing package &apos;{0}&apos;..
        /// </summary>
        internal static string AuditingPackage {
            get {
                return ResourceManager.GetString("AuditingPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while trying to audit package(s): {0}.
        /// </summary>
        internal static string AuditingPackageError {
            get {
                return ResourceManager.GetString("AuditingPackageError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Auditing {0} packages in project &apos;{1}&apos;..
        /// </summary>
        internal static string AuditingPackagesInProject {
            get {
                return ResourceManager.GetString("AuditingPackagesInProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Auditing {0} packages in solution &apos;{1}&apos;..
        /// </summary>
        internal static string AuditingPackagesInSolution {
            get {
                return ResourceManager.GetString("AuditingPackagesInSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service &apos;{0}&apos; must be installed for this feature to work. Ensure that this service is available..
        /// </summary>
        internal static string General_MissingService {
            get {
                return ResourceManager.GetString("General_MissingService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vulnerabilities found in package &apos;{0}&apos;. See error list for details..
        /// </summary>
        internal static string MarkerTipText_VulnarebilitiesFound {
            get {
                return ResourceManager.GetString("MarkerTipText_VulnarebilitiesFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No vulnerabilities found..
        /// </summary>
        internal static string NoVulnarebilitiesFound {
            get {
                return ResourceManager.GetString("NoVulnarebilitiesFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vulnerabilities found in {0} package(s). See Error List for details..
        /// </summary>
        internal static string VulnerabilitiesFound {
            get {
                return ResourceManager.GetString("VulnerabilitiesFound", resourceCulture);
            }
        }
    }
}
