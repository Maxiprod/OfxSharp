﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OfxSharpLib {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OfxSharpLib.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to OFX/BANKMSGSRSV1/STMTTRNRS/.
        /// </summary>
        internal static string BankAccount {
            get {
                return ResourceManager.GetString("BankAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OFX/CREDITCARDMSGSRSV1/CCSTMTTRNRS/CCSTMTRS.
        /// </summary>
        internal static string CCAccount {
            get {
                return ResourceManager.GetString("CCAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are insufficent funds to pay your {item}. We have allocated what you have evenly between the {item} but there is no room in the budget for anything else, sorry....
        /// </summary>
        internal static string InsufficentFunds {
            get {
                return ResourceManager.GetString("InsufficentFunds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are no funds for your {item} sorry....
        /// </summary>
        internal static string NoFunds {
            get {
                return ResourceManager.GetString("NoFunds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are spending beyond your means so we have had to use your savings to create this budget. Perhaps you need to review your spending....
        /// </summary>
        internal static string NoMoney {
            get {
                return ResourceManager.GetString("NoMoney", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OFX/SIGNONMSGSRSV1/SONRS.
        /// </summary>
        internal static string SignOn {
            get {
                return ResourceManager.GetString("SignOn", resourceCulture);
            }
        }
    }
}
