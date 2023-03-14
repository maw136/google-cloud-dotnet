// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2;

public abstract partial class BigQueryClient
{
    #region GetTable
    /// <summary>
    /// Retrieves the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetTable(TableReference, GetTableOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The requested table.</returns>
    public virtual BigQueryTable GetTable(string datasetId, string tableId, GetTableOptions options = null) =>
        GetTable(GetTableReference(datasetId, tableId), options);
    
    /// <summary>
    /// Retrieves the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetTable(TableReference, GetTableOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The requested table.</returns>
    public virtual BigQueryTable GetTable(string projectId, string datasetId, string tableId, GetTableOptions options = null) =>
        GetTable(GetTableReference(projectId, datasetId, tableId), options);
    
    /// <summary>
    /// Retrieves the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The requested table.</returns>
    public virtual BigQueryTable GetTable(TableReference tableReference, GetTableOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously retrieves the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetTableAsync(TableReference, GetTableOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the requested table.</returns>
    public virtual Task<BigQueryTable> GetTableAsync(string datasetId, string tableId, GetTableOptions options = null, CancellationToken cancellationToken = default) =>
        GetTableAsync(GetTableReference(datasetId, tableId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously retrieves the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetTableAsync(TableReference, GetTableOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the requested table.</returns>
    public virtual Task<BigQueryTable> GetTableAsync(string projectId, string datasetId, string tableId, GetTableOptions options = null, CancellationToken cancellationToken = default) =>
        GetTableAsync(GetTableReference(projectId, datasetId, tableId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously retrieves the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the requested table.</returns>
    public virtual Task<BigQueryTable> GetTableAsync(TableReference tableReference, GetTableOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region CreateTable
    /// <summary>
    /// Creates the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateTable(TableReference, Table, CreateTableOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the creation. Must not be null. If this table's <see cref="Table.TableReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The newly created table.</returns>
    public virtual BigQueryTable CreateTable(string datasetId, string tableId, Table resource, CreateTableOptions options = null) =>
        CreateTable(GetTableReference(datasetId, tableId), resource, options);
    
    /// <summary>
    /// Creates the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateTable(TableReference, Table, CreateTableOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the creation. Must not be null. If this table's <see cref="Table.TableReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The newly created table.</returns>
    public virtual BigQueryTable CreateTable(string projectId, string datasetId, string tableId, Table resource, CreateTableOptions options = null) =>
        CreateTable(GetTableReference(projectId, datasetId, tableId), resource, options);
    
    /// <summary>
    /// Creates the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the creation. Must not be null. If this table's <see cref="Table.TableReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The newly created table.</returns>
    public virtual BigQueryTable CreateTable(TableReference tableReference, Table resource, CreateTableOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously creates the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateTableAsync(TableReference, Table, CreateTableOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the creation. Must not be null. If this table's <see cref="Table.TableReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the newly created table.</returns>
    public virtual Task<BigQueryTable> CreateTableAsync(string datasetId, string tableId, Table resource, CreateTableOptions options = null, CancellationToken cancellationToken = default) =>
        CreateTableAsync(GetTableReference(datasetId, tableId), resource, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously creates the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateTableAsync(TableReference, Table, CreateTableOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the creation. Must not be null. If this table's <see cref="Table.TableReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the newly created table.</returns>
    public virtual Task<BigQueryTable> CreateTableAsync(string projectId, string datasetId, string tableId, Table resource, CreateTableOptions options = null, CancellationToken cancellationToken = default) =>
        CreateTableAsync(GetTableReference(projectId, datasetId, tableId), resource, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously creates the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the creation. Must not be null. If this table's <see cref="Table.TableReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the newly created table.</returns>
    public virtual Task<BigQueryTable> CreateTableAsync(TableReference tableReference, Table resource, CreateTableOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    /// <summary>
    /// Creates the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateTable(TableReference, TableSchema, CreateTableOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">The schema for the new table. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The newly created table.</returns>
    public virtual BigQueryTable CreateTable(string datasetId, string tableId, TableSchema schema, CreateTableOptions options = null) =>
        CreateTable(GetTableReference(datasetId, tableId), schema, options);
    
    /// <summary>
    /// Creates the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateTable(TableReference, TableSchema, CreateTableOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">The schema for the new table. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The newly created table.</returns>
    public virtual BigQueryTable CreateTable(string projectId, string datasetId, string tableId, TableSchema schema, CreateTableOptions options = null) =>
        CreateTable(GetTableReference(projectId, datasetId, tableId), schema, options);
    
    /// <summary>
    /// Creates the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="schema">The schema for the new table. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The newly created table.</returns>
    public virtual BigQueryTable CreateTable(TableReference tableReference, TableSchema schema, CreateTableOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously creates the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateTableAsync(TableReference, TableSchema, CreateTableOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">The schema for the new table. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the newly created table.</returns>
    public virtual Task<BigQueryTable> CreateTableAsync(string datasetId, string tableId, TableSchema schema, CreateTableOptions options = null, CancellationToken cancellationToken = default) =>
        CreateTableAsync(GetTableReference(datasetId, tableId), schema, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously creates the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateTableAsync(TableReference, TableSchema, CreateTableOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">The schema for the new table. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the newly created table.</returns>
    public virtual Task<BigQueryTable> CreateTableAsync(string projectId, string datasetId, string tableId, TableSchema schema, CreateTableOptions options = null, CancellationToken cancellationToken = default) =>
        CreateTableAsync(GetTableReference(projectId, datasetId, tableId), schema, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously creates the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="schema">The schema for the new table. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the newly created table.</returns>
    public virtual Task<BigQueryTable> CreateTableAsync(TableReference tableReference, TableSchema schema, CreateTableOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region GetOrCreateTable
    /// <summary>
    /// Attempts to fetch the specified table within this client's project, creating it if it doesn't exist.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetOrCreateTable(TableReference, Table, GetTableOptions, CreateTableOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the creation. Must not be null. If this table's <see cref="Table.TableReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The existing or new table.</returns>
    public virtual BigQueryTable GetOrCreateTable(string datasetId, string tableId, Table resource, GetTableOptions getOptions = null, CreateTableOptions createOptions = null) =>
        GetOrCreateTable(GetTableReference(datasetId, tableId), resource, getOptions, createOptions);
    
    /// <summary>
    /// Attempts to fetch the specified table, creating it if it doesn't exist.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetOrCreateTable(TableReference, Table, GetTableOptions, CreateTableOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the creation. Must not be null. If this table's <see cref="Table.TableReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The existing or new table.</returns>
    public virtual BigQueryTable GetOrCreateTable(string projectId, string datasetId, string tableId, Table resource, GetTableOptions getOptions = null, CreateTableOptions createOptions = null) =>
        GetOrCreateTable(GetTableReference(projectId, datasetId, tableId), resource, getOptions, createOptions);
    
    /// <summary>
    /// Attempts to fetch the specified table, creating it if it doesn't exist.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the creation. Must not be null. If this table's <see cref="Table.TableReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The existing or new table.</returns>
    public virtual BigQueryTable GetOrCreateTable(TableReference tableReference, Table resource, GetTableOptions getOptions = null, CreateTableOptions createOptions = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously attempts to fetch the specified table within this client's project, creating it if it doesn't exist.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetOrCreateTableAsync(TableReference, Table, GetTableOptions, CreateTableOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the creation. Must not be null. If this table's <see cref="Table.TableReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the existing or new table.</returns>
    public virtual Task<BigQueryTable> GetOrCreateTableAsync(string datasetId, string tableId, Table resource, GetTableOptions getOptions = null, CreateTableOptions createOptions = null, CancellationToken cancellationToken = default) =>
        GetOrCreateTableAsync(GetTableReference(datasetId, tableId), resource, getOptions, createOptions, cancellationToken);
    
    /// <summary>
    /// Asynchronously attempts to fetch the specified table, creating it if it doesn't exist.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetOrCreateTableAsync(TableReference, Table, GetTableOptions, CreateTableOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the creation. Must not be null. If this table's <see cref="Table.TableReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the existing or new table.</returns>
    public virtual Task<BigQueryTable> GetOrCreateTableAsync(string projectId, string datasetId, string tableId, Table resource, GetTableOptions getOptions = null, CreateTableOptions createOptions = null, CancellationToken cancellationToken = default) =>
        GetOrCreateTableAsync(GetTableReference(projectId, datasetId, tableId), resource, getOptions, createOptions, cancellationToken);
    
    /// <summary>
    /// Asynchronously attempts to fetch the specified table, creating it if it doesn't exist.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the creation. Must not be null. If this table's <see cref="Table.TableReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the existing or new table.</returns>
    public virtual Task<BigQueryTable> GetOrCreateTableAsync(TableReference tableReference, Table resource, GetTableOptions getOptions = null, CreateTableOptions createOptions = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    /// <summary>
    /// Attempts to fetch the specified table within this client's project, creating it if it doesn't exist.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetOrCreateTable(TableReference, TableSchema, GetTableOptions, CreateTableOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">The schema for the new table. Must not be null.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The existing or new table.</returns>
    public virtual BigQueryTable GetOrCreateTable(string datasetId, string tableId, TableSchema schema, GetTableOptions getOptions = null, CreateTableOptions createOptions = null) =>
        GetOrCreateTable(GetTableReference(datasetId, tableId), schema, getOptions, createOptions);
    
    /// <summary>
    /// Attempts to fetch the specified table, creating it if it doesn't exist.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetOrCreateTable(TableReference, TableSchema, GetTableOptions, CreateTableOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">The schema for the new table. Must not be null.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The existing or new table.</returns>
    public virtual BigQueryTable GetOrCreateTable(string projectId, string datasetId, string tableId, TableSchema schema, GetTableOptions getOptions = null, CreateTableOptions createOptions = null) =>
        GetOrCreateTable(GetTableReference(projectId, datasetId, tableId), schema, getOptions, createOptions);
    
    /// <summary>
    /// Attempts to fetch the specified table, creating it if it doesn't exist.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="schema">The schema for the new table. Must not be null.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The existing or new table.</returns>
    public virtual BigQueryTable GetOrCreateTable(TableReference tableReference, TableSchema schema, GetTableOptions getOptions = null, CreateTableOptions createOptions = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously attempts to fetch the specified table within this client's project, creating it if it doesn't exist.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetOrCreateTableAsync(TableReference, TableSchema, GetTableOptions, CreateTableOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">The schema for the new table. Must not be null.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the existing or new table.</returns>
    public virtual Task<BigQueryTable> GetOrCreateTableAsync(string datasetId, string tableId, TableSchema schema, GetTableOptions getOptions = null, CreateTableOptions createOptions = null, CancellationToken cancellationToken = default) =>
        GetOrCreateTableAsync(GetTableReference(datasetId, tableId), schema, getOptions, createOptions, cancellationToken);
    
    /// <summary>
    /// Asynchronously attempts to fetch the specified table, creating it if it doesn't exist.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetOrCreateTableAsync(TableReference, TableSchema, GetTableOptions, CreateTableOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="schema">The schema for the new table. Must not be null.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the existing or new table.</returns>
    public virtual Task<BigQueryTable> GetOrCreateTableAsync(string projectId, string datasetId, string tableId, TableSchema schema, GetTableOptions getOptions = null, CreateTableOptions createOptions = null, CancellationToken cancellationToken = default) =>
        GetOrCreateTableAsync(GetTableReference(projectId, datasetId, tableId), schema, getOptions, createOptions, cancellationToken);
    
    /// <summary>
    /// Asynchronously attempts to fetch the specified table, creating it if it doesn't exist.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="schema">The schema for the new table. Must not be null.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the existing or new table.</returns>
    public virtual Task<BigQueryTable> GetOrCreateTableAsync(TableReference tableReference, TableSchema schema, GetTableOptions getOptions = null, CreateTableOptions createOptions = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region DeleteTable
    /// <summary>
    /// Deletes the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="DeleteTable(TableReference, DeleteTableOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    public virtual void DeleteTable(string datasetId, string tableId, DeleteTableOptions options = null) =>
        DeleteTable(GetTableReference(datasetId, tableId), options);
    
    /// <summary>
    /// Deletes the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="DeleteTable(TableReference, DeleteTableOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    public virtual void DeleteTable(string projectId, string datasetId, string tableId, DeleteTableOptions options = null) =>
        DeleteTable(GetTableReference(projectId, datasetId, tableId), options);
    
    /// <summary>
    /// Deletes the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    public virtual void DeleteTable(TableReference tableReference, DeleteTableOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously deletes the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="DeleteTableAsync(TableReference, DeleteTableOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public virtual Task DeleteTableAsync(string datasetId, string tableId, DeleteTableOptions options = null, CancellationToken cancellationToken = default) =>
        DeleteTableAsync(GetTableReference(datasetId, tableId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously deletes the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="DeleteTableAsync(TableReference, DeleteTableOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public virtual Task DeleteTableAsync(string projectId, string datasetId, string tableId, DeleteTableOptions options = null, CancellationToken cancellationToken = default) =>
        DeleteTableAsync(GetTableReference(projectId, datasetId, tableId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously deletes the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public virtual Task DeleteTableAsync(TableReference tableReference, DeleteTableOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region UpdateTable
    /// <summary>
    /// Updates the specified table within this client's project to match the specified resource.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UpdateTable(TableReference, Table, UpdateTableOptions)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the update. All updatable fields will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The updated table.</returns>
    public virtual BigQueryTable UpdateTable(string datasetId, string tableId, Table resource, UpdateTableOptions options = null) =>
        UpdateTable(GetTableReference(datasetId, tableId), resource, options);
    
    /// <summary>
    /// Updates the specified table to match the specified resource.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UpdateTable(TableReference, Table, UpdateTableOptions)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the update. All updatable fields will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The updated table.</returns>
    public virtual BigQueryTable UpdateTable(string projectId, string datasetId, string tableId, Table resource, UpdateTableOptions options = null) =>
        UpdateTable(GetTableReference(projectId, datasetId, tableId), resource, options);
    
    /// <summary>
    /// Updates the specified table to match the specified resource.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the update. All updatable fields will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The updated table.</returns>
    public virtual BigQueryTable UpdateTable(TableReference tableReference, Table resource, UpdateTableOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously updates the specified table within this client's project to match the specified resource.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UpdateTableAsync(TableReference, Table, UpdateTableOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the update. All updatable fields will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the updated table.</returns>
    public virtual Task<BigQueryTable> UpdateTableAsync(string datasetId, string tableId, Table resource, UpdateTableOptions options = null, CancellationToken cancellationToken = default) =>
        UpdateTableAsync(GetTableReference(datasetId, tableId), resource, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously updates the specified table to match the specified resource.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UpdateTableAsync(TableReference, Table, UpdateTableOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the update. All updatable fields will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the updated table.</returns>
    public virtual Task<BigQueryTable> UpdateTableAsync(string projectId, string datasetId, string tableId, Table resource, UpdateTableOptions options = null, CancellationToken cancellationToken = default) =>
        UpdateTableAsync(GetTableReference(projectId, datasetId, tableId), resource, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously updates the specified table to match the specified resource.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the update. All updatable fields will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the updated table.</returns>
    public virtual Task<BigQueryTable> UpdateTableAsync(TableReference tableReference, Table resource, UpdateTableOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region PatchTable
    /// <summary>
    /// Patches the specified table within this client's project with fields in the given resource.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="PatchTable(TableReference, Table, PatchTableOptions)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the patch. Only fields present in the resource will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The updated table.</returns>
    public virtual BigQueryTable PatchTable(string datasetId, string tableId, Table resource, PatchTableOptions options = null) =>
        PatchTable(GetTableReference(datasetId, tableId), resource, options);
    
    /// <summary>
    /// Patches the specified table with fields in the given resource.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="PatchTable(TableReference, Table, PatchTableOptions)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the patch. Only fields present in the resource will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The updated table.</returns>
    public virtual BigQueryTable PatchTable(string projectId, string datasetId, string tableId, Table resource, PatchTableOptions options = null) =>
        PatchTable(GetTableReference(projectId, datasetId, tableId), resource, options);
    
    /// <summary>
    /// Patches the specified table with fields in the given resource.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the patch. Only fields present in the resource will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The updated table.</returns>
    public virtual BigQueryTable PatchTable(TableReference tableReference, Table resource, PatchTableOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously patches the specified table within this client's project with fields in the given resource.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="PatchTableAsync(TableReference, Table, PatchTableOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the patch. Only fields present in the resource will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the updated table.</returns>
    public virtual Task<BigQueryTable> PatchTableAsync(string datasetId, string tableId, Table resource, PatchTableOptions options = null, CancellationToken cancellationToken = default) =>
        PatchTableAsync(GetTableReference(datasetId, tableId), resource, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously patches the specified table with fields in the given resource.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="PatchTableAsync(TableReference, Table, PatchTableOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the patch. Only fields present in the resource will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the updated table.</returns>
    public virtual Task<BigQueryTable> PatchTableAsync(string projectId, string datasetId, string tableId, Table resource, PatchTableOptions options = null, CancellationToken cancellationToken = default) =>
        PatchTableAsync(GetTableReference(projectId, datasetId, tableId), resource, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously patches the specified table with fields in the given resource.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="resource">The table resource representation to use for the patch. Only fields present in the resource will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the updated table.</returns>
    public virtual Task<BigQueryTable> PatchTableAsync(TableReference tableReference, Table resource, PatchTableOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region GetTableIamPolicy
    /// <summary>
    /// Gets the IAM policy applied to the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetTableIamPolicy(TableReference, GetTableIamPolicyOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The table's IAM policy.</returns>
    public virtual Policy GetTableIamPolicy(string datasetId, string tableId, GetTableIamPolicyOptions options = null) =>
        GetTableIamPolicy(GetTableReference(datasetId, tableId), options);
    
    /// <summary>
    /// Gets the IAM policy applied to the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetTableIamPolicy(TableReference, GetTableIamPolicyOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The table's IAM policy.</returns>
    public virtual Policy GetTableIamPolicy(string projectId, string datasetId, string tableId, GetTableIamPolicyOptions options = null) =>
        GetTableIamPolicy(GetTableReference(projectId, datasetId, tableId), options);
    
    /// <summary>
    /// Gets the IAM policy applied to the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The table's IAM policy.</returns>
    public virtual Policy GetTableIamPolicy(TableReference tableReference, GetTableIamPolicyOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously gets the IAM policy applied to the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetTableIamPolicyAsync(TableReference, GetTableIamPolicyOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the table's IAM policy.</returns>
    public virtual Task<Policy> GetTableIamPolicyAsync(string datasetId, string tableId, GetTableIamPolicyOptions options = null, CancellationToken cancellationToken = default) =>
        GetTableIamPolicyAsync(GetTableReference(datasetId, tableId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously gets the IAM policy applied to the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetTableIamPolicyAsync(TableReference, GetTableIamPolicyOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the table's IAM policy.</returns>
    public virtual Task<Policy> GetTableIamPolicyAsync(string projectId, string datasetId, string tableId, GetTableIamPolicyOptions options = null, CancellationToken cancellationToken = default) =>
        GetTableIamPolicyAsync(GetTableReference(projectId, datasetId, tableId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously gets the IAM policy applied to the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the table's IAM policy.</returns>
    public virtual Task<Policy> GetTableIamPolicyAsync(TableReference tableReference, GetTableIamPolicyOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region SetTableIamPolicy
    /// <summary>
    /// Applies the given IAM policy to the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="SetTableIamPolicy(TableReference, Policy, SetTableIamPolicyOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="policy">The policy to set on the table. An update mask may be specified through options.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The resulting IAM policy after aplying the given policy.</returns>
    public virtual Policy SetTableIamPolicy(string datasetId, string tableId, Policy policy, SetTableIamPolicyOptions options = null) =>
        SetTableIamPolicy(GetTableReference(datasetId, tableId), policy, options);
    
    /// <summary>
    /// Applies the given IAM policy to the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="SetTableIamPolicy(TableReference, Policy, SetTableIamPolicyOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="policy">The policy to set on the table. An update mask may be specified through options.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The resulting IAM policy after aplying the given policy.</returns>
    public virtual Policy SetTableIamPolicy(string projectId, string datasetId, string tableId, Policy policy, SetTableIamPolicyOptions options = null) =>
        SetTableIamPolicy(GetTableReference(projectId, datasetId, tableId), policy, options);
    
    /// <summary>
    /// Applies the given IAM policy to the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="policy">The policy to set on the table. An update mask may be specified through options.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The resulting IAM policy after aplying the given policy.</returns>
    public virtual Policy SetTableIamPolicy(TableReference tableReference, Policy policy, SetTableIamPolicyOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously applies the given IAM policy to the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="SetTableIamPolicyAsync(TableReference, Policy, SetTableIamPolicyOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="policy">The policy to set on the table. An update mask may be specified through options.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the resulting IAM policy after aplying the given policy.</returns>
    public virtual Task<Policy> SetTableIamPolicyAsync(string datasetId, string tableId, Policy policy, SetTableIamPolicyOptions options = null, CancellationToken cancellationToken = default) =>
        SetTableIamPolicyAsync(GetTableReference(datasetId, tableId), policy, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously applies the given IAM policy to the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="SetTableIamPolicyAsync(TableReference, Policy, SetTableIamPolicyOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="policy">The policy to set on the table. An update mask may be specified through options.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the resulting IAM policy after aplying the given policy.</returns>
    public virtual Task<Policy> SetTableIamPolicyAsync(string projectId, string datasetId, string tableId, Policy policy, SetTableIamPolicyOptions options = null, CancellationToken cancellationToken = default) =>
        SetTableIamPolicyAsync(GetTableReference(projectId, datasetId, tableId), policy, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously applies the given IAM policy to the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="policy">The policy to set on the table. An update mask may be specified through options.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the resulting IAM policy after aplying the given policy.</returns>
    public virtual Task<Policy> SetTableIamPolicyAsync(TableReference tableReference, Policy policy, SetTableIamPolicyOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region TestTableIamPermissions
    /// <summary>
    /// Returns the subset of permissions that the caller has on the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="TestTableIamPermissions(TableReference, IList{string}, TestTableIamPermissionsOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="permissions">The permissions to test on the table.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The subset of permissions that the caller has on {target}.</returns>
    public virtual TestIamPermissionsResponse TestTableIamPermissions(string datasetId, string tableId, IList<string> permissions, TestTableIamPermissionsOptions options = null) =>
        TestTableIamPermissions(GetTableReference(datasetId, tableId), permissions, options);
    
    /// <summary>
    /// Returns the subset of permissions that the caller has on the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="TestTableIamPermissions(TableReference, IList{string}, TestTableIamPermissionsOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="permissions">The permissions to test on the table.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The subset of permissions that the caller has on {target}.</returns>
    public virtual TestIamPermissionsResponse TestTableIamPermissions(string projectId, string datasetId, string tableId, IList<string> permissions, TestTableIamPermissionsOptions options = null) =>
        TestTableIamPermissions(GetTableReference(projectId, datasetId, tableId), permissions, options);
    
    /// <summary>
    /// Returns the subset of permissions that the caller has on the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="permissions">The permissions to test on the table.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The subset of permissions that the caller has on {target}.</returns>
    public virtual TestIamPermissionsResponse TestTableIamPermissions(TableReference tableReference, IList<string> permissions, TestTableIamPermissionsOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously returns the subset of permissions that the caller has on the specified table within this client's project.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="TestTableIamPermissionsAsync(TableReference, IList{string}, TestTableIamPermissionsOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="permissions">The permissions to test on the table.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the subset of permissions that the caller has on {target}.</returns>
    public virtual Task<TestIamPermissionsResponse> TestTableIamPermissionsAsync(string datasetId, string tableId, IList<string> permissions, TestTableIamPermissionsOptions options = null, CancellationToken cancellationToken = default) =>
        TestTableIamPermissionsAsync(GetTableReference(datasetId, tableId), permissions, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously returns the subset of permissions that the caller has on the specified table.
    /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="TestTableIamPermissionsAsync(TableReference, IList{string}, TestTableIamPermissionsOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="tableId">The table ID. Must not be null.</param>
    /// <param name="permissions">The permissions to test on the table.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the subset of permissions that the caller has on {target}.</returns>
    public virtual Task<TestIamPermissionsResponse> TestTableIamPermissionsAsync(string projectId, string datasetId, string tableId, IList<string> permissions, TestTableIamPermissionsOptions options = null, CancellationToken cancellationToken = default) =>
        TestTableIamPermissionsAsync(GetTableReference(projectId, datasetId, tableId), permissions, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously returns the subset of permissions that the caller has on the specified table.
    /// </summary>
    /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
    /// <param name="permissions">The permissions to test on the table.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the subset of permissions that the caller has on {target}.</returns>
    public virtual Task<TestIamPermissionsResponse> TestTableIamPermissionsAsync(TableReference tableReference, IList<string> permissions, TestTableIamPermissionsOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion
}
