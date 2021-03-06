﻿using ArangoDB.Client.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArangoDB.Client
{
    public interface IAdvancedOperation
    {
        /// <summary>
        /// Imports documents
        /// </summary>
        /// <typeparam name="TCollection">Collection Type</typeparam>
        /// <param name="documents">Documents to import</param>
        /// <param name="createCollection">If true, then the collection is created if it does not yet exist</param>
        /// <param name="overwrite">If true, then all data in the collection will be removed prior to the import</param>
        /// <param name="waitForSync">Wait until document has been synced to disk</param>
        /// <param name="onDuplicate">Controls what action is carried out in case of a unique key constraint violation</param>
        /// <param name="complete">If true, then it will make the whole import fail if any error occurs</param>
        /// <param name="details">If true, then the result will include details about documents that could not be imported</param>
        /// <param name="baseResult"></param>
        /// <returns>BulkImportResult</returns>
        BulkImportResult BulkImport<TCollection>(IEnumerable documents, bool? createCollection = null, bool? overwrite = null
            , bool? waitForSync = null, ImportDuplicatePolicy? onDuplicate = null, bool? complete = null, bool? details = null
            , Action<BaseResult> baseResult = null);

        /// <summary>
        /// Imports documents
        /// </summary>
        /// <typeparam name="TCollection">Collection Type</typeparam>
        /// <param name="documents">Documents to import</param>
        /// <param name="createCollection">If true, then the collection is created if it does not yet exist</param>
        /// <param name="overwrite">If true, then all data in the collection will be removed prior to the import</param>
        /// <param name="waitForSync">Wait until document has been synced to disk</param>
        /// <param name="onDuplicate">Controls what action is carried out in case of a unique key constraint violation</param>
        /// <param name="complete">If true, then it will make the whole import fail if any error occurs</param>
        /// <param name="details">If true, then the result will include details about documents that could not be imported</param>
        /// <param name="baseResult"></param>
        /// <returns>BulkImportResult</returns>
        Task<BulkImportResult> BulkImportAsync<TCollection>(IEnumerable documents, bool? createCollection = null, bool? overwrite = null
            , bool? waitForSync = null, ImportDuplicatePolicy? onDuplicate = null, bool? complete = null, bool? details = null
            , Action<BaseResult> baseResult = null);

        /// <summary>
        /// Imports documents
        /// </summary>
        /// <param name="collection">The collection name</param>
        /// <param name="documents">Documents to import</param>
        /// <param name="createCollection">If true, then the collection is created if it does not yet exist</param>
        /// <param name="overwrite">If true, then all data in the collection will be removed prior to the import</param>
        /// <param name="waitForSync">Wait until document has been synced to disk</param>
        /// <param name="onDuplicate">Controls what action is carried out in case of a unique key constraint violation</param>
        /// <param name="complete">If true, then it will make the whole import fail if any error occurs</param>
        /// <param name="details">If true, then the result will include details about documents that could not be imported</param>
        /// <param name="baseResult"></param>
        /// <returns>BulkImportResult</returns>
        BulkImportResult BulkImport(string collection, IEnumerable documents, bool? createCollection = null, bool? overwrite = null
            , bool? waitForSync = null, ImportDuplicatePolicy? onDuplicate = null, bool? complete = null, bool? details = null
            , Action<BaseResult> baseResult = null);

        /// <summary>
        /// Imports documents
        /// </summary>
        /// <param name="collection">The collection name</param>
        /// <param name="documents">Documents to import</param>
        /// <param name="createCollection">If true, then the collection is created if it does not yet exist</param>
        /// <param name="overwrite">If true, then all data in the collection will be removed prior to the import</param>
        /// <param name="waitForSync">Wait until document has been synced to disk</param>
        /// <param name="onDuplicate">Controls what action is carried out in case of a unique key constraint violation</param>
        /// <param name="complete">If true, then it will make the whole import fail if any error occurs</param>
        /// <param name="details">If true, then the result will include details about documents that could not be imported</param>
        /// <param name="baseResult"></param>
        /// <returns>BulkImportResult</returns>
        Task<BulkImportResult> BulkImportAsync(string collection, IEnumerable documents, bool? createCollection = null, bool? overwrite = null
            , bool? waitForSync = null, ImportDuplicatePolicy? onDuplicate = null, bool? complete = null, bool? details = null
            , Action<BaseResult> baseResult = null);
    }
}
