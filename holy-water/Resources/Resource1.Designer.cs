﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace holy_water.Resources {
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
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("holy_water.Resources.Resource1", typeof(Resource1).Assembly);
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
        ///   Looks up a localized string similar to You are allowed to drink.
        /// </summary>
        internal static string AgeAllowed {
            get {
                return ResourceManager.GetString("AgeAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you 18+ years old?.
        /// </summary>
        internal static string AgeCheck {
            get {
                return ResourceManager.GetString("AgeCheck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, you are underaged.
        /// </summary>
        internal static string AgeDenied {
            get {
                return ResourceManager.GetString("AgeDenied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please fill all the fields.
        /// </summary>
        internal static string EmptyFields {
            get {
                return ResourceManager.GetString("EmptyFields", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is nothing to remove.
        /// </summary>
        internal static string EmptyList {
            get {
                return ResourceManager.GetString("EmptyList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bar_Data.txt.
        /// </summary>
        internal static string FileName {
            get {
                return ResourceManager.GetString("FileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Filter by average.
        /// </summary>
        internal static string FilterConditionAvg {
            get {
                return ResourceManager.GetString("FilterConditionAvg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Filter by percentage.
        /// </summary>
        internal static string FilterConditionPerc {
            get {
                return ResourceManager.GetString("FilterConditionPerc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^[0-9]+$.
        /// </summary>
        internal static string FilterNumberReg {
            get {
                return ResourceManager.GetString("FilterNumberReg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter the minimal level for filter.
        /// </summary>
        internal static string MinimalFilter {
            get {
                return ResourceManager.GetString("MinimalFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have entered non-numeric characters.
        /// </summary>
        internal static string NonNumeric {
            get {
                return ResourceManager.GetString("NonNumeric", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nothing to show.
        /// </summary>
        internal static string NothingToShow {
            get {
                return ResourceManager.GetString("NothingToShow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The returned list is empty. Try again with different criteria or list.
        /// </summary>
        internal static string ReturnEmpty {
            get {
                return ResourceManager.GetString("ReturnEmpty", resourceCulture);
            }
        }
    }
}
