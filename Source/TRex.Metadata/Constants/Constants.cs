﻿namespace QuickLearn.ApiApps.Metadata
{

    /// <summary>
    /// Contains all of the required magical constants
    /// </summary>
    internal static class Constants
    {

        #region Microsoft Vendor Extensions

        /// <summary>
        /// Gets the string "x-ms-summary"
        /// </summary>
        internal const string X_MS_SUMMARY = "x-ms-summary";
        
        /// <summary>
        /// Gets the string "x-ms-notification-url"
        /// </summary>
        internal const string X_MS_NOTIFICATION_URL = "x-ms-notification-url";

        /// <summary>
        /// Gets the string "x-ms-visibility"
        /// </summary>
        internal const string X_MS_VISIBILITY = "x-ms-visibility";

        /// <summary>
        /// Gets the string "x-ms-notification-content"
        /// </summary>
        internal const string X_MS_NOTIFICATION_CONTENT = "x-ms-notification-content";

        /// <summary>
        /// Gets the string "x-ms-trigger";
        /// </summary>
        internal const string X_MS_TRIGGER = "x-ms-trigger";

        /// <summary>
        /// Gets the string "x-ms-dynamic-values";
        /// </summary>
        internal const string X_MS_DYNAMIC_VALUES = "x-ms-dynamic-values";

        /// <summary>
        /// Gets the string "x-ms-dynamic-schema";
        /// </summary>
        internal const string X_MS_DYNAMIC_SCHEMA = "x-ms-dynamic-schema";

        #endregion

        #region Vendor Extension Properties

        /// <summary>
        /// Gets the string "operationId"
        /// </summary>
        public const string OPERATION_ID = "operationId";

        /// <summary>
        /// Gets the string "parameters"
        /// </summary>
        public const string PARAMETERS = "parameters";

        /// <summary>
        /// Gets the string "value-collection"
        /// </summary>
        public const string VALUE_COLLECTION = "value-collection";


        /// <summary>
        /// Gets the string "value-path"
        /// </summary>
        public const string VALUE_PATH = "value-path";

        /// <summary>
        /// Gets the string "value-title"
        /// </summary>
        public const string VALUE_TITLE = "value-title";
        
        /// <summary>
        /// Gets the string "schema"
        /// </summary>
        public const string SCHEMA = "schema";

        /// <summary>
        /// Gets the string "description"
        /// </summary>
        public const string DESCRIPTION = "description";

        /// <summary>
        /// Gets the string "type"
        /// </summary>
        public const string TYPE = "type";

        /// <summary>
        /// Gets the string "$ref"
        /// </summary>
        public const string REF = "$ref";

        #endregion

        #region Response Descriptions

        /// <summary>
        /// Gets the string "default"
        /// </summary>
        internal const string DEFAULT_RESPONSE_KEY = "default";

        /// <summary>
        /// Gets the response code "200"
        /// </summary>
        internal const string HAPPY_POLL_WITH_DATA_RESPONSE_CODE = "200";

        /// <summary>
        /// Gets the response code "202"
        /// </summary>
        internal const string HAPPY_POLL_NO_DATA_RESPONSE_CODE = "202";

        /// <summary>
        /// Gets the first digit ("2") of the 200 level of response codes
        /// </summary>
        internal const string HAPPY_RESPONSE_CODE_LEVEL_START = "2";
        

        #endregion

    }
}
