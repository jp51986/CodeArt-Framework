﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeArt.DomainDriven.Extensions {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CodeArt.DomainDriven.Extensions.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 {0} can only include {1} 的本地化字符串。
        /// </summary>
        internal static string CanOnlyInclude {
            get {
                return ResourceManager.GetString("CanOnlyInclude", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Chinese, English letters 的本地化字符串。
        /// </summary>
        internal static string CE {
            get {
                return ResourceManager.GetString("CE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Chinese, English letters, numbers 的本地化字符串。
        /// </summary>
        internal static string CEN {
            get {
                return ResourceManager.GetString("CEN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Chinese, numbers 的本地化字符串。
        /// </summary>
        internal static string CN {
            get {
                return ResourceManager.GetString("CN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} does not meet the rules {1} 的本地化字符串。
        /// </summary>
        internal static string DoesNotMeetRule {
            get {
                return ResourceManager.GetString("DoesNotMeetRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 English letters, numbers 的本地化字符串。
        /// </summary>
        internal static string EN {
            get {
                return ResourceManager.GetString("EN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Obtain an unexpected error in getting system service {0} 的本地化字符串。
        /// </summary>
        internal static string GetServiceUnexpectedError {
            get {
                return ResourceManager.GetString("GetServiceUnexpectedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The identity {0} failed to use the remote object 的本地化字符串。
        /// </summary>
        internal static string IdentityFailed {
            get {
                return ResourceManager.GetString("IdentityFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The property {0} is incorrect for the email format 的本地化字符串。
        /// </summary>
        internal static string IncorrectEmailFormat {
            get {
                return ResourceManager.GetString("IncorrectEmailFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} is incorrect for the mobile number format 的本地化字符串。
        /// </summary>
        internal static string IncorrectMobileNumberFormat {
            get {
                return ResourceManager.GetString("IncorrectMobileNumberFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} value less than {1} 的本地化字符串。
        /// </summary>
        internal static string ValueLessThan {
            get {
                return ResourceManager.GetString("ValueLessThan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} value more than {1} 的本地化字符串。
        /// </summary>
        internal static string ValueMoreThan {
            get {
                return ResourceManager.GetString("ValueMoreThan", resourceCulture);
            }
        }
    }
}
