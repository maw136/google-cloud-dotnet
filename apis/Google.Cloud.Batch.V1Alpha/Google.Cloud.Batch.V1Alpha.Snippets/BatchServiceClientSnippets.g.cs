// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981

namespace Google.Cloud.Batch.V1Alpha.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcbv = Google.Cloud.Batch.V1Alpha;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedBatchServiceClientSnippets
    {
        /// <summary>Snippet for CreateJob</summary>
        public void CreateJobRequestObject()
        {
            // Snippet: CreateJob(CreateJobRequest, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = BatchServiceClient.Create();
            // Initialize request argument(s)
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobId = "",
                Job = new Job(),
                RequestId = "",
            };
            // Make the request
            Job response = batchServiceClient.CreateJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobRequestObjectAsync()
        {
            // Snippet: CreateJobAsync(CreateJobRequest, CallSettings)
            // Additional: CreateJobAsync(CreateJobRequest, CancellationToken)
            // Create client
            BatchServiceClient batchServiceClient = await BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobId = "",
                Job = new Job(),
                RequestId = "",
            };
            // Make the request
            Job response = await batchServiceClient.CreateJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateJob</summary>
        public void CreateJob()
        {
            // Snippet: CreateJob(string, Job, string, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = BatchServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Job job = new Job();
            string jobId = "";
            // Make the request
            Job response = batchServiceClient.CreateJob(parent, job, jobId);
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobAsync()
        {
            // Snippet: CreateJobAsync(string, Job, string, CallSettings)
            // Additional: CreateJobAsync(string, Job, string, CancellationToken)
            // Create client
            BatchServiceClient batchServiceClient = await BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Job job = new Job();
            string jobId = "";
            // Make the request
            Job response = await batchServiceClient.CreateJobAsync(parent, job, jobId);
            // End snippet
        }

        /// <summary>Snippet for CreateJob</summary>
        public void CreateJobResourceNames()
        {
            // Snippet: CreateJob(LocationName, Job, string, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = BatchServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Job job = new Job();
            string jobId = "";
            // Make the request
            Job response = batchServiceClient.CreateJob(parent, job, jobId);
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobResourceNamesAsync()
        {
            // Snippet: CreateJobAsync(LocationName, Job, string, CallSettings)
            // Additional: CreateJobAsync(LocationName, Job, string, CancellationToken)
            // Create client
            BatchServiceClient batchServiceClient = await BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Job job = new Job();
            string jobId = "";
            // Make the request
            Job response = await batchServiceClient.CreateJobAsync(parent, job, jobId);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJobRequestObject()
        {
            // Snippet: GetJob(GetJobRequest, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = BatchServiceClient.Create();
            // Initialize request argument(s)
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            // Make the request
            Job response = batchServiceClient.GetJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobRequestObjectAsync()
        {
            // Snippet: GetJobAsync(GetJobRequest, CallSettings)
            // Additional: GetJobAsync(GetJobRequest, CancellationToken)
            // Create client
            BatchServiceClient batchServiceClient = await BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            // Make the request
            Job response = await batchServiceClient.GetJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJob()
        {
            // Snippet: GetJob(string, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = BatchServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Job response = batchServiceClient.GetJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobAsync()
        {
            // Snippet: GetJobAsync(string, CallSettings)
            // Additional: GetJobAsync(string, CancellationToken)
            // Create client
            BatchServiceClient batchServiceClient = await BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Job response = await batchServiceClient.GetJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJobResourceNames()
        {
            // Snippet: GetJob(JobName, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = BatchServiceClient.Create();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Job response = batchServiceClient.GetJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobResourceNamesAsync()
        {
            // Snippet: GetJobAsync(JobName, CallSettings)
            // Additional: GetJobAsync(JobName, CancellationToken)
            // Create client
            BatchServiceClient batchServiceClient = await BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Job response = await batchServiceClient.GetJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJobRequestObject()
        {
            // Snippet: DeleteJob(DeleteJobRequest, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = BatchServiceClient.Create();
            // Initialize request argument(s)
            DeleteJobRequest request = new DeleteJobRequest
            {
                Name = "",
                Reason = "",
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = batchServiceClient.DeleteJob(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = batchServiceClient.PollOnceDeleteJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobRequestObjectAsync()
        {
            // Snippet: DeleteJobAsync(DeleteJobRequest, CallSettings)
            // Additional: DeleteJobAsync(DeleteJobRequest, CancellationToken)
            // Create client
            BatchServiceClient batchServiceClient = await BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteJobRequest request = new DeleteJobRequest
            {
                Name = "",
                Reason = "",
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await batchServiceClient.DeleteJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await batchServiceClient.PollOnceDeleteJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJob()
        {
            // Snippet: DeleteJob(string, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = BatchServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Empty, OperationMetadata> response = batchServiceClient.DeleteJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = batchServiceClient.PollOnceDeleteJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobAsync()
        {
            // Snippet: DeleteJobAsync(string, CallSettings)
            // Additional: DeleteJobAsync(string, CancellationToken)
            // Create client
            BatchServiceClient batchServiceClient = await BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Empty, OperationMetadata> response = await batchServiceClient.DeleteJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await batchServiceClient.PollOnceDeleteJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListJobs</summary>
        public void ListJobsRequestObject()
        {
            // Snippet: ListJobs(ListJobsRequest, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = BatchServiceClient.Create();
            // Initialize request argument(s)
            ListJobsRequest request = new ListJobsRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response = batchServiceClient.ListJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Job item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Job> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Job item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobsAsync</summary>
        public async Task ListJobsRequestObjectAsync()
        {
            // Snippet: ListJobsAsync(ListJobsRequest, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = await BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListJobsRequest request = new ListJobsRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response = batchServiceClient.ListJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Job item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Job> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Job item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobs</summary>
        public void ListJobs()
        {
            // Snippet: ListJobs(string, string, int?, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = BatchServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response = batchServiceClient.ListJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Job item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Job> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Job item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobsAsync</summary>
        public async Task ListJobsAsync()
        {
            // Snippet: ListJobsAsync(string, string, int?, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = await BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response = batchServiceClient.ListJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Job item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Job> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Job item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTaskRequestObject()
        {
            // Snippet: GetTask(GetTaskRequest, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = BatchServiceClient.Create();
            // Initialize request argument(s)
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]"),
            };
            // Make the request
            gcbv::Task response = batchServiceClient.GetTask(request);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskRequestObjectAsync()
        {
            // Snippet: GetTaskAsync(GetTaskRequest, CallSettings)
            // Additional: GetTaskAsync(GetTaskRequest, CancellationToken)
            // Create client
            BatchServiceClient batchServiceClient = await BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]"),
            };
            // Make the request
            gcbv::Task response = await batchServiceClient.GetTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTask()
        {
            // Snippet: GetTask(string, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = BatchServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]/taskGroups/[TASK_GROUP]/tasks/[TASK]";
            // Make the request
            gcbv::Task response = batchServiceClient.GetTask(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskAsync()
        {
            // Snippet: GetTaskAsync(string, CallSettings)
            // Additional: GetTaskAsync(string, CancellationToken)
            // Create client
            BatchServiceClient batchServiceClient = await BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]/taskGroups/[TASK_GROUP]/tasks/[TASK]";
            // Make the request
            gcbv::Task response = await batchServiceClient.GetTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTaskResourceNames()
        {
            // Snippet: GetTask(TaskName, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = BatchServiceClient.Create();
            // Initialize request argument(s)
            TaskName name = TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]");
            // Make the request
            gcbv::Task response = batchServiceClient.GetTask(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskResourceNamesAsync()
        {
            // Snippet: GetTaskAsync(TaskName, CallSettings)
            // Additional: GetTaskAsync(TaskName, CancellationToken)
            // Create client
            BatchServiceClient batchServiceClient = await BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            TaskName name = TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]");
            // Make the request
            gcbv::Task response = await batchServiceClient.GetTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public void ListTasksRequestObject()
        {
            // Snippet: ListTasks(ListTasksRequest, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = BatchServiceClient.Create();
            // Initialize request argument(s)
            ListTasksRequest request = new ListTasksRequest
            {
                ParentAsTaskGroupName = TaskGroupName.FromProjectLocationJobTaskGroup("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListTasksResponse, gcbv::Task> response = batchServiceClient.ListTasks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcbv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::Task> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasksAsync</summary>
        public async Task ListTasksRequestObjectAsync()
        {
            // Snippet: ListTasksAsync(ListTasksRequest, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = await BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTasksRequest request = new ListTasksRequest
            {
                ParentAsTaskGroupName = TaskGroupName.FromProjectLocationJobTaskGroup("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTasksResponse, gcbv::Task> response = batchServiceClient.ListTasksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcbv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::Task> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public void ListTasks()
        {
            // Snippet: ListTasks(string, string, int?, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = BatchServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]/taskGroups/[TASK_GROUP]";
            // Make the request
            PagedEnumerable<ListTasksResponse, gcbv::Task> response = batchServiceClient.ListTasks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcbv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::Task> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasksAsync</summary>
        public async Task ListTasksAsync()
        {
            // Snippet: ListTasksAsync(string, string, int?, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = await BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]/taskGroups/[TASK_GROUP]";
            // Make the request
            PagedAsyncEnumerable<ListTasksResponse, gcbv::Task> response = batchServiceClient.ListTasksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcbv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::Task> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public void ListTasksResourceNames()
        {
            // Snippet: ListTasks(TaskGroupName, string, int?, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = BatchServiceClient.Create();
            // Initialize request argument(s)
            TaskGroupName parent = TaskGroupName.FromProjectLocationJobTaskGroup("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]");
            // Make the request
            PagedEnumerable<ListTasksResponse, gcbv::Task> response = batchServiceClient.ListTasks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcbv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::Task> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasksAsync</summary>
        public async Task ListTasksResourceNamesAsync()
        {
            // Snippet: ListTasksAsync(TaskGroupName, string, int?, CallSettings)
            // Create client
            BatchServiceClient batchServiceClient = await BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            TaskGroupName parent = TaskGroupName.FromProjectLocationJobTaskGroup("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]");
            // Make the request
            PagedAsyncEnumerable<ListTasksResponse, gcbv::Task> response = batchServiceClient.ListTasksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcbv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::Task> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
