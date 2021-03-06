// -----------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// <summary>Global Suppressions file for FxCop warnings for BillingDataApi project.</summary>
// -----------------------------------------------------------------------

[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
        Scope = "namespace", Target = "BillingDataApi", Justification = "Namespace designed to decouple components.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
        Scope = "namespace", Target = "BillingDataApi.Common", Justification = "Namespace designed to decouple components.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
        Scope = "namespace", Target = "BillingDataApi.Helpers.EABillingHelpers", Justification = "Namespace designed to decouple components.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
        Scope = "namespace", Target = "BillingDataApi.Helpers.SwaggerUIHelpers", Justification = "Namespace designed to decouple components.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
        Scope = "namespace", Target = "BillingDataApi.Models.EABillingModels.Utilities", Justification = "Namespace designed to decouple components.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
        Scope = "namespace", Target = "BillingDataApi.UserHelpers", Justification = "Namespace designed to decouple components.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
        Scope = "namespace", Target = "BillingDataApi.Models.EABillingModels", Justification = "Namespace designed to decouple components.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes",
        Scope = "member", Target = "BillingDataApi.Controllers.EaBillingController.#GetResponse(System.String)", Justification = "By Design.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design",
        "CA1053:StaticHolderTypesShouldNotHaveConstructors", Scope = "type", Target = "BillingDataApi.SwaggerConfig", Justification = "Auto-generated file.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
        MessageId = "0", Scope = "member",
        Target = "BillingDataApi.WebApiConfig.#Register(System.Web.Http.HttpConfiguration)", Justification = "Auto-generated file.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic",
        Scope = "member", Target = "BillingDataApi.WebApiApplication.#Application_Start()", Justification = "Auto-generated file.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes",
        Scope = "member",
        Target = "BillingDataApi.UserHelpers.AzureADGraphAPIUtil.#GetOrganizationDisplayName(System.String)", Justification = "By design.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes",
        Scope = "member",
        Target =
            "BillingDataApi.UserHelpers.AzureResourceManagerUtil.#GetUserSubscriptions(BillingDataApi.Models.Organization,Microsoft.IdentityModel.Clients.ActiveDirectory.AuthenticationResult)",
        Justification = "By design.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames", Justification = "One of the dependency nugets contains unsigned assembly.")]

// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.