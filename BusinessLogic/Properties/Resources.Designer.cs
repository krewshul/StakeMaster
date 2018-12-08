﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StakeMaster.BusinessLogic.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("StakeMaster.BusinessLogic.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Zero fee transaction size limit:.
        /// </summary>
        internal static string FreeTransactionNotPossibleException_Free_Name {
            get {
                return ResourceManager.GetString("FreeTransactionNotPossibleException_Free_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A free Transaction is not possible with the given values..
        /// </summary>
        internal static string FreeTransactionNotPossibleException_Generic {
            get {
                return ResourceManager.GetString("FreeTransactionNotPossibleException_Generic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Inputs:.
        /// </summary>
        internal static string FreeTransactionNotPossibleException_InputCount_Name {
            get {
                return ResourceManager.GetString("FreeTransactionNotPossibleException_InputCount_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Outputs:.
        /// </summary>
        internal static string FreeTransactionNotPossibleException_OutputCount_Name {
            get {
                return ResourceManager.GetString("FreeTransactionNotPossibleException_OutputCount_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calculated transaction size:.
        /// </summary>
        internal static string FreeTransactionNotPossibleException_Size_Name {
            get {
                return ResourceManager.GetString("FreeTransactionNotPossibleException_Size_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument:.
        /// </summary>
        internal static string SettingsArgumentInvalidException_Argument_Name {
            get {
                return ResourceManager.GetString("SettingsArgumentInvalidException_Argument_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument given is invalid or unknown in the current context..
        /// </summary>
        internal static string SettingsArgumentInvalidException_Generic {
            get {
                return ResourceManager.GetString("SettingsArgumentInvalidException_Generic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StakeMaster commandline arguments:.
        /// </summary>
        internal static string SettingsHelper_DisplayHelp_Header {
            get {
                return ResourceManager.GetString("SettingsHelper_DisplayHelp_Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}{1}Please check your settings..
        /// </summary>
        internal static string SettingsHelper_DisplayHelp_InvalidArgument_Text {
            get {
                return ResourceManager.GetString("SettingsHelper_DisplayHelp_InvalidArgument_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to General settings{0}-? or --help: Displays this help{0}{0}Settings regarding the stake function{0}-s=&lt;true/false&gt; or --stakes=&lt;true/false&gt;    : Enables or disables modifications of inputs at the stake address. Default: true{0}-a=&lt;address&gt; or --stakeaddress=&lt;addres&gt;     : Sets the dedicated stake address. Mandatory.{0}-c=&lt;address&gt; or --collectaddress=&lt;address&gt;  : Sets the dedicated collect address. Mandatory.{0}-w=&lt;days&gt; or --patience=&lt;days&gt;              : Sets the number of days when a input should stake at  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SettingsHelper_DisplayHelp_Text {
            get {
                return ResourceManager.GetString("SettingsHelper_DisplayHelp_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument is not defined..
        /// </summary>
        internal static string SettingsHelper_ExtractArgument_ArgumentNotDefined_Message {
            get {
                return ResourceManager.GetString("SettingsHelper_ExtractArgument_ArgumentNotDefined_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument is not unique..
        /// </summary>
        internal static string SettingsHelper_ExtractArgument_ArgumentNotUnique_Message {
            get {
                return ResourceManager.GetString("SettingsHelper_ExtractArgument_ArgumentNotUnique_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirms must be greater 0..
        /// </summary>
        internal static string TransactionHelper_TransactionHelper_Confirms_OutOfRange {
            get {
                return ResourceManager.GetString("TransactionHelper_TransactionHelper_Confirms_OutOfRange", resourceCulture);
            }
        }
    }
}
