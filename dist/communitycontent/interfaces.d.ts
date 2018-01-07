/**
 * Bungie.Net API
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * OpenAPI spec version: 2.1.1
 * Contact: support@bungie.com
 *
 * NOTE: This class is auto generated by the bungie-api-ts code generator program.
 * https://github.com/DestinyItemManager/bugie-api-ts
 * Do not edit these files manually.
 */

import {
  PagedQuery,
  PartnershipType
} from '../platform';
import {
  UserInfoCard
} from '../user/interfaces';

export const enum CommunityStatusSort {
  Viewers = 0,
  Trending = 1,
  OverallViewers = 2,
  Followers = 3
}

export interface SearchResultOfCommunityLiveStatus {
  results?: CommunityLiveStatus[];
  totalResults?: number;
  hasMore?: boolean;
  query?: PagedQuery;
  replacementContinuationToken?: string;
  /**
   * If useTotalResults is true, then totalResults represents an accurate count.
   * 
   * If False, it does not, and may be estimated/only the size of the current page.
   * 
   * Either way, you should probably always only trust hasMore.
   * 
   * This is a long-held historical throwback to when we used to do paging with known
   * total results. Those queries toasted our database, and we were left to hastily
   * alter our endpoints and create backward- compatible shims, of which
   * useTotalResults is one.
   */
  useTotalResults?: boolean;
}

export interface CommunityLiveStatus {
  dateStatusUpdated?: string;
  url?: string;
  partnershipIdentifier?: string;
  partnershipType?: PartnershipType;
  thumbnail?: string;
  thumbnailSmall?: string;
  thumbnailLarge?: string;
  destinyCharacterId?: number;
  userInfo?: UserInfoCard;
  currentActivityHash?: number;
  dateLastPlayed?: string;
  dateStreamStarted?: string;
  locale?: string;
  currentViewers?: number;
  followers?: number;
  overallViewers?: number;
  isFeatured?: boolean;
  title?: string;
  activityModeHash?: number;
  dateFeatured?: string;
  trendingValue?: number;
  isSubscribable?: boolean;
}