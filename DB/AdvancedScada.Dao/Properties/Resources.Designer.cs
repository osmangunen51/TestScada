﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdvancedScada.Dao.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AdvancedScada.Dao.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN TRANSACTION;
        ///CREATE TABLE IF NOT EXISTS &quot;tag&quot; (
        ///	&quot;channelid&quot;	int NOT NULL,
        ///	&quot;deviceid&quot;	int NOT NULL,
        ///	&quot;datablockid&quot;	int NOT NULL,
        ///	&quot;tagid&quot;	int NOT NULL,
        ///	&quot;tagname&quot;	text NOT NULL,
        ///	&quot;tagprefix&quot;	text NOT NULL,
        ///	&quot;address&quot;	double NOT NULL,
        ///	&quot;datatype&quot;	int NOT NULL DEFAULT 0,
        ///	&quot;size&quot;	int NOT NULL,
        ///	&quot;description&quot;	text NOT NULL,
        ///	PRIMARY KEY(&quot;tagid&quot;,&quot;datablockid&quot;,&quot;deviceid&quot;,&quot;channelid&quot;),
        ///	FOREIGN KEY(&quot;datablockid&quot;,&quot;deviceid&quot;,&quot;channelid&quot;) REFERENCES &quot;datablock&quot;(&quot;datablockid&quot;,&quot;deviceid&quot;,&quot;channelid&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        public static string TagCollection {
            get {
                return ResourceManager.GetString("TagCollection", resourceCulture);
            }
        }
    }
}
