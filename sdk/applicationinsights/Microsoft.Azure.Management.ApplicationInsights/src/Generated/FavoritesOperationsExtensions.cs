// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApplicationInsights.Management
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FavoritesOperations.
    /// </summary>
    public static partial class FavoritesOperationsExtensions
    {
            /// <summary>
            /// Gets a list of favorites defined within an Application Insights component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='favoriteType'>
            /// The type of favorite. Value can be either shared or user. Possible values
            /// include: 'shared', 'user'
            /// </param>
            /// <param name='sourceType'>
            /// Source type of favorite to return. When left out, the source type defaults
            /// to 'other' (not present in this enum). Possible values include:
            /// 'retention', 'notebook', 'sessions', 'events', 'userflows', 'funnel',
            /// 'impact', 'segmentation'
            /// </param>
            /// <param name='canFetchContent'>
            /// Flag indicating whether or not to return the full content for each
            /// applicable favorite. If false, only return summary content for favorites.
            /// </param>
            /// <param name='tags'>
            /// Tags that must be present on each favorite returned.
            /// </param>
            public static IList<ApplicationInsightsComponentFavorite> List(this IFavoritesOperations operations, string resourceGroupName, string resourceName, FavoriteType? favoriteType = default(FavoriteType?), string sourceType = default(string), bool? canFetchContent = default(bool?), IList<string> tags = default(IList<string>))
            {
                return operations.ListAsync(resourceGroupName, resourceName, favoriteType, sourceType, canFetchContent, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of favorites defined within an Application Insights component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='favoriteType'>
            /// The type of favorite. Value can be either shared or user. Possible values
            /// include: 'shared', 'user'
            /// </param>
            /// <param name='sourceType'>
            /// Source type of favorite to return. When left out, the source type defaults
            /// to 'other' (not present in this enum). Possible values include:
            /// 'retention', 'notebook', 'sessions', 'events', 'userflows', 'funnel',
            /// 'impact', 'segmentation'
            /// </param>
            /// <param name='canFetchContent'>
            /// Flag indicating whether or not to return the full content for each
            /// applicable favorite. If false, only return summary content for favorites.
            /// </param>
            /// <param name='tags'>
            /// Tags that must be present on each favorite returned.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ApplicationInsightsComponentFavorite>> ListAsync(this IFavoritesOperations operations, string resourceGroupName, string resourceName, FavoriteType? favoriteType = default(FavoriteType?), string sourceType = default(string), bool? canFetchContent = default(bool?), IList<string> tags = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, resourceName, favoriteType, sourceType, canFetchContent, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a single favorite by its FavoriteId, defined within an Application
            /// Insights component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='favoriteId'>
            /// The Id of a specific favorite defined in the Application Insights component
            /// </param>
            public static ApplicationInsightsComponentFavorite Get(this IFavoritesOperations operations, string resourceGroupName, string resourceName, string favoriteId)
            {
                return operations.GetAsync(resourceGroupName, resourceName, favoriteId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a single favorite by its FavoriteId, defined within an Application
            /// Insights component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='favoriteId'>
            /// The Id of a specific favorite defined in the Application Insights component
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationInsightsComponentFavorite> GetAsync(this IFavoritesOperations operations, string resourceGroupName, string resourceName, string favoriteId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, favoriteId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds a new favorites to an Application Insights component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='favoriteId'>
            /// The Id of a specific favorite defined in the Application Insights component
            /// </param>
            /// <param name='favoriteProperties'>
            /// Properties that need to be specified to create a new favorite and add it to
            /// an Application Insights component.
            /// </param>
            public static ApplicationInsightsComponentFavorite Add(this IFavoritesOperations operations, string resourceGroupName, string resourceName, string favoriteId, ApplicationInsightsComponentFavorite favoriteProperties)
            {
                return operations.AddAsync(resourceGroupName, resourceName, favoriteId, favoriteProperties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a new favorites to an Application Insights component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='favoriteId'>
            /// The Id of a specific favorite defined in the Application Insights component
            /// </param>
            /// <param name='favoriteProperties'>
            /// Properties that need to be specified to create a new favorite and add it to
            /// an Application Insights component.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationInsightsComponentFavorite> AddAsync(this IFavoritesOperations operations, string resourceGroupName, string resourceName, string favoriteId, ApplicationInsightsComponentFavorite favoriteProperties, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddWithHttpMessagesAsync(resourceGroupName, resourceName, favoriteId, favoriteProperties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a favorite that has already been added to an Application Insights
            /// component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='favoriteId'>
            /// The Id of a specific favorite defined in the Application Insights component
            /// </param>
            /// <param name='favoriteProperties'>
            /// Properties that need to be specified to update the existing favorite.
            /// </param>
            public static ApplicationInsightsComponentFavorite Update(this IFavoritesOperations operations, string resourceGroupName, string resourceName, string favoriteId, ApplicationInsightsComponentFavorite favoriteProperties)
            {
                return operations.UpdateAsync(resourceGroupName, resourceName, favoriteId, favoriteProperties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a favorite that has already been added to an Application Insights
            /// component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='favoriteId'>
            /// The Id of a specific favorite defined in the Application Insights component
            /// </param>
            /// <param name='favoriteProperties'>
            /// Properties that need to be specified to update the existing favorite.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationInsightsComponentFavorite> UpdateAsync(this IFavoritesOperations operations, string resourceGroupName, string resourceName, string favoriteId, ApplicationInsightsComponentFavorite favoriteProperties, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, resourceName, favoriteId, favoriteProperties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Remove a favorite that is associated to an Application Insights component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='favoriteId'>
            /// The Id of a specific favorite defined in the Application Insights component
            /// </param>
            public static void Delete(this IFavoritesOperations operations, string resourceGroupName, string resourceName, string favoriteId)
            {
                operations.DeleteAsync(resourceGroupName, resourceName, favoriteId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Remove a favorite that is associated to an Application Insights component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='favoriteId'>
            /// The Id of a specific favorite defined in the Application Insights component
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IFavoritesOperations operations, string resourceGroupName, string resourceName, string favoriteId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, resourceName, favoriteId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}