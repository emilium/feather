﻿using System.Diagnostics.CodeAnalysis;
using Telerik.Sitefinity.Localization;

namespace Telerik.Sitefinity.Frontend.Mvc.Infrastructure
{
    /// <summary>
    /// Localizable strings for the Frontend infrastructure.
    /// </summary>
    [ObjectInfo(typeof(InfrastructureResources), Title = "InfrastructureResourcesTitle", Description = "InfrastructureResourcesDescription")]
    public class InfrastructureResources : Resource
    {
        /// <summary>
        /// Title for the infrastructure resources class.
        /// </summary>
        [ResourceEntry("InfrastructureResourcesTitle",
            Value = "Frontend Infrastructure resources",
            Description = "Title for the infrastructure resources class.",
            LastModified = "2015/01/12")]
        public string InfrastructureResourcesTitle
        {
            get
            {
                return this["InfrastructureResourcesTitle"];
            }
        }

        /// <summary>
        /// Description for the infrastructure resources class.
        /// </summary>
        [ResourceEntry("InfrastructureResourcesDescription",
            Value = "Localizable strings for the Frontend infrastructure.",
            Description = "Description for the infrastructure resources class.",
            LastModified = "2015/01/12")]
        public string InfrastructureResourcesDescription
        {
            get
            {
                return this["InfrastructureResourcesDescription"];
            }
        }

        /// <summary>
        /// Message that is to be displayed for a widget when its controller execution throws exception.
        /// </summary>
        [ResourceEntry("ErrorExecutingController",
            Value = "Exception occured while executing the controller. Check error logs for details.",
            Description = "Description for the infrastructure resources class.",
            LastModified = "2015/01/12")]
        public string ErrorExecutingController
        {
            get
            {
                return this["ErrorExecutingController"];
            }
        }

        /// <summary>
        /// Caption of the Feather config section.
        /// </summary>
        [ResourceEntry("FeatherConfigCaption",
            Value = "Feather",
            Description = "Caption of the Feather config section.",
            LastModified = "2015/11/23")]
        public string FeatherConfigCaption
        {
            get
            {
                return this["FeatherConfigCaption"];
            }
        }

        /// <summary>
        /// Description of the Feather config section.
        /// </summary>
        [ResourceEntry("FeatherConfigDescription",
            Value = "Configuration for the Feather module.",
            Description = "Description of the Feather config section.",
            LastModified = "2015/11/23")]
        public string FeatherConfigDescription
        {
            get
            {
                return this["FeatherConfigDescription"];
            }
        }

        /// <summary>
        /// Caption of the 'Disable precompiled views' checkbox.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Precompilation")]
        [ResourceEntry("DisablePrecompilationCaption",
            Value = "Disable precompiled views",
            Description = "Caption of the 'Disable precompiled views' checkbox.",
            LastModified = "2015/11/23")]
        public string DisablePrecompilationCaption
        {
            get
            {
                return this["DisablePrecompilationCaption"];
            }
        }

        /// <summary>
        /// Description of the 'Disable precompiled views' checkbox.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Precompilation")]
        [ResourceEntry("DisablePrecompilationDescription",
            Value = "Feather will use precompiled view templated unless this checkbox is checked.",
            Description = "Description of the 'Disable precompiled views' checkbox.",
            LastModified = "2015/11/23")]
        public string DisablePrecompilationDescription
        {
            get
            {
                return this["DisablePrecompilationDescription"];
            }
        }

        /// <summary>
        /// Caption of the 'Always use precompiled version' checkbox.
        /// </summary>
        [ResourceEntry("AlwaysUsePrecompiledVersionCaption",
            Value = "Always use precompiled version",
            Description = "Caption of the 'Always use precompiled version' checkbox.",
            LastModified = "2015/11/23")]
        public string AlwaysUsePrecompiledVersionCaption
        {
            get
            {
                return this["AlwaysUsePrecompiledVersionCaption"];
            }
        }

        /// <summary>
        /// Description of the 'Always use precompiled version' checkbox.
        /// </summary>
        [ResourceEntry("AlwaysUsePrecompiledVersionDescription",
            Value = "When checked Feather will always use the precompiled version of a resource regardless of changes to physical files.",
            Description = "Description of the 'Always use precompiled version' checkbox.",
            LastModified = "2015/11/23")]
        public string AlwaysUsePrecompiledVersionDescription
        {
            get
            {
                return this["AlwaysUsePrecompiledVersionDescription"];
            }
        }

        /// <summary>
        /// Caption of the 'Log usage of precompiled views' checkbox.
        /// </summary>
        [ResourceEntry("LogPrecompiledViewUsageCaption",
            Value = "Log usage of precompiled views",
            Description = "Caption of the 'Log usage of precompiled views' checkbox.",
            LastModified = "2015/11/24")]
        public string LogPrecompiledViewUsageCaption
        {
            get
            {
                return this["LogPrecompiledViewUsageCaption"];
            }
        }

        /// <summary>
        /// Description of the 'Log usage of precompiled views' checkbox.
        /// </summary>
        [ResourceEntry("LogPrecompiledViewUsageDescription",
            Value = "Feather will log when it uses precompiled views in the Trace log. Use for debugging.",
            Description = "Description of the 'Log usage of precompiled views' checkbox.",
            LastModified = "2015/11/24")]
        public string LogPrecompiledViewUsageDescription
        {
            get
            {
                return this["LogPrecompiledViewUsageDescription"];
            }
        }

        /// <summary>
        /// Detailed error message when cannot find template in MVC form.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1304:SpecifyCultureInfo", MessageId = "Telerik.Sitefinity.Localization.Resource.get_Item(System.String)"), ResourceEntry("CannotFindTemplateMvcForm",
            Value = "Cannot find template \"{0}\". Most probably it is specific for a particular resource package which is not applied in the current context. Try duplicating the template in SitefinityWebApp root folder while keeping the same folder hierarchy.",
            Description = "Detailed error message when cannot find template in MVC form.",
            LastModified = "2016/11/28")]
        public string CannotFindTemplateMvcForm
        {
            get
            {
                return base["CannotFindTemplateMvcForm"];
            }
        }
    }
}
